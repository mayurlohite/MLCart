﻿namespace AspEcommerce.Web.Areas.Admin.Models.Support
{
    public class ContactUsMessageModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Title { get; set; }
        public string? Message { get; set; }
        public bool Read { get; set; }
        public DateTime SendDate { get; set; }
    }
}
