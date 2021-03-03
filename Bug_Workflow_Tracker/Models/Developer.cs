using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Workflow_Tracker.Models
{
    public class Developer
    {
        [Key]
        public int Dev_Id { get; set; }

        [Display(Name = "First Name")]
        public string First_name { get; set; }

        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Developer Production Rate")]
        public double Dev_ProductionRate { get; set; }

        //foreign keys
    }
}
