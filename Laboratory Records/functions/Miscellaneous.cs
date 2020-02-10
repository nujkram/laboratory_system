using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Miscellaneous
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();
        Profile Profile = new Profile();

        public void LoadMiscRecord(int trans_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblmisc WHERE trans_id = @trans_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@trans_id", trans_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.MiscID = dt.Rows[0].Field<int>("id");
                        val.MiscExam = dt.Rows[0].Field<string>("exam_desired");
                        val.MiscSpecimen = dt.Rows[0].Field<string>("specimen");
                        val.MiscResult = dt.Rows[0].Field<string>("result");
                        val.MiscRemarks = dt.Rows[0].Field<string>("remarks");
                        val.MiscNotes = dt.Rows[0].Field<string>("notes");
                        val.MiscOthers = dt.Rows[0].Field<string>("others");
                        val.MiscPathologist = dt.Rows[0].Field<int>("pathologist");
                        val.MiscMedTech = dt.Rows[0].Field<int>("med_tech");

                        Profile.GetPathologistProfile(val.MiscPathologist);
                        Profile.GetMedTechProfile(val.MiscMedTech);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Miscellaneous Records: " + error);
            }
        }

        public bool AddMiscRecord(int record_id, int lab_type_id, string exam_desired, string specimen, string result, string remarks, 
            string notes, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbltransactions(record_id, lab_type_id, created_by) VALUES(@record_id, @lab_type_id, @user);
                                
                                SET @'last_trans_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblmisc(trans_id, exam_desired, specimen, result, remarks, notes, pathologist, med_tech)
                                VALUES(@'last_trans_id', @exam_desired, @specimen, UPPER(@result), UPPER(@remarks), UPPER(@notes), @pathologist, @med_tech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@lab_type_id", lab_type_id);
                        cmd.Parameters.AddWithValue("@user", val.ProfileLoggedID);
                        cmd.Parameters.AddWithValue("@exam_desired", exam_desired);
                        cmd.Parameters.AddWithValue("@specimen", specimen);
                        cmd.Parameters.AddWithValue("@result", result);
                        cmd.Parameters.AddWithValue("@remarks", remarks);
                        cmd.Parameters.AddWithValue("@notes", notes);
                        cmd.Parameters.AddWithValue("@pathologist", pathologist);
                        cmd.Parameters.AddWithValue("@med_tech", med_tech);

                        cmd.Connection.Open();
                        MySqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        return true;
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Adding Miscellaneous Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Miscellaneous Record: " + error.ToString());
                return false;
            }
        }

        public bool UpdateMiscellaneous(int id, string specimen, string result, string remarks,
            string notes, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblmisc SET specimen=UPPER(@specimen), result=UPPER(@result), remarks=UPPER(@remarks), 
                                notes=UPPER(@notes), pathologist=@pathologist, med_tech=@med_tech, 
                                last_updated=@last_updated WHERE id=@id;";
                    
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@specimen", specimen);
                        cmd.Parameters.AddWithValue("@result", result);
                        cmd.Parameters.AddWithValue("@remarks", remarks);
                        cmd.Parameters.AddWithValue("@notes", notes);
                        cmd.Parameters.AddWithValue("@pathologist", pathologist);
                        cmd.Parameters.AddWithValue("@med_tech", med_tech);
                        cmd.Parameters.AddWithValue("@last_updated", DateTime.Now);
                        cmd.Parameters.AddWithValue("@id", id);

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
                Console.WriteLine("Error Updating Miscellaneous Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Miscellaneous Record: " + error.ToString());
                return false;
            }
        }

        /// <summary>
        /// Genarate data for reporting
        /// </summary>
        /// <param name="misc_id"></param>
        /// <returns></returns>
        public Records GetMiscData(int misc_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblmisc WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", misc_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsMiscellanous = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsMiscellanous, "Miscellaneous");

                        return dsMiscellanous;

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Miscellanous Data: " + error);
                return null;
            }
        }


    }
}
