namespace MOVEROAD
{
    partial class search_username
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lv_dpt_users = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userindex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(0, 185);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(198, 21);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "종료하기";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lv_dpt_users
            // 
            this.lv_dpt_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lv_dpt_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_dpt_users.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.userindex});
            this.lv_dpt_users.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_dpt_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_dpt_users.FullRowSelect = true;
            this.lv_dpt_users.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dpt_users.HideSelection = false;
            this.lv_dpt_users.HoverSelection = true;
            this.lv_dpt_users.Location = new System.Drawing.Point(0, 0);
            this.lv_dpt_users.Name = "lv_dpt_users";
            this.lv_dpt_users.Size = new System.Drawing.Size(198, 186);
            this.lv_dpt_users.TabIndex = 6;
            this.lv_dpt_users.UseCompatibleStateImageBehavior = false;
            this.lv_dpt_users.View = System.Windows.Forms.View.Details;
            this.lv_dpt_users.DoubleClick += new System.EventHandler(this.lv_dpt_users_DoubleClick);
            // 
            // username
            // 
            this.username.Text = "이름";
            this.username.Width = 94;
            // 
            // userindex
            // 
            this.userindex.Text = "부서";
            this.userindex.Width = 100;
            // 
            // change_dpt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 205);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lv_dpt_users);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "change_dpt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "change_dpt";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.ListView lv_dpt_users;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader userindex;
    }
}