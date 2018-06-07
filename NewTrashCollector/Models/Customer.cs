using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        [ForeignKey("Schedule")]
        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }


        public List<Customer> Customers { get; set; }
        public ApplicationUser User { get; set; }

    }
}