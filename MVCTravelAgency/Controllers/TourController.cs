using Microsoft.AspNetCore.Mvc;
using MVCTravelAgency.Entities;
using MVCTravelAgency.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCTravelAgency.Controllers
{
    public class TourController : Controller
    {
        private readonly DBContext _context;
        public TourController(DBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Tour> Tours = _context.Tours.ToList();
            return View(Tours);
        }
    }
}