using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace KunstWerk.Web.Models
{
    public class Artwork
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Dimensions { get; set; } = string.Empty;

        
        [ValidateNever]
        public string? ImageUrl { get; set; }
    }
}
