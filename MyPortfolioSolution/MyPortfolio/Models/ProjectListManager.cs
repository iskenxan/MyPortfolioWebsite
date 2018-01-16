using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class ProjectListManager
    {
        private List<Project> projects = new List<Project>();
        public List<Project> Projects { get { return projects; } set { this.projects = value; } }

        public void addProject(Project project)
        {
            projects.Add(project);
        }

        public Project getProject(int index)
        {
            return projects[index];
        }
    }
}