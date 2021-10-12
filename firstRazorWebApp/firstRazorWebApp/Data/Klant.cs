﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstRazorWebApp.Data
{
    public class Klant
    {
        public Klant()
        {
            KlantId = -1;
            KlantNaam = string.Empty;
        }

        public Klant(int id, string naam)
        {
            KlantId = id;
            KlantNaam = naam;
            LocatieId = 0;
        }

        public Klant(int id, string naam, int locatieId)
        {
            KlantId = id;
            KlantNaam = naam;
            LocatieId = locatieId;
        }

        public int KlantId { get; set; }
        public string KlantNaam { get; set; }
        public bool GevalideerdeKlant => (KlantId > -1);
        public int LocatieId { get; set; }
    }
}
