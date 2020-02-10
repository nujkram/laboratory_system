using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Log
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();

        public void AddLog(int user_id, string detail)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbllogs(user_id, detail) VALUES(@user_id, @detail)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@detail", detail);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Adding Patient: " + error);
            }
        }
    }
}
