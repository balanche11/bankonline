using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class PhysicalCard
    {
        public int Id { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ValidUntil { get; set; }
        public string ControlNumber { get; set; }
        public string AccountNumber { get; set; }
        public Card Card { get; set; }

    }
}