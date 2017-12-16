using SimpleCarERide.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleCarERide.ViewModels
{
    public class ListTypesViewModel
    {

        public List<CarType> lstCarTypes { get; set; }

        public ListTypesViewModel(List<CarType> carTypes)
        {
            lstCarTypes = carTypes;
        }
    }
}