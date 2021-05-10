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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SessionViewTab = new System.Windows.Forms.TabPage();
            this.AddSessionTab = new System.Windows.Forms.TabPage();
            this.MGTSessionTab = new System.Windows.Forms.TabPage();
            this.SessionAddTopic = new System.Windows.Forms.Label();
            this.SessionLecName = new System.Windows.Forms.Label();
            this.SessionTag = new System.Windows.Forms.Label();
            this.SessionStGroup = new System.Windows.Forms.Label();
            this.SessionSubCode = new System.Windows.Forms.Label();
            this.SessionDuration = new System.Windows.Forms.Label();
            this.SessionSubName = new System.Windows.Forms.Label();
            this.SessionStuCount = new System.Windows.Forms.Label();
            this.SessionLecBox = new System.Windows.Forms.ComboBox();
            this.SessionGroupBox = new System.Windows.Forms.ComboBox();
            this.SessionTagBox = new System.Windows.Forms.ComboBox();
            this.SessionSubNBox = new System.Windows.Forms.ComboBox();
            this.SessionSubCodeBox = new System.Windows.Forms.ComboBox();
            this.SessionStucountBox = new System.Windows.Forms.NumericUpDown();
            this.SesionDurationBox = new System.Windows.Forms.NumericUpDown();
            this.SessionAddBtn = new System.Windows.Forms.Button();
            this.SesionClearBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.AddSessionTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionStucountBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionDurationBox)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(801, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // SessionViewTab
            // 
            this.SessionViewTab.Location = new System.Drawing.Point(4, 22);
            this.SessionViewTab.Name = "SessionViewTab";
            this.SessionViewTab.Padding = new System.Windows.Forms.Padding(3);
            this.SessionViewTab.Size = new System.Drawing.Size(793, 423);
            this.SessionViewTab.TabIndex = 0;
            this.SessionViewTab.Text = "View Sessions";
            this.SessionViewTab.UseVisualStyleBackColor = true;
            // 
            // AddSessionTab
            // 
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
            this.AddSessionTab.Size = new System.Drawing.Size(793, 423);
            this.AddSessionTab.TabIndex = 1;
            this.AddSessionTab.Text = "Add Session";
            this.AddSessionTab.UseVisualStyleBackColor = true;
            // 
            // MGTSessionTab
            // 
            this.MGTSessionTab.Location = new System.Drawing.Point(4, 22);
            this.MGTSessionTab.Name = "MGTSessionTab";
            this.MGTSessionTab.Padding = new System.Windows.Forms.Padding(3);
            this.MGTSessionTab.Size = new System.Drawing.Size(793, 423);
            this.MGTSessionTab.TabIndex = 2;
            this.MGTSessionTab.Text = "Manage Session";
            this.MGTSessionTab.UseVisualStyleBackColor = true;
            // 
            // SessionAddTopic
            // 
            this.SessionAddTopic.AutoSize = true;
            this.SessionAddTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SessionAddTopic.Location = new System.Drawing.Point(336, 28);
            this.SessionAddTopic.Name = "SessionAddTopic";
            this.SessionAddTopic.Size = new System.Drawing.Size(110, 20);
            this.SessionAddTopic.TabIndex = 0;
            this.SessionAddTopic.Text = "Add Session";
            // 
            // SessionLecName
            // 
            this.SessionLecName.AutoSize = true;
            this.SessionLecName.Location = new System.Drawing.Point(223, 98);
            this.SessionLecName.Name = "SessionLecName";
            this.SessionLecName.Size = new System.Drawing.Size(46, 13);
            this.SessionLecName.TabIndex = 1;
            this.SessionLecName.Text = "Lecturer";
            // 
            // SessionTag
            // 
            this.SessionTag.AutoSize = true;
            this.SessionTag.Location = new System.Drawing.Point(226, 145);
            this.SessionTag.Name = "SessionTag";
            this.SessionTag.Size = new System.Drawing.Size(26, 13);
            this.SessionTag.TabIndex = 2;
            this.SessionTag.Text = "Tag";
            // 
            // SessionStGroup
            // 
            this.SessionStGroup.AutoSize = true;
            this.SessionStGroup.Location = new System.Drawing.Point(221, 188);
            this.SessionStGroup.Name = "SessionStGroup";
            this.SessionStGroup.Size = new System.Drawing.Size(76, 13);
            this.SessionStGroup.TabIndex = 3;
            this.SessionStGroup.Text = "Student Group";
            // 
            // SessionSubCode
            // 
            this.SessionSubCode.AutoSize = true;
            this.SessionSubCode.Location = new System.Drawing.Point(224, 264);
            this.SessionSubCode.Name = "SessionSubCode";
            this.SessionSubCode.Size = new System.Drawing.Size(71, 13);
            this.SessionSubCode.TabIndex = 4;
            this.SessionSubCode.Text = "Subject Code";
            // 
            // SessionDuration
            // 
            this.SessionDuration.AutoSize = true;
            this.SessionDuration.Location = new System.Drawing.Point(239, 334);
            this.SessionDuration.Name = "SessionDuration";
            this.SessionDuration.Size = new System.Drawing.Size(47, 13);
            this.SessionDuration.TabIndex = 5;
            this.SessionDuration.Text = "Duration";
            // 
            // SessionSubName
            // 
            this.SessionSubName.AutoSize = true;
            this.SessionSubName.Location = new System.Drawing.Point(221, 222);
            this.SessionSubName.Name = "SessionSubName";
            this.SessionSubName.Size = new System.Drawing.Size(74, 13);
            this.SessionSubName.TabIndex = 6;
            this.SessionSubName.Text = "Subject Name";
            // 
            // SessionStuCount
            // 
            this.SessionStuCount.AutoSize = true;
            this.SessionStuCount.Location = new System.Drawing.Point(226, 299);
            this.SessionStuCount.Name = "SessionStuCount";
            this.SessionStuCount.Size = new System.Drawing.Size(75, 13);
            this.SessionStuCount.TabIndex = 7;
            this.SessionStuCount.Text = "Student Count";
            // 
            // SessionLecBox
            // 
            this.SessionLecBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionLecBox.FormattingEnabled = true;
            this.SessionLecBox.Location = new System.Drawing.Point(325, 90);
            this.SessionLecBox.Name = "SessionLecBox";
            this.SessionLecBox.Size = new System.Drawing.Size(198, 21);
            this.SessionLecBox.TabIndex = 8;
            // 
            // SessionGroupBox
            // 
            this.SessionGroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionGroupBox.FormattingEnabled = true;
            this.SessionGroupBox.Location = new System.Drawing.Point(325, 180);
            this.SessionGroupBox.Name = "SessionGroupBox";
            this.SessionGroupBox.Size = new System.Drawing.Size(198, 21);
            this.SessionGroupBox.TabIndex = 9;
            // 
            // SessionTagBox
            // 
            this.SessionTagBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionTagBox.FormattingEnabled = true;
            this.SessionTagBox.Location = new System.Drawing.Point(325, 137);
            this.SessionTagBox.Name = "SessionTagBox";
            this.SessionTagBox.Size = new System.Drawing.Size(198, 21);
            this.SessionTagBox.TabIndex = 10;
            this.SessionTagBox.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // SessionSubNBox
            // 
            this.SessionSubNBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionSubNBox.FormattingEnabled = true;
            this.SessionSubNBox.Location = new System.Drawing.Point(325, 219);
            this.SessionSubNBox.Name = "SessionSubNBox";
            this.SessionSubNBox.Size = new System.Drawing.Size(198, 21);
            this.SessionSubNBox.TabIndex = 11;
            // 
            // SessionSubCodeBox
            // 
            this.SessionSubCodeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SessionSubCodeBox.FormattingEnabled = true;
            this.SessionSubCodeBox.Location = new System.Drawing.Point(325, 261);
            this.SessionSubCodeBox.Name = "SessionSubCodeBox";
            this.SessionSubCodeBox.Size = new System.Drawing.Size(198, 21);
            this.SessionSubCodeBox.TabIndex = 12;
            // 
            // SessionStucountBox
            // 
            this.SessionStucountBox.Location = new System.Drawing.Point(325, 297);
            this.SessionStucountBox.Name = "SessionStucountBox";
            this.SessionStucountBox.Size = new System.Drawing.Size(89, 20);
            this.SessionStucountBox.TabIndex = 13;
            // 
            // SesionDurationBox
            // 
            this.SesionDurationBox.Location = new System.Drawing.Point(325, 332);
            this.SesionDurationBox.Name = "SesionDurationBox";
            this.SesionDurationBox.Size = new System.Drawing.Size(89, 20);
            this.SesionDurationBox.TabIndex = 14;
            // 
            // SessionAddBtn
            // 
            this.SessionAddBtn.Location = new System.Drawing.Point(523, 370);
            this.SessionAddBtn.Name = "SessionAddBtn";
            this.SessionAddBtn.Size = new System.Drawing.Size(94, 35);
            this.SessionAddBtn.TabIndex = 15;
            this.SessionAddBtn.Text = "Add";
            this.SessionAddBtn.UseVisualStyleBackColor = true;
            // 
            // SesionClearBtn
            // 
            this.SesionClearBtn.Location = new System.Drawing.Point(672, 370);
            this.SesionClearBtn.Name = "SesionClearBtn";
            this.SesionClearBtn.Size = new System.Drawing.Size(94, 35);
            this.SesionClearBtn.TabIndex = 16;
            this.SesionClearBtn.Text = "Clear";
            this.SesionClearBtn.UseVisualStyleBackColor = true;
            // 
            // AddSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddSessionForm";
            this.Text = "AddSessionForm";
            this.tabControl1.ResumeLayout(false);
            this.AddSessionTab.ResumeLayout(false);
            this.AddSessionTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SessionStucountBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SesionDurationBox)).EndInit();
            this.ResumeLayout(false);

        }

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
    }
}