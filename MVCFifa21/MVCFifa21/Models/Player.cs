using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCFifa21.Models
{
    public class Player
    {
        // Id of PlayerId gebruiken zo weet entity framework uniek veld
        public int PlayerId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximum 50 tekens")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string ImageLink { get; set; }

        public Player()
        {

        }
        public Player(int id, string firstName, string lastName, string imageLink)
        {
            PlayerId = id;
            FirstName = firstName;
            LastName = LastName;
            ImageLink = imageLink;
        }
    }
}
