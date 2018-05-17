using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
    public class Page
    {
        public string Color { get; set; }

        public bool Lined { get; set; }

        public Profile Profile { get; set; }

        public TechnicalSkills TechnicalSkills { get; set; }

        public Projects Projects { get; set; }

        public Experience Experience { get; set; }

        public Education Education { get; set; }
    }
}
