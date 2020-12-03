namespace MOVEROAD
{
    partial class Departmanagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_depart_description = new System.Windows.Forms.TextBox();
            this.tb_depart_head = new System.Windows.Forms.TextBox();
            this.tb_depart_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_depart = new System.Windows.Forms.DataGridView();
            this.lv_depart = new System.Windows.Forms.ListView();
            this.depart_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.depart_head = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_depart)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(13, 312);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(166, 50);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "부서 등록";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(199, 312);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(166, 50);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "부서 수정";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(567, 312);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(166, 50);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "부서 삭제";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_depart_description);
            this.groupBox1.Controls.Add(this.tb_depart_head);
            this.groupBox1.Controls.Add(this.tb_depart_name);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.groupBox1.Location = new System.Drawing.Point(289, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 272);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세 정보";
            // 
            // tb_depart_description
            // 
            this.tb_depart_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_depart_description.Location = new System.Drawing.Point(33, 145);
            this.tb_depart_description.Multiline = true;
            this.tb_depart_description.Name = "tb_depart_description";
            this.tb_depart_description.ReadOnly = true;
            this.tb_depart_description.Size = new System.Drawing.Size(342, 108);
            this.tb_depart_description.TabIndex = 5;
            // 
            // tb_depart_head
            // 
            this.tb_depart_head.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_depart_head.Location = new System.Drawing.Point(110, 75);
            this.tb_depart_head.Name = "tb_depart_head";
            this.tb_depart_head.ReadOnly = true;
            this.tb_depart_head.Size = new System.Drawing.Size(265, 23);
            this.tb_depart_head.TabIndex = 4;
            // 
            // tb_depart_name
            // 
            this.tb_depart_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tb_depart_name.Location = new System.Drawing.Point(110, 32);
            this.tb_depart_name.Name = "tb_depart_name";
            this.tb_depart_name.ReadOnly = true;
            this.tb_depart_name.Size = new System.Drawing.Size(265, 23);
            this.tb_depart_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label3.Location = new System.Drawing.Point(31, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "부서 설명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(31, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "부서 장";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "부서 명";
            // 
            // DGV_depart
            // 
            this.DGV_depart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGV_depart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_depart.BackgroundColor = System.Drawing.Color.White;
            this.DGV_depart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV_depart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.DGV_depart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_depart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_depart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_depart.EnableHeadersVisualStyles = false;
            this.DGV_depart.GridColor = System.Drawing.Color.Black;
            this.DGV_depart.Location = new System.Drawing.Point(12, 23);
            this.DGV_depart.MultiSelect = false;
            this.DGV_depart.Name = "DGV_depart";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_depart.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_depart.RowHeadersVisible = false;
            this.DGV_depart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DGV_depart.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_depart.RowTemplate.Height = 23;
            this.DGV_depart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_depart.Size = new System.Drawing.Size(270, 266);
            this.DGV_depart.TabIndex = 11;
            // 
            // lv_depart
            // 
            this.lv_depart.BackColor = System.Drawing.Color.White;
            this.lv_depart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_depart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.depart_name,
            this.depart_head,
            this.memo});
            this.lv_depart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lv_depart.FullRowSelect = true;
            this.lv_depart.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_depart.HideSelection = false;
            this.lv_depart.HoverSelection = true;
            this.lv_depart.Location = new System.Drawing.Point(13, 23);
            this.lv_depart.Name = "lv_depart";
            this.lv_depart.Scrollable = false;
            this.lv_depart.Size = new System.Drawing.Size(270, 266);
            this.lv_depart.TabIndex = 12;
            this.lv_depart.UseCompatibleStateImageBehavior = false;
            this.lv_depart.View = System.Windows.Forms.View.Details;
            this.lv_depart.Click += new System.EventHandler(this.lv_depart_Click);
            // 
            // depart_name
            // 
            this.depart_name.Text = "부서 명";
            this.depart_name.Width = 70;
            // 
            // depart_head
            // 
            this.depart_head.Text = "부서 장";
            this.depart_head.Width = 81;
            // 
            // memo
            // 
            this.memo.Text = "설명";
            this.memo.Width = 161;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "부서 이동";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Departmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv_depart);
            this.Controls.Add(this.DGV_depart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departmanagement";
            this.Text = "Departmanagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_depart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_depart_description;
        private System.Windows.Forms.TextBox tb_depart_head;
        private System.Windows.Forms.TextBox tb_depart_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_depart;
        public System.Windows.Forms.ListView lv_depart;
        private System.Windows.Forms.ColumnHeader depart_name;
        private System.Windows.Forms.ColumnHeader depart_head;
        private System.Windows.Forms.ColumnHeader memo;
        private System.Windows.Forms.Button button1;
    }
}