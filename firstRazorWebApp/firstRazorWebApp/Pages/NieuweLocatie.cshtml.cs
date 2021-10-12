using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstRazorWebApp.Pages
{
    public class NieuweLocatieModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            string postcode = Request.Form["PostCode"];
            string city = Request.Form["City"];
            Data.Databank.AddLocation(postcode, city);
            return RedirectToPage("Locaties");
        }
    }
}
