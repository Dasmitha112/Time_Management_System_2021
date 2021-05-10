namespace Time_Management_System_2021.Lecturers
{
    partial class AddLecturerForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ltab1 = new System.Windows.Forms.TabPage();
            this.Lsave = new System.Windows.Forms.Button();
            this.Lclear = new System.Windows.Forms.Button();
            this.deptBox = new System.Windows.Forms.ComboBox();
            this.levelbox = new System.Windows.Forms.ComboBox();
            this.centerBox = new System.Windows.Forms.ComboBox();
            this.Lcenter = new System.Windows.Forms.Label();
            this.Ldepartment = new System.Windows.Forms.Label();
            this.Llevels = new System.Windows.Forms.Label();
            this.Lbuilding = new System.Windows.Forms.Label();
            this.LFaculty = new System.Windows.Forms.Label();
            this.textLname = new System.Windows.Forms.TextBox();
            this.buildingBox = new System.Windows.Forms.ComboBox();
            this.facultybox = new System.Windows.Forms.ComboBox();
            this.LAdd = new System.Windows.Forms.Label();
            this.LName = new System.Windows.Forms.Label();
            this.Ltab2 = new System.Windows.Forms.TabPage();
            this.UPdelete = new System.Windows.Forms.Button();
            this.UPadd = new System.Windows.Forms.Button();
            this.LUPbuildingbox = new System.Windows.Forms.ComboBox();
            this.UPlevel = new System.Windows.Forms.ComboBox();
            this.UPcenter = new System.Windows.Forms.ComboBox();
            this.LUPdeptbox = new System.Windows.Forms.ComboBox();
            this.LUPfacultyBox = new System.Windows.Forms.ComboBox();
            this.updatename = new System.Windows.Forms.TextBox();
            this.LUPfaculty = new System.Windows.Forms.Label();
            this.LUPbuilding = new System.Windows.Forms.Label();
            this.LUPcenter = new System.Windows.Forms.Label();
            this.LUPlevel = new System.Windows.Forms.Label();
            this.LUPdept = new System.Windows.Forms.Label();
            this.LUPname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ltab0 = new System.Windows.Forms.TabPage();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterlevel = new System.Windows.Forms.Label();
            this.searchlecture = new System.Windows.Forms.Label();
            this.filterDepartment = new System.Windows.Forms.Label();
            this.SearchLevel = new System.Windows.Forms.ComboBox();
            this.SearchDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addLecturerFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addLecturerFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.Ltab1.SuspendLayout();
            this.Ltab2.SuspendLayout();
            this.Ltab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ltab0);
            this.tabControl1.Controls.Add(this.Ltab1);
            this.tabControl1.Controls.Add(this.Ltab2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(868, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // Ltab1
            // 
            this.Ltab1.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.Ltab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab1.Controls.Add(this.Lsave);
            this.Ltab1.Controls.Add(this.Lclear);
            this.Ltab1.Controls.Add(this.deptBox);
            this.Ltab1.Controls.Add(this.levelbox);
            this.Ltab1.Controls.Add(this.centerBox);
            this.Ltab1.Controls.Add(this.Lcenter);
            this.Ltab1.Controls.Add(this.Ldepartment);
            this.Ltab1.Controls.Add(this.Llevels);
            this.Ltab1.Controls.Add(this.Lbuilding);
            this.Ltab1.Controls.Add(this.LFaculty);
            this.Ltab1.Controls.Add(this.textLname);
            this.Ltab1.Controls.Add(this.buildingBox);
            this.Ltab1.Controls.Add(this.facultybox);
            this.Ltab1.Controls.Add(this.LAdd);
            this.Ltab1.Controls.Add(this.LName);
            this.Ltab1.Location = new System.Drawing.Point(4, 22);
            this.Ltab1.Name = "Ltab1";
            this.Ltab1.Padding = new System.Windows.Forms.Padding(3);
            this.Ltab1.Size = new System.Drawing.Size(860, 423);
            this.Ltab1.TabIndex = 1;
            this.Ltab1.Text = "Add lecturers Details";
            this.Ltab1.UseVisualStyleBackColor = true;
            // 
            // Lsave
            // 
            this.Lsave.Location = new System.Drawing.Point(282, 342);
            this.Lsave.Name = "Lsave";
            this.Lsave.Size = new System.Drawing.Size(90, 38);
            this.Lsave.TabIndex = 17;
            this.Lsave.Text = "ADD";
            this.Lsave.UseVisualStyleBackColor = true;
            this.Lsave.Click += new System.EventHandler(this.Lsave_Click);
            // 
            // Lclear
            // 
            this.Lclear.Location = new System.Drawing.Point(421, 342);
            this.Lclear.Name = "Lclear";
            this.Lclear.Size = new System.Drawing.Size(90, 38);
            this.Lclear.TabIndex = 16;
            this.Lclear.Text = "Clear";
            this.Lclear.UseVisualStyleBackColor = true;
            this.Lclear.Click += new System.EventHandler(this.Lclear_Click);
            // 
            // deptBox
            // 
            this.deptBox.FormattingEnabled = true;
            this.deptBox.Items.AddRange(new object[] {
            "SE",
            "IT",
            "CN",
            "Cyber Sequrity",
            "BM"});
            this.deptBox.Location = new System.Drawing.Point(88, 198);
            this.deptBox.Name = "deptBox";
            this.deptBox.Size = new System.Drawing.Size(196, 21);
            this.deptBox.TabIndex = 14;
            this.deptBox.Text = "Select Department";
            // 
            // levelbox
            // 
            this.levelbox.FormattingEnabled = true;
            this.levelbox.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.levelbox.Location = new System.Drawing.Point(508, 273);
            this.levelbox.Name = "levelbox";
            this.levelbox.Size = new System.Drawing.Size(196, 21);
            this.levelbox.TabIndex = 13;
            this.levelbox.Text = "Select Level";
            this.levelbox.SelectedIndexChanged += new System.EventHandler(this.levelbox_SelectedIndexChanged);
            // 
            // centerBox
            // 
            this.centerBox.FormattingEnabled = true;
            this.centerBox.Items.AddRange(new object[] {
            "Malabe",
            "Metro"});
            this.centerBox.Location = new System.Drawing.Point(88, 273);
            this.centerBox.Name = "centerBox";
            this.centerBox.Size = new System.Drawing.Size(196, 21);
            this.centerBox.TabIndex = 12;
            this.centerBox.Text = "Select Center";
            // 
            // Lcenter
            // 
            this.Lcenter.AutoSize = true;
            this.Lcenter.Location = new System.Drawing.Point(85, 238);
            this.Lcenter.Name = "Lcenter";
            this.Lcenter.Size = new System.Drawing.Size(38, 13);
            this.Lcenter.TabIndex = 11;
            this.Lcenter.Text = "Center";
            // 
            // Ldepartment
            // 
            this.Ldepartment.AutoSize = true;
            this.Ldepartment.Location = new System.Drawing.Point(85, 170);
            this.Ldepartment.Name = "Ldepartment";
            this.Ldepartment.Size = new System.Drawing.Size(62, 13);
            this.Ldepartment.TabIndex = 10;
            this.Ldepartment.Text = "Department";
            // 
            // Llevels
            // 
            this.Llevels.AutoSize = true;
            this.Llevels.Location = new System.Drawing.Point(505, 238);
            this.Llevels.Name = "Llevels";
            this.Llevels.Size = new System.Drawing.Size(38, 13);
            this.Llevels.TabIndex = 9;
            this.Llevels.Text = "Levels";
            // 
            // Lbuilding
            // 
            this.Lbuilding.AutoSize = true;
            this.Lbuilding.Location = new System.Drawing.Point(505, 170);
            this.Lbuilding.Name = "Lbuilding";
            this.Lbuilding.Size = new System.Drawing.Size(44, 13);
            this.Lbuilding.TabIndex = 8;
            this.Lbuilding.Text = "Building";
            // 
            // LFaculty
            // 
            this.LFaculty.AutoSize = true;
            this.LFaculty.Location = new System.Drawing.Point(505, 98);
            this.LFaculty.Name = "LFaculty";
            this.LFaculty.Size = new System.Drawing.Size(41, 13);
            this.LFaculty.TabIndex = 7;
            this.LFaculty.Text = "Faculty";
            this.LFaculty.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(88, 127);
            this.textLname.Name = "textLname";
            this.textLname.Size = new System.Drawing.Size(196, 20);
            this.textLname.TabIndex = 6;
            this.textLname.TextChanged += new System.EventHandler(this.textLname_TextChanged);
            // 
            // buildingBox
            // 
            this.buildingBox.FormattingEnabled = true;
            this.buildingBox.Items.AddRange(new object[] {
            "New Building",
            "Main Building"});
            this.buildingBox.Location = new System.Drawing.Point(508, 198);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(196, 21);
            this.buildingBox.TabIndex = 5;
            this.buildingBox.Text = "Select Building";
            // 
            // facultybox
            // 
            this.facultybox.FormattingEnabled = true;
            this.facultybox.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Bussiness",
            "Faculty Of Humanties",
            "Faculty Of Engineering"});
            this.facultybox.Location = new System.Drawing.Point(508, 126);
            this.facultybox.Name = "facultybox";
            this.facultybox.Size = new System.Drawing.Size(196, 21);
            this.facultybox.TabIndex = 4;
            this.facultybox.Text = "Select Faculty";
            // 
            // LAdd
            // 
            this.LAdd.AutoSize = true;
            this.LAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdd.Location = new System.Drawing.Point(354, 36);
            this.LAdd.Name = "LAdd";
            this.LAdd.Size = new System.Drawing.Size(128, 20);
            this.LAdd.TabIndex = 3;
            this.LAdd.Text = "ADD Lecturers";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(85, 98);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(54, 13);
            this.LName.TabIndex = 2;
            this.LName.Text = "Full Name";
            // 
            // Ltab2
            // 
            this.Ltab2.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.Ltab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab2.Controls.Add(this.UPdelete);
            this.Ltab2.Controls.Add(this.UPadd);
            this.Ltab2.Controls.Add(this.LUPbuildingbox);
            this.Ltab2.Controls.Add(this.UPlevel);
            this.Ltab2.Controls.Add(this.UPcenter);
            this.Ltab2.Controls.Add(this.LUPdeptbox);
            this.Ltab2.Controls.Add(this.LUPfacultyBox);
            this.Ltab2.Controls.Add(this.updatename);
            this.Ltab2.Controls.Add(this.LUPfaculty);
            this.Ltab2.Controls.Add(this.LUPbuilding);
            this.Ltab2.Controls.Add(this.LUPcenter);
            this.Ltab2.Controls.Add(this.LUPlevel);
            this.Ltab2.Controls.Add(this.LUPdept);
            this.Ltab2.Controls.Add(this.LUPname);
            this.Ltab2.Controls.Add(this.label1);
            this.Ltab2.Location = new System.Drawing.Point(4, 22);
            this.Ltab2.Name = "Ltab2";
            this.Ltab2.Size = new System.Drawing.Size(860, 423);
            this.Ltab2.TabIndex = 2;
            this.Ltab2.Text = "Manage Details";
            this.Ltab2.UseVisualStyleBackColor = true;
            // 
            // UPdelete
            // 
            this.UPdelete.Location = new System.Drawing.Point(434, 353);
            this.UPdelete.Name = "UPdelete";
            this.UPdelete.Size = new System.Drawing.Size(90, 38);
            this.UPdelete.TabIndex = 19;
            this.UPdelete.Text = "Delete";
            this.UPdelete.UseVisualStyleBackColor = true;
            this.UPdelete.Click += new System.EventHandler(this.UPdelete_Click);
            // 
            // UPadd
            // 
            this.UPadd.Location = new System.Drawing.Point(298, 353);
            this.UPadd.Name = "UPadd";
            this.UPadd.Size = new System.Drawing.Size(90, 38);
            this.UPadd.TabIndex = 18;
            this.UPadd.Text = "Update";
            this.UPadd.UseVisualStyleBackColor = true;
            this.UPadd.Click += new System.EventHandler(this.UPadd_Click);
            // 
            // LUPbuildingbox
            // 
            this.LUPbuildingbox.FormattingEnabled = true;
            this.LUPbuildingbox.Items.AddRange(new object[] {
            "New Building",
            "Main Building"});
            this.LUPbuildingbox.Location = new System.Drawing.Point(486, 209);
            this.LUPbuildingbox.Name = "LUPbuildingbox";
            this.LUPbuildingbox.Size = new System.Drawing.Size(196, 21);
            this.LUPbuildingbox.TabIndex = 12;
            // 
            // UPlevel
            // 
            this.UPlevel.FormattingEnabled = true;
            this.UPlevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.UPlevel.Location = new System.Drawing.Point(486, 294);
            this.UPlevel.Name = "UPlevel";
            this.UPlevel.Size = new System.Drawing.Size(196, 21);
            this.UPlevel.TabIndex = 11;
            this.UPlevel.SelectedIndexChanged += new System.EventHandler(this.UPlevel_SelectedIndexChanged);
            // 
            // UPcenter
            // 
            this.UPcenter.FormattingEnabled = true;
            this.UPcenter.Items.AddRange(new object[] {
            "Malabe",
            "Metro"});
            this.UPcenter.Location = new System.Drawing.Point(116, 294);
            this.UPcenter.Name = "UPcenter";
            this.UPcenter.Size = new System.Drawing.Size(196, 21);
            this.UPcenter.TabIndex = 10;
            // 
            // LUPdeptbox
            // 
            this.LUPdeptbox.FormattingEnabled = true;
            this.LUPdeptbox.Items.AddRange(new object[] {
            "SE",
            "IT",
            "CN",
            "Cyber Sequrity",
            "BM"});
            this.LUPdeptbox.Location = new System.Drawing.Point(116, 209);
            this.LUPdeptbox.Name = "LUPdeptbox";
            this.LUPdeptbox.Size = new System.Drawing.Size(196, 21);
            this.LUPdeptbox.TabIndex = 9;
            // 
            // LUPfacultyBox
            // 
            this.LUPfacultyBox.FormattingEnabled = true;
            this.LUPfacultyBox.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Bussiness",
            "Faculty Of Humanties",
            "Faculty Of Engineering"});
            this.LUPfacultyBox.Location = new System.Drawing.Point(486, 129);
            this.LUPfacultyBox.Name = "LUPfacultyBox";
            this.LUPfacultyBox.Size = new System.Drawing.Size(196, 21);
            this.LUPfacultyBox.TabIndex = 8;
            // 
            // updatename
            // 
            this.updatename.Location = new System.Drawing.Point(116, 129);
            this.updatename.Name = "updatename";
            this.updatename.Size = new System.Drawing.Size(196, 20);
            this.updatename.TabIndex = 7;
            this.updatename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LUPfaculty
            // 
            this.LUPfaculty.AutoSize = true;
            this.LUPfaculty.Location = new System.Drawing.Point(483, 113);
            this.LUPfaculty.Name = "LUPfaculty";
            this.LUPfaculty.Size = new System.Drawing.Size(41, 13);
            this.LUPfaculty.TabIndex = 6;
            this.LUPfaculty.Text = "Faculty";
            // 
            // LUPbuilding
            // 
            this.LUPbuilding.AutoSize = true;
            this.LUPbuilding.Location = new System.Drawing.Point(483, 193);
            this.LUPbuilding.Name = "LUPbuilding";
            this.LUPbuilding.Size = new System.Drawing.Size(44, 13);
            this.LUPbuilding.TabIndex = 5;
            this.LUPbuilding.Text = "Building";
            // 
            // LUPcenter
            // 
            this.LUPcenter.AutoSize = true;
            this.LUPcenter.Location = new System.Drawing.Point(113, 278);
            this.LUPcenter.Name = "LUPcenter";
            this.LUPcenter.Size = new System.Drawing.Size(38, 13);
            this.LUPcenter.TabIndex = 4;
            this.LUPcenter.Text = "Center";
            // 
            // LUPlevel
            // 
            this.LUPlevel.AutoSize = true;
            this.LUPlevel.Location = new System.Drawing.Point(486, 278);
            this.LUPlevel.Name = "LUPlevel";
            this.LUPlevel.Size = new System.Drawing.Size(38, 13);
            this.LUPlevel.TabIndex = 3;
            this.LUPlevel.Text = "Levels";
            this.LUPlevel.Click += new System.EventHandler(this.label4_Click);
            // 
            // LUPdept
            // 
            this.LUPdept.AutoSize = true;
            this.LUPdept.Location = new System.Drawing.Point(113, 193);
            this.LUPdept.Name = "LUPdept";
            this.LUPdept.Size = new System.Drawing.Size(62, 13);
            this.LUPdept.TabIndex = 2;
            this.LUPdept.Text = "Department";
            // 
            // LUPname
            // 
            this.LUPname.AutoSize = true;
            this.LUPname.Location = new System.Drawing.Point(113, 113);
            this.LUPname.Name = "LUPname";
            this.LUPname.Size = new System.Drawing.Size(54, 13);
            this.LUPname.TabIndex = 1;
            this.LUPname.Text = "Full Name";
            this.LUPname.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Lecturer Details";
            // 
            // Ltab0
            // 
            this.Ltab0.BackColor = System.Drawing.Color.Transparent;
            this.Ltab0.BackgroundImage = global::Time_Management_System_2021.Properties.Resources._22;
            this.Ltab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab0.Controls.Add(this.SearchName);
            this.Ltab0.Controls.Add(this.dataGridView1);
            this.Ltab0.Controls.Add(this.filterlevel);
            this.Ltab0.Controls.Add(this.searchlecture);
            this.Ltab0.Controls.Add(this.filterDepartment);
            this.Ltab0.Controls.Add(this.SearchLevel);
            this.Ltab0.Controls.Add(this.SearchDept);
            this.Ltab0.Controls.Add(this.label2);
            this.Ltab0.Location = new System.Drawing.Point(4, 22);
            this.Ltab0.Name = "Ltab0";
            this.Ltab0.Padding = new System.Windows.Forms.Padding(3);
            this.Ltab0.Size = new System.Drawing.Size(860, 423);
            this.Ltab0.TabIndex = 0;
            this.Ltab0.Text = "View Lecturers Details";
            this.Ltab0.Click += new System.EventHandler(this.Ltab0_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(687, 69);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(144, 20);
            this.SearchName.TabIndex = 8;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // filterlevel
            // 
            this.filterlevel.AutoSize = true;
            this.filterlevel.Location = new System.Drawing.Point(316, 76);
            this.filterlevel.Name = "filterlevel";
            this.filterlevel.Size = new System.Drawing.Size(73, 13);
            this.filterlevel.TabIndex = 6;
            this.filterlevel.Text = "Filter By Level";
            // 
            // searchlecture
            // 
            this.searchlecture.AutoSize = true;
            this.searchlecture.Location = new System.Drawing.Point(582, 76);
            this.searchlecture.Name = "searchlecture";
            this.searchlecture.Size = new System.Drawing.Size(87, 13);
            this.searchlecture.TabIndex = 5;
            this.searchlecture.Text = "Search By Name";
            this.searchlecture.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // filterDepartment
            // 
            this.filterDepartment.AutoSize = true;
            this.filterDepartment.Location = new System.Drawing.Point(39, 76);
            this.filterDepartment.Name = "filterDepartment";
            this.filterDepartment.Size = new System.Drawing.Size(102, 13);
            this.filterDepartment.TabIndex = 4;
            this.filterDepartment.Text = "Filter By Department";
            // 
            // SearchLevel
            // 
            this.SearchLevel.FormattingEnabled = true;
            this.SearchLevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer"});
            this.SearchLevel.Location = new System.Drawing.Point(395, 73);
            this.SearchLevel.Name = "SearchLevel";
            this.SearchLevel.Size = new System.Drawing.Size(170, 21);
            this.SearchLevel.TabIndex = 3;
            this.SearchLevel.SelectedIndexChanged += new System.EventHandler(this.SearchLevel_SelectedIndexChanged);
            // 
            // SearchDept
            // 
            this.SearchDept.FormattingEnabled = true;
            this.SearchDept.Items.AddRange(new object[] {
            "IT",
            "SE",
            "CN",
            "IM",
            "Cyber Sequrity"});
            this.SearchDept.Location = new System.Drawing.Point(141, 73);
            this.SearchDept.Name = "SearchDept";
            this.SearchDept.Size = new System.Drawing.Size(169, 21);
            this.SearchDept.TabIndex = 2;
            this.SearchDept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Details";
            // 
            // addLecturerFormBindingSource
            // 
            this.addLecturerFormBindingSource.DataSource = typeof(Time_Management_System_2021.Lecturers.AddLecturerForm);
            // 
            // addLecturerFormBindingSource1
            // 
            this.addLecturerFormBindingSource1.DataSource = typeof(Time_Management_System_2021.Lecturers.AddLecturerForm);
            // 
            // AddLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddLecturerForm";
            this.tabControl1.ResumeLayout(false);
            this.Ltab1.ResumeLayout(false);
            this.Ltab1.PerformLayout();
            this.Ltab2.ResumeLayout(false);
            this.Ltab2.PerformLayout();
            this.Ltab0.ResumeLayout(false);
            this.Ltab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Ltab0;
        private System.Windows.Forms.TabPage Ltab1;
        private System.Windows.Forms.TabPage Ltab2;
        private System.Windows.Forms.TextBox textLname;
        private System.Windows.Forms.ComboBox buildingBox;
        private System.Windows.Forms.ComboBox facultybox;
        private System.Windows.Forms.Label LAdd;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label Lcenter;
        private System.Windows.Forms.Label Ldepartment;
        private System.Windows.Forms.Label Llevels;
        private System.Windows.Forms.Label Lbuilding;
        private System.Windows.Forms.Label LFaculty;
        private System.Windows.Forms.ComboBox deptBox;
        private System.Windows.Forms.ComboBox levelbox;
        private System.Windows.Forms.ComboBox centerBox;
        private System.Windows.Forms.Button Lsave;
        private System.Windows.Forms.Button Lclear;
        private System.Windows.Forms.Label LUPfaculty;
        private System.Windows.Forms.Label LUPbuilding;
        private System.Windows.Forms.Label LUPcenter;
        private System.Windows.Forms.Label LUPlevel;
        private System.Windows.Forms.Label LUPdept;
        private System.Windows.Forms.Label LUPname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UPdelete;
        private System.Windows.Forms.Button UPadd;
        private System.Windows.Forms.Label filterlevel;
        private System.Windows.Forms.Label searchlecture;
        private System.Windows.Forms.Label filterDepartment;
        private System.Windows.Forms.ComboBox SearchLevel;
        private System.Windows.Forms.ComboBox SearchDept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox LUPbuildingbox;
        public System.Windows.Forms.ComboBox UPlevel;
        public System.Windows.Forms.ComboBox UPcenter;
        public System.Windows.Forms.ComboBox LUPdeptbox;
        public System.Windows.Forms.ComboBox LUPfacultyBox;
        public System.Windows.Forms.TextBox updatename;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.BindingSource addLecturerFormBindingSource;
        private System.Windows.Forms.BindingSource addLecturerFormBindingSource1;
    }
}