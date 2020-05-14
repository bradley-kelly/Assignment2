using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment2.Pages
{
    public class MassModel : PageModel
    {
        public string Conversion { get; set; }
        [BindProperty]
        public float Number { get; set; }
        public void OnGet()
        {

        }
        public void OnPost(string select)
        {
            switch (select)
            {
                case "pto":
                    Conversion = (Number * 16) + " Ounces";
                    break;
                case "otp":
                    Conversion = (Number / 16) + " Pounds";
                    break;
                case "gtp":
                    Conversion = (Number / 454) + " Pounds";
                    break;
                case "mtp":
                    Conversion = (Number / 453592) + " Pounds";
                    break;
            }
        }
    }
}