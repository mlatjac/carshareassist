using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarSharing.Models
{
    public class Loan
    {
        public int ID { get; set; }
        public byte MemberId { get; set; }
        public Member UserMember { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime ActualStartTime { get; set; }
        public DateTime ActualEndTime { get; set; }
        public Car Car { get; set; }
    }
}