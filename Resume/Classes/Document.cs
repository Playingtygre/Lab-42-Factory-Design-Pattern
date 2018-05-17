using System;
using System.Collections.Generic;
using System.Text;

namespace Resume.Classes
{
    public abstract class Document
    {
        public Profile Profile { get; set; }

        public TechnicalSkills TechnicalSkills { get; set; }

        public Projects Projects { get; set; }

        public Experience Experience { get; set; }

        public Education Education { get; set; }


        public List<Page> Page = new List<Page>();

        public abstract void CreatePage();

        public Document Factory(ResumeStyle resumeStyle)
        {
            switch (resumeStyle)
            {
                case ResumeStyle.CleanResume:
                    return new ResumePaper();

                case ResumeStyle.DraftResume:
                    return new ResumePaper();

                default:
                    return null;
            }
        }


    }
}
