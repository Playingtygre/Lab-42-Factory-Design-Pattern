﻿using System;
using System.Collections.Generic;
using Resume.Classes;

namespace Resume
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t Build a simple Resume");

            Console.ReadLine();

            Console.WriteLine("What is your name?");

            string applicantName = Console.ReadLine();
            ////
            Console.WriteLine("What is your email");

            string email = Console.ReadLine();

            Console.WriteLine("how would you describe yourself???");

            string summary = Console.ReadLine();
            Console.Clear();

            Profile profile = new Profile
            {
                ApplicantName = applicantName,
                Email = email,
                Summary = summary,

            };


            Console.WriteLine("A few questions about where you worked last");

            Console.WriteLine("What was your last company name?");

            string company = Console.ReadLine();

            Console.WriteLine("What was your Job title?");

            string jobtitle = Console.ReadLine();

            Console.WriteLine("summarize that job");

            string jobdescription = Console.ReadLine();


            Experience experience = new Experience
            {
                CompanyName = company,
                JobTitle = jobtitle,
                JobDescription = jobdescription
            };
            Console.Clear();
            Console.WriteLine("One question about your education");
            Console.WriteLine("What was your last education experience");

            string school = Console.ReadLine();

            Console.WriteLine("What kind of degree did you get?");

            string degree = Console.ReadLine();

            Console.WriteLine("What year was your degree?");

            int gradyear = Int32.Parse(Console.ReadLine());

            Education education = new Education
            {
                School = school,
                Degree = degree,
                GraduationYear = gradyear
            };

            
            ResumePaper resume = new ResumePaper
            {
                Profile = profile,
                Experience = experience,
                Education = education
            };

            resume.CreatePage();

            Console.Clear();
            Console.WriteLine($"\n\t-----------------------------------------------------------------------------------------");
            Console.WriteLine($"\n\t Console Log Resume Builder");
            Console.WriteLine($"\n\t {resume.Profile.ApplicantName}");
            Console.WriteLine($"\n\t {resume.Profile.Email} || {resume.Profile.Summary}");
            Console.WriteLine($"\n\t---------------------------------------My Work Experience-------------------------------------------");
            Console.WriteLine($"\n\t {resume.Experience.CompanyName}");
            Console.WriteLine($"\n\t {resume.Experience.JobTitle} || {resume.Experience.JobDescription}");
            Console.WriteLine($"\n\t---------------------------------------My Education Background--------------------------------");
            Console.WriteLine($"\n\t {resume.Education.School}");
            Console.WriteLine($"\n\t {resume.Education.School} || {resume.Education.Degree} || {resume.Education.GraduationYear}");
            Console.WriteLine($"\n\t-----------------------------------------------------------------------------------------");

            //Console.WriteLine($"{resume.Profile.ApplicantName}");
            Console.ReadLine();
            










        }
    }
}

//Uploaded the Diagram from yesterday's lecture. Quick hint for your construction of the factory.
//Think of your *Documents* you are createing in your lab as the PizzaStore, and the individual *Pages*
 //   you are instantiating as your Pizza. A *Document* depends on *Pages* for completion.