using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class User
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();

        public void LoadUsers(MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT u.id, u.username, u.password, u.user_level, u.active, u.created,
                            CONCAT(p.first_name, ' ', p.last_name) AS Name, p.title AS Title
                            FROM mmg_lab.tblusers u, mmg_lab.tblprofiles p WHERE u.id = p.id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        grid.DataSource = dt;

                        if (dt.Rows.Count != 0)
                        {
                            // Get number of records
                            val.PatientCount = dt.Rows.Count;

                            // Set column headers
                            grid.Columns["username"].Visible = false;
                            grid.Columns["password"].Visible = false;
                            grid.Columns["user_level"].Visible = false;
                            grid.Columns["created"].Visible = false;
                            grid.Columns["active"].HeaderText = "Is Active";

                            GetUserDetail(0, grid);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Load Patients: " + error);
            }
        }

        public void GetUserDetail(int row, MetroFramework.Controls.MetroGrid grid)
        {
            val.UserID = (int)grid[0, row].Value;
            val.Username = (string)grid[1, row].Value;
            val.UserLevel = (int)grid[3, row].Value;
            val.UserActive = (bool)grid[4, row].Value;
        }

        public bool AddUser(string username, string password, int user_level, string first_name, string middle_name, string last_name, string title, string license_no)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tblusers(username, password, user_level)
                                VALUES(@username, MD5(@password), @user_level);
                                
                                SET @'last_user_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name,
                                title, license_no) VALUES(@'last_user_id', @first_name, @middle_name, 
                                @last_name, @title, @license_no);";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@user_level", user_level);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@title", title);
                        cmd.Parameters.AddWithValue("@license_no", license_no);                     

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }

                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Adding User: " + error);
                Log.AddLog(val.UserID, "Error Adding User: " + error.ToString());
                return false;
            } 
        }

        public void SearchUser(string keyword, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT u.id, u.username, u.password, u.user_level, u.active, u.created,
                            CONCAT(p.first_name, ' ', p.last_name) AS Name, p.title AS Title
                            FROM mmg_lab.tblusers u, mmg_lab.tblprofiles p WHERE u.id = p.id AND 
                            (p.first_name LIKE @keyword OR p.middle_name LIKE @keyword OR p.last_name LIKE @keyword OR p.title LIKE @keyword)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@keyword", String.Format("{0}{1}{2}", "%", keyword, "%"));


                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        grid.DataSource = dt;

                        if (dt.Rows.Count != 0)
                        {
                            // Get number of records
                            val.PatientCount = dt.Rows.Count;

                            // Set column headers
                            grid.Columns["username"].Visible = false;
                            grid.Columns["password"].Visible = false;
                            grid.Columns["user_level"].Visible = false;
                            grid.Columns["created"].Visible = false;
                            grid.Columns["active"].HeaderText = "Is Active";

                            GetUserDetail(0, grid);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Searching User: " + error);
                Log.AddLog(val.UserID, "Error Searching User: " + error.ToString());
            }
        }
    }
}
