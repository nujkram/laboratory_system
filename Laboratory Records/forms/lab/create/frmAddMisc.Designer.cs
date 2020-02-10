namespace Laboratory_Records.forms.lab
{
    partial class frmAddMisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMisc));
            this.lblCase = new MetroFramework.Controls.MetroLabel();
            this.lblRequest = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.cboExamDesired = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtResult = new MetroFramework.Controls.MetroTextBox();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.cboMedTech = new MetroFramework.Controls.MetroComboBox();
            this.cboPathologist = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtSpecimen = new MetroFramework.Controls.MetroTextBox();
            this.txtNotes = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(324, 59);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(65, 19);
            this.lblCase.TabIndex = 47;
            this.lblCase.Text = "Case No.:";
            // 
            // lblRequest
            // 
            this.lblRequest.AutoSize = true;
            this.lblRequest.Location = new System.Drawing.Point(23, 97);
            this.lblRequest.Name = "lblRequest";
            this.lblRequest.Size = new System.Drawing.Size(91, 19);
            this.lblRequest.TabIndex = 46;
            this.lblRequest.Text = "Requested by:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(75, 59);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 19);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "Date:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(333, 97);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 44;
            this.lblGender.Text = "Gender:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(353, 78);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 43;
            this.lblAge.Text = "Age:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(42, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 19);
            this.lblName.TabIndex = 42;
            this.lblName.Text = "Full Name:";
            // 
            // cboExamDesired
            // 
            this.cboExamDesired.FormattingEnabled = true;
            this.cboExamDesired.ItemHeight = 23;
            this.cboExamDesired.Items.AddRange(new object[] {
            "Anti - HAV",
            "Anti - HBs",
            "ASOT",
            "CRP",
            "Dengue Duo",
            "Gram\'s Stain",
            "HBsAg",
            "H.Pylori",
            "KOH",
            "Pregnancy Test",
            "RPR"});
            this.cboExamDesired.Location = new System.Drawing.Point(120, 137);
            this.cboExamDesired.Name = "cboExamDesired";
            this.cboExamDesired.Size = new System.Drawing.Size(337, 29);
            this.cboExamDesired.TabIndex = 1;
            this.cboExamDesired.UseSelectable = true;
            this.cboExamDesired.SelectedIndexChanged += new System.EventHandler(this.cboExamDesired_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 137);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 83;
            this.metroLabel1.Text = "Exam Desired:";
            // 
            // txtResult
            // 
            // 
            // 
            // 
            this.txtResult.CustomButton.Image = null;
            this.txtResult.CustomButton.Location = new System.Drawing.Point(408, 2);
            this.txtResult.CustomButton.Name = "";
            this.txtResult.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtResult.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtResult.CustomButton.TabIndex = 1;
            this.txtResult.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtResult.CustomButton.UseSelectable = true;
            this.txtResult.CustomButton.Visible = false;
            this.txtResult.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtResult.Lines = new string[0];
            this.txtResult.Location = new System.Drawing.Point(22, 206);
            this.txtResult.MaxLength = 32767;
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PromptText = "Result";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtResult.SelectedText = "";
            this.txtResult.SelectionLength = 0;
            this.txtResult.SelectionStart = 0;
            this.txtResult.ShortcutsEnabled = true;
            this.txtResult.Size = new System.Drawing.Size(434, 28);
            this.txtResult.TabIndex = 3;
            this.txtResult.UseSelectable = true;
            this.txtResult.WaterMark = "Result";
            this.txtResult.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtResult.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(409, 2);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(22, 240);
            this.txtRemarks.MaxLength = 32767;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.PromptText = "IgG";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(435, 28);
            this.txtRemarks.TabIndex = 4;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.Visible = false;
            this.txtRemarks.WaterMark = "IgG";
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cboMedTech
            // 
            this.cboMedTech.FormattingEnabled = true;
            this.cboMedTech.ItemHeight = 23;
            this.cboMedTech.Location = new System.Drawing.Point(161, 358);
            this.cboMedTech.Name = "cboMedTech";
            this.cboMedTech.Size = new System.Drawing.Size(295, 29);
            this.cboMedTech.TabIndex = 7;
            this.cboMedTech.UseSelectable = true;
            this.cboMedTech.SelectedIndexChanged += new System.EventHandler(this.cboMedTech_SelectedIndexChanged);
            // 
            // cboPathologist
            // 
            this.cboPathologist.FormattingEnabled = true;
            this.cboPathologist.ItemHeight = 23;
            this.cboPathologist.Location = new System.Drawing.Point(161, 323);
            this.cboPathologist.Name = "cboPathologist";
            this.cboPathologist.Size = new System.Drawing.Size(295, 29);
            this.cboPathologist.TabIndex = 6;
            this.cboPathologist.UseSelectable = true;
            this.cboPathologist.SelectedIndexChanged += new System.EventHandler(this.cboPathologist_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(22, 367);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 89;
            this.metroLabel2.Text = "Medical Technologist:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(79, 333);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(76, 19);
            this.metroLabel3.TabIndex = 88;
            this.metroLabel3.Text = "Pathologist:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(22, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(434, 39);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnSave.UseCustomBackColor = true;
            this.btnSave.UseCustomForeColor = true;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSpecimen
            // 
            // 
            // 
            // 
            this.txtSpecimen.CustomButton.Image = null;
            this.txtSpecimen.CustomButton.Location = new System.Drawing.Point(408, 2);
            this.txtSpecimen.CustomButton.Name = "";
            this.txtSpecimen.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSpecimen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSpecimen.CustomButton.TabIndex = 1;
            this.txtSpecimen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSpecimen.CustomButton.UseSelectable = true;
            this.txtSpecimen.CustomButton.Visible = false;
            this.txtSpecimen.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSpecimen.Lines = new string[0];
            this.txtSpecimen.Location = new System.Drawing.Point(22, 172);
            this.txtSpecimen.MaxLength = 32767;
            this.txtSpecimen.Name = "txtSpecimen";
            this.txtSpecimen.PasswordChar = '\0';
            this.txtSpecimen.PromptText = "Specimen";
            this.txtSpecimen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSpecimen.SelectedText = "";
            this.txtSpecimen.SelectionLength = 0;
            this.txtSpecimen.SelectionStart = 0;
            this.txtSpecimen.ShortcutsEnabled = true;
            this.txtSpecimen.Size = new System.Drawing.Size(434, 28);
            this.txtSpecimen.TabIndex = 2;
            this.txtSpecimen.UseSelectable = true;
            this.txtSpecimen.WaterMark = "Specimen";
            this.txtSpecimen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSpecimen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNotes
            // 
            // 
            // 
            // 
            this.txtNotes.CustomButton.Image = null;
            this.txtNotes.CustomButton.Location = new System.Drawing.Point(409, 2);
            this.txtNotes.CustomButton.Name = "";
            this.txtNotes.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtNotes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotes.CustomButton.TabIndex = 1;
            this.txtNotes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotes.CustomButton.UseSelectable = true;
            this.txtNotes.CustomButton.Visible = false;
            this.txtNotes.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNotes.Lines = new string[0];
            this.txtNotes.Location = new System.Drawing.Point(21, 274);
            this.txtNotes.MaxLength = 32767;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PromptText = "IgG";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotes.SelectedText = "";
            this.txtNotes.SelectionLength = 0;
            this.txtNotes.SelectionStart = 0;
            this.txtNotes.ShortcutsEnabled = true;
            this.txtNotes.Size = new System.Drawing.Size(435, 28);
            this.txtNotes.TabIndex = 5;
            this.txtNotes.UseSelectable = true;
            this.txtNotes.Visible = false;
            this.txtNotes.WaterMark = "IgG";
            this.txtNotes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmAddMisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 453);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtSpecimen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboMedTech);
            this.Controls.Add(this.cboPathologist);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cboExamDesired);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lblRequest);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddMisc";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Add Miscellaneous";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAddMisc_Load);
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
        private MetroFramework.Controls.MetroComboBox cboExamDesired;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtResult;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private MetroFramework.Controls.MetroComboBox cboMedTech;
        private MetroFramework.Controls.MetroComboBox cboPathologist;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtSpecimen;
        private MetroFramework.Controls.MetroTextBox txtNotes;
    }
}