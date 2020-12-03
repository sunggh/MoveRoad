namespace MOVEROAD
{
    partial class depart_add_event
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_depart_name = new System.Windows.Forms.TextBox();
            this.tb_depart_head = new System.Windows.Forms.TextBox();
            this.tb_depart_memo = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_search_head = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "부서 명";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(23, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "부서 장";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "부서 설명";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_depart_name
            // 
            this.tb_depart_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tb_depart_name.Location = new System.Drawing.Point(95, 13);
            this.tb_depart_name.Name = "tb_depart_name";
            this.tb_depart_name.Size = new System.Drawing.Size(122, 23);
            this.tb_depart_name.TabIndex = 8;
            this.tb_depart_name.TextChanged += new System.EventHandler(this.tb_depart_name_TextChanged);
            // 
            // tb_depart_head
            // 
            this.tb_depart_head.BackColor = System.Drawing.Color.White;
            this.tb_depart_head.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tb_depart_head.Location = new System.Drawing.Point(95, 45);
            this.tb_depart_head.Name = "tb_depart_head";
            this.tb_depart_head.ReadOnly = true;
            this.tb_depart_head.Size = new System.Drawing.Size(122, 23);
            this.tb_depart_head.TabIndex = 9;
            this.tb_depart_head.TextChanged += new System.EventHandler(this.tb_depart_head_TextChanged);
            // 
            // tb_depart_memo
            // 
            this.tb_depart_memo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tb_depart_memo.Location = new System.Drawing.Point(25, 109);
            this.tb_depart_memo.Multiline = true;
            this.tb_depart_memo.Name = "tb_depart_memo";
            this.tb_depart_memo.Size = new System.Drawing.Size(249, 104);
            this.tb_depart_memo.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(25, 229);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 38);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "추가하기";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(169, 229);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 38);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_search_head
            // 
            this.btn_search_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_search_head.FlatAppearance.BorderSize = 0;
            this.btn_search_head.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_head.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_search_head.ForeColor = System.Drawing.Color.White;
            this.btn_search_head.Location = new System.Drawing.Point(224, 47);
            this.btn_search_head.Name = "btn_search_head";
            this.btn_search_head.Size = new System.Drawing.Size(50, 21);
            this.btn_search_head.TabIndex = 13;
            this.btn_search_head.Text = "검색";
            this.btn_search_head.UseVisualStyleBackColor = false;
            this.btn_search_head.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_depart_memo);
            this.panel1.Controls.Add(this.btn_search_head);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_depart_name);
            this.panel1.Controls.Add(this.tb_depart_head);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 295);
            this.panel1.TabIndex = 14;
            // 
            // depart_add_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(315, 299);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "depart_add_event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "부서 등록";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_depart_name;
        private System.Windows.Forms.TextBox tb_depart_memo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_search_head;
        public System.Windows.Forms.TextBox tb_depart_head;
        private System.Windows.Forms.Panel panel1;
    }
}