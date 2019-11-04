using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ACG_CoreRazorContoso.Pages
{
    public class ConverterModel : PageModel
    {
        public Decimal Pounds { get; set; }

        public Decimal Dollars { get; set; }

        public void OnGet()
        {
            Pounds = 0;
            Dollars = 0;
        }
        public void OnPost()
        {
            this.Pounds = Convert.ToDecimal(Request.Form["Pounds"]);
            Dollars = Pounds * 1.13m;
        }
    }
}