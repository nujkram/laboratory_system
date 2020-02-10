using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Laboratory_Records.functions
{
    class Report
    {
        components.Connection connection = new components.Connection();
        components.Values val = new components.Values();
        Log log = new Log();

        public Records GetReportChemistryData(DateTime from, DateTime to)
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

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsChemistry = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsChemistry, "ChemistryReport");

                        return dsChemistry;
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Chemistry Report Data: " + error);
                return null;
            }
        }

        public Records GetReportHematologyData(DateTime from, DateTime to)
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

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsHematology = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsHematology, "HematologyReport");

                        return dsHematology;
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Hematology Report Data: " + error);
                return null;
            }
        }

        public Records GetReportParasitologyData(DateTime from, DateTime to)
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

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsParasitology = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsParasitology, "ParasitologyReport");

                        return dsParasitology;
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Parasitology Report Data: " + error);
                return null;
            }
        }

        public Records GetReportUrinalysisData(DateTime from, DateTime to)
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

                        MySqlDataAdapter da = new MySqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        Records dsUrinalysis = new Records();
                        dt.Clear();
                        da.Fill(dt);
                        da.Fill(dsUrinalysis, "UrinalysisReport");

                        return dsUrinalysis;
                    }
                }

            }
            catch (Exception error)
            {
                Console.WriteLine("Error Getting Urinalysis Report Data: " + error);
                return null;
            }
        }
    }
}
