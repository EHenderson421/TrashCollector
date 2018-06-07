using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewTrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "User Name")]
        public string UserId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone#")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Pick Up Day")]
        public string PickUpDay { get; set; }

        [Display(Name = "Suspend Pick Up")]
        public string SuspendPickUp { get; set; }

        [Display(Name = "Restart Pick Up")]
        public string RestartPickUp { get; set; }

        [Display(Name = "Bill Current")]
        public bool HasPaid { get; set; }





    }
}