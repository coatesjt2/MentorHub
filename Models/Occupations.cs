using System.ComponentModel.DataAnnotations;

namespace MentorHub.Models
{
    public class Occupations
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}