using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyPortfolio.Models
{
    public class DatabaseManager
    {
        

        public static string connectToDatabase()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\MyDB.mdf;Initial Catalog=MyDB;Integrated Security=True");
                SqlCommand command = new SqlCommand();
                command.CommandText = "insert into [Reviews] values('','Iskander Samatov','Test',123123,5)";
                command.Connection = con;
                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                return "Success";
            }
            catch(Exception e)
            {
                return e.GetBaseException().ToString();
            }

        }
    }
}   