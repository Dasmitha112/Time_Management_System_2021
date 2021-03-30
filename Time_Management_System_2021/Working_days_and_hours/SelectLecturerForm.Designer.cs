
namespace Time_Management_System_2021.Working_days_and_hours
{
    partial class SelectLecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectLecturerForm));
            this.lblSelectLecturerInForm = new System.Windows.Forms.Label();
            this.cmbBoxSelectLecturerInForm = new System.Windows.Forms.ComboBox();
            this.btnSelectLecturerInForm = new System.Windows.Forms.Button();
            this.btnCancelInForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectLecturerInForm
            // 
            this.lblSelectLecturerInForm.AutoSize = true;
            this.lblSelectLecturerInForm.ForeColor = System.Drawing.Color.Black;
            this.lblSelectLecturerInForm.Location = new System.Drawing.Point(116, 74);
            this.lblSelectLecturerInForm.Name = "lblSelectLecturerInForm";
            this.lblSelectLecturerInForm.Size = new System.Drawing.Size(75, 13);
            this.lblSelectLecturerInForm.TabIndex = 0;
            this.lblSelectLecturerInForm.Text = "Select lecturer";
            // 
            // cmbBoxSelectLecturerInForm
            // 
            this.cmbBoxSelectLecturerInForm.FormattingEnabled = true;
            this.cmbBoxSelectLecturerInForm.Location = new System.Drawing.Point(202, 71);
            this.cmbBoxSelectLecturerInForm.Name = "cmbBoxSelectLecturerInForm";
            this.cmbBoxSelectLecturerInForm.Size = new System.Drawing.Size(166, 21);
            this.cmbBoxSelectLecturerInForm.TabIndex = 1;
            // 
            // btnSelectLecturerInForm
            // 
            this.btnSelectLecturerInForm.Location = new System.Drawing.Point(146, 155);
            this.btnSelectLecturerInForm.Name = "btnSelectLecturerInForm";
            this.btnSelectLecturerInForm.Size = new System.Drawing.Size(75, 23);
            this.btnSelectLecturerInForm.TabIndex = 2;
            this.btnSelectLecturerInForm.Text = "SELECT";
            this.btnSelectLecturerInForm.UseVisualStyleBackColor = true;
            this.btnSelectLecturerInForm.Click += new System.EventHandler(this.btnSelectLecturerInForm_Click);
            // 
            // btnCancelInForm
            // 
            this.btnCancelInForm.Location = new System.Drawing.Point(254, 155);
            this.btnCancelInForm.Name = "btnCancelInForm";
            this.btnCancelInForm.Size = new System.Drawing.Size(75, 23);
            this.btnCancelInForm.TabIndex = 3;
            this.btnCancelInForm.Text = "CANCEL";
            this.btnCancelInForm.UseVisualStyleBackColor = true;
            this.btnCancelInForm.Click += new System.EventHandler(this.btnCancelInForm_Click);
            // 
            // SelectLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 259);
            this.Controls.Add(this.btnCancelInForm);
            this.Controls.Add(this.btnSelectLecturerInForm);
            this.Controls.Add(this.cmbBoxSelectLecturerInForm);
            this.Controls.Add(this.lblSelectLecturerInForm);
            this.Name = "SelectLecturerForm";
            this.Text = "SelectLecturerForm";
            this.Load += new System.EventHandler(this.SelectLecturerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectLecturerInForm;
        private System.Windows.Forms.ComboBox cmbBoxSelectLecturerInForm;
        private System.Windows.Forms.Button btnSelectLecturerInForm;
        private System.Windows.Forms.Button btnCancelInForm;
    }
}