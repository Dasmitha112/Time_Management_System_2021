
namespace Time_Management_System_2021.tag
{
    partial class AddTag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTag));
            this.label1 = new System.Windows.Forms.Label();
            this.tagname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tagcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.relatedTag = new System.Windows.Forms.ComboBox();
            this.tagDelete = new System.Windows.Forms.Button();
            this.tagEdit = new System.Windows.Forms.Button();
            this.AddClear = new System.Windows.Forms.Button();
            this.tagADD = new System.Windows.Forms.Button();
            this.dataGridView_manageTag = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnHomeMWD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manageTag)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(344, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Tags";
            // 
            // tagname
            // 
            this.tagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tagname.FormattingEnabled = true;
            this.tagname.Items.AddRange(new object[] {
            "Lec",
            "tute",
            "prac"});
            this.tagname.Location = new System.Drawing.Point(127, 135);
            this.tagname.Name = "tagname";
            this.tagname.Size = new System.Drawing.Size(216, 28);
            this.tagname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tag Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(17, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tag Code";
            // 
            // tagcode
            // 
            this.tagcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tagcode.Location = new System.Drawing.Point(127, 198);
            this.tagcode.Name = "tagcode";
            this.tagcode.Size = new System.Drawing.Size(216, 26);
            this.tagcode.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(-6, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Related Tag ";
            // 
            // relatedTag
            // 
            this.relatedTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.relatedTag.FormattingEnabled = true;
            this.relatedTag.Items.AddRange(new object[] {
            "Lecture",
            "tutorial",
            "practical"});
            this.relatedTag.Location = new System.Drawing.Point(127, 265);
            this.relatedTag.Name = "relatedTag";
            this.relatedTag.Size = new System.Drawing.Size(216, 28);
            this.relatedTag.TabIndex = 6;
            // 
            // tagDelete
            // 
            this.tagDelete.BackColor = System.Drawing.Color.Maroon;
            this.tagDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tagDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagDelete.Location = new System.Drawing.Point(756, 447);
            this.tagDelete.Name = "tagDelete";
            this.tagDelete.Size = new System.Drawing.Size(150, 60);
            this.tagDelete.TabIndex = 16;
            this.tagDelete.Text = "DELETE";
            this.tagDelete.UseVisualStyleBackColor = false;
            this.tagDelete.Click += new System.EventHandler(this.tagDelete_Click);
            // 
            // tagEdit
            // 
            this.tagEdit.BackColor = System.Drawing.Color.DarkBlue;
            this.tagEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tagEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagEdit.Location = new System.Drawing.Point(550, 447);
            this.tagEdit.Name = "tagEdit";
            this.tagEdit.Size = new System.Drawing.Size(150, 60);
            this.tagEdit.TabIndex = 15;
            this.tagEdit.Text = "UPDATE";
            this.tagEdit.UseVisualStyleBackColor = false;
            this.tagEdit.Click += new System.EventHandler(this.tagEdit_Click);
            // 
            // AddClear
            // 
            this.AddClear.BackColor = System.Drawing.Color.DarkOrange;
            this.AddClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddClear.Location = new System.Drawing.Point(235, 348);
            this.AddClear.Name = "AddClear";
            this.AddClear.Size = new System.Drawing.Size(150, 60);
            this.AddClear.TabIndex = 14;
            this.AddClear.Text = "CLEAR";
            this.AddClear.UseVisualStyleBackColor = false;
            this.AddClear.Click += new System.EventHandler(this.AddClear_Click);
            // 
            // tagADD
            // 
            this.tagADD.BackColor = System.Drawing.Color.ForestGreen;
            this.tagADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tagADD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tagADD.Location = new System.Drawing.Point(52, 348);
            this.tagADD.Name = "tagADD";
            this.tagADD.Size = new System.Drawing.Size(150, 60);
            this.tagADD.TabIndex = 13;
            this.tagADD.Text = "ADD";
            this.tagADD.UseVisualStyleBackColor = false;
            this.tagADD.Click += new System.EventHandler(this.tagADD_Click);
            // 
            // dataGridView_manageTag
            // 
            this.dataGridView_manageTag.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_manageTag.Location = new System.Drawing.Point(467, 167);
            this.dataGridView_manageTag.Name = "dataGridView_manageTag";
            this.dataGridView_manageTag.RowHeadersWidth = 51;
            this.dataGridView_manageTag.RowTemplate.Height = 24;
            this.dataGridView_manageTag.Size = new System.Drawing.Size(469, 259);
            this.dataGridView_manageTag.TabIndex = 12;
            this.dataGridView_manageTag.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_manageTag_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(483, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Search By Tag Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(679, 130);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 28);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnHomeMWD
            // 
            this.btnHomeMWD.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMWD.FlatAppearance.BorderSize = 0;
            this.btnHomeMWD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeMWD.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeMWD.Image")));
            this.btnHomeMWD.Location = new System.Drawing.Point(16, 32);
            this.btnHomeMWD.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeMWD.Name = "btnHomeMWD";
            this.btnHomeMWD.Size = new System.Drawing.Size(82, 60);
            this.btnHomeMWD.TabIndex = 19;
            this.btnHomeMWD.UseVisualStyleBackColor = false;
            this.btnHomeMWD.Click += new System.EventHandler(this.btnHomeMWD_Click);
            // 
            // AddTag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnHomeMWD);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tagDelete);
            this.Controls.Add(this.tagEdit);
            this.Controls.Add(this.AddClear);
            this.Controls.Add(this.tagADD);
            this.Controls.Add(this.dataGridView_manageTag);
            this.Controls.Add(this.relatedTag);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tagcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tagname);
            this.Controls.Add(this.label1);
            this.Name = "AddTag";
            this.Text = "tag";
            this.Load += new System.EventHandler(this.AddTag_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_manageTag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tagname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tagcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox relatedTag;
        private System.Windows.Forms.Button tagDelete;
        private System.Windows.Forms.Button tagEdit;
        private System.Windows.Forms.Button AddClear;
        private System.Windows.Forms.Button tagADD;
        private System.Windows.Forms.DataGridView dataGridView_manageTag;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnHomeMWD;
    }
}