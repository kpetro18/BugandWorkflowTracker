using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Workflow_Tracker.Models
{
    public class ProjectManager
    {
        [Key]
        public int PM_Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [ForeignKey("Developer")]
        [Display(Name = "Developer Production Rate")]
        public int Dev_Productionrate { get; set; }
        public Developer? Developer { get; set; }

        // add [ForeignKey("Developer")]
    }
}
