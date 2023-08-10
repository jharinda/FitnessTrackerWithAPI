
namespace FitnessTrackerNet4.Forms
{
    partial class Signin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signin));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.input_password = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.input_email = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(398, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 95);
            this.label1.TabIndex = 1;
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
            this.btnSubmit.Location = new System.Drawing.Point(338, 591);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(283, 76);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.BackColor = System.Drawing.Color.Transparent;
            this.lbl_error.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_error.Location = new System.Drawing.Point(233, 554);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(92, 28);
            this.lbl_error.TabIndex = 14;
            this.lbl_error.Text = "Error label";
            this.lbl_error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // input_password
            // 
            this.input_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_password.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_password.ForeColor = System.Drawing.Color.Gray;
            this.input_password.Location = new System.Drawing.Point(238, 492);
            this.input_password.MaxLength = 10000000;
            this.input_password.Name = "input_password";
            this.input_password.PlaceHolderText = "Password";
            this.input_password.Size = new System.Drawing.Size(400, 20);
            this.input_password.TabIndex = 16;
            this.input_password.Text = "Password";
            this.input_password.TextChanged += new System.EventHandler(this.input_password_TextChanged);
            // 
            // input_email
            // 
            this.input_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_email.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F);
            this.input_email.ForeColor = System.Drawing.Color.Gray;
            this.input_email.Location = new System.Drawing.Point(238, 426);
            this.input_email.MaxLength = 10000000;
            this.input_email.Name = "input_email";
            this.input_email.PlaceHolderText = "Email";
            this.input_email.Size = new System.Drawing.Size(400, 20);
            this.input_email.TabIndex = 15;
            this.input_email.Text = "Email";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lblRegister.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(333, 679);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(273, 28);
            this.lblRegister.TabIndex = 17;
            this.lblRegister.Text = "Don\'t have an account ? Register";
            this.lblRegister.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegister.Click += new System.EventHandler(this.lblRegister_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 809);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.input_email);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lbl_error;
        private Controls.TextBoxCustom input_email;
        private Controls.TextBoxCustom input_password;
        private System.Windows.Forms.Label lblRegister;
    }
}