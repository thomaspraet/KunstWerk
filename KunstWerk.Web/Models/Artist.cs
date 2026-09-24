using System;
using System.Collections.Generic;
using System.Text;

namespace KunstWerk.Models
{
    public class Artist
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PlaceOfBirth { get; set; } = string.Empty;
        public string YearOfBirth { get; set; } = string.Empty;
    }
}
