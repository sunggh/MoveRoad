namespace MOVEROAD
{
    partial class search_departname
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
            this.lv_dpt_name = new System.Windows.Forms.ListView();
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(0, 180);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(136, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "종료하기";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lv_dpt_name
            // 
            this.lv_dpt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lv_dpt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_dpt_name.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.username});
            this.lv_dpt_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_dpt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_dpt_name.FullRowSelect = true;
            this.lv_dpt_name.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_dpt_name.HideSelection = false;
            this.lv_dpt_name.HoverSelection = true;
            this.lv_dpt_name.Location = new System.Drawing.Point(0, 0);
            this.lv_dpt_name.Name = "lv_dpt_name";
            this.lv_dpt_name.Size = new System.Drawing.Size(136, 180);
            this.lv_dpt_name.TabIndex = 8;
            this.lv_dpt_name.UseCompatibleStateImageBehavior = false;
            this.lv_dpt_name.View = System.Windows.Forms.View.Details;
            this.lv_dpt_name.DoubleClick += new System.EventHandler(this.lv_dpt_name_DoubleClick);
            // 
            // username
            // 
            this.username.Text = "부서명";
            this.username.Width = 128;
            // 
            // search_departname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 203);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lv_dpt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "search_departname";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "search_departname";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.ListView lv_dpt_name;
        private System.Windows.Forms.ColumnHeader username;
    }
}