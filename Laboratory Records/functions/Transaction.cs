using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Transaction
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Profile profile = new Profile();
        Log Log = new Log();

        public void LoadTransactions(int record_id, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT t.id, t.record_id, t.lab_type_id, l.name AS Name, DATE(t.created) as Created, t.created_by 
                                FROM mmg_lab.tbltransactions t, mmg_lab.tbllab_type l 
                                WHERE t.lab_type_id = l.id AND t.record_id = @record_id ORDER BY t.created DESC";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        grid.DataSource = dt;

                        if (dt.Rows.Count != 0)
                        {
                            val.TransID = dt.Rows[0].Field<int>("id");
                            val.TransCreated = dt.Rows[0].Field<DateTime>("Created");

                            grid.Columns[0].Visible = false;
                            grid.Columns[1].Visible = false;
                            grid.Columns[2].Visible = false;
                            grid.Columns[5].Visible = false;

                            profile.GetEncoderProfile(dt.Rows[0].Field<int>("created_by"));
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Transactions: " + error);
            }
        }

        public void GetTransaction(int row, MetroFramework.Controls.MetroGrid grid)
        {
            val.TransID = (int)grid[0, row].Value;
            val.TransLabType = (int)grid[2, row].Value;
            val.TransCreatedBy = (int)grid[5, row].Value;
            val.TransCreated = (DateTime)grid[4, row].Value;
        }
    }
}
