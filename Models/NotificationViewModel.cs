using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PechicoDesktop.Models
{
    class NotificationViewModel
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string TelephoneNumber { get; set; }

        public DateTime InquiryAt { get; set; }
    }
}
