using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Workflow_Tracker.Models
{
    public class Project
    {
        [Key]
        public int Project_Id { get; set; }

        //add FKs
    }
}
