namespace AspEcommerce.Web.Areas.Admin.Models.Catalog
{
    public class ManufacturerListModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? MainImage { get; set; }
        public string? MainImageFileName { get; set; }
        public bool Published { get; set; }
    }
}
