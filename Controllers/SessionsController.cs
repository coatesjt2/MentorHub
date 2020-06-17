using MentorHub.Models;
using MentorHub.ViewModels;
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
        public ActionResult Create()
        {
            var viewModel = new SessionsFormViewModel
            {
                Profession =  _context.Occupations.ToList()
            };

            return View(viewModel);
        }
    }
}