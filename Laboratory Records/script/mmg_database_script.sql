DROP DATABASE IF EXISTS mmg_lab;

CREATE DATABASE IF NOT EXISTS mmg_lab;
-- user levels
-- Admin: 198
-- Med Tech: 184
-- Pathologist: 145
-- Doctor: 153

CREATE TABLE mmg_lab.tblusers(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    username 			VARCHAR(16) NOT NULL,
    `password` 			VARCHAR(254) NOT NULL,
    user_level			INT(6) DEFAULT 3, 
    active				BOOLEAN DEFAULT TRUE,
    created 			TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id)
);

CREATE TABLE mmg_lab.tblprofiles(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    user_id 			INT(6) NOT NULL,
    first_name 			VARCHAR(42) DEFAULT NULL,
    middle_name 		VARCHAR(42) DEFAULT NULL,
    last_name 			VARCHAR(42) DEFAULT NULL,
    title 				VARCHAR(42) DEFAULT NULL,
    license_no			VARCHAR(42) DEFAULT NULL,
    created 			TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(user_id) REFERENCES mmg_lab.tblusers(id) ON DELETE CASCADE
);

CREATE TABLE mmg_lab.tblpatients(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    first_name 			VARCHAR(42) DEFAULT NULL,
    middle_name 		VARCHAR(42) DEFAULT NULL,
    last_name 			VARCHAR(42) DEFAULT NULL,
    gender				VARCHAR(6) DEFAULT NULL,
    birth_date 			DATE DEFAULT NULL,
    age					INT(3) DEFAULT NULL,
    address 			VARCHAR(254) DEFAULT NULL,
    created 			TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id)
);

CREATE TABLE mmg_lab.tbllab_type(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    `name`				VARCHAR(254) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY (id)
);

INSERT INTO mmg_lab.tbllab_type(`name`) VALUES('Chemistry');
INSERT INTO mmg_lab.tbllab_type(`name`) VALUES('Hematology');
INSERT INTO mmg_lab.tbllab_type(`name`) VALUES('Miscellaneous');
INSERT INTO mmg_lab.tbllab_type(`name`) VALUES('Parasitology');
INSERT INTO mmg_lab.tbllab_type(`name`) VALUES('Urinalysis');

CREATE TABLE mmg_lab.tblrecords(
	id					INT(6) NOT NULL AUTO_INCREMENT,
    patient_id			INT(6) NOT NULL,
    requested_by		VARCHAR(42) DEFAULT NULL,
    case_number			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
                        FOREIGN KEY(patient_id) REFERENCES mmg_lab.tblpatients(id)
);

CREATE TABLE mmg_lab.tbltransactions(
	id					INT(6) NOT NULL AUTO_INCREMENT,
    record_id 			INT(6) NOT NULL,
    lab_type_id			INT(6) NOT NULL,
    created_by			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
                        FOREIGN KEY(record_id) REFERENCES mmg_lab.tblrecords(id),
                        FOREIGN KEY(lab_type_id) REFERENCES mmg_lab.tbllab_type(id),
                        FOREIGN KEY(created_by) REFERENCES mmg_lab.tblprofiles(id)
);

CREATE TABLE mmg_lab.tblchemistry(
	id					INT(6) NOT NULL AUTO_INCREMENT,
    trans_id 			INT(6) NOT NULL,
    stat				VARCHAR(24) DEFAULT NULL,
    fasting_blood_sugar VARCHAR(24) DEFAULT NULL,
    random_blood_sugar 	VARCHAR(24) DEFAULT NULL,
    post_prandial 		VARCHAR(24) DEFAULT NULL,
    hba1c 				VARCHAR(24) DEFAULT NULL,
    urea 				VARCHAR(24) DEFAULT NULL,
    creatinine 			VARCHAR(24) DEFAULT NULL,
    uric_acid 			VARCHAR(24) DEFAULT NULL,
    cholesterol 		VARCHAR(24) DEFAULT NULL,
    triglycerides 		VARCHAR(24) DEFAULT NULL,
    hdl_cholesterol 	VARCHAR(24) DEFAULT NULL,
    ldl_cholesterol 	VARCHAR(24) DEFAULT NULL,
    sgot_ast 			VARCHAR(24) DEFAULT NULL,
    sgpt_alt 			VARCHAR(24) DEFAULT NULL,
    sodium 				VARCHAR(24) DEFAULT NULL,
    potassium 			VARCHAR(24) DEFAULT NULL,
    calcium 			VARCHAR(24) DEFAULT NULL,
    pathologist			INT(6) NOT NULL,
    med_tech			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated		TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(trans_id) REFERENCES mmg_lab.tbltransactions(id),
                        FOREIGN KEY(pathologist) REFERENCES mmg_lab.tblusers(id),
                        FOREIGN KEY(med_tech) REFERENCES mmg_lab.tblusers(id)
);

CREATE TABLE mmg_lab.tblhematology(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    trans_id 			INT(6) NOT NULL,
    exam_desired		VARCHAR(42) DEFAULT NULL,
    stat				VARCHAR(24) DEFAULT NULL,
    hemoglobin_con_mass VARCHAR(24) DEFAULT NULL,
    erythrocyte_vol_con VARCHAR(24) DEFAULT NULL,
    erythrocyte_num_con VARCHAR(24) DEFAULT NULL,
    leukocyte_num_con 	VARCHAR(24) DEFAULT NULL,
    blood_type 			VARCHAR(24) DEFAULT NULL,
	rh					VARCHAR(24) DEFAULT NULL,
    neutrophil_num_frac VARCHAR(24) DEFAULT NULL,
    segmenters 			VARCHAR(24) DEFAULT NULL,
    stab 				VARCHAR(24) DEFAULT NULL,
    eosinophil			VARCHAR(24) DEFAULT NULL,
    basophil 			VARCHAR(24) DEFAULT NULL,
    lymphocyte 			VARCHAR(24) DEFAULT NULL,
    monocyte 			VARCHAR(24) DEFAULT NULL,
    total 				VARCHAR(24) DEFAULT NULL,
    erythrocyte_sed_rate VARCHAR(24) DEFAULT NULL,
    thrombocyte_num_frac VARCHAR(24) DEFAULT NULL,
    bleeding_time 		VARCHAR(24) DEFAULT NULL,
    clotting_time 		VARCHAR(24) DEFAULT NULL,
    others 				VARCHAR(254) DEFAULT NULL,
    pathologist			INT(6) NOT NULL,
    med_tech			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated		TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
							FOREIGN KEY(trans_id) REFERENCES mmg_lab.tbltransactions(id),
                        FOREIGN KEY(pathologist) REFERENCES mmg_lab.tblusers(id),
                        FOREIGN KEY(med_tech) REFERENCES mmg_lab.tblusers(id)
);


CREATE TABLE mmg_lab.tblmisc(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    trans_id 			INT(6) NOT NULL,
    exam_desired		VARCHAR(42) DEFAULT NULL,
    specimen			VARCHAR(42) DEFAULT NULL,
    result 				VARCHAR(254) DEFAULT NULL,
    remarks 			VARCHAR(24) DEFAULT NULL,
    notes 				VARCHAR(24) DEFAULT NULL,
    others 				VARCHAR(24) DEFAULT NULL,
    pathologist			INT(6) NOT NULL,
    med_tech			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated		TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(trans_id) REFERENCES mmg_lab.tbltransactions(id),
                        FOREIGN KEY(pathologist) REFERENCES mmg_lab.tblusers(id),
                        FOREIGN KEY(med_tech) REFERENCES mmg_lab.tblusers(id)
);

CREATE TABLE mmg_lab.tblparasitology(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    trans_id 			INT(6) NOT NULL,
    color 				VARCHAR(42) NOT NULL,
    consistency 		VARCHAR(42) DEFAULT NULL,
    ascaris_lumb 		VARCHAR(24) DEFAULT NULL,
    hookworm 			VARCHAR(24) DEFAULT NULL,
    trichuris_trichiura VARCHAR(24) DEFAULT NULL,
    strongyloides_ster 	VARCHAR(24) DEFAULT NULL,
    ent_coli_cyst 		VARCHAR(24) DEFAULT NULL,
    ent_coli_trop		VARCHAR(24) DEFAULT NULL,
    ent_his_cyst 		VARCHAR(24) DEFAULT NULL,
    ent_his_trop 		VARCHAR(24) DEFAULT NULL,
    pus_cells 			VARCHAR(24) DEFAULT NULL,
    rbc 				VARCHAR(24) DEFAULT NULL,
    yeast_cell 			VARCHAR(24) DEFAULT NULL,
    fat_globules 		VARCHAR(24) DEFAULT NULL,
    bacteria 			VARCHAR(42) DEFAULT NULL,
    remarks				VARCHAR(254) DEFAULT NULL,
    others				VARCHAR(254) DEFAULT NULL,
    pathologist			INT(6) NOT NULL,
    med_tech			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated		TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(trans_id) REFERENCES mmg_lab.tbltransactions(id),
                        FOREIGN KEY(pathologist) REFERENCES mmg_lab.tblusers(id),
                        FOREIGN KEY(med_tech) REFERENCES mmg_lab.tblusers(id)
);

CREATE TABLE mmg_lab.tblurinalysis(
	id INT(6) NOT NULL AUTO_INCREMENT,
    trans_id 			INT(6) NOT NULL,
    exam_desired		VARCHAR(42) DEFAULT NULL,
    color				VARCHAR(24) DEFAULT NULL,
    transparency		VARCHAR(25) DEFAULT NULL,
    reaction			VARCHAR(24) DEFAULT NULL,
    specific_gravity	VARCHAR(24) DEFAULT NULL,
    protein				VARCHAR(24) DEFAULT NULL,
    sugar				VARCHAR(24) DEFAULT NULL,
    fine_granular		VARCHAR(24) DEFAULT NULL,
    coarse_granular		VARCHAR(24) DEFAULT NULL,
    pus_cell_cast		VARCHAR(24) DEFAULT NULL,
    hyaline				VARCHAR(24) DEFAULT NULL,
    rbc					VARCHAR(24) DEFAULT NULL,
    pus_cells			VARCHAR(24) DEFAULT NULL,
    uric_acid			VARCHAR(24) DEFAULT NULL,
    calcium_oxalate		VARCHAR(24) DEFAULT NULL,
    amorphous			VARCHAR(24) DEFAULT NULL,
    triple_phosphates	VARCHAR(24) DEFAULT NULL,
    squamous			VARCHAR(24) DEFAULT NULL,
    bacteria			VARCHAR(24) DEFAULT NULL,
    mucous				VARCHAR(24) DEFAULT NULL,
    round_epithelial	VARCHAR(24) DEFAULT NULL,
    yeast_cells			VARCHAR(24) DEFAULT NULL,
    vaginalis			VARCHAR(24) DEFAULT NULL,
    hominis				VARCHAR(24) DEFAULT NULL,
    pathologist			INT(6) NOT NULL,
    med_tech			INT(6) NOT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    last_updated		TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(trans_id) REFERENCES mmg_lab.tbltransactions(id),
                        FOREIGN KEY(pathologist) REFERENCES mmg_lab.tblusers(id),
                        FOREIGN KEY(med_tech) REFERENCES mmg_lab.tblusers(id)
);

CREATE TABLE mmg_lab.tbllogs(
	id 					INT(6) NOT NULL AUTO_INCREMENT,
    user_id				INT(6) NOT NULL,
    detail 				VARCHAR(1920) DEFAULT NULL,
    created				TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
						PRIMARY KEY(id),
						FOREIGN KEY(user_id) REFERENCES mmg_lab.tblusers(id)
);

INSERT INTO mmg_lab.tblusers(
`username`, `password`, `user_level
`) VALUES(
'admin', MD5('admin'), 198
);
INSERT INTO mmg_lab.tblusers(`username`, `password`, `user_level`) VALUES('test_mt', MD5('test_mt'), 184);
INSERT INTO mmg_lab.tblusers(`username`, `password`, `user_level`) VALUES('test_mt_1', MD5('test_mt'), 184);
INSERT INTO mmg_lab.tblusers(`username`, `password`, `user_level`) VALUES('test_pat', MD5('test_pathologist'), 145);
INSERT INTO mmg_lab.tblusers(`username`, `password`, `user_level`) VALUES('test_pat_1', MD5('test_pathologist'), 145);
INSERT INTO mmg_lab.tblusers(`username`, `password`, `user_level`) VALUES('test_pat_2', MD5('test_pathologist'), 145);

INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(1, 'Mark', 'Altamia', 'Gersaniva', 'Programmer', '000000');
INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(2, 'Joe Gina', 'N', 'Baltero', 'Medical Technologist', '0078558');
INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(3, 'Shine', 'Natividad', 'Gancero', 'Medical Technologist', '0085649');
INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(4, 'Mariam Margarita', 'J', 'Lena', 'Pathologist', '0044825');
INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(5, 'Maria', 'Arroyo', 'Clara', 'Pathologist', '00236548');
INSERT INTO mmg_lab.tblprofiles(user_id, first_name, middle_name, last_name, title, license_no) VALUES(6, 'Kharen', 'Janayon', 'Dilla', 'Pathologist', '00886453');
