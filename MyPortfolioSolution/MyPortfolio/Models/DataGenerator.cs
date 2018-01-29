﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class DataConverter
    {

        public static Review generateReview(string reviewerName, string projectDescription, string reviewComment, int rating)
        {
            String dateStr = Formatter.convertDateToHumanString(DateTime.Now);
            Review review = new Review() {Name=reviewerName,ProjectName=projectDescription,Comment=reviewComment,Rating=rating,DateString=dateStr };

            return review;
        }

        public static Review getSingleReview(SqlDataReader reader)
        {
            Review review = new Review();
            review.Name = (string)reader["ReviewerName"];
            review.ProjectName = (string)reader["ProjectTitle"];
            review.Comment = (string)reader["Comments"];
            review.DateString = (string)reader["Date"];
            review.Rating = (int)reader["Rating"];

            return review;
        }
    }
}