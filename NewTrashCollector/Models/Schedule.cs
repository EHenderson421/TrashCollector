using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewTrashCollector.Models
{
    public class Schedule
    {
        [Key]
        public int ScheduleId { get; set; }

        [Display(Name = "Pick Up Frequency")]
        public string PickUpFrequency { get; set; }

    }
}