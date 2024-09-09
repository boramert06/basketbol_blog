using DocumentFormat.OpenXml.Drawing.Charts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Deneme.Controllers
{
    [AllowAnonymous]
    public class RepresentationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddRepresentation()
        {
            return View();
        }
        public IActionResult AddRefereeBoard()
        {
            return View(); 
        }
        public IActionResult AddOrderCommittee()
        {
            return View();
        }
        public IActionResult AddFormerrePresentatives()
        {
            return View();
        }
    }
}
