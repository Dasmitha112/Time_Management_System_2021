using System;

namespace Time_Management_System_2021.Sessions
{
    partial class AddSessionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSessionForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SessionViewTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSession = new System.Windows.Forms.DataGridView();
            this.AddSessionTab = new System.Windows.Forms.TabPage();
            this.SBoxDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtend = new System.Windows.Forms.Label();
            this.txtstart = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.TextBox();
            this.SesionClearBtn = new System.Windows.Forms.Button();
            this.SessionAddBtn = new System.Windows.Forms.Button();
            this.SesionDurationBox = new System.Windows.Forms.NumericUpDown();
            this.SessionStucountBox = new System.Windows.Forms.NumericUpDown();
            this.SessionSubCodeBox = new System.Windows.Forms.ComboBox();
            this.SessionSubNBox = new System.Windows.Forms.ComboBox();
            this.SessionTagBox = new System.Windows.Forms.ComboBox();
            this.SessionGroupBox = new System.Windows.Forms.ComboBox();
            this.SessionLecBox = new System.Windows.Forms.ComboBox();
            this.SessionStuCount = new System.Windows.Forms.Label();
            this.SessionSubName = new System.Windows.Forms.Label();
            this.SessionDuration = new System.Windows.Forms.Label();
            this.SessionSubCode = new System.Windows.Forms.Label();
            this.SessionStGroup = new System.Windows.Forms.Label();
            this.SessionTag = new System.Windows.Forms.Label();
            this.SessionLecName = new System.Windows.Forms.Label();
            this.SessionAddTopic = new System.Windows.Forms.Label();
            this.MGTSessionTab = new System.Windows.Forms.TabPage();
            this.MDay = new System.Windows.Forms.Label();
            this.MBoxDay = new System.Windows.Forms.ComboBox();
            this.MEnd = new System.Windows.Forms.Label();
            this.MBoxEnd = new System.Windows.Forms.TextBox();
            this.MBoxstart = new System.Windows.Forms.TextBox();
            this.Mstart = new System.Windows.Forms.Label();
            this.SMdelete = new System.Windows.Forms.Button();
            this.SMupdate = new System.Windows.Forms.Button();
            this.numericMCOUNT = new System.Windows.Forms.NumericUpDown();
            this.numericMDuration = new System.Windows.Forms.NumericUpDown();
            this.MBoxLecture = new System.Windows.Forms.ComboBox();
            this.MBoxtag = new System.Windows.Forms.ComboBox();
            this.MBoxName = new System.Windows.Forms.ComboBox();
            this.MBoxGroup = new System.Windows.Forms.ComboBox();
            this.MBoxCode = new System.Windows.Forms.ComboBox();
            this.SDuration = new System.Windows.Forms.Label();
            this.Scount = new System.Windows.Forms.Label();
            this.SMSC = new System.Windows.Forms.Label();
            this.SName = new System.Windows.Forms.Label();
            this.Sgroup = new System.Windows.Forms.Label();
            this.SMT = new System.Windows.Forms.Label();
            this.MSL = new System.Windows.Forms.Label();
            this.sessionM = new System.Windows.Forms.Label();
            this.backhomesession = new System.Windows.Forms.Button();
            this.backhomeS2 = new System.Windows.Forms.Button();
            this.backhome2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SessionViewTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).BeginInit();
            this.AddSessionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SesionDurationBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionStucountBox)).BeginInit();
            this.MGTSessionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMCOUNT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SessionViewTab);
            this.tabControl1.Controls.Add(this.AddSessionTab);
            this.tabControl1.Controls.Add(this.MGTSessionTab);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 540);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.Sessions_Load);
            // 
            // SessionViewTab
            // 
            this.SessionViewTab.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.SessionViewTab.Controls.Add(this.backhomesession);
            this.SessionViewTab.Controls.Add(this.label2);
            this.SessionViewTab.Controls.Add(this.dataGridViewSession);
            this.SessionViewTab.Location = new System.Drawing.Point(4, 22);
            this.SessionViewTab.Name = "SessionViewTab";
            this.SessionViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.SessionViewTab.Size = new System.Drawing.Size(976, 514);
            this.SessionViewTab.TabIndex = 0;
            this.SessionViewTab.Text = "View Sessions";
            this.SessionViewTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(372, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "View Session";
            // 
            // dataGridViewSession
            // 
            this.dataGridViewSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSession.Location = new System.Drawing.Point(20, 122);
            this.dataGridViewSession.Name = "dataGridViewSession";
            this.dataGridViewSession.Size = new System.Drawing.Size(940, 262);
            this.dataGridViewSession.TabIndex = 0;
            this.dataGridViewSession.DoubleClick += new System.EventHandler(this.DataGridViewSession_cellDoubleClick);
            // 
            // AddSessionTab
            // 
            this.AddSessionTab.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.AddSessionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddSessionTab.Controls.Add(this.backhomeS2);
            this.AddSessionTab.Controls.Add(this.SBoxDay);
            this.AddSessionTab.Controls.Add(this.label1);
            this.AddSessionTab.Controls.Add(this.txtend);
            this.AddSessionTab.Controls.Add(this.txtstart);
            this.AddSessionTab.Controls.Add(this.end);
            this.AddSessionTab.Controls.Add(this.start);
            this.AddSessionTab.Controls.Add(this.SesionClearBtn);
            this.AddSessionTab.Controls.Add(this.SessionAddBtn);
            this.AddSessionTab.Controls.Add(this.SesionDurationBox);
            this.AddSessionTab.Controls.Add(this.SessionStucountBox);
            this.AddSessionTab.Controls.Add(this.SessionSubCodeBox);
            this.AddSessionTab.Controls.Add(this.SessionSubNBox);
            this.AddSessionTab.Controls.Add(this.SessionTagBox);
            this.AddSessionTab.Controls.Add(this.SessionGroupBox);
            this.AddSessionTab.Controls.Add(this.SessionLecBox);
            this.AddSessionTab.Controls.Add(this.SessionStuCount);
            this.AddSessionTab.Controls.Add(this.SessionSubName);
            this.AddSessionTab.Controls.Add(this.SessionDuration);
            this.AddSessionTab.Controls.Add(this.SessionSubCode);
            this.AddSessionTab.Controls.Add(this.SessionStGroup);
            this.AddSessionTab.Controls.Add(this.SessionTag);
            this.AddSessionTab.Controls.Add(this.SessionLecName);
            this.AddSessionTab.Controls.Add(this.SessionAddTopic);
            this.AddSessionTab.Location = new System.Drawing.Point(4, 22);
            this.AddSessionTab.Name = "AddSessionTab";
            this.AddSessionTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddSessionTab.Size = new System.Drawing.Size(976, 514);
            this.AddSessionTab.TabIndex = 1;
            this.AddSessionTab.Text = "Add Session";
            this.AddSessionTab.UseVisualStyleBackColor = true;
            // 
            // SBoxDay
            // 
            this.SBoxDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SBoxDay.FormattingEnabled = true;
            this.SBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.SBoxDay.Location = new System.Drawing.Point(277, 431);
            this.SBoxDay.Name = "SBoxDay";
            this.SBoxDay.Size = new System.Drawing.Size(150, 21);
            this.SBoxDay.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Day";
            // 
            // txtend
            // 
            this.txtend.AutoSize = true;
            this.txtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(151, 392);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(90, 18);
            this.txtend.TabIndex = 20;
            this.txtend.Text = "Ending Time";
            // 
            // txtstart
            // 
            this.txtstart.AutoSize = true;
            this.txtstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstart.Location = new System.Drawing.Point(151, 360);
            this.txtstart.Name = "txtstart";
            this.txtstart.Size = new System.Drawing.Size(95, 18);
            this.txtstart.TabIndex = 19;
            this.txtstart.Text = "Starting Time";
            this.txtstart.Click += new System.EventHandler(this.txtstart_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(277, 393);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(100, 20);
            this.end.TabIndex = 18;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(277, 358);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(100, 20);
            this.start.TabIndex = 17;
            // 
            // SesionClearBtn
            // 
            this.SesionClearBtn.BackColor = System.Drawing.Color.DarkOrange;
            this.SesionClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SesionClearBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SesionClearBtn.Location = new System.Drawing.Point(804, 410);
            this.SesionClearBtn.Name = "SesionClearBtn";
            this.SesionClearBtn.Size = new System.Drawing.Size(150, 60);
            this.SesionClearBtn.TabIndex = 16;
            this.SesionClearBtn.Text = "Clear";
            this.SesionClearBtn.UseVisualStyleBackColor = false;
            this.SesionClearBtn.Click += new System.EventHandler(this.SesionClearBtn_Click);
            // 
            // SessionAddBtn
            // 
            this.SessionAddBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.SessionAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionAddBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SessionAddBtn.Location = new System.Drawing.Point(624, 410);
            this.SessionAddBtn.Name = "SessionAddBtn";
            this.SessionAddBtn.Size = new System.Drawing.Size(150, 60);
            this.SessionAddBtn.TabIndex = 15;
            this.SessionAddBtn.Text = "Add";
            this.SessionAddBtn.UseVisualStyleBackColor = false;
            this.SessionAddBtn.Click += new System.EventHandler(this.SessionAddBtn_Click_1);
            // 
            // SesionDurationBox
            // 
            this.SesionDurationBox.Location = new System.Drawing.Point(277, 332);
            this.SesionDurationBox.Name = "SesionDurationBox";
            this.SesionDurationBox.Size = new System.Drawing.Size(89, 20);
            this.SesionDurationBox.TabIndex = 14;
            // 
            // SessionStucountBox
            // 
            this.SessionStucountBox.Location = new System.Drawing.Point(277, 297);
            this.SessionStucountBox.Name = "SessionStucountBox";
            this.SessionStucountBox.Size = new System.Drawing.Size(89, 20);
            this.SessionStucountBox.TabIndex = 13;
            // 
            // SessionSubCodeBox
            // 
            this.SessionSubCodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionSubCodeBox.FormattingEnabled = true;
            this.SessionSubCodeBox.Location = new System.Drawing.Point(277, 261);
            this.SessionSubCodeBox.Name = "SessionSubCodeBox";
            this.SessionSubCodeBox.Size = new System.Drawing.Size(198, 21);
            this.SessionSubCodeBox.TabIndex = 12;
            this.SessionSubCodeBox.SelectedIndexChanged += new System.EventHandler(this.SessionSubCodeBox_SelectedIndexChanged);
            // 
            // SessionSubNBox
            // 
            this.SessionSubNBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionSubNBox.FormattingEnabled = true;
            this.SessionSubNBox.Location = new System.Drawing.Point(277, 223);
            this.SessionSubNBox.Name = "SessionSubNBox";
            this.SessionSubNBox.Size = new System.Drawing.Size(198, 21);
            this.SessionSubNBox.TabIndex = 11;
            // 
            // SessionTagBox
            // 
            this.SessionTagBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionTagBox.FormattingEnabled = true;
            this.SessionTagBox.Location = new System.Drawing.Point(277, 148);
            this.SessionTagBox.Name = "SessionTagBox";
            this.SessionTagBox.Size = new System.Drawing.Size(198, 21);
            this.SessionTagBox.TabIndex = 10;
            // 
            // SessionGroupBox
            // 
            this.SessionGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionGroupBox.FormattingEnabled = true;
            this.SessionGroupBox.Location = new System.Drawing.Point(277, 180);
            this.SessionGroupBox.Name = "SessionGroupBox";
            this.SessionGroupBox.Size = new System.Drawing.Size(198, 21);
            this.SessionGroupBox.TabIndex = 9;
            // 
            // SessionLecBox
            // 
            this.SessionLecBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionLecBox.FormattingEnabled = true;
            this.SessionLecBox.Location = new System.Drawing.Point(277, 108);
            this.SessionLecBox.Name = "SessionLecBox";
            this.SessionLecBox.Size = new System.Drawing.Size(198, 21);
            this.SessionLecBox.TabIndex = 8;
            this.SessionLecBox.SelectedIndexChanged += new System.EventHandler(this.SessionLecBox_SelectedIndexChanged);
            this.SessionLecBox.TextChanged += new System.EventHandler(this.TxtSessionLecBox_TextChanged);
            // 
            // SessionStuCount
            // 
            this.SessionStuCount.AutoSize = true;
            this.SessionStuCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionStuCount.Location = new System.Drawing.Point(151, 299);
            this.SessionStuCount.Name = "SessionStuCount";
            this.SessionStuCount.Size = new System.Drawing.Size(102, 18);
            this.SessionStuCount.TabIndex = 7;
            this.SessionStuCount.Text = "Student Count";
            // 
            // SessionSubName
            // 
            this.SessionSubName.AutoSize = true;
            this.SessionSubName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSubName.Location = new System.Drawing.Point(151, 222);
            this.SessionSubName.Name = "SessionSubName";
            this.SessionSubName.Size = new System.Drawing.Size(101, 18);
            this.SessionSubName.TabIndex = 6;
            this.SessionSubName.Text = "Subject Name";
            // 
            // SessionDuration
            // 
            this.SessionDuration.AutoSize = true;
            this.SessionDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionDuration.Location = new System.Drawing.Point(154, 330);
            this.SessionDuration.Name = "SessionDuration";
            this.SessionDuration.Size = new System.Drawing.Size(64, 18);
            this.SessionDuration.TabIndex = 5;
            this.SessionDuration.Text = "Duration";
            // 
            // SessionSubCode
            // 
            this.SessionSubCode.AutoSize = true;
            this.SessionSubCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionSubCode.Location = new System.Drawing.Point(151, 264);
            this.SessionSubCode.Name = "SessionSubCode";
            this.SessionSubCode.Size = new System.Drawing.Size(97, 18);
            this.SessionSubCode.TabIndex = 4;
            this.SessionSubCode.Text = "Subject Code";
            // 
            // SessionStGroup
            // 
            this.SessionStGroup.AutoSize = true;
            this.SessionStGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionStGroup.Location = new System.Drawing.Point(151, 183);
            this.SessionStGroup.Name = "SessionStGroup";
            this.SessionStGroup.Size = new System.Drawing.Size(104, 18);
            this.SessionStGroup.TabIndex = 3;
            this.SessionStGroup.Text = "Student Group";
            // 
            // SessionTag
            // 
            this.SessionTag.AutoSize = true;
            this.SessionTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionTag.Location = new System.Drawing.Point(151, 151);
            this.SessionTag.Name = "SessionTag";
            this.SessionTag.Size = new System.Drawing.Size(33, 18);
            this.SessionTag.TabIndex = 2;
            this.SessionTag.Text = "Tag";
            // 
            // SessionLecName
            // 
            this.SessionLecName.AutoSize = true;
            this.SessionLecName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionLecName.Location = new System.Drawing.Point(151, 111);
            this.SessionLecName.Name = "SessionLecName";
            this.SessionLecName.Size = new System.Drawing.Size(62, 18);
            this.SessionLecName.TabIndex = 1;
            this.SessionLecName.Text = "Lecturer";
            // 
            // SessionAddTopic
            // 
            this.SessionAddTopic.AutoSize = true;
            this.SessionAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionAddTopic.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SessionAddTopic.Location = new System.Drawing.Point(361, 29);
            this.SessionAddTopic.Name = "SessionAddTopic";
            this.SessionAddTopic.Size = new System.Drawing.Size(189, 33);
            this.SessionAddTopic.TabIndex = 0;
            this.SessionAddTopic.Text = "Add Session";
            // 
            // MGTSessionTab
            // 
            this.MGTSessionTab.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.MGTSessionTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MGTSessionTab.Controls.Add(this.backhome2);
            this.MGTSessionTab.Controls.Add(this.MDay);
            this.MGTSessionTab.Controls.Add(this.MBoxDay);
            this.MGTSessionTab.Controls.Add(this.MEnd);
            this.MGTSessionTab.Controls.Add(this.MBoxEnd);
            this.MGTSessionTab.Controls.Add(this.MBoxstart);
            this.MGTSessionTab.Controls.Add(this.Mstart);
            this.MGTSessionTab.Controls.Add(this.SMdelete);
            this.MGTSessionTab.Controls.Add(this.SMupdate);
            this.MGTSessionTab.Controls.Add(this.numericMCOUNT);
            this.MGTSessionTab.Controls.Add(this.numericMDuration);
            this.MGTSessionTab.Controls.Add(this.MBoxLecture);
            this.MGTSessionTab.Controls.Add(this.MBoxtag);
            this.MGTSessionTab.Controls.Add(this.MBoxName);
            this.MGTSessionTab.Controls.Add(this.MBoxGroup);
            this.MGTSessionTab.Controls.Add(this.MBoxCode);
            this.MGTSessionTab.Controls.Add(this.SDuration);
            this.MGTSessionTab.Controls.Add(this.Scount);
            this.MGTSessionTab.Controls.Add(this.SMSC);
            this.MGTSessionTab.Controls.Add(this.SName);
            this.MGTSessionTab.Controls.Add(this.Sgroup);
            this.MGTSessionTab.Controls.Add(this.SMT);
            this.MGTSessionTab.Controls.Add(this.MSL);
            this.MGTSessionTab.Controls.Add(this.sessionM);
            this.MGTSessionTab.Location = new System.Drawing.Point(4, 22);
            this.MGTSessionTab.Name = "MGTSessionTab";
            this.MGTSessionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MGTSessionTab.Size = new System.Drawing.Size(976, 514);
            this.MGTSessionTab.TabIndex = 2;
            this.MGTSessionTab.Text = "Manage Session";
            this.MGTSessionTab.UseVisualStyleBackColor = true;
            this.MGTSessionTab.Click += new System.EventHandler(this.Sessions_Load);
            // 
            // MDay
            // 
            this.MDay.AutoSize = true;
            this.MDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDay.Location = new System.Drawing.Point(98, 436);
            this.MDay.Name = "MDay";
            this.MDay.Size = new System.Drawing.Size(34, 18);
            this.MDay.TabIndex = 26;
            this.MDay.Text = "Day";
            // 
            // MBoxDay
            // 
            this.MBoxDay.FormattingEnabled = true;
            this.MBoxDay.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.MBoxDay.Location = new System.Drawing.Point(266, 437);
            this.MBoxDay.Name = "MBoxDay";
            this.MBoxDay.Size = new System.Drawing.Size(150, 21);
            this.MBoxDay.TabIndex = 25;
            // 
            // MEnd
            // 
            this.MEnd.AutoSize = true;
            this.MEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEnd.Location = new System.Drawing.Point(98, 399);
            this.MEnd.Name = "MEnd";
            this.MEnd.Size = new System.Drawing.Size(90, 18);
            this.MEnd.TabIndex = 24;
            this.MEnd.Text = "Ending Time";
            // 
            // MBoxEnd
            // 
            this.MBoxEnd.Location = new System.Drawing.Point(266, 397);
            this.MBoxEnd.Name = "MBoxEnd";
            this.MBoxEnd.Size = new System.Drawing.Size(100, 20);
            this.MBoxEnd.TabIndex = 23;
            // 
            // MBoxstart
            // 
            this.MBoxstart.Location = new System.Drawing.Point(266, 371);
            this.MBoxstart.Name = "MBoxstart";
            this.MBoxstart.Size = new System.Drawing.Size(100, 20);
            this.MBoxstart.TabIndex = 22;
            // 
            // Mstart
            // 
            this.Mstart.AutoSize = true;
            this.Mstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mstart.Location = new System.Drawing.Point(96, 373);
            this.Mstart.Name = "Mstart";
            this.Mstart.Size = new System.Drawing.Size(95, 18);
            this.Mstart.TabIndex = 21;
            this.Mstart.Text = "Starting Time";
            // 
            // SMdelete
            // 
            this.SMdelete.BackColor = System.Drawing.Color.Maroon;
            this.SMdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMdelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SMdelete.Location = new System.Drawing.Point(785, 397);
            this.SMdelete.Name = "SMdelete";
            this.SMdelete.Size = new System.Drawing.Size(150, 60);
            this.SMdelete.TabIndex = 20;
            this.SMdelete.Text = "Delete";
            this.SMdelete.UseVisualStyleBackColor = false;
            this.SMdelete.Click += new System.EventHandler(this.SMdelete_Click);
            // 
            // SMupdate
            // 
            this.SMupdate.BackColor = System.Drawing.Color.DarkBlue;
            this.SMupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMupdate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SMupdate.Location = new System.Drawing.Point(598, 399);
            this.SMupdate.Name = "SMupdate";
            this.SMupdate.Size = new System.Drawing.Size(150, 60);
            this.SMupdate.TabIndex = 19;
            this.SMupdate.Text = "Update";
            this.SMupdate.UseVisualStyleBackColor = false;
            this.SMupdate.Click += new System.EventHandler(this.SMupdate_Click);
            // 
            // numericMCOUNT
            // 
            this.numericMCOUNT.Location = new System.Drawing.Point(266, 301);
            this.numericMCOUNT.Name = "numericMCOUNT";
            this.numericMCOUNT.Size = new System.Drawing.Size(89, 20);
            this.numericMCOUNT.TabIndex = 18;
            // 
            // numericMDuration
            // 
            this.numericMDuration.Location = new System.Drawing.Point(266, 338);
            this.numericMDuration.Name = "numericMDuration";
            this.numericMDuration.Size = new System.Drawing.Size(89, 20);
            this.numericMDuration.TabIndex = 17;
            // 
            // MBoxLecture
            // 
            this.MBoxLecture.FormattingEnabled = true;
            this.MBoxLecture.Location = new System.Drawing.Point(266, 115);
            this.MBoxLecture.Name = "MBoxLecture";
            this.MBoxLecture.Size = new System.Drawing.Size(198, 21);
            this.MBoxLecture.TabIndex = 16;
            // 
            // MBoxtag
            // 
            this.MBoxtag.FormattingEnabled = true;
            this.MBoxtag.Location = new System.Drawing.Point(266, 151);
            this.MBoxtag.Name = "MBoxtag";
            this.MBoxtag.Size = new System.Drawing.Size(198, 21);
            this.MBoxtag.TabIndex = 15;
            // 
            // MBoxName
            // 
            this.MBoxName.FormattingEnabled = true;
            this.MBoxName.Location = new System.Drawing.Point(266, 261);
            this.MBoxName.Name = "MBoxName";
            this.MBoxName.Size = new System.Drawing.Size(198, 21);
            this.MBoxName.TabIndex = 14;
            // 
            // MBoxGroup
            // 
            this.MBoxGroup.FormattingEnabled = true;
            this.MBoxGroup.Location = new System.Drawing.Point(266, 224);
            this.MBoxGroup.Name = "MBoxGroup";
            this.MBoxGroup.Size = new System.Drawing.Size(198, 21);
            this.MBoxGroup.TabIndex = 12;
            // 
            // MBoxCode
            // 
            this.MBoxCode.FormattingEnabled = true;
            this.MBoxCode.Location = new System.Drawing.Point(266, 188);
            this.MBoxCode.Name = "MBoxCode";
            this.MBoxCode.Size = new System.Drawing.Size(198, 21);
            this.MBoxCode.TabIndex = 11;
            // 
            // SDuration
            // 
            this.SDuration.AutoSize = true;
            this.SDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SDuration.Location = new System.Drawing.Point(96, 336);
            this.SDuration.Name = "SDuration";
            this.SDuration.Size = new System.Drawing.Size(64, 18);
            this.SDuration.TabIndex = 10;
            this.SDuration.Text = "Duration";
            // 
            // Scount
            // 
            this.Scount.AutoSize = true;
            this.Scount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scount.Location = new System.Drawing.Point(96, 299);
            this.Scount.Name = "Scount";
            this.Scount.Size = new System.Drawing.Size(102, 18);
            this.Scount.TabIndex = 9;
            this.Scount.Text = "Student Count";
            // 
            // SMSC
            // 
            this.SMSC.AutoSize = true;
            this.SMSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSC.Location = new System.Drawing.Point(96, 191);
            this.SMSC.Name = "SMSC";
            this.SMSC.Size = new System.Drawing.Size(97, 18);
            this.SMSC.TabIndex = 8;
            this.SMSC.Text = "Subject Code";
            // 
            // SName
            // 
            this.SName.AutoSize = true;
            this.SName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SName.Location = new System.Drawing.Point(96, 264);
            this.SName.Name = "SName";
            this.SName.Size = new System.Drawing.Size(101, 18);
            this.SName.TabIndex = 7;
            this.SName.Text = "Subject Name";
            // 
            // Sgroup
            // 
            this.Sgroup.AutoSize = true;
            this.Sgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sgroup.Location = new System.Drawing.Point(96, 227);
            this.Sgroup.Name = "Sgroup";
            this.Sgroup.Size = new System.Drawing.Size(104, 18);
            this.Sgroup.TabIndex = 4;
            this.Sgroup.Text = "Student Group";
            // 
            // SMT
            // 
            this.SMT.AutoSize = true;
            this.SMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMT.Location = new System.Drawing.Point(96, 150);
            this.SMT.Name = "SMT";
            this.SMT.Size = new System.Drawing.Size(33, 18);
            this.SMT.TabIndex = 3;
            this.SMT.Text = "Tag";
            // 
            // MSL
            // 
            this.MSL.AutoSize = true;
            this.MSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSL.Location = new System.Drawing.Point(98, 114);
            this.MSL.Name = "MSL";
            this.MSL.Size = new System.Drawing.Size(62, 18);
            this.MSL.TabIndex = 2;
            this.MSL.Text = "Lecturer";
            // 
            // sessionM
            // 
            this.sessionM.AutoSize = true;
            this.sessionM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessionM.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sessionM.Location = new System.Drawing.Point(350, 25);
            this.sessionM.Name = "sessionM";
            this.sessionM.Size = new System.Drawing.Size(245, 33);
            this.sessionM.TabIndex = 1;
            this.sessionM.Text = "Manage Session";
            // 
            // backhomesession
            // 
            this.backhomesession.FlatAppearance.BorderSize = 0;
            this.backhomesession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhomesession.Image = ((System.Drawing.Image)(resources.GetObject("backhomesession.Image")));
            this.backhomesession.Location = new System.Drawing.Point(20, 18);
            this.backhomesession.Name = "backhomesession";
            this.backhomesession.Size = new System.Drawing.Size(47, 37);
            this.backhomesession.TabIndex = 15;
            this.backhomesession.UseVisualStyleBackColor = true;
            this.backhomesession.Click += new System.EventHandler(this.backhomesession_Click);
            // 
            // backhomeS2
            // 
            this.backhomeS2.FlatAppearance.BorderSize = 0;
            this.backhomeS2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhomeS2.Image = ((System.Drawing.Image)(resources.GetObject("backhomeS2.Image")));
            this.backhomeS2.Location = new System.Drawing.Point(18, 25);
            this.backhomeS2.Name = "backhomeS2";
            this.backhomeS2.Size = new System.Drawing.Size(47, 37);
            this.backhomeS2.TabIndex = 23;
            this.backhomeS2.UseVisualStyleBackColor = true;
            this.backhomeS2.Click += new System.EventHandler(this.backhomeS2_Click);
            // 
            // backhome2
            // 
            this.backhome2.FlatAppearance.BorderSize = 0;
            this.backhome2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhome2.Image = ((System.Drawing.Image)(resources.GetObject("backhome2.Image")));
            this.backhome2.Location = new System.Drawing.Point(20, 21);
            this.backhome2.Name = "backhome2";
            this.backhome2.Size = new System.Drawing.Size(47, 37);
            this.backhome2.TabIndex = 27;
            this.backhome2.UseVisualStyleBackColor = true;
            this.backhome2.Click += new System.EventHandler(this.backhome2_Click);
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 552);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSessionForm";
            this.Text = "AddSessionForm";
            this.tabControl1.ResumeLayout(false);
            this.SessionViewTab.ResumeLayout(false);
            this.SessionViewTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSession)).EndInit();
            this.AddSessionTab.ResumeLayout(false);
            this.AddSessionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SesionDurationBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionStucountBox)).EndInit();
            this.MGTSessionTab.ResumeLayout(false);
            this.MGTSessionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMCOUNT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMDuration)).EndInit();
            this.ResumeLayout(false);

        }

        //private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SessionViewTab;
        private System.Windows.Forms.TabPage AddSessionTab;
        private System.Windows.Forms.TabPage MGTSessionTab;
        private System.Windows.Forms.NumericUpDown SesionDurationBox;
        private System.Windows.Forms.NumericUpDown SessionStucountBox;
        private System.Windows.Forms.ComboBox SessionSubCodeBox;
        private System.Windows.Forms.ComboBox SessionSubNBox;
        private System.Windows.Forms.ComboBox SessionTagBox;
        private System.Windows.Forms.ComboBox SessionGroupBox;
        private System.Windows.Forms.ComboBox SessionLecBox;
        private System.Windows.Forms.Label SessionStuCount;
        private System.Windows.Forms.Label SessionSubName;
        private System.Windows.Forms.Label SessionDuration;
        private System.Windows.Forms.Label SessionSubCode;
        private System.Windows.Forms.Label SessionStGroup;
        private System.Windows.Forms.Label SessionTag;
        private System.Windows.Forms.Label SessionLecName;
        private System.Windows.Forms.Label SessionAddTopic;
        private System.Windows.Forms.Button SesionClearBtn;
        private System.Windows.Forms.Button SessionAddBtn;
        private System.Windows.Forms.Button SMdelete;
        private System.Windows.Forms.Button SMupdate;
        private System.Windows.Forms.NumericUpDown numericMCOUNT;
        private System.Windows.Forms.NumericUpDown numericMDuration;
        private System.Windows.Forms.ComboBox MBoxLecture;
        private System.Windows.Forms.ComboBox MBoxtag;
        private System.Windows.Forms.ComboBox MBoxName;
        private System.Windows.Forms.ComboBox MBoxGroup;
        private System.Windows.Forms.ComboBox MBoxCode;
        private System.Windows.Forms.Label SDuration;
        private System.Windows.Forms.Label Scount;
        private System.Windows.Forms.Label SMSC;
        private System.Windows.Forms.Label SName;
        private System.Windows.Forms.Label Sgroup;
        private System.Windows.Forms.Label SMT;
        private System.Windows.Forms.Label MSL;
        private System.Windows.Forms.Label sessionM;
        private System.Windows.Forms.Label txtend;
        private System.Windows.Forms.Label txtstart;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.TextBox start;
        private System.Windows.Forms.Label Mstart;
        private System.Windows.Forms.Label MEnd;
        private System.Windows.Forms.TextBox MBoxEnd;
        private System.Windows.Forms.TextBox MBoxstart;
        private System.Windows.Forms.ComboBox SBoxDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label MDay;
        private System.Windows.Forms.ComboBox MBoxDay;
        private System.Windows.Forms.Button backhomesession;
        private System.Windows.Forms.Button backhomeS2;
        private System.Windows.Forms.Button backhome2;
    }
}