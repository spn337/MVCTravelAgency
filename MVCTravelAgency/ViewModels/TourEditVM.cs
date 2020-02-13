using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTravelAgency.ViewModels
{
    public class TourEditVM : TourCreateVM
    {
        public int Id { get; set; }
        public string ExistImgName { get; set; }
        public string ExistImgLargeName { get; set; }
    }
}
