using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Chemistry
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();
        Profile Profile = new Profile();

        public void LoadChemistryRecord(int trans_id) 
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblchemistry WHERE trans_id = @trans_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@trans_id", trans_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.ChemID = dt.Rows[0].Field<int>("id");
                        val.ChemStat = dt.Rows[0].Field<string>("stat");
                        val.ChemFastingBloodSugar = dt.Rows[0].Field<string>("fasting_blood_sugar");
                        val.ChemRandomBloodSugar = dt.Rows[0].Field<string>("random_blood_sugar");
                        val.ChemPostPrandial = dt.Rows[0].Field<string>("post_prandial");
                        val.ChemHba1c = dt.Rows[0].Field<string>("hba1c");
                        val.ChemUrea = dt.Rows[0].Field<string>("urea");
                        val.ChemCreatinine = dt.Rows[0].Field<string>("creatinine");
                        val.ChemUricAcid = dt.Rows[0].Field<string>("uric_acid");
                        val.ChemCholesterol = dt.Rows[0].Field<string>("cholesterol");
                        val.ChemTriglycerides = dt.Rows[0].Field<string>("triglycerides");
                        val.ChemHdlCholesterol = dt.Rows[0].Field<string>("hdl_cholesterol");
                        val.ChemLdlCholesterol = dt.Rows[0].Field<string>("ldl_cholesterol");
                        val.ChemSgotAst = dt.Rows[0].Field<string>("sgot_ast");
                        val.ChemSgptAlt = dt.Rows[0].Field<string>("sgpt_alt");
                        val.ChemSodium = dt.Rows[0].Field<string>("sodium");
                        val.ChemPotassium = dt.Rows[0].Field<string>("potassium");
                        val.ChemCalcium = dt.Rows[0].Field<string>("calcium");
                        val.ChemPathologist = dt.Rows[0].Field<int>("pathologist");
                        val.ChemMedTech = dt.Rows[0].Field<int>("med_tech");

                        Profile.GetPathologistProfile(val.ChemPathologist);
                        Profile.GetMedTechProfile(val.ChemMedTech);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Chemistry Records: " + error);
            }
        }

        public bool AddChemistryRecord(int record_id, int lab_type_id, string stat, string fasting_blood_sugar, string random_blood_sugar,
            string post_prandial, string hba1c, string urea, string creatinine, string uric_acid, string cholesterol, string triglycerides,
            string hdl_cholesterol, string ldl_cholesterol, string sgot_ast, string sgpt_alt, string sodium, string potassium, string calcium,
            int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbltransactions(record_id, lab_type_id, created_by) VALUES(@record_id, @lab_type_id, @user);
                                
                                SET @'last_trans_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblchemistry(trans_id, stat, fasting_blood_sugar, random_blood_sugar,
                                post_prandial, hba1c, urea, creatinine, uric_acid, cholesterol, triglycerides, hdl_cholesterol, 
                                ldl_cholesterol, sgot_ast, sgpt_alt, sodium, potassium, calcium, pathologist, med_tech)
                                VALUES(@'last_trans_id', UPPER(@stat), @fasting_blood_sugar, @random_blood_sugar,
                                @post_prandial, @hba1c, @urea, @creatinine, @uric_acid, @cholesterol, @triglycerides, @hdl_cholesterol, 
                                @ldl_cholesterol, @sgot_ast, @sgpt_alt, @sodium, @potassium, @calcium, @pathologist, @med_tech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@lab_type_id", lab_type_id);
                        cmd.Parameters.AddWithValue("@user", val.ProfileLoggedID);
                        cmd.Parameters.AddWithValue("@stat", stat);
                        cmd.Parameters.AddWithValue("@fasting_blood_sugar", fasting_blood_sugar);
                        cmd.Parameters.AddWithValue("@random_blood_sugar", random_blood_sugar);
                        cmd.Parameters.AddWithValue("@post_prandial", post_prandial);
                        cmd.Parameters.AddWithValue("@hba1c", hba1c);
                        cmd.Parameters.AddWithValue("@urea", urea);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@uric_acid", uric_acid);
                        cmd.Parameters.AddWithValue("@cholesterol", cholesterol);
                        cmd.Parameters.AddWithValue("@triglycerides", triglycerides);
                        cmd.Parameters.AddWithValue("@hdl_cholesterol", hdl_cholesterol);
                        cmd.Parameters.AddWithValue("@ldl_cholesterol", ldl_cholesterol);
                        cmd.Parameters.AddWithValue("@sgot_ast", sgot_ast);
                        cmd.Parameters.AddWithValue("@sgpt_alt", sgpt_alt);
                        cmd.Parameters.AddWithValue("@sodium", sodium);
                        cmd.Parameters.AddWithValue("@potassium", potassium);
                        cmd.Parameters.AddWithValue("@calcium", calcium);
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
                Console.WriteLine("Error Adding Chemistry Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Chemistry Record: " + error.ToString());
                return false;
            }
        }

        public bool UpdateChemistry(int id, string stat, string fasting_blood_sugar, string random_blood_sugar,
            string post_prandial, string hba1c, string urea, string creatinine, string uric_acid, string cholesterol, string triglycerides,
            string hdl_cholesterol, string ldl_cholesterol, string sgot_ast, string sgpt_alt, string sodium, string potassium, string calcium,
            int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblchemistry SET stat=UPPER(@stat), fasting_blood_sugar=UPPER(@fasting_blood_sugar), 
                                random_blood_sugar=UPPER(@random_blood_sugar), post_prandial=UPPER(@post_prandial), hba1c=UPPER(@hba1c), 
                                urea=UPPER(@urea), creatinine=UPPER(@creatinine), uric_acid=UPPER(@uric_acid), cholesterol=UPPER(@cholesterol), 
                                triglycerides=UPPER(@triglycerides), hdl_cholesterol=UPPER(@hdl_cholesterol), ldl_cholesterol=UPPER(@ldl_cholesterol), 
                                sgot_ast=UPPER(@sgot_ast), sgpt_alt=UPPER(@sgpt_alt), sodium=UPPER(@sodium), potassium=UPPER(@potassium), 
                                calcium=UPPER(@calcium), pathologist=@pathologist, med_tech=@med_tech,
                                last_updated=@last_updated 
                                WHERE id=@id;";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {

                        cmd.Parameters.AddWithValue("@stat", stat);
                        cmd.Parameters.AddWithValue("@fasting_blood_sugar", fasting_blood_sugar);
                        cmd.Parameters.AddWithValue("@random_blood_sugar", random_blood_sugar);
                        cmd.Parameters.AddWithValue("@post_prandial", post_prandial);
                        cmd.Parameters.AddWithValue("@hba1c", hba1c);
                        cmd.Parameters.AddWithValue("@urea", urea);
                        cmd.Parameters.AddWithValue("@creatinine", creatinine);
                        cmd.Parameters.AddWithValue("@uric_acid", uric_acid);
                        cmd.Parameters.AddWithValue("@cholesterol", cholesterol);
                        cmd.Parameters.AddWithValue("@triglycerides", triglycerides);
                        cmd.Parameters.AddWithValue("@hdl_cholesterol", hdl_cholesterol);
                        cmd.Parameters.AddWithValue("@ldl_cholesterol", ldl_cholesterol);
                        cmd.Parameters.AddWithValue("@sgot_ast", sgot_ast);
                        cmd.Parameters.AddWithValue("@sgpt_alt", sgpt_alt);
                        cmd.Parameters.AddWithValue("@sodium", sodium);
                        cmd.Parameters.AddWithValue("@potassium", potassium);
                        cmd.Parameters.AddWithValue("@calcium", calcium);
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
                Console.WriteLine("Error Updating Chemistry Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Chemistry Record: " + error.ToString());
                return false;
            }
        }

        /// <summary>
        /// Generate data for reporting
        /// </summary>
        /// <param name="record_id"></param>
        /// <returns></returns>
        public Records GetChemistryData(int chem_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblchemistry WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", chem_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsChemistry = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsChemistry, "Chemistry");

                        return dsChemistry;

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Chemistry Data: " + error);
                return null;
            }
        }
    }
}
