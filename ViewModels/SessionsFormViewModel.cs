using MentorHub.Models;
using System.Collections.Generic;

namespace MentorHub.ViewModels
{
    public class SessionsFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; } 
        public string Time { get; set; }
        public int Occupations { get; set; }
        public IEnumerable<Occupations> Profession { get; set; }

    }
}