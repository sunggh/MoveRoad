namespace MOVEROAD
{
    partial class HRForm
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
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_payment = new System.Windows.Forms.Button();
            this.btn_HR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_department
            // 
            this.btn_department.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_department.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_department.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_department.FlatAppearance.BorderSize = 0;
            this.btn_department.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_department.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_department.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_department.Image = global::MOVEROAD.Properties.Resources.test01;
            this.btn_department.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_department.Location = new System.Drawing.Point(283, 120);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(171, 186);
            this.btn_department.TabIndex = 3;
            this.btn_department.Text = "\r\n부서 관리";
            this.btn_department.UseVisualStyleBackColor = false;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // btn_payment
            // 
            this.btn_payment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_payment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_payment.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_payment.FlatAppearance.BorderSize = 0;
            this.btn_payment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_payment.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_payment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_payment.Image = global::MOVEROAD.Properties.Resources.payment01;
            this.btn_payment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_payment.Location = new System.Drawing.Point(482, 120);
            this.btn_payment.Name = "btn_payment";
            this.btn_payment.Size = new System.Drawing.Size(171, 186);
            this.btn_payment.TabIndex = 2;
            this.btn_payment.Text = "\r\n급여 관리";
            this.btn_payment.UseVisualStyleBackColor = false;
            this.btn_payment.Click += new System.EventHandler(this.btn_payment_Click);
            // 
            // btn_HR
            // 
            this.btn_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_HR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_HR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HR.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_HR.FlatAppearance.BorderSize = 0;
            this.btn_HR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_HR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HR.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.btn_HR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_HR.Image = global::MOVEROAD.Properties.Resources.test02;
            this.btn_HR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HR.Location = new System.Drawing.Point(86, 120);
            this.btn_HR.Name = "btn_HR";
            this.btn_HR.Size = new System.Drawing.Size(171, 186);
            this.btn_HR.TabIndex = 0;
            this.btn_HR.Text = "\r\n사원 관리";
            this.btn_HR.UseVisualStyleBackColor = false;
            this.btn_HR.Click += new System.EventHandler(this.btn_HR_Click);
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.btn_department);
            this.Controls.Add(this.btn_payment);
            this.Controls.Add(this.btn_HR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.Load += new System.EventHandler(this.HRForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_HR;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Button btn_payment;
        private System.Windows.Forms.Button btn_department;
    }
}