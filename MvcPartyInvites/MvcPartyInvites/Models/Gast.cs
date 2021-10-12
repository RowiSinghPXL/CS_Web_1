using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPartyInvites.Models
{
    public class Gast
    {
        [Required]
        public string Naam { get; set; }
        [Required(ErrorMessage ="Vul je email in")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage ="Vul je telefoonnummer in!")]
        public string Telefoon { get; set; }
        [Required(ErrorMessage = "Laat weten of je aanwezig zal zijn!")]
        public bool? Aanwezig { get; set; }

       
    }
}
