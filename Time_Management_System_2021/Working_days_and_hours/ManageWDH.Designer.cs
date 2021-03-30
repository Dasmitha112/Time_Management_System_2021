
using System;
using System.Windows.Forms;

namespace Time_Management_System_2021.Working_days_and_hours
{
    partial class ManageWDH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWDH));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDownMWD = new System.Windows.Forms.NumericUpDown();
            this.lblNumberOfWorkingDays = new System.Windows.Forms.Label();
            this.btnHomeMWD = new System.Windows.Forms.Button();
            this.btnResetMWD = new System.Windows.Forms.Button();
            this.btnDeleteMWD = new System.Windows.Forms.Button();
            this.btnEditMWD = new System.Windows.Forms.Button();
            this.btnAddMWD = new System.Windows.Forms.Button();
            this.chkboxSunday = new System.Windows.Forms.CheckBox();
            this.chkboxSaturday = new System.Windows.Forms.CheckBox();
            this.chkboxFriday = new System.Windows.Forms.CheckBox();
            this.chkboxThursday = new System.Windows.Forms.CheckBox();
            this.chkboxWednesday = new System.Windows.Forms.CheckBox();
            this.chkboxTuesday = new System.Windows.Forms.CheckBox();
            this.chkboxMonday = new System.Windows.Forms.CheckBox();
            this.dgvMWD = new System.Windows.Forms.DataGridView();
            this.lblTopicMWD = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnHomeWTPerDay = new System.Windows.Forms.Button();
            this.dgvWTPerDay = new System.Windows.Forms.DataGridView();
            this.numericUpDownMinutesWTPerDay = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHoursWTPerDay = new System.Windows.Forms.NumericUpDown();
            this.btnResetWTPerDay = new System.Windows.Forms.Button();
            this.btnDeleteWTPerDay = new System.Windows.Forms.Button();
            this.btnEditWTPerDay = new System.Windows.Forms.Button();
            this.btnAddWTPerDay = new System.Windows.Forms.Button();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWTPerDay = new System.Windows.Forms.Label();
            this.lblTopicWTPerDay = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnHomeTimeSlots = new System.Windows.Forms.Button();
            this.txtBoxEndTime = new System.Windows.Forms.TextBox();
            this.txtBoxStartTime = new System.Windows.Forms.TextBox();
            this.cmbTimeSlot = new System.Windows.Forms.ComboBox();
            this.dgvTimeSlots = new System.Windows.Forms.DataGridView();
            this.btnResetTimeSlots = new System.Windows.Forms.Button();
            this.btnDeleteTimeSlots = new System.Windows.Forms.Button();
            this.btnEditTimeSlots = new System.Windows.Forms.Button();
            this.btnAddTimeSlots = new System.Windows.Forms.Button();
            this.lblTimeSlot = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTopicTimeSlots = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMWD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMWD)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWTPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesWTPerDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursWTPerDay)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(720, 448);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.numericUpDownMWD);
            this.tabPage3.Controls.Add(this.lblNumberOfWorkingDays);
            this.tabPage3.Controls.Add(this.btnHomeMWD);
            this.tabPage3.Controls.Add(this.btnResetMWD);
            this.tabPage3.Controls.Add(this.btnDeleteMWD);
            this.tabPage3.Controls.Add(this.btnEditMWD);
            this.tabPage3.Controls.Add(this.btnAddMWD);
            this.tabPage3.Controls.Add(this.chkboxSunday);
            this.tabPage3.Controls.Add(this.chkboxSaturday);
            this.tabPage3.Controls.Add(this.chkboxFriday);
            this.tabPage3.Controls.Add(this.chkboxThursday);
            this.tabPage3.Controls.Add(this.chkboxWednesday);
            this.tabPage3.Controls.Add(this.chkboxTuesday);
            this.tabPage3.Controls.Add(this.chkboxMonday);
            this.tabPage3.Controls.Add(this.dgvMWD);
            this.tabPage3.Controls.Add(this.lblTopicMWD);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(712, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage working days";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMWD
            // 
            this.numericUpDownMWD.Location = new System.Drawing.Point(176, 120);
            this.numericUpDownMWD.Name = "numericUpDownMWD";
            this.numericUpDownMWD.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownMWD.TabIndex = 15;
            this.numericUpDownMWD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblNumberOfWorkingDays
            // 
            this.lblNumberOfWorkingDays.AutoSize = true;
            this.lblNumberOfWorkingDays.Location = new System.Drawing.Point(49, 122);
            this.lblNumberOfWorkingDays.Name = "lblNumberOfWorkingDays";
            this.lblNumberOfWorkingDays.Size = new System.Drawing.Size(121, 13);
            this.lblNumberOfWorkingDays.TabIndex = 14;
            this.lblNumberOfWorkingDays.Text = "Number of working days";
            // 
            // btnHomeMWD
            // 
            this.btnHomeMWD.FlatAppearance.BorderSize = 0;
            this.btnHomeMWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMWD.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeMWD.Image")));
            this.btnHomeMWD.Location = new System.Drawing.Point(8, 14);
            this.btnHomeMWD.Name = "btnHomeMWD";
            this.btnHomeMWD.Size = new System.Drawing.Size(47, 37);
            this.btnHomeMWD.TabIndex = 13;
            this.btnHomeMWD.UseVisualStyleBackColor = true;
            this.btnHomeMWD.Click += new System.EventHandler(this.btnHomeMWD_Click);
            // 
            // btnResetMWD
            // 
            this.btnResetMWD.Location = new System.Drawing.Point(457, 343);
            this.btnResetMWD.Name = "btnResetMWD";
            this.btnResetMWD.Size = new System.Drawing.Size(75, 23);
            this.btnResetMWD.TabIndex = 12;
            this.btnResetMWD.Text = "RESET";
            this.btnResetMWD.UseVisualStyleBackColor = true;
            this.btnResetMWD.Click += new System.EventHandler(this.btnResetMWD_Click);
            // 
            // btnDeleteMWD
            // 
            this.btnDeleteMWD.Location = new System.Drawing.Point(351, 343);
            this.btnDeleteMWD.Name = "btnDeleteMWD";
            this.btnDeleteMWD.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMWD.TabIndex = 11;
            this.btnDeleteMWD.Text = "DELETE";
            this.btnDeleteMWD.UseVisualStyleBackColor = true;
            this.btnDeleteMWD.Click += new System.EventHandler(this.btnDeleteMWD_Click);
            // 
            // btnEditMWD
            // 
            this.btnEditMWD.Location = new System.Drawing.Point(247, 343);
            this.btnEditMWD.Name = "btnEditMWD";
            this.btnEditMWD.Size = new System.Drawing.Size(75, 23);
            this.btnEditMWD.TabIndex = 10;
            this.btnEditMWD.Text = "EDIT";
            this.btnEditMWD.UseVisualStyleBackColor = true;
            this.btnEditMWD.Click += new System.EventHandler(this.btnEditMWD_Click);
            // 
            // btnAddMWD
            // 
            this.btnAddMWD.Location = new System.Drawing.Point(144, 343);
            this.btnAddMWD.Name = "btnAddMWD";
            this.btnAddMWD.Size = new System.Drawing.Size(75, 23);
            this.btnAddMWD.TabIndex = 9;
            this.btnAddMWD.Text = "ADD";
            this.btnAddMWD.UseVisualStyleBackColor = true;
            this.btnAddMWD.Click += new System.EventHandler(this.btnAddMWD_Click);
            // 
            // chkboxSunday
            // 
            this.chkboxSunday.AutoSize = true;
            this.chkboxSunday.Location = new System.Drawing.Point(543, 285);
            this.chkboxSunday.Name = "chkboxSunday";
            this.chkboxSunday.Size = new System.Drawing.Size(62, 17);
            this.chkboxSunday.TabIndex = 8;
            this.chkboxSunday.Text = "Sunday";
            this.chkboxSunday.UseVisualStyleBackColor = true;
            // 
            // chkboxSaturday
            // 
            this.chkboxSaturday.AutoSize = true;
            this.chkboxSaturday.Location = new System.Drawing.Point(454, 285);
            this.chkboxSaturday.Name = "chkboxSaturday";
            this.chkboxSaturday.Size = new System.Drawing.Size(68, 17);
            this.chkboxSaturday.TabIndex = 7;
            this.chkboxSaturday.Text = "Saturday";
            this.chkboxSaturday.UseVisualStyleBackColor = true;
            // 
            // chkboxFriday
            // 
            this.chkboxFriday.AutoSize = true;
            this.chkboxFriday.Location = new System.Drawing.Point(382, 285);
            this.chkboxFriday.Name = "chkboxFriday";
            this.chkboxFriday.Size = new System.Drawing.Size(54, 17);
            this.chkboxFriday.TabIndex = 6;
            this.chkboxFriday.Text = "Friday";
            this.chkboxFriday.UseVisualStyleBackColor = true;
            // 
            // chkboxThursday
            // 
            this.chkboxThursday.AutoSize = true;
            this.chkboxThursday.Location = new System.Drawing.Point(306, 285);
            this.chkboxThursday.Name = "chkboxThursday";
            this.chkboxThursday.Size = new System.Drawing.Size(70, 17);
            this.chkboxThursday.TabIndex = 5;
            this.chkboxThursday.Text = "Thursday";
            this.chkboxThursday.UseVisualStyleBackColor = true;
            // 
            // chkboxWednesday
            // 
            this.chkboxWednesday.AutoSize = true;
            this.chkboxWednesday.Location = new System.Drawing.Point(212, 285);
            this.chkboxWednesday.Name = "chkboxWednesday";
            this.chkboxWednesday.Size = new System.Drawing.Size(83, 17);
            this.chkboxWednesday.TabIndex = 4;
            this.chkboxWednesday.Text = "Wednesday";
            this.chkboxWednesday.UseVisualStyleBackColor = true;
            // 
            // chkboxTuesday
            // 
            this.chkboxTuesday.AutoSize = true;
            this.chkboxTuesday.Location = new System.Drawing.Point(135, 285);
            this.chkboxTuesday.Name = "chkboxTuesday";
            this.chkboxTuesday.Size = new System.Drawing.Size(67, 17);
            this.chkboxTuesday.TabIndex = 3;
            this.chkboxTuesday.Text = "Tuesday";
            this.chkboxTuesday.UseVisualStyleBackColor = true;
            // 
            // chkboxMonday
            // 
            this.chkboxMonday.AutoSize = true;
            this.chkboxMonday.Location = new System.Drawing.Point(52, 285);
            this.chkboxMonday.Name = "chkboxMonday";
            this.chkboxMonday.Size = new System.Drawing.Size(64, 17);
            this.chkboxMonday.TabIndex = 2;
            this.chkboxMonday.Text = "Monday";
            this.chkboxMonday.UseVisualStyleBackColor = true;
            // 
            // dgvMWD
            // 
            this.dgvMWD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMWD.Location = new System.Drawing.Point(306, 85);
            this.dgvMWD.Name = "dgvMWD";
            this.dgvMWD.Size = new System.Drawing.Size(389, 167);
            this.dgvMWD.TabIndex = 1;
            this.dgvMWD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMWD_CellContentClick);
            this.dgvMWD.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMWD_RowHeaderMouseClick);
            // 
            // lblTopicMWD
            // 
            this.lblTopicMWD.AutoSize = true;
            this.lblTopicMWD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicMWD.Location = new System.Drawing.Point(267, 35);
            this.lblTopicMWD.Name = "lblTopicMWD";
            this.lblTopicMWD.Size = new System.Drawing.Size(159, 16);
            this.lblTopicMWD.TabIndex = 0;
            this.lblTopicMWD.Text = "Manage working days";
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.Controls.Add(this.btnHomeWTPerDay);
            this.tabPage4.Controls.Add(this.dgvWTPerDay);
            this.tabPage4.Controls.Add(this.numericUpDownMinutesWTPerDay);
            this.tabPage4.Controls.Add(this.numericUpDownHoursWTPerDay);
            this.tabPage4.Controls.Add(this.btnResetWTPerDay);
            this.tabPage4.Controls.Add(this.btnDeleteWTPerDay);
            this.tabPage4.Controls.Add(this.btnEditWTPerDay);
            this.tabPage4.Controls.Add(this.btnAddWTPerDay);
            this.tabPage4.Controls.Add(this.lblMinutes);
            this.tabPage4.Controls.Add(this.lblHours);
            this.tabPage4.Controls.Add(this.lblWTPerDay);
            this.tabPage4.Controls.Add(this.lblTopicWTPerDay);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(712, 422);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Working time per day";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnHomeWTPerDay
            // 
            this.btnHomeWTPerDay.FlatAppearance.BorderSize = 0;
            this.btnHomeWTPerDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeWTPerDay.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeWTPerDay.Image")));
            this.btnHomeWTPerDay.Location = new System.Drawing.Point(8, 17);
            this.btnHomeWTPerDay.Name = "btnHomeWTPerDay";
            this.btnHomeWTPerDay.Size = new System.Drawing.Size(51, 37);
            this.btnHomeWTPerDay.TabIndex = 11;
            this.btnHomeWTPerDay.UseVisualStyleBackColor = true;
            this.btnHomeWTPerDay.Click += new System.EventHandler(this.btnHomeWTPerDay_Click);
            // 
            // dgvWTPerDay
            // 
            this.dgvWTPerDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWTPerDay.Location = new System.Drawing.Point(157, 269);
            this.dgvWTPerDay.Name = "dgvWTPerDay";
            this.dgvWTPerDay.Size = new System.Drawing.Size(340, 130);
            this.dgvWTPerDay.TabIndex = 10;
            this.dgvWTPerDay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWTPerDay_CellContentClick);
            this.dgvWTPerDay.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvWTPerDay_RowHeaderMouseClick);
            // 
            // numericUpDownMinutesWTPerDay
            // 
            this.numericUpDownMinutesWTPerDay.Location = new System.Drawing.Point(367, 120);
            this.numericUpDownMinutesWTPerDay.Name = "numericUpDownMinutesWTPerDay";
            this.numericUpDownMinutesWTPerDay.Size = new System.Drawing.Size(80, 20);
            this.numericUpDownMinutesWTPerDay.TabIndex = 9;
            // 
            // numericUpDownHoursWTPerDay
            // 
            this.numericUpDownHoursWTPerDay.Location = new System.Drawing.Point(207, 120);
            this.numericUpDownHoursWTPerDay.Name = "numericUpDownHoursWTPerDay";
            this.numericUpDownHoursWTPerDay.Size = new System.Drawing.Size(84, 20);
            this.numericUpDownHoursWTPerDay.TabIndex = 8;
            // 
            // btnResetWTPerDay
            // 
            this.btnResetWTPerDay.Location = new System.Drawing.Point(514, 213);
            this.btnResetWTPerDay.Name = "btnResetWTPerDay";
            this.btnResetWTPerDay.Size = new System.Drawing.Size(75, 23);
            this.btnResetWTPerDay.TabIndex = 7;
            this.btnResetWTPerDay.Text = "RESET";
            this.btnResetWTPerDay.UseVisualStyleBackColor = true;
            this.btnResetWTPerDay.Click += new System.EventHandler(this.btnResetWTPerDay_Click_1);
            // 
            // btnDeleteWTPerDay
            // 
            this.btnDeleteWTPerDay.Location = new System.Drawing.Point(372, 213);
            this.btnDeleteWTPerDay.Name = "btnDeleteWTPerDay";
            this.btnDeleteWTPerDay.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteWTPerDay.TabIndex = 6;
            this.btnDeleteWTPerDay.Text = "DELETE";
            this.btnDeleteWTPerDay.UseVisualStyleBackColor = true;
            this.btnDeleteWTPerDay.Click += new System.EventHandler(this.btnDeleteWTPerDay_Click_1);
            // 
            // btnEditWTPerDay
            // 
            this.btnEditWTPerDay.Location = new System.Drawing.Point(228, 213);
            this.btnEditWTPerDay.Name = "btnEditWTPerDay";
            this.btnEditWTPerDay.Size = new System.Drawing.Size(75, 23);
            this.btnEditWTPerDay.TabIndex = 5;
            this.btnEditWTPerDay.Text = "EDIT";
            this.btnEditWTPerDay.UseVisualStyleBackColor = true;
            this.btnEditWTPerDay.Click += new System.EventHandler(this.btnEditWTPerDay_Click);
            // 
            // btnAddWTPerDay
            // 
            this.btnAddWTPerDay.Location = new System.Drawing.Point(91, 213);
            this.btnAddWTPerDay.Name = "btnAddWTPerDay";
            this.btnAddWTPerDay.Size = new System.Drawing.Size(75, 23);
            this.btnAddWTPerDay.TabIndex = 4;
            this.btnAddWTPerDay.Text = "ADD";
            this.btnAddWTPerDay.UseVisualStyleBackColor = true;
            this.btnAddWTPerDay.Click += new System.EventHandler(this.btnAddWTPerDay_Click);
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(453, 123);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(44, 13);
            this.lblMinutes.TabIndex = 3;
            this.lblMinutes.Text = "Minutes";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(297, 123);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours";
            // 
            // lblWTPerDay
            // 
            this.lblWTPerDay.AutoSize = true;
            this.lblWTPerDay.Location = new System.Drawing.Point(63, 125);
            this.lblWTPerDay.Name = "lblWTPerDay";
            this.lblWTPerDay.Size = new System.Drawing.Size(107, 13);
            this.lblWTPerDay.TabIndex = 1;
            this.lblWTPerDay.Text = "Working time per day";
            // 
            // lblTopicWTPerDay
            // 
            this.lblTopicWTPerDay.AutoSize = true;
            this.lblTopicWTPerDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicWTPerDay.Location = new System.Drawing.Point(279, 38);
            this.lblTopicWTPerDay.Name = "lblTopicWTPerDay";
            this.lblTopicWTPerDay.Size = new System.Drawing.Size(155, 16);
            this.lblTopicWTPerDay.TabIndex = 0;
            this.lblTopicWTPerDay.Text = "Working time per day";
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage5.BackgroundImage")));
            this.tabPage5.Controls.Add(this.btnHomeTimeSlots);
            this.tabPage5.Controls.Add(this.txtBoxEndTime);
            this.tabPage5.Controls.Add(this.txtBoxStartTime);
            this.tabPage5.Controls.Add(this.cmbTimeSlot);
            this.tabPage5.Controls.Add(this.dgvTimeSlots);
            this.tabPage5.Controls.Add(this.btnResetTimeSlots);
            this.tabPage5.Controls.Add(this.btnDeleteTimeSlots);
            this.tabPage5.Controls.Add(this.btnEditTimeSlots);
            this.tabPage5.Controls.Add(this.btnAddTimeSlots);
            this.tabPage5.Controls.Add(this.lblTimeSlot);
            this.tabPage5.Controls.Add(this.lblEndTime);
            this.tabPage5.Controls.Add(this.lblStartTime);
            this.tabPage5.Controls.Add(this.lblTopicTimeSlots);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(712, 422);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Time slots";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // btnHomeTimeSlots
            // 
            this.btnHomeTimeSlots.FlatAppearance.BorderSize = 0;
            this.btnHomeTimeSlots.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTimeSlots.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeTimeSlots.Image")));
            this.btnHomeTimeSlots.Location = new System.Drawing.Point(8, 14);
            this.btnHomeTimeSlots.Name = "btnHomeTimeSlots";
            this.btnHomeTimeSlots.Size = new System.Drawing.Size(51, 38);
            this.btnHomeTimeSlots.TabIndex = 12;
            this.btnHomeTimeSlots.UseVisualStyleBackColor = true;
            this.btnHomeTimeSlots.Click += new System.EventHandler(this.btnHomeTimeSlots_Click);
            // 
            // txtBoxEndTime
            // 
            this.txtBoxEndTime.Location = new System.Drawing.Point(450, 112);
            this.txtBoxEndTime.Name = "txtBoxEndTime";
            this.txtBoxEndTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEndTime.TabIndex = 11;
            // 
            // txtBoxStartTime
            // 
            this.txtBoxStartTime.Location = new System.Drawing.Point(161, 112);
            this.txtBoxStartTime.Name = "txtBoxStartTime";
            this.txtBoxStartTime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStartTime.TabIndex = 10;
            // 
            // cmbTimeSlot
            // 
            this.cmbTimeSlot.FormattingEnabled = true;
            this.cmbTimeSlot.Items.AddRange(new object[] {
            "1 Hour",
            "30 Minutes"});
            this.cmbTimeSlot.Location = new System.Drawing.Point(302, 162);
            this.cmbTimeSlot.Name = "cmbTimeSlot";
            this.cmbTimeSlot.Size = new System.Drawing.Size(121, 21);
            this.cmbTimeSlot.TabIndex = 9;
            // 
            // dgvTimeSlots
            // 
            this.dgvTimeSlots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeSlots.Location = new System.Drawing.Point(139, 291);
            this.dgvTimeSlots.Name = "dgvTimeSlots";
            this.dgvTimeSlots.Size = new System.Drawing.Size(443, 121);
            this.dgvTimeSlots.TabIndex = 8;
            this.dgvTimeSlots.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeSlots_CellContentClick);
            this.dgvTimeSlots.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTimeSlots_RowHeaderMouseClick);
            // 
            // btnResetTimeSlots
            // 
            this.btnResetTimeSlots.Location = new System.Drawing.Point(534, 231);
            this.btnResetTimeSlots.Name = "btnResetTimeSlots";
            this.btnResetTimeSlots.Size = new System.Drawing.Size(75, 23);
            this.btnResetTimeSlots.TabIndex = 7;
            this.btnResetTimeSlots.Text = "RESET";
            this.btnResetTimeSlots.UseVisualStyleBackColor = true;
            this.btnResetTimeSlots.Click += new System.EventHandler(this.btnResetTimeSlots_Click);
            // 
            // btnDeleteTimeSlots
            // 
            this.btnDeleteTimeSlots.Location = new System.Drawing.Point(399, 231);
            this.btnDeleteTimeSlots.Name = "btnDeleteTimeSlots";
            this.btnDeleteTimeSlots.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTimeSlots.TabIndex = 6;
            this.btnDeleteTimeSlots.Text = "DELETE";
            this.btnDeleteTimeSlots.UseVisualStyleBackColor = true;
            this.btnDeleteTimeSlots.Click += new System.EventHandler(this.btnDeleteTimeSlots_Click);
            // 
            // btnEditTimeSlots
            // 
            this.btnEditTimeSlots.Location = new System.Drawing.Point(266, 231);
            this.btnEditTimeSlots.Name = "btnEditTimeSlots";
            this.btnEditTimeSlots.Size = new System.Drawing.Size(75, 23);
            this.btnEditTimeSlots.TabIndex = 5;
            this.btnEditTimeSlots.Text = "EDIT";
            this.btnEditTimeSlots.UseVisualStyleBackColor = true;
            this.btnEditTimeSlots.Click += new System.EventHandler(this.btnEditTimeSlots_Click);
            // 
            // btnAddTimeSlots
            // 
            this.btnAddTimeSlots.Location = new System.Drawing.Point(139, 231);
            this.btnAddTimeSlots.Name = "btnAddTimeSlots";
            this.btnAddTimeSlots.Size = new System.Drawing.Size(75, 23);
            this.btnAddTimeSlots.TabIndex = 4;
            this.btnAddTimeSlots.Text = "ADD";
            this.btnAddTimeSlots.UseVisualStyleBackColor = true;
            this.btnAddTimeSlots.Click += new System.EventHandler(this.btnAddTimeSlots_Click);
            // 
            // lblTimeSlot
            // 
            this.lblTimeSlot.AutoSize = true;
            this.lblTimeSlot.Location = new System.Drawing.Point(247, 165);
            this.lblTimeSlot.Name = "lblTimeSlot";
            this.lblTimeSlot.Size = new System.Drawing.Size(49, 13);
            this.lblTimeSlot.TabIndex = 3;
            this.lblTimeSlot.Text = "Time slot";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(396, 115);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(48, 13);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "End time";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(104, 115);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(51, 13);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start time";
            // 
            // lblTopicTimeSlots
            // 
            this.lblTopicTimeSlots.AutoSize = true;
            this.lblTopicTimeSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopicTimeSlots.Location = new System.Drawing.Point(298, 36);
            this.lblTopicTimeSlots.Name = "lblTopicTimeSlots";
            this.lblTopicTimeSlots.Size = new System.Drawing.Size(80, 16);
            this.lblTopicTimeSlots.TabIndex = 0;
            this.lblTopicTimeSlots.Text = "Time slots";
            // 
            // ManageWDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(721, 446);
            this.Controls.Add(this.tabControl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ManageWDH";
            this.Load += new System.EventHandler(this.ManageWDH_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMWD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMWD)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWTPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutesWTPerDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHoursWTPerDay)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeSlots)).EndInit();
            this.ResumeLayout(false);

        }

        private void dgvWTPerDay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvMWD;
        private System.Windows.Forms.Label lblTopicMWD;
        private System.Windows.Forms.Button btnHomeMWD;
        private System.Windows.Forms.Button btnResetMWD;
        private System.Windows.Forms.Button btnDeleteMWD;
        private System.Windows.Forms.Button btnEditMWD;
        private System.Windows.Forms.Button btnAddMWD;
        private System.Windows.Forms.CheckBox chkboxSunday;
        private System.Windows.Forms.CheckBox chkboxSaturday;
        private System.Windows.Forms.CheckBox chkboxFriday;
        private System.Windows.Forms.CheckBox chkboxThursday;
        private System.Windows.Forms.CheckBox chkboxWednesday;
        private System.Windows.Forms.CheckBox chkboxTuesday;
        private System.Windows.Forms.CheckBox chkboxMonday;
        private System.Windows.Forms.Button btnHomeWTPerDay;
        private System.Windows.Forms.DataGridView dgvWTPerDay;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutesWTPerDay;
        private System.Windows.Forms.NumericUpDown numericUpDownHoursWTPerDay;
        private System.Windows.Forms.Button btnResetWTPerDay;
        private System.Windows.Forms.Button btnDeleteWTPerDay;
        private System.Windows.Forms.Button btnEditWTPerDay;
        private System.Windows.Forms.Button btnAddWTPerDay;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblWTPerDay;
        private System.Windows.Forms.Label lblTopicWTPerDay;
        private System.Windows.Forms.TextBox txtBoxEndTime;
        private System.Windows.Forms.TextBox txtBoxStartTime;
        private System.Windows.Forms.ComboBox cmbTimeSlot;
        private System.Windows.Forms.DataGridView dgvTimeSlots;
        private System.Windows.Forms.Button btnResetTimeSlots;
        private System.Windows.Forms.Button btnDeleteTimeSlots;
        private System.Windows.Forms.Button btnEditTimeSlots;
        private System.Windows.Forms.Button btnAddTimeSlots;
        private System.Windows.Forms.Label lblTimeSlot;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTopicTimeSlots;
        private System.Windows.Forms.Button btnHomeTimeSlots;
        private System.Windows.Forms.NumericUpDown numericUpDownMWD;
        private System.Windows.Forms.Label lblNumberOfWorkingDays;
    }
}