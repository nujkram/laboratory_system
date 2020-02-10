using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Urinalysis
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();
        Profile Profile = new Profile();

        public void LoadUrinalysisRecord(int trans_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblurinalysis WHERE trans_id = @trans_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@trans_id", trans_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.UriID = dt.Rows[0].Field<int>("id");
                        val.UriExam = dt.Rows[0].Field<string>("exam_desired");
                        val.UriColor = dt.Rows[0].Field<string>("color");
                        val.UriTrans = dt.Rows[0].Field<string>("transparency");
                        val.UriReaction = dt.Rows[0].Field<string>("reaction");
                        val.UriSpecificGravity = dt.Rows[0].Field<string>("specific_gravity");
                        val.UriProtein = dt.Rows[0].Field<string>("protein");
                        val.UriSugar = dt.Rows[0].Field<string>("sugar");
                        val.UriFineGran = dt.Rows[0].Field<string>("fine_granular");
                        val.UriCoarseGran = dt.Rows[0].Field<string>("coarse_granular");
                        val.UriPusCellCast = dt.Rows[0].Field<string>("pus_cell_cast");
                        val.UriHyaline = dt.Rows[0].Field<string>("hyaline");
                        val.UriRBC = dt.Rows[0].Field<string>("rbc");
                        val.UriPusCells = dt.Rows[0].Field<string>("pus_cells");
                        val.UriUricAcid = dt.Rows[0].Field<string>("uric_acid");
                        val.UriCalciumOxolate = dt.Rows[0].Field<string>("calcium_oxalate");
                        val.UriAmorphous = dt.Rows[0].Field<string>("amorphous");
                        val.UriTriplePhospahtes = dt.Rows[0].Field<string>("triple_phosphates");
                        val.UriSquamous = dt.Rows[0].Field<string>("squamous");
                        val.UriBacteria = dt.Rows[0].Field<string>("bacteria");
                        val.UriMucous = dt.Rows[0].Field<string>("mucous");
                        val.UriRoundEpi = dt.Rows[0].Field<string>("round_epithelial");
                        val.UriYeastCells = dt.Rows[0].Field<string>("yeast_cells");
                        val.UriVaginalis = dt.Rows[0].Field<string>("vaginalis");
                        val.UriHominis = dt.Rows[0].Field<string>("hominis");
                        val.UriPathologist = dt.Rows[0].Field<int>("pathologist");
                        val.UriMedTech = dt.Rows[0].Field<int>("med_tech");

                        Profile.GetPathologistProfile(val.UriPathologist);
                        Profile.GetMedTechProfile(val.UriMedTech);
                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Urinalysis Records: " + error);
            }
        }

        public bool AddUrinalysisRecord(int record_id, int lab_type_id, string exam_desired, string color, string transparency, string reaction,
            string specific_gravity, string protein, string sugar, string fine_gran, string coarse_gran, string pus_cell_cast,
            string hyaline, string rbc, string pus_cells, string uric_acid, string calcium_oxolate, string amorphous, 
            string trip_phosphates, string squamous, string bacteria, string mucous, string round_epithelial, string yeast_cells,
            string vaginalis, string hominis, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbltransactions(record_id, lab_type_id, created_by) VALUES(@record_id, @lab_type_id, @user);
                                
                                SET @'last_trans_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblurinalysis(trans_id, exam_desired, color, transparency,
                                reaction, specific_gravity, protein, sugar, fine_granular, coarse_granular, pus_cell_cast, hyaline,
                                rbc, pus_cells, uric_acid, calcium_oxalate, amorphous, triple_phosphates, squamous, bacteria,
                                mucous, round_epithelial, yeast_cells, vaginalis, hominis, pathologist, med_tech)
                                VALUES(@'last_trans_id', UPPER(@exam_desired), UPPER(@color), UPPER(@transparency),
                                @reaction, @specific_gravity, @protein, @sugar, @fine_gran, @coarse_gran, @pus_cell_cast,
                                @hyaline, UPPER(@rbc), UPPER(@pus_cells), UPPER(@uric_acid), UPPER(@calcium_oxolate), 
                                UPPER(@amorphous), UPPER(@trip_phosphates), UPPER(@squamous), UPPER(@bacteria), UPPER(@mucous),
                                UPPER(@round_epithelial), UPPER(@yeast_cells), UPPER(@vaginalis), UPPER(@hominis), @pathologist, @med_tech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@lab_type_id", lab_type_id);
                        cmd.Parameters.AddWithValue("@user", val.ProfileLoggedID);
                        cmd.Parameters.AddWithValue("@exam_desired", exam_desired);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@transparency", transparency);
                        cmd.Parameters.AddWithValue("@reaction", reaction);
                        cmd.Parameters.AddWithValue("@specific_gravity", specific_gravity);
                        cmd.Parameters.AddWithValue("@protein", protein);
                        cmd.Parameters.AddWithValue("@sugar", sugar);
                        cmd.Parameters.AddWithValue("@fine_gran", fine_gran);
                        cmd.Parameters.AddWithValue("@coarse_gran", coarse_gran);
                        cmd.Parameters.AddWithValue("@pus_cell_cast", pus_cell_cast);
                        cmd.Parameters.AddWithValue("@hyaline", hyaline);
                        cmd.Parameters.AddWithValue("@rbc", rbc);
                        cmd.Parameters.AddWithValue("@pus_cells", pus_cells);
                        cmd.Parameters.AddWithValue("@uric_acid", uric_acid);
                        cmd.Parameters.AddWithValue("@calcium_oxolate", calcium_oxolate);
                        cmd.Parameters.AddWithValue("@amorphous", amorphous);
                        cmd.Parameters.AddWithValue("@trip_phosphates", trip_phosphates);
                        cmd.Parameters.AddWithValue("@squamous", squamous);
                        cmd.Parameters.AddWithValue("@bacteria", bacteria);
                        cmd.Parameters.AddWithValue("@mucous", mucous);
                        cmd.Parameters.AddWithValue("@round_epithelial", round_epithelial);
                        cmd.Parameters.AddWithValue("@yeast_cells", yeast_cells);
                        cmd.Parameters.AddWithValue("@vaginalis", vaginalis);
                        cmd.Parameters.AddWithValue("@hominis", hominis);
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
                Console.WriteLine("Error Adding Urinalysis Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Urinalysis Record: " + error.ToString());
                return false;
            }
        }

        public bool UpdateUrinalysis(int id, string exam_desired, string color, string transparency, string reaction,
            string specific_gravity, string protein, string sugar, string fine_gran, string coarse_gran, string pus_cell_cast,
            string hyaline, string rbc, string pus_cells, string uric_acid, string calcium_oxalate, string amorphous,
            string triple_phosphates, string squamous, string bacteria, string mucous, string round_epithelial, string yeast_cells,
            string vaginalis, string hominis, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblurinalysis SET exam_desired=UPPER(@exam_desired), color=UPPER(@color), 
                                transparency=UPPER(@transparency), reaction=UPPER(@reaction), specific_gravity=UPPER(@specific_gravity),
                                protein=UPPER(@protein), sugar=UPPER(@sugar), fine_granular=UPPER(@fine_granular), 
                                coarse_granular=UPPER(@coarse_granular), pus_cell_cast=UPPER(@pus_cell_cast), hyaline=UPPER(@hyaline), 
                                rbc=UPPER(@rbc), pus_cells=UPPER(@pus_cells), uric_acid=UPPER(@uric_acid), calcium_oxalate=UPPER(@calcium_oxalate), 
                                amorphous=UPPER(@amorphous), triple_phosphates=UPPER(@triple_phosphates), squamous=UPPER(@squamous), 
                                bacteria=UPPER(@bacteria), mucous=UPPER(@mucous), round_epithelial=UPPER(@round_epithelial), 
                                yeast_cells=UPPER(@yeast_cells), vaginalis=UPPER(@vaginalis), hominis=UPPER(@hominis), 
                                pathologist=@pathologist, med_tech=@med_tech, last_updated=@last_updated WHERE id=@id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@exam_desired", exam_desired);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@transparency", transparency);
                        cmd.Parameters.AddWithValue("@reaction", reaction);
                        cmd.Parameters.AddWithValue("@specific_gravity", specific_gravity);
                        cmd.Parameters.AddWithValue("@protein", protein);
                        cmd.Parameters.AddWithValue("@sugar", sugar);
                        cmd.Parameters.AddWithValue("@fine_granular", fine_gran);
                        cmd.Parameters.AddWithValue("@coarse_granular", coarse_gran);
                        cmd.Parameters.AddWithValue("@pus_cell_cast", pus_cell_cast);
                        cmd.Parameters.AddWithValue("@hyaline", hyaline);
                        cmd.Parameters.AddWithValue("@rbc", rbc);
                        cmd.Parameters.AddWithValue("@pus_cells", pus_cells);
                        cmd.Parameters.AddWithValue("@uric_acid", uric_acid);
                        cmd.Parameters.AddWithValue("@calcium_oxalate", calcium_oxalate);
                        cmd.Parameters.AddWithValue("@amorphous", amorphous);
                        cmd.Parameters.AddWithValue("@triple_phosphates", triple_phosphates);
                        cmd.Parameters.AddWithValue("@squamous", squamous);
                        cmd.Parameters.AddWithValue("@bacteria", bacteria);
                        cmd.Parameters.AddWithValue("@mucous", mucous);
                        cmd.Parameters.AddWithValue("@round_epithelial", round_epithelial);
                        cmd.Parameters.AddWithValue("@yeast_cells", yeast_cells);
                        cmd.Parameters.AddWithValue("@vaginalis", vaginalis);
                        cmd.Parameters.AddWithValue("@hominis", hominis);
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
                Console.WriteLine("Error Updating Urinalysis Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Urinalysis Record: " + error.ToString());
                return false;
            }
        }

        public Records GetUrinalysisData(int uri_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblurinalysis WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", uri_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsUrinalysis = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsUrinalysis, "Urinalysis");

                        return dsUrinalysis;

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Urinalysis Data: " + error);
                return null;
            }
        }
    }
}
