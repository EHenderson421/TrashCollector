using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewTrashCollector.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public float Amount { get; set; }
    }
}