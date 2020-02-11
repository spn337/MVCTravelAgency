using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MVCTravelAgency.Helpers;
using MVCTravelAgency.Interfaces;
using MVCTravelAgency.Models;
using MVCTravelAgency.ViewModels;
using System;
using System.IO;

namespace MVCTravelAgency.Controllers
{
    public class AdminController : Controller
    {
        private ITourRepository _tourRepository;
        private IHostingEnvironment _hostingEnvironment;
        public AdminController(ITourRepository tourRepository, IHostingEnvironment hostingEnvironment)
        {
            _tourRepository = tourRepository;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult CreateTour()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTour(TourCreateVM model)
        {
            if(!ModelState.IsValid)
            {
                BadRequest();
            }

            string uniqImgName = ImageHelper.Create(_hostingEnvironment, model.Img);
            string uniqImgLargeName = ImageHelper.Create(_hostingEnvironment, model.ImgLarge);

            Tour newTour = new Tour
            {
                Name = model.Name,
                Description = model.Description,
                DepartureTown = model.DepartureTown,
                DepartureDate = model.DepartureDate,
                Countries = model.Countries,
                IsNightCrossing = model.IsNightCrossing,
                isFavorite = model.isFavorite,
                Period = model.Period,
                Price = model.Price,
                Img = uniqImgName,
                ImgLarge = uniqImgLargeName,
            };

            _tourRepository.CreateTour(newTour);

            return View();
        }
    }
}