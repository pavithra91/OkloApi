using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OkloApi.Models
{
    public class Invoice
    {
        public string ReferenceId { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string ErrorType { get; set; }

        public string DocumentId { get; set; }
    }
}