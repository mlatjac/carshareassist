using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace carshareassiststarter.Models
{
    public class Car
    {


        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Brand { get; set; }
       
        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Rent date")]
        public DateTime? Rentdate { get; set; }

   

      
    }
}