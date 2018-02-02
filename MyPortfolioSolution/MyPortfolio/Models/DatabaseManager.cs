using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class DatabaseManager
    {
        public static string REVIEWS_TABLE = "[Reviews]";
        public static string REVIEW_APPROVED = "IsApproved";


        private static string DATABASE_CONNECTION_STRING = "Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MyDB.mdf;Initial Catalog=MyDB;Integrated Security=True";
        private static SqlConnection con;

        public static string writeReviewToDatabase(Review review)
        {
            string query = "insert into [Reviews] values('"+review.Name+"','"+review.ProjectName+"','"+review.Comment+"','"+review.DateString+"',"+review.Rating+","+review.IsApproved+");";
            string result = executeWriteCommand(query);

            return result;
        }


        public static string updateRecord(string table, int id, string column, object newValue)
        {
            string result = null;
            newValue = DataConverter.convertDataToDatabaseFormat(newValue);
            string query = "update " + table + " set " + column + "=" + newValue + " where Id=" + id + ";";
            result = executeWriteCommand(query);

            return result;
        }


        public static string removeRecord(string table, int id)
        {
            string result = null;
            string query = "delete from " + table +" where Id=" + id + ";";
            result = executeWriteCommand(query);

            return result;
        }


        public static List<DatabaseRecord> getRecords(string table)
        {
           string query = "select * from "+table+";";
           return  executeSelectQueryAndReadResult(query, table);
        }


        public static List<DatabaseRecord> getRecords(string table, string selector, object value)
        {
            value = DataConverter.convertDataToDatabaseFormat(value);

            string query = "select * from " + table + " where "+selector+"="+value+";";
            return executeSelectQueryAndReadResult(query, table);
        }


        private static List<DatabaseRecord> executeSelectQueryAndReadResult(string query,string table)
        {
            List<DatabaseRecord> reviews = new List<DatabaseRecord>();
            SqlDataReader reader = executeSelectCommand(query);
            while (reader != null && reader.Read())
            {
                DatabaseRecord review = DataConverter.getSingleRecord(reader,table);
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