using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class Brand
    { 
        public int Id { get; set; }

        [Required]
        [Display(Name = "Brand Name")]
        public string Name { get; set; }
        public ICollection<TypeOfCard> TypeOfCards { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}