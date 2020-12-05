namespace MOVEROAD
{
    partial class LoginForm
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
            this.Loginid = new System.Windows.Forms.TextBox();
            this.LoginPass = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.autoSave = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginid
            // 
            this.Loginid.BackColor = System.Drawing.Color.White;
            this.Loginid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loginid.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Loginid.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Loginid.Location = new System.Drawing.Point(20, 76);
            this.Loginid.Name = "Loginid";
            this.Loginid.Size = new System.Drawing.Size(80, 20);
            this.Loginid.TabIndex = 5;
            this.Loginid.TabStop = false;
            this.Loginid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPass
            // 
            this.LoginPass.BackColor = System.Drawing.Color.White;
            this.LoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPass.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPass.ForeColor = System.Drawing.Color.Black;
            this.LoginPass.Location = new System.Drawing.Point(20, 100);
            this.LoginPass.Name = "LoginPass";
            this.LoginPass.PasswordChar = '*';
            this.LoginPass.Size = new System.Drawing.Size(80, 18);
            this.LoginPass.TabIndex = 6;
            this.LoginPass.TabStop = false;
            this.LoginPass.Text = "123456";
            this.LoginPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginPass_KeyDown);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.login_button.Location = new System.Drawing.Point(105, 76);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(49, 42);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.autoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.autoSave.Location = new System.Drawing.Point(36, 124);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(104, 17);
            this.autoSave.TabIndex = 8;
            this.autoSave.Text = "ID/PW자동 저장";
            this.autoSave.UseVisualStyleBackColor = true;
            this.autoSave.CheckedChanged += new System.EventHandler(this.autoSave_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.Loginid);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.autoSave);
            this.panel1.Controls.Add(this.LoginPass);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 161);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MOVEROAD.Properties.Resources.메인3;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(172, 168);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Loginid;
        private System.Windows.Forms.TextBox LoginPass;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox autoSave;
        private System.Windows.Forms.Panel panel1;
    }
}