using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace carshareassiststarter.Models
{
    public class Client
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter Your FullName")]
        [MaxLength(50)]
        public string FullName { get; set; }

        //[MaxLength(255)]
        [MaxLength(255, ErrorMessage = "Address cannot exceed 255 characters")]
        public string Address { get; set; }


        [Required]
        public DateTime rentalTimeDuration { get; set; }

     
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        
      
        ////override toString method
        //public override string ToString()
        //{
        //    //return "Customer name:" + Name + " | Address: " + Address;
        //}
    }
}