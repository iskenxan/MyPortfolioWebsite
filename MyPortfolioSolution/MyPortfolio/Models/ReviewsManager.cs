using System.Collections.Generic;

namespace MyPortfolio.Models
{
    public class ReviewsManager
    {
        private List<Review> reviews = new List<Review>();

        public List<Review> Reviews { get { return reviews; } set { reviews = value; } }

        public void addReview(Review review)
        {
            reviews.Add(review);
        }

    }
}