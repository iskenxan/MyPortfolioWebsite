using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class DatabaseManager
    {

        private static string DATABASE_CONNECTION_STRING = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MyDB.mdf;Initial Catalog=MyDB;Integrated Security=True";
        private static SqlConnection con;

        public static string writeReviewToDatabase(Review review)
        {
            string query = "insert into [Reviews] values('"+review.Name+"','"+review.ProjectName+"','"+review.Comment+"','"+review.DateString+"',"+review.Rating+");";
            string result = executeWriteCommand(query);

            return result;
        }


        public static List<Review> getReviews()
        {
            string query = "select * from [Reviews];";
            List<Review> reviews = new List<Review>();
            SqlDataReader reader = executeSelectCommand(query);
            while (reader != null && reader.Read())
            {
                Review review = DataConverter.getSingleReview(reader);
                reviews.Add(review);
            }

            return reviews;
        }


        private static string executeWriteCommand(string query)
        {
            string result;
            try
            {
                result= executeNonQueryCommand(query);
            }
            catch(Exception e)
            {
                result = e.GetBaseException().ToString();
            }

            return result;
        }


        private static SqlDataReader executeSelectCommand(string query)
        {
            SqlDataReader reader;
            try
            {
                reader = executeQueryCommand(query);
            }
            catch (Exception e)
            {
                reader = null;
            }

            return reader;
        }



        private static string executeNonQueryCommand(string query)
        {
            SqlCommand command = getConnectedCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            con.Close();

            return "success";
        }


        private static SqlDataReader executeQueryCommand(string query)
        {
            SqlCommand command = getConnectedCommand();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            return reader;
        }


        private static SqlCommand getConnectedCommand()
        {
            con = new SqlConnection(DATABASE_CONNECTION_STRING);
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            con.Open();

            return command;
        }
    }
}   