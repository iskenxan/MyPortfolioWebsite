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
    }
}