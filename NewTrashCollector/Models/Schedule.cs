using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewTrashCollector.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Display(Name = "Pick Up Day")]
        public string PickUpDay { get; set; }

        [Display(Name = "Pick Up Frequency")]
        public string PickUpFrequency { get; set; }

        [Display(Name = "Suspend Pick Up")]
        public bool SuspendPickUp { get; set; }

    }
}