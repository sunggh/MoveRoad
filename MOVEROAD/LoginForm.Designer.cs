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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.autoSave = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Loginid
            // 
            this.Loginid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.Loginid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Loginid.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loginid.ForeColor = System.Drawing.SystemColors.Window;
            this.Loginid.Location = new System.Drawing.Point(29, 76);
            this.Loginid.Name = "Loginid";
            this.Loginid.Size = new System.Drawing.Size(80, 18);
            this.Loginid.TabIndex = 5;
            this.Loginid.TabStop = false;
            this.Loginid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginPass
            // 
            this.LoginPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.LoginPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginPass.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginPass.ForeColor = System.Drawing.SystemColors.Window;
            this.LoginPass.Location = new System.Drawing.Point(29, 100);
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
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.login_button.Location = new System.Drawing.Point(114, 76);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(49, 42);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::MOVEROAD.Properties.Resources.Untitled_11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoSave.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.autoSave.Location = new System.Drawing.Point(28, 126);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(104, 17);
            this.autoSave.TabIndex = 8;
            this.autoSave.Text = "ID/PW자동 저장";
            this.autoSave.UseVisualStyleBackColor = true;
            this.autoSave.CheckedChanged += new System.EventHandler(this.autoSave_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(164, 151);
            this.Controls.Add(this.autoSave);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.LoginPass);
            this.Controls.Add(this.Loginid);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Loginid;
        private System.Windows.Forms.TextBox LoginPass;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox autoSave;
    }
}