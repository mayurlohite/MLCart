namespace AspEcommerce.Web.Models
{
    public class ReviewModel
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
        public string? Username { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public int Rating { get; set; }
        public string? CreatedOn { get; set; }
        public string? DateModified { get; set; }
        public bool IsVerifiedOwner { get; set; }
    }
}
