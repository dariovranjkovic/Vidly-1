using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly_1.Models;

namespace Vidly_1.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customers { get; set; }
    }
}