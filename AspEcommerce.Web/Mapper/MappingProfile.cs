using AspEcommerce.Core.Domain.Catalog;
using AspEcommerce.Core.Domain.Messages;
using AspEcommerce.Core.Domain.Sale;
using AspEcommerce.Core.Domain.User;
using AspEcommerce.Web.Areas.Admin.Models.Catalog;
using AspEcommerce.Web.Areas.Admin.Models.Sale;
using AspEcommerce.Web.Areas.Admin.Models.Support;
using AspEcommerce.Web.Models;
using AspEcommerce.Web.Models.ManageViewModels;
using AutoMapper;

namespace AspEcommerce.Web.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // billing address mappings
            CreateMap<BillingAddress, BillingAddressModel>()
                .ReverseMap();
            CreateMap<BillingAddress, CheckoutModel>()
                .ReverseMap();

            // category mappings
            CreateMap<Category, CategoryListModel>();
            CreateMap<Category, CategoryCreateOrUpdateModel>()
                .ReverseMap();

            // manufacturer mappings
            CreateMap<Manufacturer, ManufacturerListModel>();
            CreateMap<Manufacturer, ManufacturerCreateOrUpdateModel>()
                .ReverseMap();

            // order mapping
            CreateMap<OrderManageModel, Order>();

            // product mappings
            CreateMap<Product, ProductListModel>();
            CreateMap<Product, ProductModel>()
                .ForMember(dest => dest.Categories, opt => opt.Ignore())
                .ForMember(dest => dest.Manufacturers, opt => opt.Ignore())
                .ForMember(dest => dest.Specifications, opt => opt.Ignore());
            CreateMap<Product, ProductCreateOrUpdateModel>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ForMember(dest => dest.Specifications, opt => opt.Ignore());
            CreateMap<ProductCreateOrUpdateModel, Product>()
                .ForMember(dest => dest.Images, opt => opt.Ignore())
                .ForMember(dest => dest.Specifications, opt => opt.Ignore());

            // review
            CreateMap<Review, ReviewModel>()
                .ReverseMap();

            // specifications
            CreateMap<Specification, SpecificationListModel>();
            CreateMap<Specification, SpecificationCreateOrUpdateModel>()
                .ReverseMap();

            // suport
            CreateMap<ContactUsMessage, ContactUsMessageModel>();
        }
    }
}
