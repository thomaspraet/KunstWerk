using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KunstWerk.Models
{
    public class Artist
    {
        public int Id { get; set; }
        [ValidateNever]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [ValidateNever]
        public string PlaceOfBirth { get; set; } = string.Empty;
        [ValidateNever]
        public string YearOfBirth { get; set; } = string.Empty;
    }
}
