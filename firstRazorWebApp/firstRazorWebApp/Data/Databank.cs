using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstRazorWebApp.Data
{
    public class Databank
    {
        public static List<Klant> Klanten = new List<Klant>();
        public static List<Locatie> Locaties = new List<Locatie>();
        public static void StartDataBank()
        {
            Klanten.Add(new Klant(1, "Klant A", 1));
            Klanten.Add(new Klant(2, "Klant B", 2));
            Locaties.Add(new Locatie(1, "Hasselt", 3500));
            Locaties.Add(new Locatie(2, "Genk", 3600));

        }
        public static void AddLocation(string postcode, string city)
        {
            int p = Convert.ToInt32(postcode);
            int id = Locaties.Max(x => x.LocationId) + 1;
            Locaties.Add(new Locatie(id, city, p));
        }
        public static void AddKlant(string naam)
        {
            int id = Klanten.Max(x => x.KlantId) + 1;
            Klanten.Add(new Klant(id, naam));
        }
    }
}
