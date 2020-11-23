namespace MOVEROAD
{
    partial class internal_mobility
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_user_search = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_depart_name = new System.Windows.Forms.TextBox();
            this.btn_dpt_search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_dpt_search);
            this.panel1.Controls.Add(this.tb_depart_name);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_user_search);
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_move);
            this.panel1.Controls.Add(this.tb_user);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 172);
            this.panel1.TabIndex = 15;
            // 
            // btn_user_search
            // 
            this.btn_user_search.Location = new System.Drawing.Point(225, 12);
            this.btn_user_search.Name = "btn_user_search";
            this.btn_user_search.Size = new System.Drawing.Size(50, 21);
            this.btn_user_search.TabIndex = 13;
            this.btn_user_search.Text = "검색";
            this.btn_user_search.UseVisualStyleBackColor = true;
            this.btn_user_search.Click += new System.EventHandler(this.btn_user_search_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(170, 121);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 38);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(23, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "부서원";
            // 
            // btn_move
            // 
            this.btn_move.Location = new System.Drawing.Point(35, 121);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(105, 38);
            this.btn_move.TabIndex = 11;
            this.btn_move.Text = "이동하기";
            this.btn_move.UseVisualStyleBackColor = true;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(80, 13);
            this.tb_user.Name = "tb_user";
            this.tb_user.ReadOnly = true;
            this.tb_user.Size = new System.Drawing.Size(122, 21);
            this.tb_user.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(23, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "부서명";
            // 
            // tb_depart_name
            // 
            this.tb_depart_name.Location = new System.Drawing.Point(80, 79);
            this.tb_depart_name.Name = "tb_depart_name";
            this.tb_depart_name.ReadOnly = true;
            this.tb_depart_name.Size = new System.Drawing.Size(122, 21);
            this.tb_depart_name.TabIndex = 15;
            // 
            // btn_dpt_search
            // 
            this.btn_dpt_search.Location = new System.Drawing.Point(225, 79);
            this.btn_dpt_search.Name = "btn_dpt_search";
            this.btn_dpt_search.Size = new System.Drawing.Size(50, 21);
            this.btn_dpt_search.TabIndex = 16;
            this.btn_dpt_search.Text = "검색";
            this.btn_dpt_search.UseVisualStyleBackColor = true;
            this.btn_dpt_search.Click += new System.EventHandler(this.btn_dpt_search_Click);
            // 
            // internal_mobility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(301, 177);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "internal_mobility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "internal_mobility";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_user_search;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_move;
        public System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Button btn_dpt_search;
        public System.Windows.Forms.TextBox tb_depart_name;
        private System.Windows.Forms.Label label1;
    }
}