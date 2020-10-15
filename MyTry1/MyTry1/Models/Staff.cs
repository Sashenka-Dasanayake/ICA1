using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyTry1.Models
{
    public class Staff
    {
        [Key]
        public String StaffNo { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Position { get; set; }
        public DateTime DOB { get; set; }
        public int Salary { get; set; }
        public Branch branch_BranchNo { get; set; }
    }
}