using AspEcommerce.Core.Interface.Services.Catalog;
using AspEcommerce.Core.Interface.Services.Messages;
using AspEcommerce.Core.Interface.Services.Sale;
using AspEcommerce.Core.Interface.Services.Statistics;
using AspEcommerce.Core.Interface.Services.User;
using AspEcommerce.Infrastructure;
using AspEcommerce.Infrastructure.EFModels;
using AspEcommerce.Infrastructure.EFRepository;
using AspEcommerce.Infrastructure.Services.Catalog;
using AspEcommerce.Infrastructure.Services.Messages;
using AspEcommerce.Infrastructure.Services.Sale;
using AspEcommerce.Infrastructure.Services.Statistics;
using AspEcommerce.Infrastructure.Services.User;
using AspEcommerce.Web.Areas.Admin.Helpers;
using AspEcommerce.Web.Helpers;
using AspEcommerce.Web.Mapper;
using AspEcommerce.Web.Middleware;
using AspEcommerce.Web.Models;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting.Internal;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



// For Entity Framework  
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// For Identity  
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();

// idenity password requirement
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
});



//// configure admin account injectable
//builder.Services.Configure<AdminAccount>(
//    Configuration.GetSection("AdminAccount"));

//builder.Services.Configure<UserAccount>(
//    Configuration.GetSection("UserAccount"));

//builder.Configuration.GetValue<AdminAccount>("AdminAccount");
//builder.Configuration.GetValue<UserAccount>("UserAccount");

// Add this line to your program.cs
builder.Services.Configure<AdminAccount>(builder.Configuration.GetSection("AdminAccount"));
builder.Services.Configure<UserAccount>(builder.Configuration.GetSection("UserAccount"));

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
    options.Cookie.Name = "aspCart";
});

//Configure Automapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MappingProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);


// Add application services.
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IBillingAddressService, BillingAddressService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IImageManagerService, ImageManagerService>();
builder.Services.AddScoped<IManufacturerService, ManufacturerService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<ISpecificationService, SpecificationService>();

builder.Services.AddScoped<IOrderCountService, OrderCountService>();
builder.Services.AddScoped<IVisitorCountService, VisitorCountService>();
builder.Services.AddScoped<IContactUsService, ContactUsService>();

builder.Services.AddScoped<IViewHelper, ViewHelper>();
builder.Services.AddScoped<IDataHelper, DataHelper>();

builder.Services.AddSingleton<IFileProvider>(builder.Environment.ContentRootFileProvider);




var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseImageResize();
app.UseStaticFiles();

app.UseSession();
app.UseVisitorCounter();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "Admin",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// seed default data
//SampleDataProvider.Seed(app);

app.Run();
