namespace MyPortfolio.Models
{
    public class Project:DatabaseRecord
    {
        private string name;
        private string description;
        private string imageName;

        public string Name { get { return name; } set { this.name = value; } }
        public string Description { get { return description; } set { this.description = value; } }
        public string ImageName { get { return imageName; } set { imageName = value; } }
    }
}