using MentorHub.Models;
using System;
using System.Collections.Generic;

namespace MentorHub.ViewModels
{
    public class SessionsFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; } 
        public string Time { get; set; }
        public byte Occupations { get; set; }
        public IEnumerable<Occupations> Profession { get; set; }
        public DateTime DateTime 
        {
            get { return DateTime.Parse(string.Format("{0} {1}", Date, Time)); }
        }
    }
}