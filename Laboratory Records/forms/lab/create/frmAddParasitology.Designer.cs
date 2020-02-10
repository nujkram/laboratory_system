namespace Laboratory_Records.forms.lab
{
    partial class frmAddParasitology
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddParasitology));
            this.lblCase = new MetroFramework.Controls.MetroLabel();
            this.lblRequest = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.cboMedTech = new MetroFramework.Controls.MetroComboBox();
            this.cboPathologist = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtColor = new MetroFramework.Controls.MetroTextBox();
            this.txtConsistency = new MetroFramework.Controls.MetroTextBox();
            this.txtAscaris = new MetroFramework.Controls.MetroTextBox();
            this.txtHookworm = new MetroFramework.Controls.MetroTextBox();
            this.txtTrichuris = new MetroFramework.Controls.MetroTextBox();
            this.txtStrongyloides = new MetroFramework.Controls.MetroTextBox();
            this.txtEntaColiCyst = new MetroFramework.Controls.MetroTextBox();
            this.txtEntaColiTrop = new MetroFramework.Controls.MetroTextBox();
            this.txtEntaHisCyst = new MetroFramework.Controls.MetroTextBox();
            this.txtEntaHisTrop = new MetroFramework.Controls.MetroTextBox();
            this.txtPusCell = new MetroFramework.Controls.MetroTextBox();
            this.txtRBC = new MetroFramework.Controls.MetroTextBox();
            this.txtYeastCell = new MetroFramework.Controls.MetroTextBox();
            this.txtFatGlobules = new MetroFramework.Controls.MetroTextBox();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.txtOthers = new MetroFramework.Controls.MetroTextBox();
            this.txtBacteria = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(750, 60);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(65, 19);
            this.lblCase.TabIndex = 47;
            this.lblCase.Text = "Case No.:";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(25, 98);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(91, 19);
            this.lblRequest.TabIndex = 46;
            this.lblRequest.Text = "Requested by:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(77, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 19);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(759, 98);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(779, 79);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 43;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 19);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Full Name:";
            // 
            // cboMedTech
            // 
            this.cboMedTech.FormattingEnabled = true;
            this.cboMedTech.ItemHeight = 23;
            this.cboMedTech.Location = new System.Drawing.Point(354, 383);
            this.cboMedTech.Name = "cboMedTech";
            this.cboMedTech.Size = new System.Drawing.Size(210, 29);
            this.cboMedTech.TabIndex = 19;
            this.cboMedTech.UseSelectable = true;
            this.cboMedTech.SelectedIndexChanged += new System.EventHandler(this.cboMedTech_SelectedIndexChanged);
            // 
            // cboPathologist
            // 
            this.cboPathologist.FormattingEnabled = true;
            this.cboPathologist.ItemHeight = 23;
            this.cboPathologist.Location = new System.Drawing.Point(23, 380);
            this.cboPathologist.Name = "cboPathologist";
            this.cboPathologist.Size = new System.Drawing.Size(210, 29);
            this.cboPathologist.TabIndex = 18;
            this.cboPathologist.UseSelectable = true;
            this.cboPathologist.SelectedIndexChanged += new System.EventHandler(this.cboPathologist_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(354, 358);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 85;
            this.metroLabel2.Text = "Medical Technologist:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 358);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 84;
            this.metroLabel1.Text = "Pathologist:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(23, 453);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(922, 39);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "SAVE";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtColor
            // 
            // 
            // 
            // 
            this.txtColor.CustomButton.Image = null;
            this.txtColor.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtColor.CustomButton.Name = "";
            this.txtColor.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtColor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtColor.CustomButton.TabIndex = 1;
            this.txtColor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtColor.CustomButton.UseSelectable = true;
            this.txtColor.CustomButton.Visible = false;
            this.txtColor.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtColor.Lines = new string[0];
            this.txtColor.Location = new System.Drawing.Point(23, 142);
            this.txtColor.MaxLength = 32767;
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.PromptText = "Color";
            this.txtColor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtColor.SelectedText = "";
            this.txtColor.SelectionLength = 0;
            this.txtColor.SelectionStart = 0;
            this.txtColor.ShortcutsEnabled = true;
            this.txtColor.Size = new System.Drawing.Size(210, 28);
            this.txtColor.TabIndex = 1;
            this.txtColor.UseSelectable = true;
            this.txtColor.WaterMark = "Color";
            this.txtColor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtColor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtConsistency
            // 
            // 
            // 
            // 
            this.txtConsistency.CustomButton.Image = null;
            this.txtConsistency.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtConsistency.CustomButton.Name = "";
            this.txtConsistency.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtConsistency.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConsistency.CustomButton.TabIndex = 1;
            this.txtConsistency.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConsistency.CustomButton.UseSelectable = true;
            this.txtConsistency.CustomButton.Visible = false;
            this.txtConsistency.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtConsistency.Lines = new string[0];
            this.txtConsistency.Location = new System.Drawing.Point(23, 176);
            this.txtConsistency.MaxLength = 32767;
            this.txtConsistency.Name = "txtConsistency";
            this.txtConsistency.PasswordChar = '\0';
            this.txtConsistency.PromptText = "Consistency";
            this.txtConsistency.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConsistency.SelectedText = "";
            this.txtConsistency.SelectionLength = 0;
            this.txtConsistency.SelectionStart = 0;
            this.txtConsistency.ShortcutsEnabled = true;
            this.txtConsistency.Size = new System.Drawing.Size(210, 28);
            this.txtConsistency.TabIndex = 2;
            this.txtConsistency.UseSelectable = true;
            this.txtConsistency.WaterMark = "Consistency";
            this.txtConsistency.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConsistency.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAscaris
            // 
            // 
            // 
            // 
            this.txtAscaris.CustomButton.Image = null;
            this.txtAscaris.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtAscaris.CustomButton.Name = "";
            this.txtAscaris.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtAscaris.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAscaris.CustomButton.TabIndex = 1;
            this.txtAscaris.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAscaris.CustomButton.UseSelectable = true;
            this.txtAscaris.CustomButton.Visible = false;
            this.txtAscaris.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAscaris.Lines = new string[0];
            this.txtAscaris.Location = new System.Drawing.Point(23, 213);
            this.txtAscaris.MaxLength = 32767;
            this.txtAscaris.Name = "txtAscaris";
            this.txtAscaris.PasswordChar = '\0';
            this.txtAscaris.PromptText = "Ascaris Lumbricoides /lpf";
            this.txtAscaris.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAscaris.SelectedText = "";
            this.txtAscaris.SelectionLength = 0;
            this.txtAscaris.SelectionStart = 0;
            this.txtAscaris.ShortcutsEnabled = true;
            this.txtAscaris.Size = new System.Drawing.Size(210, 28);
            this.txtAscaris.TabIndex = 3;
            this.txtAscaris.UseSelectable = true;
            this.txtAscaris.WaterMark = "Ascaris Lumbricoides /lpf";
            this.txtAscaris.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAscaris.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAscaris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAscaris_KeyPress);
            // 
            // txtHookworm
            // 
            // 
            // 
            // 
            this.txtHookworm.CustomButton.Image = null;
            this.txtHookworm.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtHookworm.CustomButton.Name = "";
            this.txtHookworm.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtHookworm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtHookworm.CustomButton.TabIndex = 1;
            this.txtHookworm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtHookworm.CustomButton.UseSelectable = true;
            this.txtHookworm.CustomButton.Visible = false;
            this.txtHookworm.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtHookworm.Lines = new string[0];
            this.txtHookworm.Location = new System.Drawing.Point(23, 247);
            this.txtHookworm.MaxLength = 32767;
            this.txtHookworm.Name = "txtHookworm";
            this.txtHookworm.PasswordChar = '\0';
            this.txtHookworm.PromptText = "Hookworm /lpf";
            this.txtHookworm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtHookworm.SelectedText = "";
            this.txtHookworm.SelectionLength = 0;
            this.txtHookworm.SelectionStart = 0;
            this.txtHookworm.ShortcutsEnabled = true;
            this.txtHookworm.Size = new System.Drawing.Size(210, 28);
            this.txtHookworm.TabIndex = 4;
            this.txtHookworm.UseSelectable = true;
            this.txtHookworm.WaterMark = "Hookworm /lpf";
            this.txtHookworm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtHookworm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtHookworm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHookworm_KeyPress);
            // 
            // txtTrichuris
            // 
            // 
            // 
            // 
            this.txtTrichuris.CustomButton.Image = null;
            this.txtTrichuris.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtTrichuris.CustomButton.Name = "";
            this.txtTrichuris.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTrichuris.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTrichuris.CustomButton.TabIndex = 1;
            this.txtTrichuris.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTrichuris.CustomButton.UseSelectable = true;
            this.txtTrichuris.CustomButton.Visible = false;
            this.txtTrichuris.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTrichuris.Lines = new string[0];
            this.txtTrichuris.Location = new System.Drawing.Point(23, 281);
            this.txtTrichuris.MaxLength = 32767;
            this.txtTrichuris.Name = "txtTrichuris";
            this.txtTrichuris.PasswordChar = '\0';
            this.txtTrichuris.PromptText = "Trichuris trichiura /lpf";
            this.txtTrichuris.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTrichuris.SelectedText = "";
            this.txtTrichuris.SelectionLength = 0;
            this.txtTrichuris.SelectionStart = 0;
            this.txtTrichuris.ShortcutsEnabled = true;
            this.txtTrichuris.Size = new System.Drawing.Size(210, 28);
            this.txtTrichuris.TabIndex = 5;
            this.txtTrichuris.UseSelectable = true;
            this.txtTrichuris.WaterMark = "Trichuris trichiura /lpf";
            this.txtTrichuris.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTrichuris.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTrichuris.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrichuris_KeyPress);
            // 
            // txtStrongyloides
            // 
            // 
            // 
            // 
            this.txtStrongyloides.CustomButton.Image = null;
            this.txtStrongyloides.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtStrongyloides.CustomButton.Name = "";
            this.txtStrongyloides.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtStrongyloides.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStrongyloides.CustomButton.TabIndex = 1;
            this.txtStrongyloides.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStrongyloides.CustomButton.UseSelectable = true;
            this.txtStrongyloides.CustomButton.Visible = false;
            this.txtStrongyloides.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtStrongyloides.Lines = new string[0];
            this.txtStrongyloides.Location = new System.Drawing.Point(23, 315);
            this.txtStrongyloides.MaxLength = 32767;
            this.txtStrongyloides.Name = "txtStrongyloides";
            this.txtStrongyloides.PasswordChar = '\0';
            this.txtStrongyloides.PromptText = "Strongyloides stercoralis /lpf";
            this.txtStrongyloides.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStrongyloides.SelectedText = "";
            this.txtStrongyloides.SelectionLength = 0;
            this.txtStrongyloides.SelectionStart = 0;
            this.txtStrongyloides.ShortcutsEnabled = true;
            this.txtStrongyloides.Size = new System.Drawing.Size(210, 28);
            this.txtStrongyloides.TabIndex = 6;
            this.txtStrongyloides.UseSelectable = true;
            this.txtStrongyloides.WaterMark = "Strongyloides stercoralis /lpf";
            this.txtStrongyloides.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStrongyloides.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtStrongyloides.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStrongyloides_KeyPress);
            // 
            // txtEntaColiCyst
            // 
            // 
            // 
            // 
            this.txtEntaColiCyst.CustomButton.Image = null;
            this.txtEntaColiCyst.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtEntaColiCyst.CustomButton.Name = "";
            this.txtEntaColiCyst.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEntaColiCyst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEntaColiCyst.CustomButton.TabIndex = 1;
            this.txtEntaColiCyst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEntaColiCyst.CustomButton.UseSelectable = true;
            this.txtEntaColiCyst.CustomButton.Visible = false;
            this.txtEntaColiCyst.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEntaColiCyst.Lines = new string[0];
            this.txtEntaColiCyst.Location = new System.Drawing.Point(354, 142);
            this.txtEntaColiCyst.MaxLength = 32767;
            this.txtEntaColiCyst.Name = "txtEntaColiCyst";
            this.txtEntaColiCyst.PasswordChar = '\0';
            this.txtEntaColiCyst.PromptText = "Entamoeba coli cyst /hpf";
            this.txtEntaColiCyst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEntaColiCyst.SelectedText = "";
            this.txtEntaColiCyst.SelectionLength = 0;
            this.txtEntaColiCyst.SelectionStart = 0;
            this.txtEntaColiCyst.ShortcutsEnabled = true;
            this.txtEntaColiCyst.Size = new System.Drawing.Size(210, 28);
            this.txtEntaColiCyst.TabIndex = 7;
            this.txtEntaColiCyst.UseSelectable = true;
            this.txtEntaColiCyst.WaterMark = "Entamoeba coli cyst /hpf";
            this.txtEntaColiCyst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEntaColiCyst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntaColiCyst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntaColiCyst_KeyPress);
            // 
            // txtEntaColiTrop
            // 
            // 
            // 
            // 
            this.txtEntaColiTrop.CustomButton.Image = null;
            this.txtEntaColiTrop.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtEntaColiTrop.CustomButton.Name = "";
            this.txtEntaColiTrop.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEntaColiTrop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEntaColiTrop.CustomButton.TabIndex = 1;
            this.txtEntaColiTrop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEntaColiTrop.CustomButton.UseSelectable = true;
            this.txtEntaColiTrop.CustomButton.Visible = false;
            this.txtEntaColiTrop.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEntaColiTrop.Lines = new string[0];
            this.txtEntaColiTrop.Location = new System.Drawing.Point(354, 176);
            this.txtEntaColiTrop.MaxLength = 32767;
            this.txtEntaColiTrop.Name = "txtEntaColiTrop";
            this.txtEntaColiTrop.PasswordChar = '\0';
            this.txtEntaColiTrop.PromptText = "Entamoeba coli trophozoite /hpf";
            this.txtEntaColiTrop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEntaColiTrop.SelectedText = "";
            this.txtEntaColiTrop.SelectionLength = 0;
            this.txtEntaColiTrop.SelectionStart = 0;
            this.txtEntaColiTrop.ShortcutsEnabled = true;
            this.txtEntaColiTrop.Size = new System.Drawing.Size(210, 28);
            this.txtEntaColiTrop.TabIndex = 8;
            this.txtEntaColiTrop.UseSelectable = true;
            this.txtEntaColiTrop.WaterMark = "Entamoeba coli trophozoite /hpf";
            this.txtEntaColiTrop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEntaColiTrop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntaColiTrop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntaColiTrop_KeyPress);
            // 
            // txtEntaHisCyst
            // 
            // 
            // 
            // 
            this.txtEntaHisCyst.CustomButton.Image = null;
            this.txtEntaHisCyst.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtEntaHisCyst.CustomButton.Name = "";
            this.txtEntaHisCyst.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEntaHisCyst.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEntaHisCyst.CustomButton.TabIndex = 1;
            this.txtEntaHisCyst.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEntaHisCyst.CustomButton.UseSelectable = true;
            this.txtEntaHisCyst.CustomButton.Visible = false;
            this.txtEntaHisCyst.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEntaHisCyst.Lines = new string[0];
            this.txtEntaHisCyst.Location = new System.Drawing.Point(354, 210);
            this.txtEntaHisCyst.MaxLength = 32767;
            this.txtEntaHisCyst.Name = "txtEntaHisCyst";
            this.txtEntaHisCyst.PasswordChar = '\0';
            this.txtEntaHisCyst.PromptText = "Entamoeba histolytica cyst /hpf";
            this.txtEntaHisCyst.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEntaHisCyst.SelectedText = "";
            this.txtEntaHisCyst.SelectionLength = 0;
            this.txtEntaHisCyst.SelectionStart = 0;
            this.txtEntaHisCyst.ShortcutsEnabled = true;
            this.txtEntaHisCyst.Size = new System.Drawing.Size(210, 28);
            this.txtEntaHisCyst.TabIndex = 9;
            this.txtEntaHisCyst.UseSelectable = true;
            this.txtEntaHisCyst.WaterMark = "Entamoeba histolytica cyst /hpf";
            this.txtEntaHisCyst.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEntaHisCyst.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntaHisCyst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntaHisCyst_KeyPress);
            // 
            // txtEntaHisTrop
            // 
            // 
            // 
            // 
            this.txtEntaHisTrop.CustomButton.Image = null;
            this.txtEntaHisTrop.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtEntaHisTrop.CustomButton.Name = "";
            this.txtEntaHisTrop.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtEntaHisTrop.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEntaHisTrop.CustomButton.TabIndex = 1;
            this.txtEntaHisTrop.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEntaHisTrop.CustomButton.UseSelectable = true;
            this.txtEntaHisTrop.CustomButton.Visible = false;
            this.txtEntaHisTrop.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEntaHisTrop.Lines = new string[0];
            this.txtEntaHisTrop.Location = new System.Drawing.Point(354, 244);
            this.txtEntaHisTrop.MaxLength = 32767;
            this.txtEntaHisTrop.Name = "txtEntaHisTrop";
            this.txtEntaHisTrop.PasswordChar = '\0';
            this.txtEntaHisTrop.PromptText = "Entamoeba histolytica trophozoite /hpf";
            this.txtEntaHisTrop.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEntaHisTrop.SelectedText = "";
            this.txtEntaHisTrop.SelectionLength = 0;
            this.txtEntaHisTrop.SelectionStart = 0;
            this.txtEntaHisTrop.ShortcutsEnabled = true;
            this.txtEntaHisTrop.Size = new System.Drawing.Size(210, 28);
            this.txtEntaHisTrop.TabIndex = 10;
            this.txtEntaHisTrop.UseSelectable = true;
            this.txtEntaHisTrop.WaterMark = "Entamoeba histolytica trophozoite /hpf";
            this.txtEntaHisTrop.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEntaHisTrop.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEntaHisTrop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEntaHisTrop_KeyPress);
            // 
            // txtPusCell
            // 
            // 
            // 
            // 
            this.txtPusCell.CustomButton.Image = null;
            this.txtPusCell.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtPusCell.CustomButton.Name = "";
            this.txtPusCell.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPusCell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPusCell.CustomButton.TabIndex = 1;
            this.txtPusCell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPusCell.CustomButton.UseSelectable = true;
            this.txtPusCell.CustomButton.Visible = false;
            this.txtPusCell.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPusCell.Lines = new string[0];
            this.txtPusCell.Location = new System.Drawing.Point(354, 278);
            this.txtPusCell.MaxLength = 32767;
            this.txtPusCell.Name = "txtPusCell";
            this.txtPusCell.PasswordChar = '\0';
            this.txtPusCell.PromptText = "Pus cells /hpf";
            this.txtPusCell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPusCell.SelectedText = "";
            this.txtPusCell.SelectionLength = 0;
            this.txtPusCell.SelectionStart = 0;
            this.txtPusCell.ShortcutsEnabled = true;
            this.txtPusCell.Size = new System.Drawing.Size(210, 28);
            this.txtPusCell.TabIndex = 11;
            this.txtPusCell.UseSelectable = true;
            this.txtPusCell.WaterMark = "Pus cells /hpf";
            this.txtPusCell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPusCell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPusCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPusCell_KeyPress);
            // 
            // txtRBC
            // 
            // 
            // 
            // 
            this.txtRBC.CustomButton.Image = null;
            this.txtRBC.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtRBC.CustomButton.Name = "";
            this.txtRBC.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRBC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRBC.CustomButton.TabIndex = 1;
            this.txtRBC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRBC.CustomButton.UseSelectable = true;
            this.txtRBC.CustomButton.Visible = false;
            this.txtRBC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRBC.Lines = new string[0];
            this.txtRBC.Location = new System.Drawing.Point(354, 312);
            this.txtRBC.MaxLength = 32767;
            this.txtRBC.Name = "txtRBC";
            this.txtRBC.PasswordChar = '\0';
            this.txtRBC.PromptText = "RBC /hpf";
            this.txtRBC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRBC.SelectedText = "";
            this.txtRBC.SelectionLength = 0;
            this.txtRBC.SelectionStart = 0;
            this.txtRBC.ShortcutsEnabled = true;
            this.txtRBC.Size = new System.Drawing.Size(210, 28);
            this.txtRBC.TabIndex = 12;
            this.txtRBC.UseSelectable = true;
            this.txtRBC.WaterMark = "RBC /hpf";
            this.txtRBC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRBC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRBC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRBC_KeyPress);
            // 
            // txtYeastCell
            // 
            // 
            // 
            // 
            this.txtYeastCell.CustomButton.Image = null;
            this.txtYeastCell.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtYeastCell.CustomButton.Name = "";
            this.txtYeastCell.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtYeastCell.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtYeastCell.CustomButton.TabIndex = 1;
            this.txtYeastCell.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtYeastCell.CustomButton.UseSelectable = true;
            this.txtYeastCell.CustomButton.Visible = false;
            this.txtYeastCell.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtYeastCell.Lines = new string[0];
            this.txtYeastCell.Location = new System.Drawing.Point(651, 142);
            this.txtYeastCell.MaxLength = 32767;
            this.txtYeastCell.Name = "txtYeastCell";
            this.txtYeastCell.PasswordChar = '\0';
            this.txtYeastCell.PromptText = "Yeast cells";
            this.txtYeastCell.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtYeastCell.SelectedText = "";
            this.txtYeastCell.SelectionLength = 0;
            this.txtYeastCell.SelectionStart = 0;
            this.txtYeastCell.ShortcutsEnabled = true;
            this.txtYeastCell.Size = new System.Drawing.Size(210, 28);
            this.txtYeastCell.TabIndex = 13;
            this.txtYeastCell.UseSelectable = true;
            this.txtYeastCell.WaterMark = "Yeast cells";
            this.txtYeastCell.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtYeastCell.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtFatGlobules
            // 
            // 
            // 
            // 
            this.txtFatGlobules.CustomButton.Image = null;
            this.txtFatGlobules.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtFatGlobules.CustomButton.Name = "";
            this.txtFatGlobules.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtFatGlobules.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFatGlobules.CustomButton.TabIndex = 1;
            this.txtFatGlobules.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFatGlobules.CustomButton.UseSelectable = true;
            this.txtFatGlobules.CustomButton.Visible = false;
            this.txtFatGlobules.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFatGlobules.Lines = new string[0];
            this.txtFatGlobules.Location = new System.Drawing.Point(651, 176);
            this.txtFatGlobules.MaxLength = 32767;
            this.txtFatGlobules.Name = "txtFatGlobules";
            this.txtFatGlobules.PasswordChar = '\0';
            this.txtFatGlobules.PromptText = "Fat globules";
            this.txtFatGlobules.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFatGlobules.SelectedText = "";
            this.txtFatGlobules.SelectionLength = 0;
            this.txtFatGlobules.SelectionStart = 0;
            this.txtFatGlobules.ShortcutsEnabled = true;
            this.txtFatGlobules.Size = new System.Drawing.Size(210, 28);
            this.txtFatGlobules.TabIndex = 14;
            this.txtFatGlobules.UseSelectable = true;
            this.txtFatGlobules.WaterMark = "Fat globules";
            this.txtFatGlobules.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFatGlobules.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(651, 312);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PromptText = "Remarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(210, 28);
            this.txtRemarks.TabIndex = 17;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMark = "Remarks";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOthers
            // 
            // 
            // 
            // 
            this.txtOthers.CustomButton.Image = null;
            this.txtOthers.CustomButton.Location = new System.Drawing.Point(150, 2);
            this.txtOthers.CustomButton.Name = "";
            this.txtOthers.CustomButton.Size = new System.Drawing.Size(57, 57);
            this.txtOthers.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOthers.CustomButton.TabIndex = 1;
            this.txtOthers.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOthers.CustomButton.UseSelectable = true;
            this.txtOthers.CustomButton.Visible = false;
            this.txtOthers.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtOthers.Lines = new string[0];
            this.txtOthers.Location = new System.Drawing.Point(651, 244);
            this.txtOthers.MaxLength = 32767;
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.PasswordChar = '\0';
            this.txtOthers.PromptText = "Others";
            this.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOthers.SelectedText = "";
            this.txtOthers.SelectionLength = 0;
            this.txtOthers.SelectionStart = 0;
            this.txtOthers.ShortcutsEnabled = true;
            this.txtOthers.Size = new System.Drawing.Size(210, 62);
            this.txtOthers.TabIndex = 16;
            this.txtOthers.UseSelectable = true;
            this.txtOthers.WaterMark = "Others";
            this.txtOthers.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOthers.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBacteria
            // 
            // 
            // 
            // 
            this.txtBacteria.CustomButton.Image = null;
            this.txtBacteria.CustomButton.Location = new System.Drawing.Point(184, 2);
            this.txtBacteria.CustomButton.Name = "";
            this.txtBacteria.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtBacteria.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBacteria.CustomButton.TabIndex = 1;
            this.txtBacteria.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBacteria.CustomButton.UseSelectable = true;
            this.txtBacteria.CustomButton.Visible = false;
            this.txtBacteria.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBacteria.Lines = new string[0];
            this.txtBacteria.Location = new System.Drawing.Point(651, 210);
            this.txtBacteria.MaxLength = 32767;
            this.txtBacteria.Name = "txtBacteria";
            this.txtBacteria.PasswordChar = '\0';
            this.txtBacteria.PromptText = "Bacteria";
            this.txtBacteria.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBacteria.SelectedText = "";
            this.txtBacteria.SelectionLength = 0;
            this.txtBacteria.SelectionStart = 0;
            this.txtBacteria.ShortcutsEnabled = true;
            this.txtBacteria.Size = new System.Drawing.Size(210, 28);
            this.txtBacteria.TabIndex = 15;
            this.txtBacteria.UseSelectable = true;
            this.txtBacteria.WaterMark = "Bacteria";
            this.txtBacteria.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBacteria.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAddParasitology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 510);
            this.Controls.Add(this.txtBacteria);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtOthers);
            this.Controls.Add(this.txtFatGlobules);
            this.Controls.Add(this.txtYeastCell);
            this.Controls.Add(this.txtRBC);
            this.Controls.Add(this.txtPusCell);
            this.Controls.Add(this.txtEntaHisTrop);
            this.Controls.Add(this.txtEntaHisCyst);
            this.Controls.Add(this.txtEntaColiTrop);
            this.Controls.Add(this.txtEntaColiCyst);
            this.Controls.Add(this.txtStrongyloides);
            this.Controls.Add(this.txtTrichuris);
            this.Controls.Add(this.txtHookworm);
            this.Controls.Add(this.txtAscaris);
            this.Controls.Add(this.txtConsistency);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.cboMedTech);
            this.Controls.Add(this.cboPathologist);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddParasitology";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Add Parasitology";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAddParasitology_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblCase;
        private MetroFramework.Controls.MetroLabel lblRequest;
        private MetroFramework.Controls.MetroLabel lblDate;
        private MetroFramework.Controls.MetroLabel lblGender;
        private MetroFramework.Controls.MetroLabel lblAge;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroComboBox cboMedTech;
        private MetroFramework.Controls.MetroComboBox cboPathologist;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtColor;
        private MetroFramework.Controls.MetroTextBox txtConsistency;
        private MetroFramework.Controls.MetroTextBox txtAscaris;
        private MetroFramework.Controls.MetroTextBox txtHookworm;
        private MetroFramework.Controls.MetroTextBox txtTrichuris;
        private MetroFramework.Controls.MetroTextBox txtStrongyloides;
        private MetroFramework.Controls.MetroTextBox txtEntaColiCyst;
        private MetroFramework.Controls.MetroTextBox txtEntaColiTrop;
        private MetroFramework.Controls.MetroTextBox txtEntaHisCyst;
        private MetroFramework.Controls.MetroTextBox txtEntaHisTrop;
        private MetroFramework.Controls.MetroTextBox txtPusCell;
        private MetroFramework.Controls.MetroTextBox txtRBC;
        private MetroFramework.Controls.MetroTextBox txtYeastCell;
        private MetroFramework.Controls.MetroTextBox txtFatGlobules;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private MetroFramework.Controls.MetroTextBox txtOthers;
        private MetroFramework.Controls.MetroTextBox txtBacteria;
    }
}