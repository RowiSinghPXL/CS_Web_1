using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstRazorWebApp.Pages
{
    public class NieuweKlantModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string klant = Request.Form["Klant"];
            Data.Databank.AddKlant(klant);
            return RedirectToPage("Klant");
        }
    }
}
