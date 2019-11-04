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

        /// <summary>
        /// This is a method that will be called
        /// when an http get occurs. This sets the Name
        /// to blank for the user to change
        /// </summary>
        public void OnGet()
        {
            Name = null;
        }

        /// <summary>
        /// This retrieves ther user's name from the form
        /// and sets it into the Name property
        /// </summary>
        public void OnPost()
        {
            this.Name = Request.Form["Name"];
        }



    }
}