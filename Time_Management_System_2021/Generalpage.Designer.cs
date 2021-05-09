
namespace Time_Management_System_2021
{
    partial class Generalpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generalpage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to SLIIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Table Management System";
            // 
            // btnGetStart
            // 
            this.btnGetStart.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGetStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGetStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F);
            this.btnGetStart.ForeColor = System.Drawing.Color.White;
            this.btnGetStart.Image = ((System.Drawing.Image)(resources.GetObject("btnGetStart.Image")));
            this.btnGetStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGetStart.Location = new System.Drawing.Point(60, 316);
            this.btnGetStart.Name = "btnGetStart";
            this.btnGetStart.Size = new System.Drawing.Size(119, 56);
            this.btnGetStart.TabIndex = 2;
            this.btnGetStart.Text = "Get Start";
            this.btnGetStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetStart.UseVisualStyleBackColor = false;
            this.btnGetStart.Click += new System.EventHandler(this.btnGetStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Location = new System.Drawing.Point(536, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 225);
            this.panel1.TabIndex = 3;
            // 
            // Generalpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGetStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Generalpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetStart;
        private System.Windows.Forms.Panel panel1;
    }
}