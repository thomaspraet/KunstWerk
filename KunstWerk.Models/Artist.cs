using System.ComponentModel.DataAnnotations;

namespace KunstWerk.Models
{
    public class Artist
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        public string? BirthPlace { get; set; }

        public int? BirthYear { get; set; }
    }
}
