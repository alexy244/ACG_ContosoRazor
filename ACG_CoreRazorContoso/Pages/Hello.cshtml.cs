using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ACG_CoreRazorContoso.Pages
{
    public class HelloModel : PageModel
    {

        public string Name { get; set; }
        public void OnGet()
        {
            Name = null;
        }

        public void onPost()
        {

            this.Name = Request.Form["Name"];


        }



    }
}