using MentorHub.Models;
using MentorHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace MentorHub.Controllers
{
    public class SessionsController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        public SessionsController()
        {
            _context = new ApplicationDbContext();
        }
        
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new SessionsFormViewModel
            {
                Profession =  _context.Occupations.ToList()
            };

            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(SessionsFormViewModel viewModel)
        {
            var sessions = new Sessions
            {
                MentorId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0} {1}", viewModel.Date, viewModel.Time)),
                OccupationsId = viewModel.Occupations,
                Venue = viewModel.Venue
            };

            _context.Sessions.Add(sessions);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}