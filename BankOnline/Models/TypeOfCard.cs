using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class TypeOfCard
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<Brand> Brands { get; set; }
        public ICollection<Card> Cards { get; set; }

    }
}