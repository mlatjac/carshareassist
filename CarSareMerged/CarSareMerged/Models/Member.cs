using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarSareMerged.Models
{
    public class Member
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter the first name")]
        [MaxLength(50)]
        [Display(Name = "First name")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Please enter the last name")]
        [MaxLength(50)]
        [Display(Name = "Last name")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        [MaxLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter phone number")]
        [MaxLength(50)]
        public string Phone { get; set; }
        public List<Loan> LoanHistory { get; set; }

    }
}