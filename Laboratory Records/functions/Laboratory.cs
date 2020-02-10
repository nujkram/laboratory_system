using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Laboratory
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();

        public void GetLaboratoryType(string name)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tbllab_type WHERE name = @name";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@name", name);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.LabID = dt.Rows[0].Field<int>("id");
                        val.LabName = dt.Rows[0].Field<string>("name");
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Laboratory Type: " + error);
            }
        } 
    }
}
