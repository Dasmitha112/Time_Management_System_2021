namespace Time_Management_System_2021.Subjects
{
    partial class AddSubjectForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabSubjectview = new System.Windows.Forms.TabPage();
            this.dataGridViewSubject = new System.Windows.Forms.DataGridView();
            this.FilterName = new System.Windows.Forms.TextBox();
            this.FilterYear = new System.Windows.Forms.ComboBox();
            this.SFilterName = new System.Windows.Forms.Label();
            this.SFilterYear = new System.Windows.Forms.Label();
            this.Sview = new System.Windows.Forms.Label();
            this.tabAddSubject = new System.Windows.Forms.TabPage();
            this.SEHBox = new System.Windows.Forms.ComboBox();
            this.SLabHBox = new System.Windows.Forms.ComboBox();
            this.STHBox = new System.Windows.Forms.ComboBox();
            this.Bclear = new System.Windows.Forms.Button();
            this.Badd = new System.Windows.Forms.Button();
            this.SLHBox = new System.Windows.Forms.ComboBox();
            this.SsemesterBox = new System.Windows.Forms.ComboBox();
            this.Tkey = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.Slab = new System.Windows.Forms.Label();
            this.Stutorial = new System.Windows.Forms.Label();
            this.Shours = new System.Windows.Forms.Label();
            this.Sviva = new System.Windows.Forms.Label();
            this.Ssemester = new System.Windows.Forms.Label();
            this.Skey = new System.Windows.Forms.Label();
            this.Sname = new System.Windows.Forms.Label();
            this.SyearBox = new System.Windows.Forms.ComboBox();
            this.Syear = new System.Windows.Forms.Label();
            this.SAdd = new System.Windows.Forms.Label();
            this.tabManageSubject = new System.Windows.Forms.TabPage();
            this.Sdelete = new System.Windows.Forms.Button();
            this.Supdate = new System.Windows.Forms.Button();
            this.SUPNametext = new System.Windows.Forms.TextBox();
            this.SUPSemesterBox = new System.Windows.Forms.ComboBox();
            this.SUPsemester = new System.Windows.Forms.Label();
            this.SUPTHBox = new System.Windows.Forms.ComboBox();
            this.SUPLabHBox = new System.Windows.Forms.ComboBox();
            this.SUPVivaHBox = new System.Windows.Forms.ComboBox();
            this.SUPKeyText = new System.Windows.Forms.TextBox();
            this.SUPLHBox = new System.Windows.Forms.ComboBox();
            this.SUPYearBox = new System.Windows.Forms.ComboBox();
            this.SUPVivaHours = new System.Windows.Forms.Label();
            this.SUPLabHours = new System.Windows.Forms.Label();
            this.SUPTutorialHours = new System.Windows.Forms.Label();
            this.SUPLectureHours = new System.Windows.Forms.Label();
            this.SUPkey = new System.Windows.Forms.Label();
            this.SUPname = new System.Windows.Forms.Label();
            this.SUPyear = new System.Windows.Forms.Label();
            this.Sup = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.TabSubjectview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).BeginInit();
            this.tabAddSubject.SuspendLayout();
            this.tabManageSubject.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabSubjectview);
            this.tabControl1.Controls.Add(this.tabAddSubject);
            this.tabControl1.Controls.Add(this.tabManageSubject);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // TabSubjectview
            // 
            this.TabSubjectview.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.TabSubjectview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabSubjectview.Controls.Add(this.dataGridViewSubject);
            this.TabSubjectview.Controls.Add(this.FilterName);
            this.TabSubjectview.Controls.Add(this.FilterYear);
            this.TabSubjectview.Controls.Add(this.SFilterName);
            this.TabSubjectview.Controls.Add(this.SFilterYear);
            this.TabSubjectview.Controls.Add(this.Sview);
            this.TabSubjectview.Location = new System.Drawing.Point(4, 22);
            this.TabSubjectview.Name = "TabSubjectview";
            this.TabSubjectview.Padding = new System.Windows.Forms.Padding(3);
            this.TabSubjectview.Size = new System.Drawing.Size(796, 424);
            this.TabSubjectview.TabIndex = 0;
            this.TabSubjectview.Text = "View Subjects";
            this.TabSubjectview.UseVisualStyleBackColor = true;
            this.TabSubjectview.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridViewSubject
            // 
            this.dataGridViewSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubject.Location = new System.Drawing.Point(9, 164);
            this.dataGridViewSubject.Name = "dataGridViewSubject";
            this.dataGridViewSubject.Size = new System.Drawing.Size(780, 150);
            this.dataGridViewSubject.TabIndex = 6;
            this.dataGridViewSubject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubject_CellClick);
            this.dataGridViewSubject.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubject_CellContentClick);
            this.dataGridViewSubject.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSubject_CellDoubleClick);
            // 
            // FilterName
            // 
            this.FilterName.Location = new System.Drawing.Point(567, 109);
            this.FilterName.Name = "FilterName";
            this.FilterName.Size = new System.Drawing.Size(120, 20);
            this.FilterName.TabIndex = 5;
            this.FilterName.TextChanged += new System.EventHandler(this.FilterName_TextChanged);
            // 
            // FilterYear
            // 
            this.FilterYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterYear.FormattingEnabled = true;
            this.FilterYear.Items.AddRange(new object[] {
            "1 Year",
            "2  Year",
            "3  Year",
            "4  Year"});
            this.FilterYear.Location = new System.Drawing.Point(167, 109);
            this.FilterYear.Name = "FilterYear";
            this.FilterYear.Size = new System.Drawing.Size(121, 21);
            this.FilterYear.TabIndex = 4;
            this.FilterYear.SelectedIndexChanged += new System.EventHandler(this.FilterYear_SelectedIndexChanged);
            // 
            // SFilterName
            // 
            this.SFilterName.AutoSize = true;
            this.SFilterName.Location = new System.Drawing.Point(422, 112);
            this.SFilterName.Name = "SFilterName";
            this.SFilterName.Size = new System.Drawing.Size(126, 13);
            this.SFilterName.TabIndex = 3;
            this.SFilterName.Text = "Search By Subject Name";
            // 
            // SFilterYear
            // 
            this.SFilterYear.AutoSize = true;
            this.SFilterYear.Location = new System.Drawing.Point(92, 112);
            this.SFilterYear.Name = "SFilterYear";
            this.SFilterYear.Size = new System.Drawing.Size(69, 13);
            this.SFilterYear.TabIndex = 2;
            this.SFilterYear.Text = "Filter By Year";
            // 
            // Sview
            // 
            this.Sview.AutoSize = true;
            this.Sview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sview.Location = new System.Drawing.Point(321, 29);
            this.Sview.Name = "Sview";
            this.Sview.Size = new System.Drawing.Size(122, 20);
            this.Sview.TabIndex = 0;
            this.Sview.Text = "View Subjects";
            // 
            // tabAddSubject
            // 
            this.tabAddSubject.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.tabAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabAddSubject.Controls.Add(this.SEHBox);
            this.tabAddSubject.Controls.Add(this.SLabHBox);
            this.tabAddSubject.Controls.Add(this.STHBox);
            this.tabAddSubject.Controls.Add(this.Bclear);
            this.tabAddSubject.Controls.Add(this.Badd);
            this.tabAddSubject.Controls.Add(this.SLHBox);
            this.tabAddSubject.Controls.Add(this.SsemesterBox);
            this.tabAddSubject.Controls.Add(this.Tkey);
            this.tabAddSubject.Controls.Add(this.Tname);
            this.tabAddSubject.Controls.Add(this.Slab);
            this.tabAddSubject.Controls.Add(this.Stutorial);
            this.tabAddSubject.Controls.Add(this.Shours);
            this.tabAddSubject.Controls.Add(this.Sviva);
            this.tabAddSubject.Controls.Add(this.Ssemester);
            this.tabAddSubject.Controls.Add(this.Skey);
            this.tabAddSubject.Controls.Add(this.Sname);
            this.tabAddSubject.Controls.Add(this.SyearBox);
            this.tabAddSubject.Controls.Add(this.Syear);
            this.tabAddSubject.Controls.Add(this.SAdd);
            this.tabAddSubject.Location = new System.Drawing.Point(4, 22);
            this.tabAddSubject.Name = "tabAddSubject";
            this.tabAddSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddSubject.Size = new System.Drawing.Size(796, 424);
            this.tabAddSubject.TabIndex = 1;
            this.tabAddSubject.Text = "Add Subject";
            this.tabAddSubject.UseVisualStyleBackColor = true;
            // 
            // SEHBox
            // 
            this.SEHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SEHBox.FormattingEnabled = true;
            this.SEHBox.Items.AddRange(new object[] {
            "0 Hour",
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SEHBox.Location = new System.Drawing.Point(672, 327);
            this.SEHBox.Name = "SEHBox";
            this.SEHBox.Size = new System.Drawing.Size(62, 21);
            this.SEHBox.TabIndex = 28;
            // 
            // SLabHBox
            // 
            this.SLabHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SLabHBox.FormattingEnabled = true;
            this.SLabHBox.Items.AddRange(new object[] {
            "0 Hour",
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SLabHBox.Location = new System.Drawing.Point(484, 327);
            this.SLabHBox.Name = "SLabHBox";
            this.SLabHBox.Size = new System.Drawing.Size(62, 21);
            this.SLabHBox.TabIndex = 27;
            // 
            // STHBox
            // 
            this.STHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.STHBox.FormattingEnabled = true;
            this.STHBox.Items.AddRange(new object[] {
            "0 Hour",
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.STHBox.Location = new System.Drawing.Point(306, 326);
            this.STHBox.Name = "STHBox";
            this.STHBox.Size = new System.Drawing.Size(62, 21);
            this.STHBox.TabIndex = 26;
            this.STHBox.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // Bclear
            // 
            this.Bclear.Location = new System.Drawing.Point(484, 380);
            this.Bclear.Name = "Bclear";
            this.Bclear.Size = new System.Drawing.Size(103, 35);
            this.Bclear.TabIndex = 25;
            this.Bclear.Text = "Clear";
            this.Bclear.UseVisualStyleBackColor = true;
            // 
            // Badd
            // 
            this.Badd.Location = new System.Drawing.Point(265, 380);
            this.Badd.Name = "Badd";
            this.Badd.Size = new System.Drawing.Size(103, 35);
            this.Badd.TabIndex = 24;
            this.Badd.Text = "Add";
            this.Badd.UseVisualStyleBackColor = true;
            this.Badd.Click += new System.EventHandler(this.Badd_Click);
            // 
            // SLHBox
            // 
            this.SLHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SLHBox.FormattingEnabled = true;
            this.SLHBox.Items.AddRange(new object[] {
            "0 Hour",
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SLHBox.Location = new System.Drawing.Point(115, 326);
            this.SLHBox.Name = "SLHBox";
            this.SLHBox.Size = new System.Drawing.Size(62, 21);
            this.SLHBox.TabIndex = 23;
            // 
            // SsemesterBox
            // 
            this.SsemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SsemesterBox.FormattingEnabled = true;
            this.SsemesterBox.Items.AddRange(new object[] {
            "1 Semester",
            "2 Semester"});
            this.SsemesterBox.Location = new System.Drawing.Point(314, 279);
            this.SsemesterBox.Name = "SsemesterBox";
            this.SsemesterBox.Size = new System.Drawing.Size(179, 21);
            this.SsemesterBox.TabIndex = 16;
            // 
            // Tkey
            // 
            this.Tkey.Location = new System.Drawing.Point(314, 227);
            this.Tkey.Name = "Tkey";
            this.Tkey.Size = new System.Drawing.Size(179, 20);
            this.Tkey.TabIndex = 15;
            this.Tkey.Text = "Enter Subject Key";
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(314, 172);
            this.Tname.Name = "Tname";
            this.Tname.Size = new System.Drawing.Size(179, 20);
            this.Tname.TabIndex = 12;
            this.Tname.Text = "Enter Name";
            // 
            // Slab
            // 
            this.Slab.AutoSize = true;
            this.Slab.Location = new System.Drawing.Point(422, 330);
            this.Slab.Name = "Slab";
            this.Slab.Size = new System.Drawing.Size(56, 13);
            this.Slab.TabIndex = 11;
            this.Slab.Text = "Lab Hours";
            // 
            // Stutorial
            // 
            this.Stutorial.AutoSize = true;
            this.Stutorial.Location = new System.Drawing.Point(227, 330);
            this.Stutorial.Name = "Stutorial";
            this.Stutorial.Size = new System.Drawing.Size(73, 13);
            this.Stutorial.TabIndex = 10;
            this.Stutorial.Text = "Tutorial Hours";
            // 
            // Shours
            // 
            this.Shours.AutoSize = true;
            this.Shours.Location = new System.Drawing.Point(35, 330);
            this.Shours.Name = "Shours";
            this.Shours.Size = new System.Drawing.Size(74, 13);
            this.Shours.TabIndex = 9;
            this.Shours.Text = "Lecture Hours";
            // 
            // Sviva
            // 
            this.Sviva.AutoSize = true;
            this.Sviva.Location = new System.Drawing.Point(578, 330);
            this.Sviva.Name = "Sviva";
            this.Sviva.Size = new System.Drawing.Size(88, 13);
            this.Sviva.TabIndex = 8;
            this.Sviva.Text = "Evaluation Hours";
            // 
            // Ssemester
            // 
            this.Ssemester.AutoSize = true;
            this.Ssemester.Location = new System.Drawing.Point(311, 263);
            this.Ssemester.Name = "Ssemester";
            this.Ssemester.Size = new System.Drawing.Size(89, 13);
            this.Ssemester.TabIndex = 7;
            this.Ssemester.Text = "Offered Semester";
            this.Ssemester.Click += new System.EventHandler(this.label4_Click);
            // 
            // Skey
            // 
            this.Skey.AutoSize = true;
            this.Skey.Location = new System.Drawing.Point(311, 211);
            this.Skey.Name = "Skey";
            this.Skey.Size = new System.Drawing.Size(64, 13);
            this.Skey.TabIndex = 6;
            this.Skey.Text = "Subject Key";
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(311, 156);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(74, 13);
            this.Sname.TabIndex = 5;
            this.Sname.Text = "Subject Name";
            // 
            // SyearBox
            // 
            this.SyearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SyearBox.FormattingEnabled = true;
            this.SyearBox.Items.AddRange(new object[] {
            "1 Year",
            "2  Year",
            "3  Year",
            "4  Year"});
            this.SyearBox.Location = new System.Drawing.Point(314, 117);
            this.SyearBox.Name = "SyearBox";
            this.SyearBox.Size = new System.Drawing.Size(179, 21);
            this.SyearBox.TabIndex = 4;
            // 
            // Syear
            // 
            this.Syear.AutoSize = true;
            this.Syear.Location = new System.Drawing.Point(311, 101);
            this.Syear.Name = "Syear";
            this.Syear.Size = new System.Drawing.Size(67, 13);
            this.Syear.TabIndex = 3;
            this.Syear.Text = "Offered Year";
            this.Syear.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // SAdd
            // 
            this.SAdd.AutoSize = true;
            this.SAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAdd.Location = new System.Drawing.Point(341, 46);
            this.SAdd.Name = "SAdd";
            this.SAdd.Size = new System.Drawing.Size(107, 20);
            this.SAdd.TabIndex = 1;
            this.SAdd.Text = "Add Subject";
            this.SAdd.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabManageSubject
            // 
            this.tabManageSubject.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.tabManageSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabManageSubject.Controls.Add(this.Sdelete);
            this.tabManageSubject.Controls.Add(this.Supdate);
            this.tabManageSubject.Controls.Add(this.SUPNametext);
            this.tabManageSubject.Controls.Add(this.SUPSemesterBox);
            this.tabManageSubject.Controls.Add(this.SUPsemester);
            this.tabManageSubject.Controls.Add(this.SUPTHBox);
            this.tabManageSubject.Controls.Add(this.SUPLabHBox);
            this.tabManageSubject.Controls.Add(this.SUPVivaHBox);
            this.tabManageSubject.Controls.Add(this.SUPKeyText);
            this.tabManageSubject.Controls.Add(this.SUPLHBox);
            this.tabManageSubject.Controls.Add(this.SUPYearBox);
            this.tabManageSubject.Controls.Add(this.SUPVivaHours);
            this.tabManageSubject.Controls.Add(this.SUPLabHours);
            this.tabManageSubject.Controls.Add(this.SUPTutorialHours);
            this.tabManageSubject.Controls.Add(this.SUPLectureHours);
            this.tabManageSubject.Controls.Add(this.SUPkey);
            this.tabManageSubject.Controls.Add(this.SUPname);
            this.tabManageSubject.Controls.Add(this.SUPyear);
            this.tabManageSubject.Controls.Add(this.Sup);
            this.tabManageSubject.Location = new System.Drawing.Point(4, 22);
            this.tabManageSubject.Name = "tabManageSubject";
            this.tabManageSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageSubject.Size = new System.Drawing.Size(796, 424);
            this.tabManageSubject.TabIndex = 2;
            this.tabManageSubject.Text = "Manage Subject ";
            this.tabManageSubject.UseVisualStyleBackColor = true;
            // 
            // Sdelete
            // 
            this.Sdelete.Location = new System.Drawing.Point(464, 380);
            this.Sdelete.Name = "Sdelete";
            this.Sdelete.Size = new System.Drawing.Size(103, 35);
            this.Sdelete.TabIndex = 39;
            this.Sdelete.Text = "Delete";
            this.Sdelete.UseVisualStyleBackColor = true;
            this.Sdelete.Click += new System.EventHandler(this.Sdelete_Click);
            // 
            // Supdate
            // 
            this.Supdate.Location = new System.Drawing.Point(236, 380);
            this.Supdate.Name = "Supdate";
            this.Supdate.Size = new System.Drawing.Size(103, 35);
            this.Supdate.TabIndex = 38;
            this.Supdate.Text = "Update";
            this.Supdate.UseVisualStyleBackColor = true;
            this.Supdate.Click += new System.EventHandler(this.Supdate_Click);
            // 
            // SUPNametext
            // 
            this.SUPNametext.Location = new System.Drawing.Point(307, 168);
            this.SUPNametext.Name = "SUPNametext";
            this.SUPNametext.Size = new System.Drawing.Size(179, 20);
            this.SUPNametext.TabIndex = 37;
            this.SUPNametext.Text = "Enter Name";
            // 
            // SUPSemesterBox
            // 
            this.SUPSemesterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPSemesterBox.FormattingEnabled = true;
            this.SUPSemesterBox.Items.AddRange(new object[] {
            "1 Semester",
            "2 Semester"});
            this.SUPSemesterBox.Location = new System.Drawing.Point(307, 290);
            this.SUPSemesterBox.Name = "SUPSemesterBox";
            this.SUPSemesterBox.Size = new System.Drawing.Size(179, 21);
            this.SUPSemesterBox.TabIndex = 35;
            // 
            // SUPsemester
            // 
            this.SUPsemester.AutoSize = true;
            this.SUPsemester.Location = new System.Drawing.Point(304, 274);
            this.SUPsemester.Name = "SUPsemester";
            this.SUPsemester.Size = new System.Drawing.Size(89, 13);
            this.SUPsemester.TabIndex = 33;
            this.SUPsemester.Text = "Offered Semester";
            this.SUPsemester.Click += new System.EventHandler(this.label9_Click);
            // 
            // SUPTHBox
            // 
            this.SUPTHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPTHBox.FormattingEnabled = true;
            this.SUPTHBox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SUPTHBox.Location = new System.Drawing.Point(326, 331);
            this.SUPTHBox.Name = "SUPTHBox";
            this.SUPTHBox.Size = new System.Drawing.Size(62, 21);
            this.SUPTHBox.TabIndex = 32;
            // 
            // SUPLabHBox
            // 
            this.SUPLabHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPLabHBox.FormattingEnabled = true;
            this.SUPLabHBox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SUPLabHBox.Location = new System.Drawing.Point(492, 331);
            this.SUPLabHBox.Name = "SUPLabHBox";
            this.SUPLabHBox.Size = new System.Drawing.Size(62, 21);
            this.SUPLabHBox.TabIndex = 31;
            // 
            // SUPVivaHBox
            // 
            this.SUPVivaHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPVivaHBox.FormattingEnabled = true;
            this.SUPVivaHBox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SUPVivaHBox.Location = new System.Drawing.Point(670, 331);
            this.SUPVivaHBox.Name = "SUPVivaHBox";
            this.SUPVivaHBox.Size = new System.Drawing.Size(62, 21);
            this.SUPVivaHBox.TabIndex = 30;
            // 
            // SUPKeyText
            // 
            this.SUPKeyText.Location = new System.Drawing.Point(307, 229);
            this.SUPKeyText.Name = "SUPKeyText";
            this.SUPKeyText.Size = new System.Drawing.Size(179, 20);
            this.SUPKeyText.TabIndex = 28;
            this.SUPKeyText.Text = "Enter Subject key";
            // 
            // SUPLHBox
            // 
            this.SUPLHBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPLHBox.FormattingEnabled = true;
            this.SUPLHBox.Items.AddRange(new object[] {
            "1 Hour",
            "2 Hour",
            "3 Hour"});
            this.SUPLHBox.Location = new System.Drawing.Point(138, 331);
            this.SUPLHBox.Name = "SUPLHBox";
            this.SUPLHBox.Size = new System.Drawing.Size(62, 21);
            this.SUPLHBox.TabIndex = 27;
            // 
            // SUPYearBox
            // 
            this.SUPYearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SUPYearBox.FormattingEnabled = true;
            this.SUPYearBox.Items.AddRange(new object[] {
            "1 Year",
            "2  Year",
            "3  Year",
            "4  Year"});
            this.SUPYearBox.Location = new System.Drawing.Point(307, 110);
            this.SUPYearBox.Name = "SUPYearBox";
            this.SUPYearBox.Size = new System.Drawing.Size(179, 21);
            this.SUPYearBox.TabIndex = 8;
            // 
            // SUPVivaHours
            // 
            this.SUPVivaHours.AutoSize = true;
            this.SUPVivaHours.Location = new System.Drawing.Point(576, 339);
            this.SUPVivaHours.Name = "SUPVivaHours";
            this.SUPVivaHours.Size = new System.Drawing.Size(88, 13);
            this.SUPVivaHours.TabIndex = 7;
            this.SUPVivaHours.Text = "Evaluation Hours";
            // 
            // SUPLabHours
            // 
            this.SUPLabHours.AutoSize = true;
            this.SUPLabHours.Location = new System.Drawing.Point(415, 339);
            this.SUPLabHours.Name = "SUPLabHours";
            this.SUPLabHours.Size = new System.Drawing.Size(56, 13);
            this.SUPLabHours.TabIndex = 6;
            this.SUPLabHours.Text = "Lab Hours";
            // 
            // SUPTutorialHours
            // 
            this.SUPTutorialHours.AutoSize = true;
            this.SUPTutorialHours.Location = new System.Drawing.Point(233, 339);
            this.SUPTutorialHours.Name = "SUPTutorialHours";
            this.SUPTutorialHours.Size = new System.Drawing.Size(73, 13);
            this.SUPTutorialHours.TabIndex = 5;
            this.SUPTutorialHours.Text = "Tutorial Hours";
            // 
            // SUPLectureHours
            // 
            this.SUPLectureHours.AutoSize = true;
            this.SUPLectureHours.Location = new System.Drawing.Point(58, 339);
            this.SUPLectureHours.Name = "SUPLectureHours";
            this.SUPLectureHours.Size = new System.Drawing.Size(74, 13);
            this.SUPLectureHours.TabIndex = 4;
            this.SUPLectureHours.Text = "Lecture Hours";
            // 
            // SUPkey
            // 
            this.SUPkey.AutoSize = true;
            this.SUPkey.Location = new System.Drawing.Point(305, 213);
            this.SUPkey.Name = "SUPkey";
            this.SUPkey.Size = new System.Drawing.Size(64, 13);
            this.SUPkey.TabIndex = 3;
            this.SUPkey.Text = "Subject Key";
            this.SUPkey.Click += new System.EventHandler(this.SUPkey_Click);
            // 
            // SUPname
            // 
            this.SUPname.AutoSize = true;
            this.SUPname.Location = new System.Drawing.Point(304, 152);
            this.SUPname.Name = "SUPname";
            this.SUPname.Size = new System.Drawing.Size(74, 13);
            this.SUPname.TabIndex = 2;
            this.SUPname.Text = "Subject Name";
            // 
            // SUPyear
            // 
            this.SUPyear.AutoSize = true;
            this.SUPyear.Location = new System.Drawing.Point(304, 94);
            this.SUPyear.Name = "SUPyear";
            this.SUPyear.Size = new System.Drawing.Size(65, 13);
            this.SUPyear.TabIndex = 1;
            this.SUPyear.Text = "Offered year";
            // 
            // Sup
            // 
            this.Sup.AutoSize = true;
            this.Sup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sup.Location = new System.Drawing.Point(322, 40);
            this.Sup.Name = "Sup";
            this.Sup.Size = new System.Drawing.Size(139, 20);
            this.Sup.TabIndex = 0;
            this.Sup.Text = "Manage Subject";
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSubjectForm";
            this.tabControl1.ResumeLayout(false);
            this.TabSubjectview.ResumeLayout(false);
            this.TabSubjectview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubject)).EndInit();
            this.tabAddSubject.ResumeLayout(false);
            this.tabAddSubject.PerformLayout();
            this.tabManageSubject.ResumeLayout(false);
            this.tabManageSubject.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabSubjectview;
        private System.Windows.Forms.TabPage tabAddSubject;
        private System.Windows.Forms.TabPage tabManageSubject;
        private System.Windows.Forms.Label Sview;
        private System.Windows.Forms.Label SAdd;
        private System.Windows.Forms.ComboBox SyearBox;
        private System.Windows.Forms.Label Syear;
        private System.Windows.Forms.ComboBox SsemesterBox;
        private System.Windows.Forms.TextBox Tkey;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Label Slab;
        private System.Windows.Forms.Label Stutorial;
        private System.Windows.Forms.Label Shours;
        private System.Windows.Forms.Label Sviva;
        private System.Windows.Forms.Label Ssemester;
        private System.Windows.Forms.Label Skey;
        private System.Windows.Forms.Label Sname;
        private System.Windows.Forms.Button Bclear;
        private System.Windows.Forms.Button Badd;
        private System.Windows.Forms.ComboBox SLHBox;
        private System.Windows.Forms.ComboBox SEHBox;
        private System.Windows.Forms.ComboBox SLabHBox;
        private System.Windows.Forms.ComboBox STHBox;
        private System.Windows.Forms.TextBox SUPNametext;
        private System.Windows.Forms.ComboBox SUPSemesterBox;
        private System.Windows.Forms.Label SUPsemester;
        private System.Windows.Forms.ComboBox SUPTHBox;
        private System.Windows.Forms.ComboBox SUPLabHBox;
        private System.Windows.Forms.ComboBox SUPVivaHBox;
        private System.Windows.Forms.TextBox SUPKeyText;
        private System.Windows.Forms.ComboBox SUPLHBox;
        private System.Windows.Forms.ComboBox SUPYearBox;
        private System.Windows.Forms.Label SUPVivaHours;
        private System.Windows.Forms.Label SUPLabHours;
        private System.Windows.Forms.Label SUPTutorialHours;
        private System.Windows.Forms.Label SUPLectureHours;
        private System.Windows.Forms.Label SUPkey;
        private System.Windows.Forms.Label SUPname;
        private System.Windows.Forms.Label SUPyear;
        private System.Windows.Forms.Label Sup;
        private System.Windows.Forms.Button Sdelete;
        private System.Windows.Forms.Button Supdate;
        private System.Windows.Forms.TextBox FilterName;
        private System.Windows.Forms.ComboBox FilterYear;
        private System.Windows.Forms.Label SFilterName;
        private System.Windows.Forms.Label SFilterYear;
        private System.Windows.Forms.DataGridView dataGridViewSubject;
    }
}