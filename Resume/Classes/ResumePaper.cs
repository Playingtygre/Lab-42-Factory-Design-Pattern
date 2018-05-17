using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
    public class ResumePaper : Document 
    {
        public override void CreatePage()
        {
            Page.Add(Profile);

            Page.Add(Experience);

            Page.Add(Education);

        }
    }
}
