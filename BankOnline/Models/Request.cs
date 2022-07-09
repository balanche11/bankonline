using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime DateOfApplication { get; set; }
        public string RequestStatus { get; set; }
        public string Commentary { get; set; }
        public List<Customer> Customers { get; set; }
        public Card Card { get; set; }
        
    }
}