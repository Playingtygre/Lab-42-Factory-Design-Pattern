using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
   public class Profile : Page
    {
        public string ApplicantName { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

        public string Summary { get; set; }
    }
}
