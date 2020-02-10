using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Hematology
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();
        Profile Profile = new Profile();

        public void LoadHematologyRecords(int trans_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblhematology WHERE trans_id = @trans_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@trans_id", trans_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.HemaID = dt.Rows[0].Field<int>("id");
                        val.HemaExam = dt.Rows[0].Field<string>("exam_desired");
                        val.HemaStat = dt.Rows[0].Field<string>("stat");
                        val.HemaHemoglobin = dt.Rows[0].Field<string>("hemoglobin_con_mass");
                        val.HemaEryVol = dt.Rows[0].Field<string>("erythrocyte_vol_con");
                        val.HemaEryNum = dt.Rows[0].Field<string>("erythrocyte_num_con");
                        val.HemaLeukocyte = dt.Rows[0].Field<string>("leukocyte_num_con");
                        val.HemaBloodType = dt.Rows[0].Field<string>("blood_type");
                        val.HemaRH = dt.Rows[0].Field<string>("rh");
                        val.HemaNeutrophil = dt.Rows[0].Field<string>("neutrophil_num_frac");
                        val.HemaSegmenters = dt.Rows[0].Field<string>("segmenters");
                        val.HemaStab = dt.Rows[0].Field<string>("stab");
                        val.HemaEosinophil = dt.Rows[0].Field<string>("eosinophil");
                        val.HemaBasophil = dt.Rows[0].Field<string>("basophil");
                        val.HemaLymphocyte = dt.Rows[0].Field<string>("lymphocyte");
                        val.HemaMonocyte = dt.Rows[0].Field<string>("monocyte");
                        val.HemaTotal = dt.Rows[0].Field<string>("total");
                        val.HemaErySed = dt.Rows[0].Field<string>("erythrocyte_sed_rate");
                        val.HemaThrombocyte = dt.Rows[0].Field<string>("thrombocyte_num_frac");
                        val.HemaBleedingTime = dt.Rows[0].Field<string>("bleeding_time");
                        val.HemaClottingTime = dt.Rows[0].Field<string>("clotting_time");
                        val.HemaOthers = dt.Rows[0].Field<string>("others");
                        val.HemaPathologist = dt.Rows[0].Field<int>("pathologist");
                        val.HemaMedTech = dt.Rows[0].Field<int>("med_tech");

                        Profile.GetPathologistProfile(val.HemaPathologist);
                        Profile.GetMedTechProfile(val.HemaMedTech);

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Hematology Records: " + error);
            }
        }

        public bool AddHematologyRecord(int record_id, int lab_type_id, string exam_desired, string stat, string hemoglobin_con_mass,
            string erythrocyte_vol_con, string erythrocyte_num_con, string leukocyte_num_con, string blood_type, string rh,
            string neutrophil_num_frac, string segmenters, string stab, string eosinophil, string basophil, string lymphocyte, 
            string monocyte, string total, string erythrocyte_sed_rate, string thrombocyte_num_frac, string bleeding_time, 
            string clotting_time, string others, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbltransactions(record_id, lab_type_id, created_by) VALUES(@record_id, @lab_type_id, @user);
                                
                                SET @'last_trans_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblhematology(trans_id, exam_desired, stat, hemoglobin_con_mass, erythrocyte_vol_con, 
                                erythrocyte_num_con, leukocyte_num_con, blood_type, rh, neutrophil_num_frac, segmenters, stab, eosinophil,
                                basophil, lymphocyte, monocyte, total, erythrocyte_sed_rate, thrombocyte_num_frac, bleeding_time, clotting_time, 
                                others, pathologist, med_tech)
                                VALUES(@'last_trans_id', UPPER(@exam_desired), UPPER(@stat), @hemoglobin_con_mass, @erythrocyte_vol_con, 
                                @erythrocyte_num_con, @leukocyte_num_con, UPPER(@blood_type), UPPER(@rh), @neutrophil_num_frac, @segmenters, @stab, @eosinophil, @basophil, 
                                @lymphocyte, @monocyte, @total, @erythrocyte_sed_rate, @thrombocyte_num_frac, @bleeding_time, @clotting_time,
                                @others, @pathologist, @med_tech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@lab_type_id", lab_type_id);
                        cmd.Parameters.AddWithValue("@user", val.ProfileLoggedID);
                        cmd.Parameters.AddWithValue("@exam_desired", exam_desired);
                        cmd.Parameters.AddWithValue("@stat", stat);
                        cmd.Parameters.AddWithValue("@hemoglobin_con_mass", hemoglobin_con_mass);
                        cmd.Parameters.AddWithValue("@erythrocyte_vol_con", erythrocyte_vol_con);
                        cmd.Parameters.AddWithValue("@erythrocyte_num_con", erythrocyte_num_con);
                        cmd.Parameters.AddWithValue("@leukocyte_num_con", leukocyte_num_con);
                        cmd.Parameters.AddWithValue("@blood_type", blood_type);
                        cmd.Parameters.AddWithValue("@rh", rh);
                        cmd.Parameters.AddWithValue("@neutrophil_num_frac", neutrophil_num_frac);
                        cmd.Parameters.AddWithValue("@segmenters", segmenters);
                        cmd.Parameters.AddWithValue("@stab", stab);
                        cmd.Parameters.AddWithValue("@eosinophil", eosinophil);
                        cmd.Parameters.AddWithValue("@basophil", basophil);
                        cmd.Parameters.AddWithValue("@lymphocyte", lymphocyte);
                        cmd.Parameters.AddWithValue("@monocyte", monocyte);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@erythrocyte_sed_rate", erythrocyte_sed_rate);
                        cmd.Parameters.AddWithValue("@thrombocyte_num_frac", thrombocyte_num_frac);
                        cmd.Parameters.AddWithValue("@bleeding_time", bleeding_time);
                        cmd.Parameters.AddWithValue("@clotting_time", clotting_time);
                        cmd.Parameters.AddWithValue("@others", others);
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
                Console.WriteLine("Error Adding Hematology Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Parasitology Record: " + error.ToString());
                return false;
            }
        }

        public bool UpdateHematology(int id, string exam_desired, string stat, string hemoglobin_con_mass,
            string erythrocyte_vol_con, string erythrocyte_num_con, string leukocyte_num_con, string blood_type, string rh,
            string neutrophil_num_frac, string segmenters, string stab, string eosinophil, string basophil, string lymphocyte,
            string monocyte, string total, string erythrocyte_sed_rate, string thrombocyte_num_frac, string bleeding_time,
            string clotting_time, string others, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblhematology SET exam_desired=UPPER(@exam_desired), stat=UPPER(@stat), 
                                hemoglobin_con_mass=UPPER(@hemoglobin_con_mass), erythrocyte_vol_con=UPPER(@erythrocyte_vol_con), 
                                erythrocyte_num_con=UPPER(@erythrocyte_num_con), leukocyte_num_con=UPPER(@leukocyte_num_con), 
                                blood_type=UPPER(@blood_type), rh=UPPER(@rh), neutrophil_num_frac=UPPER(@neutrophil_num_frac), 
                                segmenters=UPPER(@segmenters), stab=UPPER(@stab), eosinophil=UPPER(@eosinophil), basophil=UPPER(@basophil), 
                                lymphocyte=UPPER(@lymphocyte), monocyte=UPPER(@monocyte), total=UPPER(@total), 
                                erythrocyte_sed_rate=UPPER(@erythrocyte_sed_rate), thrombocyte_num_frac=UPPER(@thrombocyte_num_frac), 
                                bleeding_time=UPPER(@bleeding_time), clotting_time=UPPER(@clotting_time), others=UPPER(@others), 
                                pathologist=@pathologist, med_tech=@med_tech, last_updated=@last_updated WHERE id=@id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@exam_desired", exam_desired);
                        cmd.Parameters.AddWithValue("@stat", stat);
                        cmd.Parameters.AddWithValue("@hemoglobin_con_mass", hemoglobin_con_mass);
                        cmd.Parameters.AddWithValue("@erythrocyte_vol_con", erythrocyte_vol_con);
                        cmd.Parameters.AddWithValue("@erythrocyte_num_con", erythrocyte_num_con);
                        cmd.Parameters.AddWithValue("@leukocyte_num_con", leukocyte_num_con);
                        cmd.Parameters.AddWithValue("@blood_type", blood_type);
                        cmd.Parameters.AddWithValue("@rh", rh);
                        cmd.Parameters.AddWithValue("@neutrophil_num_frac", neutrophil_num_frac);
                        cmd.Parameters.AddWithValue("@segmenters", segmenters);
                        cmd.Parameters.AddWithValue("@stab", stab);
                        cmd.Parameters.AddWithValue("@eosinophil", eosinophil);
                        cmd.Parameters.AddWithValue("@basophil", basophil);
                        cmd.Parameters.AddWithValue("@lymphocyte", lymphocyte);
                        cmd.Parameters.AddWithValue("@monocyte", monocyte);
                        cmd.Parameters.AddWithValue("@total", total);
                        cmd.Parameters.AddWithValue("@erythrocyte_sed_rate", erythrocyte_sed_rate);
                        cmd.Parameters.AddWithValue("@thrombocyte_num_frac", thrombocyte_num_frac);
                        cmd.Parameters.AddWithValue("@bleeding_time", bleeding_time);
                        cmd.Parameters.AddWithValue("@clotting_time", clotting_time);
                        cmd.Parameters.AddWithValue("@others", others);
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
                Console.WriteLine("Error Updating Hematology Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Hematology Record: " + error.ToString());
                return false;
            }
        }

        public Records GetHematologyData(int hema_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblhematology WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", hema_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsHematology = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsHematology, "Hematology");

                        return dsHematology;

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Hematology Data: " + error);
                return null;
            }
        }
    }
}
