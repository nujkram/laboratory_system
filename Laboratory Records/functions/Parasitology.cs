using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.functions
{
    class Parasitology
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log Log = new Log();
        Profile Profile = new Profile();

        public void LoadParasitologyRecords(int trans_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblparasitology WHERE trans_id = @trans_id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@trans_id", trans_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        dt.Clear();
                        da.Fill(dt);

                        val.ParaID = dt.Rows[0].Field<int>("id");
                        val.ParaColor = dt.Rows[0].Field<string>("color");
                        val.ParaConsistency = dt.Rows[0].Field<string>("consistency");
                        val.ParaAscaris = dt.Rows[0].Field<string>("ascaris_lumb");
                        val.ParaHookworm = dt.Rows[0].Field<string>("hookworm");
                        val.ParaTrichuris = dt.Rows[0].Field<string>("trichuris_trichiura");
                        val.ParaStrongyloides = dt.Rows[0].Field<string>("strongyloides_ster");
                        val.ParaEntColiCyst = dt.Rows[0].Field<string>("ent_coli_cyst");
                        val.ParaEntColiTrop = dt.Rows[0].Field<string>("ent_coli_trop");
                        val.ParaEntHisCyst = dt.Rows[0].Field<string>("ent_his_cyst");
                        val.ParaEntHisTrop = dt.Rows[0].Field<string>("ent_his_trop");
                        val.ParaPusCells = dt.Rows[0].Field<string>("pus_cells");
                        val.ParaRBC = dt.Rows[0].Field<string>("rbc");
                        val.ParaYeastCell = dt.Rows[0].Field<string>("yeast_cell");
                        val.ParaFatGlobules = dt.Rows[0].Field<string>("fat_globules");
                        val.ParaBacteria = dt.Rows[0].Field<string>("bacteria");
                        val.ParaRemarks = dt.Rows[0].Field<string>("remarks");
                        val.ParaOthers = dt.Rows[0].Field<string>("others");
                        val.ParaPathologist = dt.Rows[0].Field<int>("pathologist");
                        val.ParaMedTech = dt.Rows[0].Field<int>("med_tech");

                        Profile.GetPathologistProfile(val.ParaPathologist);
                        Profile.GetMedTechProfile(val.ParaMedTech);

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Loading Parasitology Records: " + error);
            }
        }


        public bool AddParasitologyRecord(int record_id, int lab_type_id, string color, string consistency, string ascaris_lumb, string hookworm,
            string trichuris, string strongyloides, string ent_coli_cyst, string ent_coli_trop, string ent_his_cyst, string ent_his_trop,
            string pus_cells, string rbc, string yeast_cell, string fat_globules, string bacteria, string remarks, string others, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"INSERT INTO mmg_lab.tbltransactions(record_id, lab_type_id, created_by) VALUES(@record_id, @lab_type_id, @user);
                                
                                SET @'last_trans_id' = LAST_INSERT_ID();

                                INSERT INTO mmg_lab.tblparasitology(trans_id, color, consistency, ascaris_lumb, hookworm, 
                                trichuris_trichiura, strongyloides_ster, ent_coli_cyst, ent_coli_trop, ent_his_cyst, ent_his_trop,
                                pus_cells, rbc, yeast_cell, fat_globules, bacteria, remarks, others, pathologist, med_tech)
                                VALUES(@'last_trans_id', UPPER(@color), UPPER(@consistency), @ascaris_lumb, @hookworm, @trichuris, @strongyloides,
                                @ent_coli_cyst, @ent_coli_trop, @ent_his_cyst, @ent_his_trop, @pus_cells, @rbc, @yeast_cell, @fat_globules, @bacteria,
                                UPPER(@remarks), @others, @pathologist, @med_tech)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@record_id", record_id);
                        cmd.Parameters.AddWithValue("@lab_type_id", lab_type_id);
                        cmd.Parameters.AddWithValue("@user", val.ProfileLoggedID);
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@consistency", consistency);
                        cmd.Parameters.AddWithValue("@ascaris_lumb", ascaris_lumb);
                        cmd.Parameters.AddWithValue("@hookworm", hookworm);
                        cmd.Parameters.AddWithValue("@trichuris", trichuris);
                        cmd.Parameters.AddWithValue("@strongyloides", strongyloides);
                        cmd.Parameters.AddWithValue("@ent_coli_cyst", ent_coli_cyst);
                        cmd.Parameters.AddWithValue("@ent_coli_trop", ent_coli_trop);
                        cmd.Parameters.AddWithValue("@ent_his_cyst", ent_his_cyst);
                        cmd.Parameters.AddWithValue("@ent_his_trop", ent_his_trop);
                        cmd.Parameters.AddWithValue("@pus_cells", pus_cells);
                        cmd.Parameters.AddWithValue("@rbc", rbc);
                        cmd.Parameters.AddWithValue("@yeast_cell", yeast_cell);
                        cmd.Parameters.AddWithValue("@fat_globules", fat_globules);
                        cmd.Parameters.AddWithValue("@bacteria", bacteria);
                        cmd.Parameters.AddWithValue("@remarks", remarks);
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
                Console.WriteLine("Error Adding Parasitology Record: " + error);
                Log.AddLog(val.UserID, "Error Adding Parasitology Record: " + error.ToString());
                return false;
            }
        }

        public bool UpdateParasitology(int id, string color, string consistency, string ascaris_lumb, string hookworm,
            string trichuris, string strongyloides, string ent_coli_cyst, string ent_coli_trop, string ent_his_cyst, string ent_his_trop,
            string pus_cells, string rbc, string yeast_cell, string fat_globules, string bacteria, string remarks, string others, int pathologist, int med_tech)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"UPDATE mmg_lab.tblparasitology SET color=UPPER(@color), consistency=UPPER(@consistency), ascaris_lumb=UPPER(@ascaris_lumb), 
                                hookworm=UPPER(@hookworm), trichuris_trichiura=UPPER(@trichuris), strongyloides_ster=UPPER(@strongyloides), 
                                ent_coli_cyst=UPPER(@ent_coli_cyst), ent_coli_trop=UPPER(@ent_coli_trop), ent_his_cyst=UPPER(@ent_his_cyst), 
                                ent_his_trop=UPPER(@ent_his_trop), pus_cells=UPPER(@pus_cells), rbc=UPPER(@rbc), yeast_cell=UPPER(@yeast_cell), 
                                fat_globules=UPPER(@fat_globules), bacteria=UPPER(@bacteria), remarks=UPPER(@remarks), others=UPPER(@others), 
                                pathologist=@pathologist, med_tech=@med_tech, last_updated=@last_updated WHERE id=@id;";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@color", color);
                        cmd.Parameters.AddWithValue("@consistency", consistency);
                        cmd.Parameters.AddWithValue("@ascaris_lumb", ascaris_lumb);
                        cmd.Parameters.AddWithValue("@hookworm", hookworm);
                        cmd.Parameters.AddWithValue("@trichuris", trichuris);
                        cmd.Parameters.AddWithValue("@strongyloides", strongyloides);
                        cmd.Parameters.AddWithValue("@ent_coli_cyst", ent_coli_cyst);
                        cmd.Parameters.AddWithValue("@ent_coli_trop", ent_coli_trop);
                        cmd.Parameters.AddWithValue("@ent_his_cyst", ent_his_cyst);
                        cmd.Parameters.AddWithValue("@ent_his_trop", ent_his_trop);
                        cmd.Parameters.AddWithValue("@pus_cells", pus_cells);
                        cmd.Parameters.AddWithValue("@rbc", rbc);
                        cmd.Parameters.AddWithValue("@yeast_cell", yeast_cell);
                        cmd.Parameters.AddWithValue("@fat_globules", fat_globules);
                        cmd.Parameters.AddWithValue("@bacteria", bacteria);
                        cmd.Parameters.AddWithValue("@remarks", remarks);
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
                Console.WriteLine("Error Updating Parasitology Record: " + error);
                Log.AddLog(val.UserID, "Error Updating Parasitology Record: " + error.ToString());
                return false;
            }
        }


        public Records GetParasitologyData(int para_id)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connection.conString))
                {
                    string sql = @"SELECT * FROM mmg_lab.tblparasitology WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", para_id);

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsParasitology = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsParasitology, "Parasitology");

                        return dsParasitology;

                    }
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Parasitology Data: " + error);
                return null;
            }
        }
    }
}
