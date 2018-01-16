namespace MyPortfolio.Models
{
    public class Project
    {
        private string name;
        private string description;
        private string imageUrl;

        public string Name { get { return name; } set { this.name = value; } }
        public string Description { get { return description; } set { this.description = value; } }
        public string ImageUrl { get { return imageUrl; } set { imageUrl = value; } }
    }
}