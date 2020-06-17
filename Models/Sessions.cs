using System;
using System.ComponentModel.DataAnnotations;

namespace MentorHub.Models
{
    public class Sessions
    {
        public int Id { get; set; }

        public ApplicationUser Mentor { get; set; }
        [Required]
        public string MentorId { get; set; }
        public DateTime DateTime { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        public Occupations Occupations { get; set; }
        [Required]
        public byte OccupationsId { get; set; }

    }
}