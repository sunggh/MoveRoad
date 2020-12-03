namespace MOVEROAD
{
    partial class rivise_depart
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
            this.lv_rivise = new System.Windows.Forms.ListView();
            this.depart_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depart_head = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_rivise
            // 
            this.lv_rivise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lv_rivise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_rivise.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depart_name,
            this.depart_head,
            this.memo});
            this.lv_rivise.Dock = System.Windows.Forms.DockStyle.Top;
            this.lv_rivise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_rivise.FullRowSelect = true;
            this.lv_rivise.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_rivise.HideSelection = false;
            this.lv_rivise.HoverSelection = true;
            this.lv_rivise.Location = new System.Drawing.Point(0, 0);
            this.lv_rivise.Name = "lv_rivise";
            this.lv_rivise.Size = new System.Drawing.Size(276, 186);
            this.lv_rivise.TabIndex = 5;
            this.lv_rivise.UseCompatibleStateImageBehavior = false;
            this.lv_rivise.View = System.Windows.Forms.View.Details;
            this.lv_rivise.DoubleClick += new System.EventHandler(this.lv_rivise_DoubleClick_1);
            // 
            // depart_name
            // 
            this.depart_name.Text = "부서 명";
            this.depart_name.Width = 70;
            // 
            // depart_head
            // 
            this.depart_head.Text = "부서 장(코드)";
            this.depart_head.Width = 81;
            // 
            // memo
            // 
            this.memo.Text = "설명(간략)";
            this.memo.Width = 120;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(0, 185);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(277, 24);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "종료하기";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // rivise_depart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 208);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lv_rivise);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rivise_depart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView lv_rivise;
        private System.Windows.Forms.ColumnHeader depart_name;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ColumnHeader depart_head;
        private System.Windows.Forms.ColumnHeader memo;
    }
}