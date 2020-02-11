using MVCTravelAgency.Models;
using System.Collections.Generic;

namespace MVCTravelAgency.Interfaces
{
    public interface ITourRepository
    {
        Tour GetTourById(int id);
        IEnumerable<Tour> GetAllTours();
        Tour CreateTour(Tour newTour);
    }
}
