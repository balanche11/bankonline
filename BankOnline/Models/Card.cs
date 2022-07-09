using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class Card
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Maintenance Fee (RSD)")]
        public int MaintenanceFee { get; set; }

        [Display(Name = "Effective Nominal Rate %")]
        public decimal EffectiveNominalRate { get; set; }
        public Brand Brand { get; set; }
        public TypeOfCard TypeOfCard { get; set; }
        public ICollection<PhysicalCard> PhysicalCards { get; set; }


    }
}