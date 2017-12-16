using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarSareMerged.Models;

namespace CarSareMerged.ViewModels
{
    public class HomePageViewModel
    {

        public List<CarType> lstCarTypes { get; set; }

        public HomePageViewModel(List<CarType> carTypes)
        {
            lstCarTypes = carTypes;
        }
    }

}