using BankOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankOnline.ViewModels
{
    public class CustomerRequestViewModel
    {
        public Request Request { get; set; }
        public Customer Customer { get; set; }
        public IEnumerable<Brand> Brands { get; set; }
        public IEnumerable<TypeOfCard> TypeOfCards { get; set; }
        public IEnumerable<Customer> CustomersList { get; set; }

        
       
    }
}