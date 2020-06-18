using MentorHub.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MentorHub.ViewModels
{
    public class SessionsFormViewModel
    {
        [Required]
        public string Venue { get; set; }
        [Required]
        [FutureDate]
        public string Date { get; set; } 
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Occupations { get; set; }
        public IEnumerable<Occupations> Profession { get; set; }
        public DateTime GetDateTime() 
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}