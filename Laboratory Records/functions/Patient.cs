using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Patient
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();

        public void LoadPatients(MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblpatients ORDER BY created DESC;";
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
                            grid.Columns["id"].Visible = false;
                            grid.Columns["first_name"].HeaderText = "First Name";
                            grid.Columns["middle_name"].HeaderText = "Middle Initial";
                            grid.Columns["last_name"].HeaderText = "Last Name";
                            grid.Columns["gender"].Visible = false;
                            grid.Columns["birth_date"].Visible = false;
                            grid.Columns["address"].Visible = false;
                            grid.Columns["age"].Visible = false;
                            grid.Columns["created"].Visible = false;

                            GetPatientDetail(0, grid);
                        }  
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Load Patients: " + error);
            }
        }

        public void GetPatientDetail(int row, MetroFramework.Controls.MetroGrid grid)
        {
            val.PatientID = (int)grid[0, row].Value;
            val.PatientFirstName = (string)grid[1, row].Value;
            val.PatientMiddleName = (string)grid[2, row].Value;
            val.PatientLastName = (string)grid[3, row].Value;
            val.PatientGender = (string)grid[4, row].Value;
            val.PatientBirthDate = (DateTime)grid[5, row].Value;
            val.PatientAge = (int)grid[6, row].Value;
            val.PatientAddress = (string)grid[7, row].Value;
        }

        /// <summary>
        /// Add patient record
        /// </summary>
        /// <param name="patient_id"></param>
        /// <param name="first_name"></param>
        /// <param name="middle_name"></param>
        /// <param name="last_name"></param>
        /// <param name="birth_date"></param>
        /// <param name="age"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool AddPatient(string first_name, string middle_name, string last_name, string gender, DateTime birth_date, int age, string address)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tblpatients(first_name, middle_name, last_name, gender, birth_date, age, address)
                                VALUES(UPPER(@first_name), UPPER(@middle_name), UPPER(@last_name), UPPER(@gender), @birth_date, @age, UPPER(@address));";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birth_date", birth_date);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT * FROM mmg_lab.tblpatients ORDER BY id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con)) {

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.PatientID = dt.Rows[0].Field<int>("id");
                        val.PatientFirstName = dt.Rows[0].Field<string>("first_name");
                        val.PatientMiddleName = dt.Rows[0].Field<string>("middle_name");
                        val.PatientLastName = dt.Rows[0].Field<string>("last_name");
                        val.PatientGender = dt.Rows[0].Field<string>("gender");
                        val.PatientBirthDate = dt.Rows[0].Field<DateTime>("birth_date");
                        val.PatientAge = dt.Rows[0].Field<int>("age");
                        val.PatientAddress = dt.Rows[0].Field<string>("address");

                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Adding Patient: " + error);
                Log.AddLog(val.UserID, "Error Adding Patient: " + error.ToString());
                return false;
            } 
        }

        public bool UpdatePatient(int patient_id, string first_name, string middle_name, string last_name, string gender, DateTime birth_date, int age, string address)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblpatients SET first_name = UPPER(@first_name), middle_name = UPPER(@middle_name), 
                                last_name = UPPER(@last_name), gender = UPPER(@gender), birth_date =@birth_date, age=@age, address = UPPER(@address)
                                WHERE id=@patient_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@middle_name", middle_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@birth_date", birth_date);
                        cmd.Parameters.AddWithValue("@age", age);
                        cmd.Parameters.AddWithValue("@address", address);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Updating Patient: " + error);
                Log.AddLog(val.UserID, "Error Updating Patient: " + error.ToString());
                return false;
            } 
        }

        /// <summary>
        /// Filter patient record 
        /// </summary>
        /// <param name="first_name"></param>
        /// <param name="middle_name"></param>
        /// <param name="last_name"></param>
        /// <param name="address"></param>
        public void SearchPatient(string keyword, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * 
                                FROM mmg_lab.tblpatients WHERE first_name LIKE @first_name OR middle_name LIKE @middle_name
                                OR last_name LIKE @last_name OR address LIKE @address ORDER BY created DESC";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@first_name", String.Format("{0}{1}{2}", "%", keyword, "%"));
                        cmd.Parameters.AddWithValue("@middle_name", String.Format("{0}{1}{2}", "%", keyword, "%"));
                        cmd.Parameters.AddWithValue("@last_name", String.Format("{0}{1}{2}", "%", keyword, "%"));
                        cmd.Parameters.AddWithValue("@address", String.Format("{0}{1}{2}", "%", keyword, "%"));

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        grid.DataSource = dt;

                        // Get number of records
                        val.PatientCount = dt.Rows.Count;

                        // Set column headers
                        grid.Columns["id"].HeaderText = "ID";
                        grid.Columns["first_name"].HeaderText = "First Name";
                        grid.Columns["middle_name"].HeaderText = "Middle Initial";
                        grid.Columns["last_name"].HeaderText = "Last Name";
                        grid.Columns["gender"].Visible = false;
                        grid.Columns["birth_date"].Visible = false;
                        grid.Columns["age"].Visible = false;
                        grid.Columns["address"].Visible = false;
                        grid.Columns["created"].Visible = false;

                        GetPatientDetail(0, grid);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Searching Patient: " + error);
                Log.AddLog(val.UserID, "Error Searching Patient: " + error.ToString());
            } 
        }
    }
}
