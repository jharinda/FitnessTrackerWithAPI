
namespace FitnessTracker.Forms
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.btn_addDetails = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_addDetails
            // 
            this.btn_addDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_addDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDetails.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_addDetails.Location = new System.Drawing.Point(493, 228);
            this.btn_addDetails.Name = "btn_addDetails";
            this.btn_addDetails.Size = new System.Drawing.Size(168, 336);
            this.btn_addDetails.TabIndex = 0;
            this.btn_addDetails.Text = "Add Details";
            this.btn_addDetails.UseVisualStyleBackColor = false;
            this.btn_addDetails.Click += new System.EventHandler(this.btn_addDetails_Click);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.btn_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Font = new System.Drawing.Font("Poppins", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_profile.Location = new System.Drawing.Point(280, 228);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(168, 336);
            this.btn_profile.TabIndex = 2;
            this.btn_profile.Text = "Profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(390, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 95);
            this.label1.TabIndex = 9;
            this.label1.Text = "F i t u";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(829, 33);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(109, 50);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 853);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_profile);
            this.Controls.Add(this.btn_addDetails);
            this.Name = "Index";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addDetails;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}