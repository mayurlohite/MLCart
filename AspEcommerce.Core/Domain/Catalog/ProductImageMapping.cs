using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspEcommerce.Core.Domain.Catalog
{
    public class ProductImageMapping
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid ImageId { get; set; }
        public int SortOrder { get; set; }
        public int Position { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Image? Image { get; set; }
    }
}
