using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Profile
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();

        public void GetUserProfile(int user_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblprofiles WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.ProfileID = dt.Rows[0].Field<int>("id");
                            val.ProfileFirstName = dt.Rows[0].Field<string>("first_name");
                            val.ProfileMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.ProfileLastName = dt.Rows[0].Field<string>("last_name");
                            val.ProfileTitle = dt.Rows[0].Field<string>("title");
                            val.ProfileLicenseNo = dt.Rows[0].Field<string>("license_no");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting User Profile: " + error);
            }
        }

        public void GetEncoderProfile(int user_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblprofiles WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.EncoderID = dt.Rows[0].Field<int>("id");
                            val.EncoderFirstName = dt.Rows[0].Field<string>("first_name");
                            val.EncoderMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.EncoderLastName = dt.Rows[0].Field<string>("last_name");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Encoder Profile: " + error);
            }
        }

        public void GetPathologistProfile(int user_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblprofiles WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.PatID = dt.Rows[0].Field<int>("id");
                            val.PatFirstName = dt.Rows[0].Field<string>("first_name");
                            val.PatMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.PatLastName = dt.Rows[0].Field<string>("last_name");
                            val.PatTitle = dt.Rows[0].Field<string>("title");
                            val.PatLicense = dt.Rows[0].Field<string>("license_no");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Pathologist Profile: " + error);
            }
        }

        public void GetMedTechProfile(int user_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblprofiles WHERE user_id = @user_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user_id", user_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.MedID = dt.Rows[0].Field<int>("id");
                            val.MedFirstName = dt.Rows[0].Field<string>("first_name");
                            val.MedMiddleName = dt.Rows[0].Field<string>("middle_name");
                            val.MedLastName = dt.Rows[0].Field<string>("last_name");
                            val.MedTitle = dt.Rows[0].Field<string>("title");
                            val.MedLicense = dt.Rows[0].Field<string>("license_no");
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Medical Technologist Profile: " + error);
            }
        }

        public void LoadPathologist(MetroFramework.Controls.MetroComboBox combo_box)
        {
            using (MySqlConnection con = new MySqlConnection(connection.conString))
            {
                string sql = @"SELECT mmg_lab.tblusers.*, mmg_lab.tblprofiles.*, 
                            CONCAT(mmg_lab.tblprofiles.first_name, ' ', mmg_lab.tblprofiles.last_name)
                            AS full_name FROM mmg_lab.tblusers INNER JOIN mmg_lab.tblprofiles 
                            ON mmg_lab.tblusers.id = mmg_lab.tblprofiles.user_id WHERE 
                            mmg_lab.tblusers.user_level = 145 AND mmg_lab.tblusers.active = 1;";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        combo_box.ValueMember = "user_id";
                        combo_box.DisplayMember = "full_name";
                        combo_box.DataSource = dt;
                    }
                }
            }
        }

        public void LoadMedTech(MetroFramework.Controls.MetroComboBox combo_box)
        {
            using (MySqlConnection con = new MySqlConnection(connection.conString))
            {
                string sql = @"SELECT mmg_lab.tblusers.*, mmg_lab.tblprofiles.*, 
                            CONCAT(mmg_lab.tblprofiles.first_name, ' ', mmg_lab.tblprofiles.last_name)
                            AS full_name FROM mmg_lab.tblusers INNER JOIN mmg_lab.tblprofiles 
                            ON mmg_lab.tblusers.id = mmg_lab.tblprofiles.user_id WHERE 
                            mmg_lab.tblusers.user_level = 184 AND mmg_lab.tblusers.active = 1;";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        combo_box.ValueMember = "user_id";
                        combo_box.DisplayMember = "full_name";
                        combo_box.DataSource = dt;
                    }
                }
            }
        }

        public bool UpdateProfile(int profile_id, int user_level, bool active, string license_no, string title, string first_name, string middle_name, string last_name)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblusers SET user_level = @user_level, active = @active WHERE id = @id;
                            UPDATE mmg_lab.tblprofiles SET first_name = @first_name, middle_name = @middle_name, last_name = @last_name,
                            license_no = @license_no, title = @title WHERE id = @id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", profile_id);
                        cmd.Parameters.AddWithValue("@user_level", user_level);
                        cmd.Parameters.AddWithValue("@active", active);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@license_no", license_no);
                        cmd.Parameters.AddWithValue("@title", title);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Updating Profile: " + error);
                return false;
            }
        }
    }
}
