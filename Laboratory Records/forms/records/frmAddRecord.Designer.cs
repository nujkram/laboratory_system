namespace Laboratory_Records.forms.records
{
    partial class frmAddRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddRecord));
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtCase = new MetroFramework.Controls.MetroTextBox();
            this.txtRequest = new MetroFramework.Controls.MetroTextBox();
            this.lblAge = new MetroFramework.Controls.MetroLabel();
            this.lblGender = new MetroFramework.Controls.MetroLabel();
            this.lblDate = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 19);
            this.lblName.TabIndex = 26;
            this.lblName.Text = "Full Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(23, 279);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(330, 39);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnAdd.UseCustomBackColor = true;
            this.btnAdd.UseCustomForeColor = true;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCase
            // 
            // 
            // 
            // 
            this.txtCase.CustomButton.Image = null;
            this.txtCase.CustomButton.Location = new System.Drawing.Point(304, 2);
            this.txtCase.CustomButton.Name = "";
            this.txtCase.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCase.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCase.CustomButton.TabIndex = 1;
            this.txtCase.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCase.CustomButton.UseSelectable = true;
            this.txtCase.CustomButton.Visible = false;
            this.txtCase.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCase.Lines = new string[0];
            this.txtCase.Location = new System.Drawing.Point(23, 209);
            this.txtCase.MaxLength = 32767;
            this.txtCase.Name = "txtCase";
            this.txtCase.PasswordChar = '\0';
            this.txtCase.PromptText = "Case No.";
            this.txtCase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCase.SelectedText = "";
            this.txtCase.SelectionLength = 0;
            this.txtCase.SelectionStart = 0;
            this.txtCase.ShortcutsEnabled = true;
            this.txtCase.Size = new System.Drawing.Size(330, 28);
            this.txtCase.TabIndex = 20;
            this.txtCase.UseSelectable = true;
            this.txtCase.WaterMark = "Case No.";
            this.txtCase.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCase.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtRequest
            // 
            // 
            // 
            // 
            this.txtRequest.CustomButton.Image = null;
            this.txtRequest.CustomButton.Location = new System.Drawing.Point(304, 2);
            this.txtRequest.CustomButton.Name = "";
            this.txtRequest.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtRequest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRequest.CustomButton.TabIndex = 1;
            this.txtRequest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRequest.CustomButton.UseSelectable = true;
            this.txtRequest.CustomButton.Visible = false;
            this.txtRequest.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtRequest.Lines = new string[0];
            this.txtRequest.Location = new System.Drawing.Point(23, 175);
            this.txtRequest.MaxLength = 32767;
            this.txtRequest.Name = "txtRequest";
            this.txtRequest.PasswordChar = '\0';
            this.txtRequest.PromptText = "Requested by";
            this.txtRequest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRequest.SelectedText = "";
            this.txtRequest.SelectionLength = 0;
            this.txtRequest.SelectionStart = 0;
            this.txtRequest.ShortcutsEnabled = true;
            this.txtRequest.Size = new System.Drawing.Size(330, 28);
            this.txtRequest.TabIndex = 19;
            this.txtRequest.UseSelectable = true;
            this.txtRequest.WaterMark = "Requested by";
            this.txtRequest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRequest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(59, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(36, 19);
            this.lblAge.TabIndex = 27;
            this.lblAge.Text = "Age:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(39, 117);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 19);
            this.lblGender.TabIndex = 28;
            this.lblGender.Text = "Gender:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(56, 60);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 19);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "Date:";
            // 
            // frmAddRecord
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 343);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCase);
            this.Controls.Add(this.txtRequest);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAddRecord";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Add Patient Record";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmAddRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtCase;
        private MetroFramework.Controls.MetroTextBox txtRequest;
        private MetroFramework.Controls.MetroLabel lblAge;
        private MetroFramework.Controls.MetroLabel lblGender;
        private MetroFramework.Controls.MetroLabel lblDate;
    }
}