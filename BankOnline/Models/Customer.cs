using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankOnline.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [Display (Name = "Full Name")]
        public string Name { get; set; }

        [Required, StringLength(6)]
        public string Gender { get; set; }

        [Required]
        [StringLength(13)]
        public string JMBG { get; set; }

        [Required]
        [StringLength (9)]
        public string IdCardRegNumber { get; set; }
        public string Adress { get; set; }
        
        [Display(Name = "Date Of Birth")]
        public DateTime BirthDate { get; set; }
        public string Employer { get; set; }

        [Display(Name = "Type Of Employment")]
        public string TypeOfEmployment { get; set; }
        public DateTime DateOfEmployment { get; set; }

        public ICollection<Request> Requests { get; set; }

    }
}