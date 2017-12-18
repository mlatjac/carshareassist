using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CarSareMerged.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // Foreign Key for CarType
        public int CarTypeID { get; set; }
        public CarType CarType { get; set; }

        // Status fields
        public double currentPositionLat { get; set; }
        public double currentPositionLon { get; set; }
        public double currentOdometerReading { get; set; }
        public double currentFuelStatus { get; set; } // 0 is empty, 1 is full

    }

}