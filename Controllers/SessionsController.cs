using MentorHub.Models;
using MentorHub.ViewModels;
using Microsoft.AspNet.Identity;
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
                Profession = _context.Occupations.ToList()
            };

            return View(viewModel);
        }
        [Authorize]
        [HttpPost]
        public ActionResult Create(SessionsFormViewModel viewModel)
        {
            if (!ModelState.IsValid)//applied the not operator
            {
                viewModel.Profession = _context.Occupations.ToList();
                return View("Create", viewModel);
            }
            

            var sessions = new Sessions
            {
                MentorId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                OccupationsId = viewModel.Occupations,
                Venue = viewModel.Venue
            };

            _context.Sessions.Add(sessions);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}