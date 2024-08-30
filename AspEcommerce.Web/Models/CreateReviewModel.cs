using System.ComponentModel.DataAnnotations;

namespace AspEcommerce.Web.Models
{
    public class CreateReviewModel
    {
        [Required]
        public Guid ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public string? ProductSeo { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Message { get; set; }

        [Required]
        public int Rating { get; set; }
    }
}
