﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SimpleCarERide.Models
{
    public class CarType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ShortName { get; set; } // e.g. smart fortwo

        [Required]
        public string FullName { get; set; } // e.g. smart fortwo

        [Required]
        public string TagLine { get; set; } // e.g. zippy and easy to park

        [Required]
        public string FullDescription { get; set; } // e.g. the smart fortwo ... traffic jams

        [Required]
        public double RatePerMinute { get; set; }

        [Required]
        public double RatePerHour { get; set; }

        [Required]
        public double RatePerDay { get; set; }

        [Required]
        public string ImageReference { get; set; }
    }
}