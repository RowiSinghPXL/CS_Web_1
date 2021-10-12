using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstRazorWebApp.Data
{
    public class Locatie
    {
        public Locatie()
        {
            LocationId = -1;
            City = string.Empty;
            PostalCode = -1;
        }
        public Locatie(int locId, string city, int postalCode)
        {
            LocationId = locId;
            City = city;
            PostalCode = postalCode;
        }
        public int LocationId { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
    }
}
