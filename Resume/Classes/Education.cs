using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
    public class Education : Page
    {
        /* Concrete Class of Pages
         */

        public string School { get; set; }

        public string Degree { get; set; }

        public int GraduationYear {get;set;}

    }
}
