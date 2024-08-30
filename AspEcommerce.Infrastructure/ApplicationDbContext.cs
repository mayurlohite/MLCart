using AspEcommerce.Core.Domain.Catalog;
using AspEcommerce.Core.Domain.Messages;
using AspEcommerce.Core.Domain.Sale;
using AspEcommerce.Core.Domain.Statistics;
using AspEcommerce.Core.Domain.User;
using AspEcommerce.Infrastructure.EFModels;
using Azure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

namespace AspEcommerce.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<BillingAddress> BillingAddresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public DbSet<ProductImageMapping> ProductImageMappings { get; set; }
        public DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public DbSet<ProductSpecificationMapping> ProductSpecificationMappings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Specification> Specifications { get; set; }

        public DbSet<OrderCount> OrderCounts { get; set; }
        public DbSet<VisitorCount> VisitorCounts { get; set; }

        public DbSet<ContactUsMessage> ContactUsMessage { get; set; }


        /// <summary>
        /// <para>
        /// Override this method to configure the database (and other options) to be used for this context.
        /// This method is called for each instance of the context that is created.
        /// The base implementation does nothing.
        /// </para>
        /// <para>
        /// In situations where an instance of <see cref="T:Microsoft.EntityFrameworkCore.DbContextOptions" /> may or may not have been passed
        /// to the constructor, you can use <see cref="P:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.IsConfigured" /> to determine if
        /// the options have already been set, and skip some or all of the logic in
        /// <see cref="M:Microsoft.EntityFrameworkCore.DbContext.OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder)" />.
        /// </para>
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context. Databases (and other extensions)
        /// typically define extension methods on this object that allow you to configure the context.</param>
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseLazyLoadingProxies()
        //    //              .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));

        //    base.OnConfiguring(optionsBuilder);
        //}

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<BillingAddress>().ToTable("BillingAddress");
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Image>().ToTable("Image");
            builder.Entity<Manufacturer>().ToTable("Manufacturer");
            builder.Entity<Order>().ToTable("Order");
            builder.Entity<OrderItem>().ToTable("OrderItem");
            builder.Entity<Product>().ToTable("Product");
            builder.Entity<ProductCategoryMapping>().ToTable("ProductCategoryMapping");
            builder.Entity<ProductImageMapping>().ToTable("ProductImageMapping");
            builder.Entity<ProductManufacturerMapping>().ToTable("ProductManufacturerMapping");
            builder.Entity<ProductSpecificationMapping>().ToTable("ProductSpecificationMapping");
            builder.Entity<Review>().ToTable("Review");
            builder.Entity<Specification>().ToTable("Specification");

            builder.Entity<OrderCount>().ToTable("OrderCount");
            builder.Entity<VisitorCount>().ToTable("VisitorCount");

            builder.Entity<ContactUsMessage>().ToTable("ContactUsMessage");
        }
}
}
