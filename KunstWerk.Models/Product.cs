using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Dimensions { get; set; } = string.Empty;

        [ValidateNever]
        public string? ImageUrl { get; set; } = string.Empty;

    }
}
