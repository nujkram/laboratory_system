using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory_Records.functions
{
    class Record
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();

        public void LoadPatientRecords(int patient_id, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblrecords WHERE patient_id = @patient_id ORDER BY created DESC";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        grid.DataSource = dt;

                        if (dt.Rows.Count != 0)
                        {
                            // Get number of records
                            val.RecordCount = dt.Rows.Count;

                            // Set column headers
                            grid.Columns["id"].Visible = false;
                            grid.Columns["patient_id"].Visible = false;
                            grid.Columns["requested_by"].HeaderText = "Requested By";
                            grid.Columns["case_number"].HeaderText = "Case No.";
                            grid.Columns["created"].Visible = false;

                            GetPatientRecord(0, grid);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Load Records: " + error);
            }
        }

        public void GetPatientRecord(int row, MetroFramework.Controls.MetroGrid grid)
        {
            val.RecordID = (int)grid[0, row].Value;
            val.RecordRequest = (string)grid[2, row].Value;
            val.RecordCase = (int)grid[3, row].Value;
            val.RecordCreated = (DateTime)grid[4, row].Value;
        }

        public bool CheckCaseNo(int patient_id, int case_no)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT *
                                FROM mmg_lab.tblrecords WHERE patient_id = @patient_id AND case_number = @case_no";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@case_no", case_no);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            return true;
                        } else {
                            return false;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Checking Records: " + error);
                Log.AddLog(val.UserID, "Error Checking Records: " + error.ToString());
                return false;
            }
        }

        public bool AddPatientRecord(int patient_id, string requested_by, int case_number)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tblrecords(patient_id, requested_by, case_number)
                                VALUES(@patient_id, UPPER(@requested_by), @case_number)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@patient_id", patient_id);
                        cmd.Parameters.AddWithValue("@requested_by", requested_by);
                        cmd.Parameters.AddWithValue("@case_number", case_number);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }

                    sql = @"SELECT * FROM mmg_lab.tblrecords ORDER BY id DESC LIMIT 1";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.RecordID = dt.Rows[0].Field<int>("id");
                        val.RecordRequest = dt.Rows[0].Field<string>("requested_by");
                        val.RecordCase = dt.Rows[0].Field<int>("case_number");
                        val.RecordCreated = dt.Rows[0].Field<DateTime>("created");
                        
                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Adding Patient Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Patient Record: " + error.ToString());
                return false;
            } 
        }

        public bool UpdateRecord(int record_id, string requested_by, int case_number)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblrecords SET requested_by=@requested_by, case_number=@case_number
                                WHERE id=@record_id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@requested_by", requested_by);
                        cmd.Parameters.AddWithValue("@case_number", case_number);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Updating Patient Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Patient Record: " + error.ToString());
                return false;
            } 
        }

        // <laboratory record>
        public void LoadLabType(ComboBox combo_box)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tbllab_type";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);
                        
                        if (dt.Rows.Count > 0) {
                            combo_box.ValueMember = "id";
                            combo_box.DisplayMember = "name";
                            combo_box.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Load Laboratory Type: " + error);
            }
        }

        public void GetLaboratoryType(int lab_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tbllab_type WHERE id = @lab_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@lab_id", lab_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            val.LabID = dt.Rows[0].Field<int>("id");
                            val.LabName = dt.Rows[0].Field<string>("name");
                            Console.WriteLine(val.LabName);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Laboratory Type: " + error);
            }
        }
        // </laboratory record>

        /// <summary>
        /// Hematology Reporting View
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public string LoadChemistry(DateTime from, DateTime to, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblrecords.case_number, tblpatients.age, tblrecords.requested_by, 
                                    CONCAT(tblpatients.first_name, ' ', tblpatients.last_name) AS patient_name, 
                                    tblchemistry.* FROM mmg_lab.tblchemistry 
                                    INNER JOIN mmg_lab.tbltransactions ON mmg_lab.tbltransactions.id = mmg_lab.tblchemistry.trans_id
                                    INNER JOIN mmg_lab.tblrecords ON mmg_lab.tbltransactions.record_id = mmg_lab.tblrecords.id
                                    INNER JOIN mmg_lab.tblpatients ON mmg_lab.tblrecords.patient_id = mmg_lab.tblpatients.id
                                    WHERE mmg_lab.tblchemistry.created BETWEEN @from AND @to;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        var from_date = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
                        var to_date = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);

                        cmd.Parameters.AddWithValue("@from", from_date);
                        cmd.Parameters.AddWithValue("@to", to_date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        return "Record Count: " + dt.Rows.Count;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to load chemistry records: " + e.ToString());
                return e.ToString();
            }
        }

        /// <summary>
        /// Hematology Reporting View
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public string LoadHematology(DateTime from, DateTime to, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblrecords.case_number, tblpatients.age, tblrecords.requested_by, 
                                    CONCAT(tblpatients.first_name, ' ', tblpatients.last_name) AS patient_name, 
                                    tblhematology.* FROM mmg_lab.tblhematology 
                                    INNER JOIN mmg_lab.tbltransactions ON mmg_lab.tbltransactions.id = mmg_lab.tblhematology.trans_id
                                    INNER JOIN mmg_lab.tblrecords ON mmg_lab.tbltransactions.record_id = mmg_lab.tblrecords.id
                                    INNER JOIN mmg_lab.tblpatients ON mmg_lab.tblrecords.patient_id = mmg_lab.tblpatients.id
                                    WHERE mmg_lab.tblhematology.created BETWEEN @from AND @to;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        var from_date = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
                        var to_date = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);

                        cmd.Parameters.AddWithValue("@from", from_date);
                        cmd.Parameters.AddWithValue("@to", to_date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        return "Record Count: " + dt.Rows.Count;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to load hematology records: " + e.ToString());
                return e.ToString();
            }
        }

        /// <summary>
        /// Miscellaneous Reporting View
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public string LoadMiscellaneous(DateTime from, DateTime to, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblrecords.case_number, tblpatients.age, tblrecords.requested_by, 
                                    CONCAT(tblpatients.first_name, ' ', tblpatients.last_name) AS patient_name, 
                                    tblmisc.* FROM mmg_lab.tblmisc 
                                    INNER JOIN mmg_lab.tbltransactions ON mmg_lab.tbltransactions.id = mmg_lab.tblmisc.trans_id
                                    INNER JOIN mmg_lab.tblrecords ON mmg_lab.tbltransactions.record_id = mmg_lab.tblrecords.id
                                    INNER JOIN mmg_lab.tblpatients ON mmg_lab.tblrecords.patient_id = mmg_lab.tblpatients.id
                                    WHERE mmg_lab.tblmisc.created BETWEEN @from AND @to;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        var from_date = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
                        var to_date = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);

                        cmd.Parameters.AddWithValue("@from", from_date);
                        cmd.Parameters.AddWithValue("@to", to_date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        return "Record Count: " + dt.Rows.Count;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to load miscellaneous records: " + e.ToString());
                return e.ToString();
            }
        }

        /// <summary>
        /// Parasitology Reporting View
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public string LoadParasitology(DateTime from, DateTime to, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblrecords.case_number, tblpatients.age, tblrecords.requested_by, 
                                    CONCAT(tblpatients.first_name, ' ', tblpatients.last_name) AS patient_name, 
                                    tblparasitology.* FROM mmg_lab.tblparasitology 
                                    INNER JOIN mmg_lab.tbltransactions ON mmg_lab.tbltransactions.id = mmg_lab.tblparasitology.trans_id
                                    INNER JOIN mmg_lab.tblrecords ON mmg_lab.tbltransactions.record_id = mmg_lab.tblrecords.id
                                    INNER JOIN mmg_lab.tblpatients ON mmg_lab.tblrecords.patient_id = mmg_lab.tblpatients.id
                                    WHERE mmg_lab.tblparasitology.created BETWEEN @from AND @to;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        var from_date = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
                        var to_date = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);

                        cmd.Parameters.AddWithValue("@from", from_date);
                        cmd.Parameters.AddWithValue("@to", to_date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        return "Record Count: " + dt.Rows.Count;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to load parasitology records: " + e.ToString());
                return e.ToString();
            }
        }

        /// <summary>
        /// Urinalysis Reporting View
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="grid"></param>
        /// <returns></returns>
        public string LoadUrinalysisRecord(DateTime from, DateTime to, MetroFramework.Controls.MetroGrid grid)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT tblrecords.case_number, tblpatients.age, tblrecords.requested_by, 
                                    CONCAT(tblpatients.first_name, ' ', tblpatients.last_name) AS patient_name, 
                                    tblurinalysis.* FROM mmg_lab.tblurinalysis 
                                    INNER JOIN mmg_lab.tbltransactions ON mmg_lab.tbltransactions.id = mmg_lab.tblurinalysis.trans_id
                                    INNER JOIN mmg_lab.tblrecords ON mmg_lab.tbltransactions.record_id = mmg_lab.tblrecords.id
                                    INNER JOIN mmg_lab.tblpatients ON mmg_lab.tblrecords.patient_id = mmg_lab.tblpatients.id
                                    WHERE mmg_lab.tblurinalysis.created BETWEEN @from AND @to;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        var from_date = new DateTime(from.Year, from.Month, from.Day, 0, 0, 0);
                        var to_date = new DateTime(to.Year, to.Month, to.Day, 23, 59, 59);

                        cmd.Parameters.AddWithValue("@from", from_date);
                        cmd.Parameters.AddWithValue("@to", to_date);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        grid.DataSource = dt;
                        return "Record Count: " + dt.Rows.Count;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed to load urinalysis records: " + e.ToString());
                return e.ToString();
            }
        }
    }
}
