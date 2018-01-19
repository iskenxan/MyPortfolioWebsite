using System;
using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class DataManager
    {
        
        public static List<string> getKnownLanguages()
        {
            List<string> languages = new List<string>();
            languages.Add("Java");
            languages.Add("C#");
            languages.Add("VB.NET");
            languages.Add("JavaScript");
            languages.Add("C++");
            languages.Add("React.JSX");
            languages.Add("SQL");
            languages.Add("XML");
            languages.Add("HTML");

            return languages;
        }


        public static List<string> getKnowTechnologies()
        {
            List<string> technologies = new List<string>();
            technologies.Add("Android SDK");
            technologies.Add("Apache Tomcat");
            technologies.Add("React.JS");
            technologies.Add("ASP.NET MVC");
            technologies.Add("WPF");
            technologies.Add("AWS");
            technologies.Add("Linux");

            return technologies;
        }


        public static ProjectListManager getMyProjectListManager()
        {
            ProjectListManager manager = new ProjectListManager();

            Project project1 = new Project();
            project1.Name = "EZNDA";
            project1.Description = "A web application for signing NDA's quickly and efficiently. Written in React.JS with a Tomcat as a back end server. ";
            project1.ImageUrl = "/Content/Images/project1.jpg";

            Project project2 = new Project();
            project2.Name = "Brain Marathon";
            project2.Description = "A two player online game written for Android OS. Uses Firebase as a cloud storage and the database.";
            project2.ImageUrl = "/Content/Images/project2.jpg";

            manager.addProject(project1);
            manager.addProject(project2);

            return manager;
        }


        public static ReviewsManager getMyReviews()
        {
            ReviewsManager manager = new ReviewsManager();
            Review review1 = new Review();
            review1.Name = "Sunny Ridge Productions";
            review1.ProjectName = "Android app using Foursquare location API and camera";
            review1.Rating = 5;
            review1.Date = Formatter.convertDateToHumanString(DateTime.Now);
            review1.Comment = "I had a terrific experience with Iskander. Codes it right and tests his own stuff thoroughly. Identifies and solves problems independently. Communicates well live and in writing. I will definitely hire him again for Android development.";

            Review review2 = new Review();
            review2.Name = "Defence Unlimited";
            review2.ProjectName = "A Military website written in PHP";
            review2.Rating = 4;
            review2.Date = Formatter.convertDateToHumanString(DateTime.Now);
            review2.Comment = "Great web developer. On time. works well. understands instructions and understands what looks good. Definitely recommend this developer.";


            manager.addReview(review1);
            manager.addReview(review2);

            return manager;
        }
    }
}