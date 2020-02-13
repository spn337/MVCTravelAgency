using Microsoft.EntityFrameworkCore;
using MVCTravelAgency.Interfaces;
using MVCTravelAgency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTravelAgency.Entities.Repository
{
    public class TourRepository : ITourRepository
    {
        private readonly DBContext context;
        public TourRepository(DBContext context)
        {
            this.context = context;
        }
        public Tour CreateTour(Tour newTour)
        {
            context.Tours.Add(newTour);
            context.SaveChanges();
            return newTour;
        }

        public Tour DeleteTour(Tour tour)
        {
            context.Tours.Remove(tour);
            context.SaveChanges();
            return tour;
        }

        public Tour EditTour(Tour newTour)
        {
            var tour = context.Tours.Attach(newTour);
            tour.State = EntityState.Modified;
            context.SaveChanges();
            return newTour;
        }

        public IEnumerable<Tour> GetAllTours()
        {
            return context.Tours;
        }

        public Tour GetTourById(int id)
        {
            return context.Tours.Find(id);
        }
    }
}
