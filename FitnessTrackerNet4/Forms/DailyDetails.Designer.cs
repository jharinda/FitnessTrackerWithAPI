
namespace FitnessTracker.Forms
{
    partial class DailyDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyDetails));
            this.lbl_date = new System.Windows.Forms.Label();
            this.input_datePicker = new System.Windows.Forms.DateTimePicker();
            this.input_workoutReps = new System.Windows.Forms.TextBox();
            this.input_mealQuantity = new System.Windows.Forms.TextBox();
            this.comboBox_meals = new System.Windows.Forms.ComboBox();
            this.comboBox_workouts = new System.Windows.Forms.ComboBox();
            this.listView_meals = new System.Windows.Forms.ListView();
            this.listView_workouts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_mealCalories = new System.Windows.Forms.Label();
            this.lbl_workoutCalories = new System.Windows.Forms.Label();
            this.btn_addMeal = new System.Windows.Forms.Button();
            this.btn_addWorkout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input_weight = new FitnessTrackerNet4.Controls.TextBoxCustom();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_date.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_date.Location = new System.Drawing.Point(238, 86);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 23);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Date";
            // 
            // input_datePicker
            // 
            this.input_datePicker.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.input_datePicker.CalendarMonthBackground = System.Drawing.Color.Maroon;
            this.input_datePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.input_datePicker.CalendarTrailingForeColor = System.Drawing.Color.Maroon;
            this.input_datePicker.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.input_datePicker.Location = new System.Drawing.Point(239, 128);
            this.input_datePicker.Name = "input_datePicker";
            this.input_datePicker.Size = new System.Drawing.Size(493, 27);
            this.input_datePicker.TabIndex = 4;
            // 
            // input_workoutReps
            // 
            this.input_workoutReps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_workoutReps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_workoutReps.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.input_workoutReps.Location = new System.Drawing.Point(444, 406);
            this.input_workoutReps.Name = "input_workoutReps";
            this.input_workoutReps.Size = new System.Drawing.Size(121, 20);
            this.input_workoutReps.TabIndex = 5;
            // 
            // input_mealQuantity
            // 
            this.input_mealQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_mealQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_mealQuantity.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.input_mealQuantity.Location = new System.Drawing.Point(444, 304);
            this.input_mealQuantity.Name = "input_mealQuantity";
            this.input_mealQuantity.Size = new System.Drawing.Size(121, 20);
            this.input_mealQuantity.TabIndex = 6;
            // 
            // comboBox_meals
            // 
            this.comboBox_meals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.comboBox_meals.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.comboBox_meals.ForeColor = System.Drawing.Color.Black;
            this.comboBox_meals.FormattingEnabled = true;
            this.comboBox_meals.Location = new System.Drawing.Point(228, 298);
            this.comboBox_meals.Name = "comboBox_meals";
            this.comboBox_meals.Size = new System.Drawing.Size(161, 31);
            this.comboBox_meals.TabIndex = 8;
            // 
            // comboBox_workouts
            // 
            this.comboBox_workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.comboBox_workouts.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox_workouts.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.comboBox_workouts.FormattingEnabled = true;
            this.comboBox_workouts.Location = new System.Drawing.Point(228, 403);
            this.comboBox_workouts.Name = "comboBox_workouts";
            this.comboBox_workouts.Size = new System.Drawing.Size(161, 31);
            this.comboBox_workouts.TabIndex = 9;
            // 
            // listView_meals
            // 
            this.listView_meals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.listView_meals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_meals.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.listView_meals.HideSelection = false;
            this.listView_meals.Location = new System.Drawing.Point(239, 514);
            this.listView_meals.Name = "listView_meals";
            this.listView_meals.Size = new System.Drawing.Size(214, 147);
            this.listView_meals.TabIndex = 11;
            this.listView_meals.UseCompatibleStateImageBehavior = false;
            // 
            // listView_workouts
            // 
            this.listView_workouts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.listView_workouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_workouts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_workouts.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.listView_workouts.HideSelection = false;
            this.listView_workouts.Location = new System.Drawing.Point(518, 514);
            this.listView_workouts.Name = "listView_workouts";
            this.listView_workouts.Size = new System.Drawing.Size(214, 147);
            this.listView_workouts.TabIndex = 12;
            this.listView_workouts.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_mealCalories
            // 
            this.lbl_mealCalories.AutoSize = true;
            this.lbl_mealCalories.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mealCalories.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_mealCalories.Location = new System.Drawing.Point(235, 685);
            this.lbl_mealCalories.Name = "lbl_mealCalories";
            this.lbl_mealCalories.Size = new System.Drawing.Size(102, 23);
            this.lbl_mealCalories.TabIndex = 15;
            this.lbl_mealCalories.Text = "Total Calories";
            // 
            // lbl_workoutCalories
            // 
            this.lbl_workoutCalories.AutoSize = true;
            this.lbl_workoutCalories.BackColor = System.Drawing.Color.Transparent;
            this.lbl_workoutCalories.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_workoutCalories.Location = new System.Drawing.Point(514, 685);
            this.lbl_workoutCalories.Name = "lbl_workoutCalories";
            this.lbl_workoutCalories.Size = new System.Drawing.Size(51, 23);
            this.lbl_workoutCalories.TabIndex = 16;
            this.lbl_workoutCalories.Text = "label2";
            // 
            // btn_addMeal
            // 
            this.btn_addMeal.BackColor = System.Drawing.Color.Transparent;
            this.btn_addMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addMeal.BackgroundImage")));
            this.btn_addMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addMeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addMeal.FlatAppearance.BorderSize = 0;
            this.btn_addMeal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addMeal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMeal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMeal.Location = new System.Drawing.Point(606, 291);
            this.btn_addMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addMeal.Name = "btn_addMeal";
            this.btn_addMeal.Size = new System.Drawing.Size(141, 44);
            this.btn_addMeal.TabIndex = 20;
            this.btn_addMeal.UseVisualStyleBackColor = false;
            this.btn_addMeal.Click += new System.EventHandler(this.btn_addMeal_Click);
            // 
            // btn_addWorkout
            // 
            this.btn_addWorkout.BackColor = System.Drawing.Color.Transparent;
            this.btn_addWorkout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addWorkout.BackgroundImage")));
            this.btn_addWorkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addWorkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addWorkout.FlatAppearance.BorderSize = 0;
            this.btn_addWorkout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_addWorkout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_addWorkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addWorkout.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addWorkout.Location = new System.Drawing.Point(606, 397);
            this.btn_addWorkout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addWorkout.Name = "btn_addWorkout";
            this.btn_addWorkout.Size = new System.Drawing.Size(141, 44);
            this.btn_addWorkout.TabIndex = 21;
            this.btn_addWorkout.UseVisualStyleBackColor = false;
            this.btn_addWorkout.Click += new System.EventHandler(this.btn_addWorkout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(235, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Meals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(437, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(235, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Workout";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(440, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 23);
            this.label5.TabIndex = 26;
            this.label5.Text = "Reps";
            // 
            // input_weight
            // 
            this.input_weight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.input_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_weight.Font = new System.Drawing.Font("Poppins Medium", 9.75F);
            this.input_weight.ForeColor = System.Drawing.Color.Gray;
            this.input_weight.Location = new System.Drawing.Point(239, 201);
            this.input_weight.MaxLength = 10000000;
            this.input_weight.Name = "input_weight";
            this.input_weight.PlaceHolderText = "Weight (kg)";
            this.input_weight.Size = new System.Drawing.Size(400, 20);
            this.input_weight.TabIndex = 22;
            this.input_weight.Text = "Weight (kg)";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(341, 732);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_resetMeals_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(617, 732);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 44);
            this.button2.TabIndex = 28;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_resetWorkouts_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(370, 824);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 70);
            this.button3.TabIndex = 29;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DailyDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(977, 937);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.input_weight);
            this.Controls.Add(this.btn_addWorkout);
            this.Controls.Add(this.btn_addMeal);
            this.Controls.Add(this.lbl_workoutCalories);
            this.Controls.Add(this.lbl_mealCalories);
            this.Controls.Add(this.listView_workouts);
            this.Controls.Add(this.listView_meals);
            this.Controls.Add(this.comboBox_workouts);
            this.Controls.Add(this.comboBox_meals);
            this.Controls.Add(this.input_mealQuantity);
            this.Controls.Add(this.input_workoutReps);
            this.Controls.Add(this.input_datePicker);
            this.Controls.Add(this.lbl_date);
            this.Name = "DailyDetails";
            this.Text = "DailyDetails";
            this.Load += new System.EventHandler(this.DailyDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker input_datePicker;
        private System.Windows.Forms.TextBox input_workoutReps;
        private System.Windows.Forms.TextBox input_mealQuantity;
        private System.Windows.Forms.ComboBox comboBox_meals;
        private System.Windows.Forms.ComboBox comboBox_workouts;
        private System.Windows.Forms.ListView listView_meals;
        private System.Windows.Forms.ListView listView_workouts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lbl_mealCalories;
        private System.Windows.Forms.Label lbl_workoutCalories;
        private System.Windows.Forms.Button btn_addMeal;
        private System.Windows.Forms.Button btn_addWorkout;
        private FitnessTrackerNet4.Controls.TextBoxCustom input_weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}