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


        public static string writeReviewToDatabase(Review review)
        {
            string query = "insert in [Reviews] values('"+review.Name+"','"+review.ProjectName+"','"+review.DateString+"',"+review.Rating+")";
            string result = executeWriteCommand(query);

            return result;
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
        

        private static string executeNonQueryCommand(string query)
        {
                SqlConnection con = new SqlConnection();
                SqlCommand command = new SqlCommand();
                command.CommandText = query;
                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                return "success";
        }
    }
}   