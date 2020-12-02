namespace MOVEROAD
{
    partial class depart_revise_event
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
            this.tb_original_name = new System.Windows.Forms.TextBox();
            this.tb_original_head = new System.Windows.Forms.TextBox();
            this.tb_original_description = new System.Windows.Forms.TextBox();
            this.btn_search_head = new System.Windows.Forms.Button();
            this.lb_depart_name = new System.Windows.Forms.Label();
            this.lb_depart_head = new System.Windows.Forms.Label();
            this.lb_depart_description = new System.Windows.Forms.Label();
            this.tb_revise_name = new System.Windows.Forms.TextBox();
            this.tb_revise_head = new System.Windows.Forms.TextBox();
            this.tb_revise_description = new System.Windows.Forms.TextBox();
            this.btn_revise = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "기존 부서 명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "기존 부서 장";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(23, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "기존 부서 설명";
            // 
            // tb_original_name
            // 
            this.tb_original_name.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_original_name.Location = new System.Drawing.Point(128, 22);
            this.tb_original_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_original_name.Name = "tb_original_name";
            this.tb_original_name.ReadOnly = true;
            this.tb_original_name.Size = new System.Drawing.Size(139, 25);
            this.tb_original_name.TabIndex = 10;
            // 
            // tb_original_head
            // 
            this.tb_original_head.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_original_head.Location = new System.Drawing.Point(128, 70);
            this.tb_original_head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_original_head.Name = "tb_original_head";
            this.tb_original_head.ReadOnly = true;
            this.tb_original_head.Size = new System.Drawing.Size(139, 25);
            this.tb_original_head.TabIndex = 11;
            // 
            // tb_original_description
            // 
            this.tb_original_description.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tb_original_description.Location = new System.Drawing.Point(25, 148);
            this.tb_original_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_original_description.Multiline = true;
            this.tb_original_description.Name = "tb_original_description";
            this.tb_original_description.ReadOnly = true;
            this.tb_original_description.Size = new System.Drawing.Size(242, 140);
            this.tb_original_description.TabIndex = 12;
            // 
            // btn_search_head
            // 
            this.btn_search_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_search_head.ForeColor = System.Drawing.Color.White;
            this.btn_search_head.Location = new System.Drawing.Point(273, 248);
            this.btn_search_head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search_head.Name = "btn_search_head";
            this.btn_search_head.Size = new System.Drawing.Size(98, 40);
            this.btn_search_head.TabIndex = 14;
            this.btn_search_head.Text = "검색";
            this.btn_search_head.UseVisualStyleBackColor = false;
            this.btn_search_head.Click += new System.EventHandler(this.btn_search_head_Click);
            // 
            // lb_depart_name
            // 
            this.lb_depart_name.AutoSize = true;
            this.lb_depart_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lb_depart_name.Location = new System.Drawing.Point(413, 26);
            this.lb_depart_name.Name = "lb_depart_name";
            this.lb_depart_name.Size = new System.Drawing.Size(57, 15);
            this.lb_depart_name.TabIndex = 15;
            this.lb_depart_name.Text = "부서 명";
            this.lb_depart_name.Visible = false;
            // 
            // lb_depart_head
            // 
            this.lb_depart_head.AutoSize = true;
            this.lb_depart_head.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lb_depart_head.Location = new System.Drawing.Point(413, 77);
            this.lb_depart_head.Name = "lb_depart_head";
            this.lb_depart_head.Size = new System.Drawing.Size(57, 15);
            this.lb_depart_head.TabIndex = 16;
            this.lb_depart_head.Text = "부서 장";
            this.lb_depart_head.Visible = false;
            // 
            // lb_depart_description
            // 
            this.lb_depart_description.AutoSize = true;
            this.lb_depart_description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.lb_depart_description.Location = new System.Drawing.Point(413, 129);
            this.lb_depart_description.Name = "lb_depart_description";
            this.lb_depart_description.Size = new System.Drawing.Size(72, 15);
            this.lb_depart_description.TabIndex = 17;
            this.lb_depart_description.Text = "부서 설명";
            this.lb_depart_description.Visible = false;
            // 
            // tb_revise_name
            // 
            this.tb_revise_name.Location = new System.Drawing.Point(476, 23);
            this.tb_revise_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_revise_name.Name = "tb_revise_name";
            this.tb_revise_name.Size = new System.Drawing.Size(165, 25);
            this.tb_revise_name.TabIndex = 18;
            this.tb_revise_name.Visible = false;
            // 
            // tb_revise_head
            // 
            this.tb_revise_head.Location = new System.Drawing.Point(476, 70);
            this.tb_revise_head.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_revise_head.Name = "tb_revise_head";
            this.tb_revise_head.Size = new System.Drawing.Size(165, 25);
            this.tb_revise_head.TabIndex = 19;
            this.tb_revise_head.Visible = false;
            // 
            // tb_revise_description
            // 
            this.tb_revise_description.Location = new System.Drawing.Point(415, 148);
            this.tb_revise_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_revise_description.Multiline = true;
            this.tb_revise_description.Name = "tb_revise_description";
            this.tb_revise_description.Size = new System.Drawing.Size(242, 140);
            this.tb_revise_description.TabIndex = 20;
            this.tb_revise_description.Visible = false;
            // 
            // btn_revise
            // 
            this.btn_revise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_revise.ForeColor = System.Drawing.Color.White;
            this.btn_revise.Location = new System.Drawing.Point(663, 246);
            this.btn_revise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_revise.Name = "btn_revise";
            this.btn_revise.Size = new System.Drawing.Size(98, 42);
            this.btn_revise.TabIndex = 21;
            this.btn_revise.Text = "수정";
            this.btn_revise.UseVisualStyleBackColor = false;
            this.btn_revise.Visible = false;
            this.btn_revise.Click += new System.EventHandler(this.btn_revise_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(647, 70);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(58, 29);
            this.btn_search.TabIndex = 22;
            this.btn_search.Text = "검색";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_revise);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_revise_description);
            this.panel1.Controls.Add(this.tb_original_name);
            this.panel1.Controls.Add(this.tb_revise_head);
            this.panel1.Controls.Add(this.tb_original_head);
            this.panel1.Controls.Add(this.tb_revise_name);
            this.panel1.Controls.Add(this.tb_original_description);
            this.panel1.Controls.Add(this.lb_depart_description);
            this.panel1.Controls.Add(this.btn_search_head);
            this.panel1.Controls.Add(this.lb_depart_head);
            this.panel1.Controls.Add(this.lb_depart_name);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 324);
            this.panel1.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.pictureBox1.BackgroundImage = global::MOVEROAD.Properties.Resources.X;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(790, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.button2_Click);
            // 
            // depart_revise_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(826, 329);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "depart_revise_event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "부서 수정";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tb_original_name;
        public System.Windows.Forms.TextBox tb_original_head;
        public System.Windows.Forms.TextBox tb_original_description;
        private System.Windows.Forms.Button btn_search_head;
        public System.Windows.Forms.TextBox tb_revise_description;
        public System.Windows.Forms.Label lb_depart_name;
        public System.Windows.Forms.Label lb_depart_head;
        public System.Windows.Forms.Label lb_depart_description;
        public System.Windows.Forms.TextBox tb_revise_name;
        public System.Windows.Forms.TextBox tb_revise_head;
        public System.Windows.Forms.Button btn_revise;
        public System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}