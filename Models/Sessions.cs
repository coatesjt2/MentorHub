using System;
using System.ComponentModel.DataAnnotations;

namespace MentorHub.Models
{
    public class Sessions
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Mentor { get; set; }
        public DateTime DateTime { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Occupations Occupations { get; set; }

    }
}