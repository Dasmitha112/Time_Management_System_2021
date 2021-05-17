
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
            this.lblSelectLecturerInForm = new System.Windows.Forms.Label();
            this.cmbBoxSelectLecturerInForm = new System.Windows.Forms.ComboBox();
            this.btnSelectLecturerInForm = new System.Windows.Forms.Button();
            this.btnCancelInForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectLecturerInForm
            // 
            this.lblSelectLecturerInForm.AutoSize = true;
            this.lblSelectLecturerInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSelectLecturerInForm.ForeColor = System.Drawing.Color.Black;
            this.lblSelectLecturerInForm.Location = new System.Drawing.Point(116, 74);
            this.lblSelectLecturerInForm.Name = "lblSelectLecturerInForm";
            this.lblSelectLecturerInForm.Size = new System.Drawing.Size(102, 18);
            this.lblSelectLecturerInForm.TabIndex = 0;
            this.lblSelectLecturerInForm.Text = "Select lecturer";
            // 
            // cmbBoxSelectLecturerInForm
            // 
            this.cmbBoxSelectLecturerInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbBoxSelectLecturerInForm.FormattingEnabled = true;
            this.cmbBoxSelectLecturerInForm.Location = new System.Drawing.Point(228, 72);
            this.cmbBoxSelectLecturerInForm.Name = "cmbBoxSelectLecturerInForm";
            this.cmbBoxSelectLecturerInForm.Size = new System.Drawing.Size(166, 26);
            this.cmbBoxSelectLecturerInForm.TabIndex = 1;
            // 
            // btnSelectLecturerInForm
            // 
            this.btnSelectLecturerInForm.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSelectLecturerInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectLecturerInForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectLecturerInForm.Location = new System.Drawing.Point(119, 187);
            this.btnSelectLecturerInForm.Name = "btnSelectLecturerInForm";
            this.btnSelectLecturerInForm.Size = new System.Drawing.Size(120, 55);
            this.btnSelectLecturerInForm.TabIndex = 2;
            this.btnSelectLecturerInForm.Text = "SELECT";
            this.btnSelectLecturerInForm.UseVisualStyleBackColor = false;
            this.btnSelectLecturerInForm.Click += new System.EventHandler(this.btnSelectLecturerInForm_Click);
            // 
            // btnCancelInForm
            // 
            this.btnCancelInForm.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelInForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelInForm.Location = new System.Drawing.Point(274, 187);
            this.btnCancelInForm.Name = "btnCancelInForm";
            this.btnCancelInForm.Size = new System.Drawing.Size(120, 55);
            this.btnCancelInForm.TabIndex = 3;
            this.btnCancelInForm.Text = "CANCEL";
            this.btnCancelInForm.UseVisualStyleBackColor = false;
            this.btnCancelInForm.Click += new System.EventHandler(this.btnCancelInForm_Click);
            // 
            // SelectLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Time_Management_System_2021.Properties.Resources.background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 272);
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