using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace firstRazorWebApp.Pages
{
    public class SelecteerLocatieModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var locId = Request.Form["SelectLocatie"].FirstOrDefault();
            return RedirectToPage("LocatieDetails", new { id = int.Parse(locId) });
        }
    }
}
