namespace MOVEROAD
{
    partial class search_head
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
            this.lv_searching = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userindex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_searching
            // 
            this.lv_searching.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_searching.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lv_searching.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_searching.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username,
            this.userindex});
            this.lv_searching.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_searching.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_searching.FullRowSelect = true;
            this.lv_searching.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_searching.HideSelection = false;
            this.lv_searching.HoverSelection = true;
            this.lv_searching.Location = new System.Drawing.Point(0, 0);
            this.lv_searching.Name = "lv_searching";
            this.lv_searching.Size = new System.Drawing.Size(195, 189);
            this.lv_searching.TabIndex = 4;
            this.lv_searching.UseCompatibleStateImageBehavior = false;
            this.lv_searching.View = System.Windows.Forms.View.Details;
            this.lv_searching.SelectedIndexChanged += new System.EventHandler(this.lv_searching_SelectedIndexChanged);
            this.lv_searching.DoubleClick += new System.EventHandler(this.lv_searching_DoubleClick);
            // 
            // username
            // 
            this.username.Text = "이름";
            this.username.Width = 94;
            // 
            // userindex
            // 
            this.userindex.Text = "직급";
            this.userindex.Width = 97;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(0, 187);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(196, 21);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "종료하기";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // search_head
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 208);
            this.Controls.Add(this.lv_searching);
            this.Controls.Add(this.btn_cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search_head";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "직원 검색기";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader userindex;
        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.ListView lv_searching;
    }
}