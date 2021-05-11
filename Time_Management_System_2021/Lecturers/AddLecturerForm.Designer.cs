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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLecturerForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Ltab0 = new System.Windows.Forms.TabPage();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterlevel = new System.Windows.Forms.Label();
            this.searchlecture = new System.Windows.Forms.Label();
            this.filterDepartment = new System.Windows.Forms.Label();
            this.SearchLevel = new System.Windows.Forms.ComboBox();
            this.SearchDept = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.backhomeL1 = new System.Windows.Forms.Button();
            this.addLecturerFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addLecturerFormBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.backhomeL2 = new System.Windows.Forms.Button();
            this.backhomeL3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Ltab0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Ltab1.SuspendLayout();
            this.Ltab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addLecturerFormBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Ltab0);
            this.tabControl1.Controls.Add(this.Ltab1);
            this.tabControl1.Controls.Add(this.Ltab2);
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 590);
            this.tabControl1.TabIndex = 0;
            // 
            // Ltab0
            // 
            this.Ltab0.BackColor = System.Drawing.Color.Transparent;
            this.Ltab0.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.Ltab0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab0.Controls.Add(this.backhomeL1);
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
            this.Ltab0.Size = new System.Drawing.Size(974, 564);
            this.Ltab0.TabIndex = 0;
            this.Ltab0.Text = "View Lecturers Details";
            this.Ltab0.Click += new System.EventHandler(this.Ltab0_Click);
            // 
            // SearchName
            // 
            this.SearchName.Location = new System.Drawing.Point(784, 78);
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(144, 20);
            this.SearchName.TabIndex = 8;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 248);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // filterlevel
            // 
            this.filterlevel.AutoSize = true;
            this.filterlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterlevel.Location = new System.Drawing.Point(380, 80);
            this.filterlevel.Name = "filterlevel";
            this.filterlevel.Size = new System.Drawing.Size(99, 18);
            this.filterlevel.TabIndex = 6;
            this.filterlevel.Text = "Filter By Level";
            // 
            // searchlecture
            // 
            this.searchlecture.AutoSize = true;
            this.searchlecture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlecture.Location = new System.Drawing.Point(658, 80);
            this.searchlecture.Name = "searchlecture";
            this.searchlecture.Size = new System.Drawing.Size(120, 18);
            this.searchlecture.TabIndex = 5;
            this.searchlecture.Text = "Search By Name";
            this.searchlecture.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // filterDepartment
            // 
            this.filterDepartment.AutoSize = true;
            this.filterDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterDepartment.Location = new System.Drawing.Point(39, 76);
            this.filterDepartment.Name = "filterDepartment";
            this.filterDepartment.Size = new System.Drawing.Size(142, 18);
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
            this.SearchLevel.Location = new System.Drawing.Point(482, 80);
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
            this.SearchDept.Location = new System.Drawing.Point(187, 77);
            this.SearchDept.Name = "SearchDept";
            this.SearchDept.Size = new System.Drawing.Size(169, 21);
            this.SearchDept.TabIndex = 2;
            this.SearchDept.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(377, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Details";
            // 
            // Ltab1
            // 
            this.Ltab1.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.Ltab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab1.Controls.Add(this.backhomeL2);
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
            this.Ltab1.Size = new System.Drawing.Size(974, 564);
            this.Ltab1.TabIndex = 1;
            this.Ltab1.Text = "Add lecturers Details";
            this.Ltab1.UseVisualStyleBackColor = true;
            // 
            // Lsave
            // 
            this.Lsave.BackColor = System.Drawing.Color.ForestGreen;
            this.Lsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lsave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lsave.Location = new System.Drawing.Point(273, 342);
            this.Lsave.Name = "Lsave";
            this.Lsave.Size = new System.Drawing.Size(150, 60);
            this.Lsave.TabIndex = 17;
            this.Lsave.Text = "ADD";
            this.Lsave.UseVisualStyleBackColor = false;
            this.Lsave.Click += new System.EventHandler(this.Lsave_Click);
            // 
            // Lclear
            // 
            this.Lclear.BackColor = System.Drawing.Color.DarkOrange;
            this.Lclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lclear.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Lclear.Location = new System.Drawing.Point(465, 342);
            this.Lclear.Name = "Lclear";
            this.Lclear.Size = new System.Drawing.Size(150, 60);
            this.Lclear.TabIndex = 16;
            this.Lclear.Text = "Clear";
            this.Lclear.UseVisualStyleBackColor = false;
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
            this.deptBox.Location = new System.Drawing.Point(135, 198);
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
            this.levelbox.Location = new System.Drawing.Point(568, 273);
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
            this.centerBox.Location = new System.Drawing.Point(135, 273);
            this.centerBox.Name = "centerBox";
            this.centerBox.Size = new System.Drawing.Size(196, 21);
            this.centerBox.TabIndex = 12;
            this.centerBox.Text = "Select Center";
            // 
            // Lcenter
            // 
            this.Lcenter.AutoSize = true;
            this.Lcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcenter.Location = new System.Drawing.Point(132, 238);
            this.Lcenter.Name = "Lcenter";
            this.Lcenter.Size = new System.Drawing.Size(52, 18);
            this.Lcenter.TabIndex = 11;
            this.Lcenter.Text = "Center";
            // 
            // Ldepartment
            // 
            this.Ldepartment.AutoSize = true;
            this.Ldepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ldepartment.Location = new System.Drawing.Point(132, 170);
            this.Ldepartment.Name = "Ldepartment";
            this.Ldepartment.Size = new System.Drawing.Size(85, 18);
            this.Ldepartment.TabIndex = 10;
            this.Ldepartment.Text = "Department";
            // 
            // Llevels
            // 
            this.Llevels.AutoSize = true;
            this.Llevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llevels.Location = new System.Drawing.Point(565, 238);
            this.Llevels.Name = "Llevels";
            this.Llevels.Size = new System.Drawing.Size(50, 18);
            this.Llevels.TabIndex = 9;
            this.Llevels.Text = "Levels";
            // 
            // Lbuilding
            // 
            this.Lbuilding.AutoSize = true;
            this.Lbuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuilding.Location = new System.Drawing.Point(565, 170);
            this.Lbuilding.Name = "Lbuilding";
            this.Lbuilding.Size = new System.Drawing.Size(59, 18);
            this.Lbuilding.TabIndex = 8;
            this.Lbuilding.Text = "Building";
            // 
            // LFaculty
            // 
            this.LFaculty.AutoSize = true;
            this.LFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFaculty.Location = new System.Drawing.Point(565, 98);
            this.LFaculty.Name = "LFaculty";
            this.LFaculty.Size = new System.Drawing.Size(55, 18);
            this.LFaculty.TabIndex = 7;
            this.LFaculty.Text = "Faculty";
            this.LFaculty.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // textLname
            // 
            this.textLname.Location = new System.Drawing.Point(135, 127);
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
            this.buildingBox.Location = new System.Drawing.Point(568, 198);
            this.buildingBox.Name = "buildingBox";
            this.buildingBox.Size = new System.Drawing.Size(196, 21);
            this.buildingBox.TabIndex = 5;
            this.buildingBox.Text = "Select Building";
            this.buildingBox.SelectedIndexChanged += new System.EventHandler(this.buildingBox_SelectedIndexChanged);
            // 
            // facultybox
            // 
            this.facultybox.FormattingEnabled = true;
            this.facultybox.Items.AddRange(new object[] {
            "Faculty Of Computing",
            "Faculty Of Bussiness",
            "Faculty Of Humanties",
            "Faculty Of Engineering"});
            this.facultybox.Location = new System.Drawing.Point(568, 126);
            this.facultybox.Name = "facultybox";
            this.facultybox.Size = new System.Drawing.Size(196, 21);
            this.facultybox.TabIndex = 4;
            this.facultybox.Text = "Select Faculty";
            // 
            // LAdd
            // 
            this.LAdd.AutoSize = true;
            this.LAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAdd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LAdd.Location = new System.Drawing.Point(354, 36);
            this.LAdd.Name = "LAdd";
            this.LAdd.Size = new System.Drawing.Size(219, 33);
            this.LAdd.TabIndex = 3;
            this.LAdd.Text = "ADD Lecturers";
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LName.Location = new System.Drawing.Point(132, 98);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(75, 18);
            this.LName.TabIndex = 2;
            this.LName.Text = "Full Name";
            // 
            // Ltab2
            // 
            this.Ltab2.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.Ltab2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ltab2.Controls.Add(this.backhomeL3);
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
            this.Ltab2.Size = new System.Drawing.Size(974, 564);
            this.Ltab2.TabIndex = 2;
            this.Ltab2.Text = "Manage Details";
            this.Ltab2.UseVisualStyleBackColor = true;
            // 
            // UPdelete
            // 
            this.UPdelete.BackColor = System.Drawing.Color.Maroon;
            this.UPdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPdelete.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UPdelete.Location = new System.Drawing.Point(500, 353);
            this.UPdelete.Name = "UPdelete";
            this.UPdelete.Size = new System.Drawing.Size(150, 60);
            this.UPdelete.TabIndex = 19;
            this.UPdelete.Text = "Delete";
            this.UPdelete.UseVisualStyleBackColor = false;
            this.UPdelete.Click += new System.EventHandler(this.UPdelete_Click);
            // 
            // UPadd
            // 
            this.UPadd.BackColor = System.Drawing.Color.DarkBlue;
            this.UPadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPadd.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UPadd.Location = new System.Drawing.Point(273, 353);
            this.UPadd.Name = "UPadd";
            this.UPadd.Size = new System.Drawing.Size(150, 60);
            this.UPadd.TabIndex = 18;
            this.UPadd.Text = "Update";
            this.UPadd.UseVisualStyleBackColor = false;
            this.UPadd.Click += new System.EventHandler(this.UPadd_Click);
            // 
            // LUPbuildingbox
            // 
            this.LUPbuildingbox.FormattingEnabled = true;
            this.LUPbuildingbox.Items.AddRange(new object[] {
            "New Building",
            "Main Building"});
            this.LUPbuildingbox.Location = new System.Drawing.Point(572, 218);
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
            this.UPlevel.Location = new System.Drawing.Point(572, 299);
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
            this.UPcenter.Location = new System.Drawing.Point(139, 299);
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
            this.LUPdeptbox.Location = new System.Drawing.Point(139, 218);
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
            this.LUPfacultyBox.Location = new System.Drawing.Point(572, 129);
            this.LUPfacultyBox.Name = "LUPfacultyBox";
            this.LUPfacultyBox.Size = new System.Drawing.Size(196, 21);
            this.LUPfacultyBox.TabIndex = 8;
            // 
            // updatename
            // 
            this.updatename.Location = new System.Drawing.Point(139, 129);
            this.updatename.Name = "updatename";
            this.updatename.Size = new System.Drawing.Size(196, 20);
            this.updatename.TabIndex = 7;
            this.updatename.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LUPfaculty
            // 
            this.LUPfaculty.AutoSize = true;
            this.LUPfaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPfaculty.Location = new System.Drawing.Point(569, 108);
            this.LUPfaculty.Name = "LUPfaculty";
            this.LUPfaculty.Size = new System.Drawing.Size(55, 18);
            this.LUPfaculty.TabIndex = 6;
            this.LUPfaculty.Text = "Faculty";
            // 
            // LUPbuilding
            // 
            this.LUPbuilding.AutoSize = true;
            this.LUPbuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPbuilding.Location = new System.Drawing.Point(569, 178);
            this.LUPbuilding.Name = "LUPbuilding";
            this.LUPbuilding.Size = new System.Drawing.Size(59, 18);
            this.LUPbuilding.TabIndex = 5;
            this.LUPbuilding.Text = "Building";
            // 
            // LUPcenter
            // 
            this.LUPcenter.AutoSize = true;
            this.LUPcenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPcenter.Location = new System.Drawing.Point(136, 268);
            this.LUPcenter.Name = "LUPcenter";
            this.LUPcenter.Size = new System.Drawing.Size(52, 18);
            this.LUPcenter.TabIndex = 4;
            this.LUPcenter.Text = "Center";
            // 
            // LUPlevel
            // 
            this.LUPlevel.AutoSize = true;
            this.LUPlevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPlevel.Location = new System.Drawing.Point(574, 268);
            this.LUPlevel.Name = "LUPlevel";
            this.LUPlevel.Size = new System.Drawing.Size(50, 18);
            this.LUPlevel.TabIndex = 3;
            this.LUPlevel.Text = "Levels";
            this.LUPlevel.Click += new System.EventHandler(this.label4_Click);
            // 
            // LUPdept
            // 
            this.LUPdept.AutoSize = true;
            this.LUPdept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPdept.Location = new System.Drawing.Point(136, 178);
            this.LUPdept.Name = "LUPdept";
            this.LUPdept.Size = new System.Drawing.Size(85, 18);
            this.LUPdept.TabIndex = 2;
            this.LUPdept.Text = "Department";
            // 
            // LUPname
            // 
            this.LUPname.AutoSize = true;
            this.LUPname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LUPname.Location = new System.Drawing.Point(136, 108);
            this.LUPname.Name = "LUPname";
            this.LUPname.Size = new System.Drawing.Size(75, 18);
            this.LUPname.TabIndex = 1;
            this.LUPname.Text = "Full Name";
            this.LUPname.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(309, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Lecturer Details";
            // 
            // backhomeL1
            // 
            this.backhomeL1.FlatAppearance.BorderSize = 0;
            this.backhomeL1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhomeL1.Image = ((System.Drawing.Image)(resources.GetObject("backhomeL1.Image")));
            this.backhomeL1.Location = new System.Drawing.Point(28, 25);
            this.backhomeL1.Name = "backhomeL1";
            this.backhomeL1.Size = new System.Drawing.Size(34, 34);
            this.backhomeL1.TabIndex = 9;
            this.backhomeL1.UseVisualStyleBackColor = true;
            this.backhomeL1.Click += new System.EventHandler(this.backhomeL1_Click);
            // 
            // addLecturerFormBindingSource
            // 
            this.addLecturerFormBindingSource.DataSource = typeof(Time_Management_System_2021.Lecturers.AddLecturerForm);
            // 
            // addLecturerFormBindingSource1
            // 
            this.addLecturerFormBindingSource1.DataSource = typeof(Time_Management_System_2021.Lecturers.AddLecturerForm);
            // 
            // backhomeL2
            // 
            this.backhomeL2.FlatAppearance.BorderSize = 0;
            this.backhomeL2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhomeL2.Image = ((System.Drawing.Image)(resources.GetObject("backhomeL2.Image")));
            this.backhomeL2.Location = new System.Drawing.Point(20, 22);
            this.backhomeL2.Name = "backhomeL2";
            this.backhomeL2.Size = new System.Drawing.Size(34, 34);
            this.backhomeL2.TabIndex = 18;
            this.backhomeL2.UseVisualStyleBackColor = true;
            this.backhomeL2.Click += new System.EventHandler(this.backhomeL2_Click);
            // 
            // backhomeL3
            // 
            this.backhomeL3.FlatAppearance.BorderSize = 0;
            this.backhomeL3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backhomeL3.Image = ((System.Drawing.Image)(resources.GetObject("backhomeL3.Image")));
            this.backhomeL3.Location = new System.Drawing.Point(30, 28);
            this.backhomeL3.Name = "backhomeL3";
            this.backhomeL3.Size = new System.Drawing.Size(34, 34);
            this.backhomeL3.TabIndex = 20;
            this.backhomeL3.UseVisualStyleBackColor = true;
            this.backhomeL3.Click += new System.EventHandler(this.backhomeL3_Click);
            // 
            // AddLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddLecturerForm";
            this.tabControl1.ResumeLayout(false);
            this.Ltab0.ResumeLayout(false);
            this.Ltab0.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Ltab1.ResumeLayout(false);
            this.Ltab1.PerformLayout();
            this.Ltab2.ResumeLayout(false);
            this.Ltab2.PerformLayout();
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
        private System.Windows.Forms.Button backhomeL1;
        private System.Windows.Forms.Button backhomeL2;
        private System.Windows.Forms.Button backhomeL3;
    }
}