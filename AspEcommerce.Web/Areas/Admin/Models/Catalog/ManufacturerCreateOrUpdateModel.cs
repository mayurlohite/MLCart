﻿using System.ComponentModel.DataAnnotations;

namespace AspEcommerce.Web.Areas.Admin.Models.Catalog
{
    public class ManufacturerCreateOrUpdateModel
    {
        public ManufacturerCreateOrUpdateModel()
        {
            Published = true;
            ActiveTab = "info";
        }

        public string? ActiveTab { get; set; }

        public Guid Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 1)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Display(Name = "SEO Url")]
        [RegularExpression(@"^[a-zA-Z0-9]+(-[a-zA-Z0-9]+)*$", ErrorMessage = "URL must only contains alphanumeric [a-z A-Z 0-9] and dash [-] e.g. abc-123-D45")]
        public string? SeoUrl { get; set; }

        [Display(Name = "Meta Tag Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Meta Tag Keywords")]
        public string? MetaKeywords { get; set; }

        [Display(Name = "Meta Tag Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "Manufacturer Image")]
        public string? MainImage { get; set; }

        public string? MainImageFileName { get; set; }

        public DateTime DateAdded { get; set; }

        public bool Published { get; set; }
    }
}
