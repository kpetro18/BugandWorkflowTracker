using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Workflow_Tracker.Models
{
    public class Ticket
    {
        [Key]
        public int Ticket_Id { get; set; }

        [Display(Name = "Ticket Type")]
        public string TicketType { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Comment")]
        public string Comment { get; set; }

        [Display(Name = "Date Changed")]
        public DateTime DareChanged { get; set; }

        [Display(Name = "Priority Level")]
        public string PriorityLevel { get; set; } //auto set to high when ticket is created

        [Display(Name = "Time Updated")]
        public DateTime TimeUpdated { get; set; }

        [Display(Name = "Time Completed")]
        public DateTime TimeCompleted { get; set; }

        //add FKs

    }
}
