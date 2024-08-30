namespace AspEcommerce.Web.Areas.Admin.Models.Sale
{
    public class OrderListModel
    {
        public Guid Id { get; set; }
        public string? OrderNumber { get; set; }
        public string? Status { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public DateTime OrderPlacementDateTime { get; set; }
        public decimal TotalOrderPrice { get; set; }
    }
}
