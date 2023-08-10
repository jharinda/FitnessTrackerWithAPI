
namespace FitnessTracker.Forms
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.lbl_error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.input_heightInCm = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.input_age = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.input_name = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.input_gender = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.txtEmail = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.txtPassword = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.lblLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_error.Location = new System.Drawing.Point(235, 701);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(92, 28);
            this.lbl_error.TabIndex = 7;
            this.lbl_error.Text = "Error label";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(383, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 95);
            this.label1.TabIndex = 8;
            this.label1.Text = "F i t u";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmit.BackgroundImage")));
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(332, 738);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(283, 76);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // input_heightInCm
            // 
            this.input_heightInCm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_heightInCm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_heightInCm.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_heightInCm.ForeColor = System.Drawing.Color.Gray;
            this.input_heightInCm.Location = new System.Drawing.Point(240, 440);
            this.input_heightInCm.MaxLength = 10000000;
            this.input_heightInCm.Name = "input_heightInCm";
            this.input_heightInCm.PlaceHolderText = "Height (cm)";
            this.input_heightInCm.Size = new System.Drawing.Size(400, 20);
            this.input_heightInCm.TabIndex = 11;
            this.input_heightInCm.Text = "Height";
            // 
            // input_age
            // 
            this.input_age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_age.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_age.ForeColor = System.Drawing.Color.Gray;
            this.input_age.Location = new System.Drawing.Point(240, 374);
            this.input_age.MaxLength = 10000000;
            this.input_age.Name = "input_age";
            this.input_age.PlaceHolderText = "Age";
            this.input_age.Size = new System.Drawing.Size(400, 20);
            this.input_age.TabIndex = 10;
            this.input_age.Text = "Age";
            // 
            // input_name
            // 
            this.input_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_name.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_name.ForeColor = System.Drawing.Color.Gray;
            this.input_name.Location = new System.Drawing.Point(240, 305);
            this.input_name.MaxLength = 10000000;
            this.input_name.Name = "input_name";
            this.input_name.PlaceHolderText = "Name";
            this.input_name.Size = new System.Drawing.Size(400, 20);
            this.input_name.TabIndex = 9;
            this.input_name.Text = "Name";
            // 
            // input_gender
            // 
            this.input_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_gender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_gender.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_gender.ForeColor = System.Drawing.Color.Gray;
            this.input_gender.Location = new System.Drawing.Point(240, 508);
            this.input_gender.MaxLength = 10000000;
            this.input_gender.Name = "input_gender";
            this.input_gender.PlaceHolderText = "Gender";
            this.input_gender.Size = new System.Drawing.Size(400, 20);
            this.input_gender.TabIndex = 13;
            this.input_gender.Text = "Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(240, 576);
            this.txtEmail.MaxLength = 10000000;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceHolderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(400, 20);
            this.txtEmail.TabIndex = 14;
            this.txtEmail.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(240, 644);
            this.txtPassword.MaxLength = 10000000;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceHolderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(400, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(337, 827);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(272, 28);
            this.lblLogin.TabIndex = 16;
            this.lblLogin.Text = "Already have an account ? Login";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 940);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.input_gender);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.input_heightInCm);
            this.Controls.Add(this.input_age);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_error);
            this.Name = "Signup";
            this.Text = "Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Label label1;
        private FitnessTrackerNet4.Controls.TextBoxCustom input_name;
        private FitnessTrackerNet4.Controls.TextBoxCustom input_age;
        private FitnessTrackerNet4.Controls.TextBoxCustom input_heightInCm;
        private System.Windows.Forms.Button btnSubmit;
        private FitnessTrackerNet4.Controls.TextBoxCustom input_gender;
        private FitnessTrackerNet4.Controls.TextBoxCustom txtEmail;
        private FitnessTrackerNet4.Controls.TextBoxCustom txtPassword;
        private System.Windows.Forms.Label lblLogin;
    }
}