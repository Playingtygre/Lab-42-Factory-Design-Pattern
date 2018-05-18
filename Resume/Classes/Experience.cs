using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
   public class Experience : Page
    {
        /* Concrete Class of pages
         */

        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string JobDescription { get; set; }
    }
}
