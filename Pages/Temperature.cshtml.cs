using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class TemperatureModel : PageModel
    {
        public string Conversion { get; set; }
        [BindProperty]
        public int Number { get; set; }
        public void OnGet()
        {

        }
        public void OnPost(string select)
        {
            switch (select)
            {
                case "ftc":
                    Conversion = (Number - 32) / 1.8 + " Degrees";
                    break;
                case "ctf":
                    Conversion = (Number * 1.8) + 32 + " Degrees";
                    break;
            }
        }
    }
}
