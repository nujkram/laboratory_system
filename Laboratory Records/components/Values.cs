using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Records.components
{
    class Values
    {
        Connection connection = new Connection();

        public static string server_address = "localhost";
        public static string server_username = "root";
        public static string server_password = "admin";

        // <summary>
        // User Data
        public static int user_admin = 198;
        public static int user_med_tech = 184;
        public static int user_pathologist = 145;
        public static int user_doctor = 153;
        public static int user_id = 1;
        public static string username;
        public static int user_level;
        public static bool user_active;

        public int UserID
        {
            get { return user_id; }
            set { user_id = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public int UserLevel
        {
            get { return user_level; }
            set { user_level = value; }
        }

        public bool UserActive
        {
            get { return user_active; }
            set { user_active = value; }
        }

        public string UserStatus
        {
            get
            {
                if (user_active == true)
                {
                    return "Active";
                }
                else
                {
                    return "Inactive";
                }
            }
        }

        public string UserType
        {
            get
            {
                if (user_level == 184)
                {
                    return "Medical Technologist";
                }
                else if(user_level==145)
                {
                    return "Pathologist";
                }
                else if (user_level == 198)
                {
                    return "Admin";
                }
                else
                {
                    return "Doctor";
                }
            }
        }

        // </summary>

        // <summary>
        // Encoder Data
        public static int encoder_id;
        public static string encoder_first_name;
        public static string encoder_middle_name;
        public static string encoder_last_name;

        public int EncoderID
        {
            get { return encoder_id; }
            set { encoder_id = value; }
        }

        public string EncoderFirstName
        {
            get { return encoder_first_name; }
            set { encoder_first_name = value; }
        }

        public string EncoderMiddleName
        {
            get { return encoder_middle_name; }
            set { encoder_middle_name = value; }
        }

        public string EncoderLastName
        {
            get { return encoder_last_name; }
            set { encoder_last_name = value; }
        }

        public string EncoderNiceName
        {
            get { return encoder_first_name; }
            set { encoder_first_name = value; }
        }

        public string EncoderFullName
        {
            get
            {
                if (string.IsNullOrEmpty(pat_middle_name))
                {
                    return String.Format("{0} {1}", encoder_first_name, encoder_last_name);
                }
                else
                {
                    return String.Format("{0} {1}. {2}", encoder_first_name, encoder_middle_name[0], encoder_last_name);
                }
            }
        }

        // <summary>
        // Pathologist Data
        public static int pat_id;
        public static string pat_first_name;
        public static string pat_middle_name;
        public static string pat_last_name;
        public static string pat_title;
        public static string pat_license_no;

        public int PatID
        {
            get { return pat_id; }
            set { pat_id = value; }
        }

        public string PatFirstName
        {
            get { return pat_first_name; }
            set { pat_first_name = value; }
        }

        public string PatMiddleName
        {
            get { return pat_middle_name; }
            set { pat_middle_name = value; }
        }

        public string PatLastName
        {
            get { return pat_last_name; }
            set { pat_last_name = value; }
        }

        public string PatTitle
        {
            get { return pat_title; }
            set { pat_title = value; }
        }

        public string PatLicense
        {
            get { return pat_license_no; }
            set { pat_license_no = value; }
        }

        public string PatFullName
        {
            get {
                if (string.IsNullOrEmpty(pat_middle_name))
                {
                    return String.Format("{0} {1}", pat_first_name, pat_last_name);
                }
                else
                {
                    return String.Format("{0} {1}. {2}", pat_first_name, pat_middle_name[0], pat_last_name);
                }
            }
        }
        // </summary>

        // <summary>
        // Medical Technologist Data
        public static int med_id;
        public static string med_first_name;
        public static string med_middle_name;
        public static string med_last_name;
        public static string med_title;
        public static string med_license_no;

        public int MedID
        {
            get { return med_id; }
            set { med_id = value; }
        }

        public string MedFirstName
        {
            get { return med_first_name; }
            set { med_first_name = value; }
        }

        public string MedMiddleName
        {
            get { return med_middle_name; }
            set { med_middle_name = value; }
        }

        public string MedLastName
        {
            get { return med_last_name; }
            set { med_last_name = value; }
        }

        public string MedTitle
        {
            get { return med_title; }
            set { med_title = value; }
        }

        public string MedLicense
        {
            get { return med_license_no; }
            set { med_license_no = value; }
        }

        public string MedFullName
        {
            get {
                if (string.IsNullOrEmpty(med_middle_name))
                {
                    return String.Format("{0} {1}", med_first_name, med_last_name);
                }
                else
                {
                    return String.Format("{0} {1}. {2}", med_first_name, med_middle_name[0], med_last_name);
                }
            }
        }
        // </summary>

        // <summary>
        // Profile Data
        public static int profile_logged_id;
        public static int profile_id;
        public static string profile_first_name;
        public static string profile_middle_name;
        public static string profile_last_name;
        public static string profile_title;
        public static string profile_license_no;

        public int ProfileLoggedID
        {
            get { return profile_logged_id; }
            set { profile_logged_id = value; }
        }

        public int ProfileID
        {
            get { return profile_id; }
            set { profile_id = value; }
        }

        public string ProfileFirstName
        {
            get { return profile_first_name; }
            set { profile_first_name = value; }
        }

        public string ProfileMiddleName
        {
            get { return profile_middle_name; }
            set { profile_middle_name = value; }
        }

        public string ProfileLastName
        {
            get { return profile_last_name; }
            set { profile_last_name = value; }
        }

        public string ProfileTitle
        {
            get { return profile_title; }
            set { profile_title = value; }
        }

        public string ProfileLicenseNo
        {
            get { return profile_license_no; }
            set { profile_license_no = value; }
        }

        public string ProfileFullName
        {
            get{
                if (string.IsNullOrEmpty(profile_middle_name))
                {
                    return String.Format("{0} {1}", profile_first_name, profile_last_name);
                }
                else
                {
                    return String.Format("{0} {1}. {2}", profile_first_name, profile_middle_name[0], profile_last_name);
                }
            }
        }

        // </summary>

        // <summary>
        // Patient Data
        public static int patient_id;
        public static string patient_first_name;
        public static string patient_middle_name;
        public static string patient_last_name;
        public static string patient_gender;
        public static DateTime patient_birth_date;
        public static string patient_address;
        public static long patient_age;
        public static int patient_count;

        public int PatientID
        {
            get { return patient_id; }
            set { patient_id = value; }
        }

        public string PatientFirstName
        {
            get { return patient_first_name; }
            set { patient_first_name = value; }
        }

        public string PatientMiddleName
        {
            get { return patient_middle_name; }
            set { patient_middle_name = value; }
        }

        public string PatientLastName
        {
            get { return patient_last_name; }
            set { patient_last_name = value; }
        }

        public string PatientGender
        {
            get { return patient_gender; }
            set { patient_gender = value; }
        }

        public DateTime PatientBirthDate
        {
            get { return patient_birth_date; }
            set { patient_birth_date = value; }
        }

        public string PatientAddress
        {
            get { return patient_address; }
            set { patient_address = value; }
        }

        public long PatientAge {
            get { return patient_age; }
            set { patient_age = value; }
        }

        public string PatientFullName
        {
            get {
                if (string.IsNullOrEmpty(patient_middle_name))
                {
                    return String.Format("{0}, {1}", patient_last_name, patient_first_name);
                }
                else
                {
                    return String.Format("{0}, {1} {2}.", patient_last_name, patient_first_name, patient_middle_name[0]);
                }
            }
        }

        public int PatientCount
        {
            get { return patient_count; }
            set { patient_count = value; }
        }

        // </summary>

        // <summary>
        // Record Data
        public static int record_id;
        public static string record_request;
        public static int record_case_no;
        public static DateTime record_created;
        public static int record_count;

        public int RecordID
        {
            get { return record_id; }
            set { record_id = value; }
        }

        public string RecordRequest
        {
            get { return record_request; }
            set { record_request = value; }
        }

        public int RecordCase
        {
            get { return record_case_no; }
            set { record_case_no = value; }
        }

        public DateTime RecordCreated
        {
            get { return record_created; }
            set { record_created = value; }
        }

        public int RecordCount
        {
            get { return record_count; }
            set { record_count = value; }
        }

        // </summary>

        // <summary>
        // Transaction Data
        public static int trans_id;
        public static int trans_lab_type;
        public static int trans_created_by;
        public static DateTime trans_date;

        public int TransID
        {
            get { return trans_id; }
            set { trans_id = value; }
        }

        public int TransLabType
        {
            get { return trans_lab_type; }
            set { trans_lab_type = value; }
        }

        public int TransCreatedBy
        {
            get { return trans_created_by; }
            set { trans_created_by = value; }
        }

        public DateTime TransCreated
        {
            get { return trans_date; }
            set { trans_date = value; }
        }
        // </summary>

        // <summary>
        // Lab Data
        public static int lab_id;
        public static string lab_name;

        public int LabID {
            get { return lab_id; }
            set { lab_id = value; }
        }
        
        public string LabName {
            get { return lab_name; }
            set { lab_name = value; }
        }

        // </summary>

        // <summary>
        // Chemistry Data
        public static int chem_id;
        public static string chem_stat;
        public static string chem_fasting_blood_sugar;
        public static string chem_random_blood_sugar;
        public static string chem_post_prandial;
        public static string chem_hba1c;
        public static string chem_urea;
        public static string chem_creatinine;
        public static string chem_uric_acid;
        public static string chem_cholesterol;
        public static string chem_triglycerides;
        public static string chem_hdl_cholesterol;
        public static string chem_ldl_cholesterol;
        public static string chem_sgot_ast;
        public static string chem_sgpt_alt;
        public static string chem_sodium;
        public static string chem_potassium;
        public static string chem_calcium;
        public static int chem_pathologist;
        public static int chem_med_tech;

        public int ChemID
        {
            get { return chem_id; }
            set { chem_id = value; }
        }

        public string ChemStat
        {
            get { return chem_stat; }
            set { chem_stat = value; }
        }

        public string ChemFastingBloodSugar
        {
            get { return chem_fasting_blood_sugar; }
            set { chem_fasting_blood_sugar = value; }
        }

        public string ChemRandomBloodSugar
        {
            get { return chem_random_blood_sugar; }
            set { chem_random_blood_sugar = value; }
        }

        public string ChemPostPrandial
        {
            get { return chem_post_prandial; }
            set { chem_post_prandial = value; }
        }

        public string ChemHba1c
        {
            get { return chem_hba1c; }
            set { chem_hba1c = value; }
        }

        public string ChemUrea
        {
            get { return chem_urea; }
            set { chem_urea = value; }
        }

        public string ChemCreatinine
        {
            get { return chem_creatinine; }
            set { chem_creatinine = value; }
        }

        public string ChemUricAcid
        {
            get { return chem_uric_acid; }
            set { chem_uric_acid = value; }
        }

        public string ChemCholesterol
        {
            get { return chem_cholesterol; }
            set { chem_cholesterol = value; }
        }

        public string ChemTriglycerides
        {
            get { return chem_triglycerides; }
            set { chem_triglycerides = value; }
        }

        public string ChemHdlCholesterol
        {
            get { return chem_hdl_cholesterol; }
            set { chem_hdl_cholesterol = value; }
        }

        public string ChemLdlCholesterol
        {
            get { return chem_ldl_cholesterol; }
            set { chem_ldl_cholesterol = value; }
        }

        public string ChemSgotAst
        {
            get { return chem_sgot_ast; }
            set { chem_sgot_ast = value; }
        }

        public string ChemSgptAlt
        {
            get { return chem_sgpt_alt; }
            set { chem_sgpt_alt = value; }
        }

        public string ChemSodium
        {
            get { return chem_sodium; }
            set { chem_sodium = value; }
        }

        public string ChemPotassium
        {
            get { return chem_potassium; }
            set { chem_potassium = value; }
        }

        public string ChemCalcium
        {
            get { return chem_calcium; }
            set { chem_calcium = value; }
        }

        public int ChemPathologist
        {
            get { return chem_pathologist; }
            set { chem_pathologist = value; }
        }

        public int ChemMedTech
        {
            get { return chem_med_tech; }
            set { chem_med_tech = value; }
        }

        // </summary>

        // <summary>
        // Parasitology Data
        public static int para_id;
        public static string para_color;
        public static string para_consistency;
        public static string para_ascaris;
        public static string para_hookworm;
        public static string para_trichuris;
        public static string para_strongyloides;
        public static string para_ent_coli_cyst;
        public static string para_ent_coli_trop;
        public static string para_ent_his_cyst;
        public static string para_ent_his_trop;
        public static string para_pus_cells;
        public static string para_rbc;
        public static string para_yeast_cell;
        public static string para_fat_globules;
        public static string para_bacteria;
        public static string para_remarks;
        public static string para_others;
        public static int para_pathologist;
        public static int para_med_tech;

        public int ParaID
        {
            get { return para_id; }
            set { para_id = value; }
        }

        public string ParaColor
        {
            get { return para_color; }
            set { para_color = value; }
        }

        public string ParaConsistency
        {
            get { return para_consistency; }
            set { para_consistency = value; }
        }

        public string ParaAscaris
        {
            get { return para_ascaris; }
            set { para_ascaris = value; }
        }

        public string ParaHookworm
        {
            get { return para_hookworm; }
            set { para_hookworm = value; }
        }

        public string ParaTrichuris
        {
            get { return para_trichuris; }
            set { para_trichuris = value; }
        }

        public string ParaStrongyloides
        {
            get { return para_strongyloides; }
            set { para_strongyloides = value; }
        }

        public string ParaEntColiCyst
        {
            get { return para_ent_coli_cyst; }
            set { para_ent_coli_cyst = value; }
        }

        public string ParaEntColiTrop
        {
            get { return para_ent_coli_trop; }
            set { para_ent_coli_trop = value; }
        }

        public string ParaEntHisCyst
        {
            get { return para_ent_his_cyst; }
            set { para_ent_his_cyst = value; }
        }

        public string ParaEntHisTrop
        {
            get { return para_ent_his_trop; }
            set { para_ent_his_trop = value; }
        }

        public string ParaPusCells
        {
            get { return para_pus_cells; }
            set { para_pus_cells = value; }
        }

        public string ParaRBC
        {
            get { return para_rbc; }
            set { para_rbc = value; }
        }

        public string ParaYeastCell
        {
            get { return para_yeast_cell; }
            set { para_yeast_cell = value; }
        }

        public string ParaFatGlobules
        {
            get { return para_fat_globules; }
            set { para_fat_globules = value; }
        }

        public string ParaBacteria
        {
            get { return para_bacteria; }
            set { para_bacteria = value; }
        }

        public string ParaRemarks
        {
            get { return para_remarks; }
            set { para_remarks = value; }
        }

        public string ParaOthers
        {
            get { return para_others; }
            set { para_others = value; }
        }

        public int ParaPathologist
        {
            get { return para_pathologist; }
            set { para_pathologist = value; }
        }

        public int ParaMedTech
        {
            get { return para_med_tech; }
            set { para_med_tech = value; }
        }

        // </summary>

        // <summary>
        // Urinalysis Data
        public static int uri_id;
        public static string uri_exam;
        public static string uri_color;
        public static string uri_trans;
        public static string uri_reaction;
        public static string uri_specific_gravity;
        public static string uri_protein;
        public static string uri_sugar;
        public static string uri_fine_gran;
        public static string uri_coarse_gran;
        public static string uri_pus_cell_cast;
        public static string uri_hyaline;
        public static string uri_rbc;
        public static string uri_pus_cell;
        public static string uri_uric_acid;
        public static string uri_calcium_oxalate;
        public static string uri_amorphous;
        public static string uri_triple_phosphates;
        public static string url_squamous;
        public static string uri_bacteria;
        public static string uri_mucous;
        public static string uri_round_epi;
        public static string uri_yeast_cells;
        public static string uri_vaginalis;
        public static string uri_hominis;
        public static int uri_pathologist;
        public static int uri_med_tech;

        public int UriID
        {
            get { return uri_id; }
            set { uri_id = value; }
        }

        public string UriExam
        {
            get { return uri_exam; }
            set { uri_exam = value; }
        }

        public string UriColor
        {
            get { return uri_color; }
            set { uri_color = value; }
        }

        public string UriTrans
        {
            get { return uri_trans; }
            set { uri_trans = value; }
        }

        public string UriReaction
        {
            get { return uri_reaction; }
            set { uri_reaction = value; }
        }

        public string UriSpecificGravity
        {
            get { return uri_specific_gravity; }
            set { uri_specific_gravity = value; }
        }

        public string UriProtein
        {
            get { return uri_protein; }
            set { uri_protein = value; }
        }

        public string UriSugar
        {
            get { return uri_sugar; }
            set { uri_sugar = value; }
        }

        public string UriFineGran
        {
            get { return uri_fine_gran; }
            set { uri_fine_gran = value; }
        }

        public string UriCoarseGran
        {
            get { return uri_coarse_gran; }
            set { uri_coarse_gran = value; }
        }

        public string UriPusCellCast
        {
            get { return uri_pus_cell_cast; }
            set { uri_pus_cell_cast = value; }
        }

        public string UriHyaline
        {
            get { return uri_hyaline; }
            set { uri_hyaline = value; }
        }

        public string UriRBC
        {
            get { return uri_rbc; }
            set { uri_rbc = value; }
        }

        public string UriPusCells
        {
            get { return uri_pus_cell; }
            set { uri_pus_cell = value; }
        }

        public string UriUricAcid
        {
            get { return uri_uric_acid; }
            set { uri_uric_acid = value; }
        }

        public string UriCalciumOxolate
        {
            get { return uri_calcium_oxalate; }
            set { uri_calcium_oxalate = value; }
        }

        public string UriAmorphous
        {
            get { return uri_amorphous; }
            set { uri_amorphous = value; }
        }

        public string UriTriplePhospahtes
        {
            get { return uri_triple_phosphates; }
            set { uri_triple_phosphates = value; }
        }

        public string UriSquamous
        {
            get { return url_squamous; }
            set { url_squamous = value; }
        }

        public string UriBacteria
        {
            get { return uri_bacteria; }
            set { uri_bacteria = value; }
        }

        public string UriMucous
        {
            get { return uri_mucous; }
            set { uri_mucous = value; }
        }

        public string UriRoundEpi
        {
            get { return uri_round_epi; }
            set { uri_round_epi = value; }
        }

        public string UriYeastCells
        {
            get { return uri_yeast_cells; }
            set { uri_yeast_cells = value; }
        }

        public string UriVaginalis
        {
            get { return uri_vaginalis; }
            set { uri_vaginalis = value; }
        }

        public string UriHominis
        {
            get { return uri_hominis; }
            set { uri_hominis = value; }
        }

        public int UriPathologist
        {
            get { return uri_pathologist; }
            set { uri_pathologist = value; }
        }

        public int UriMedTech
        {
            get { return uri_med_tech; }
            set { uri_med_tech = value; }
        }

        // </summary>

        // <summary>
        // Hematology Data
        public static int hema_id;
        public static string hema_exam;
        public static string hema_stat;
        public static string hema_hemoglobin;
        public static string hema_ery_vol;
        public static string hema_ery_num;
        public static string hema_leukocyte;
        public static string hema_blood_type;
        public static string hema_rh;
        public static string hema_neutrophil;
        public static string hema_segmenters;
        public static string hema_stab;
        public static string hema_eosinophil;
        public static string hema_basophil;
        public static string hema_lymphocyte;
        public static string hema_monocyte;
        public static string hema_total;
        public static string hema_ery_sed;
        public static string hema_thrombocyte;
        public static string hema_bleeding_time;
        public static string hema_clotting_time;
        public static string hema_others;
        public static int hema_pathologist;
        public static int hema_med_tech;

        public int HemaID
        {
            get { return hema_id; }
            set { hema_id = value; }
        }

        public string HemaExam
        {
            get { return hema_exam; }
            set { hema_exam = value; }
        }

        public string HemaStat
        {
            get { return hema_stat; }
            set { hema_stat = value; }
        }

        public string HemaHemoglobin
        {
            get { return hema_hemoglobin; }
            set { hema_hemoglobin = value; }
        }

        public string HemaEryVol
        {
            get { return hema_ery_vol; }
            set { hema_ery_vol = value; }
        }

        public string HemaEryNum
        {
            get { return hema_ery_num; }
            set { hema_ery_num = value; }
        }

        public string HemaLeukocyte
        {
            get { return hema_leukocyte; }
            set { hema_leukocyte = value; }
        }

        public string HemaBloodType
        {
            get { return hema_blood_type; }
            set { hema_blood_type = value; }
        }

        public string HemaRH
        {
            get { return hema_rh; }
            set { hema_rh = value; }
        }

        public string HemaNeutrophil
        {
            get { return hema_neutrophil; }
            set { hema_neutrophil = value; }
        }

        public string HemaSegmenters
        {
            get { return hema_segmenters; }
            set { hema_segmenters = value; }
        }

        public string HemaStab
        {
            get { return hema_stab; }
            set { hema_stab = value; }
        }

        public string HemaEosinophil
        {
            get { return hema_eosinophil; }
            set { hema_eosinophil = value; }
        }

        public string HemaBasophil
        {
            get { return hema_basophil; }
            set { hema_basophil = value; }
        }

        public string HemaLymphocyte
        {
            get { return hema_lymphocyte; }
            set { hema_lymphocyte = value; }
        }

        public string HemaMonocyte
        {
            get { return hema_monocyte; }
            set { hema_monocyte = value; }
        }

        public string HemaTotal
        {
            get { return hema_total; }
            set { hema_total = value; }
        }

        public string HemaErySed
        {
            get { return hema_ery_sed; }
            set { hema_ery_sed = value; }
        }

        public string HemaThrombocyte
        {
            get { return hema_thrombocyte; }
            set { hema_thrombocyte = value; }
        }

        public string HemaBleedingTime
        {
            get { return hema_bleeding_time; }
            set { hema_bleeding_time = value; }
        }

        public string HemaClottingTime
        {
            get { return hema_clotting_time; }
            set { hema_clotting_time = value; }
        }

        public string HemaOthers
        {
            get { return hema_others; }
            set { hema_others = value; }
        }

        public int HemaPathologist
        {
            get { return hema_pathologist; }
            set { hema_pathologist = value; }
        }

        public int HemaMedTech
        {
            get { return hema_med_tech; }
            set { hema_med_tech = value; }
        }

        // </summary>

        // <summary>
        // Miscellaneous Data
        public static int misc_id;
        public static string misc_exam;
        public static string misc_specimen;
        public static string misc_result;
        public static string misc_remarks;
        public static string misc_notes;
        public static string misc_others;
        public static int misc_pathologist;
        public static int misc_med_tech;

        public int MiscID
        {
            get { return misc_id; }
            set { misc_id = value; }
        }

        public string MiscExam
        {
            get { return misc_exam; }
            set { misc_exam = value; }
        }

        public string MiscSpecimen
        {
            get { return misc_specimen; }
            set { misc_specimen = value; }
        }

        public string MiscResult
        {
            get { return misc_result; }
            set { misc_result = value; }
        }

        public string MiscRemarks
        {
            get { return misc_remarks; }
            set { misc_remarks = value; }
        }

        public string MiscNotes
        {
            get { return misc_notes; }
            set { misc_notes = value; }
        }

        public string MiscOthers
        {
            get { return misc_others; }
            set { misc_others = value; }
        }

        public int MiscPathologist
        {
            get { return misc_pathologist; }
            set { misc_pathologist = value; }
        }

        public int MiscMedTech
        {
            get { return misc_med_tech; }
            set { misc_med_tech = value; }
        }

        // </summary>

        // <summary>
        // Report
        public static DateTime date_from;
        public static DateTime date_to;

        public DateTime DateFrom
        {
            get { return date_from; }
            set { date_from = value; }
        }

        public DateTime DateTo
        {
            get { return date_to; }
            set { date_to = value; }
        }

        public double TryToParse(string value)
        {
            double number = 0;
            bool result = Double.TryParse(value, out number);
            if (result)
            {
                return number;
            }
            else
            {
                if (value == null) value = "";
                return 0;
            }
        }
    }
}
