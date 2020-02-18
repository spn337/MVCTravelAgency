using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTravelAgency.Interfaces;
using MVCTravelAgency.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCTravelAgency.Controllers
{
    public class TourController : Controller
    {
        private readonly ITourRepository _tourRepository;
        private readonly ILogger logger;
        public TourController(ITourRepository tourRepository, ILogger<TourController> logger)
        {
            _tourRepository = tourRepository;
            this.logger = logger;
        }
        [Route("Tour/Index/{id}")]
        public IActionResult Tour(int id)
        {
            //logger.LogTrace("Trace Log");
            //logger.LogDebug("Debug Log");
            //logger.LogInformation("Information Log");
            //logger.LogWarning("Warning Log");
            //logger.LogError("Error Log");
            //logger.LogCritical("Critical Log");

            var tour = _tourRepository.GetTourById(id);

            return View(tour);
        }
        public IActionResult Index()
        {
            List<Tour> Tours = _tourRepository.GetAllTours().ToList();
            return View(Tours);
        }
    }
}