namespace MOVEROAD
{
    partial class MessageBoxForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm2));
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.checkbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textsearch = new System.Windows.Forms.TextBox();
            this.titlesearch = new System.Windows.Forms.TextBox();
            this.Fromsearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.받은쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보낸쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxRegistrantSearch = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label6.Location = new System.Drawing.Point(349, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 28;
            this.label6.Text = "내용";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label5.Location = new System.Drawing.Point(195, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "제목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label4.Location = new System.Drawing.Point(46, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "받는사람";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(121, 98);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkbox,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 138);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(817, 363);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listview1_MouseDoubleClick);
            // 
            // checkbox
            // 
            this.checkbox.Text = "";
            this.checkbox.Width = 22;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "받는사람";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 67;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "제목";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 420;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "상태";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "날짜";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 110;
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textsearch.Location = new System.Drawing.Point(275, 65);
            this.textsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(177, 24);
            this.textsearch.TabIndex = 19;
            // 
            // titlesearch
            // 
            this.titlesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titlesearch.Location = new System.Drawing.Point(147, 65);
            this.titlesearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlesearch.Name = "titlesearch";
            this.titlesearch.Size = new System.Drawing.Size(121, 24);
            this.titlesearch.TabIndex = 18;
            // 
            // Fromsearch
            // 
            this.Fromsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fromsearch.Location = new System.Drawing.Point(21, 65);
            this.Fromsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fromsearch.Name = "Fromsearch";
            this.Fromsearch.Size = new System.Drawing.Size(121, 24);
            this.Fromsearch.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.받은쪽지ToolStripMenuItem,
            this.보낸쪽지ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(851, 26);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 받은쪽지ToolStripMenuItem
            // 
            this.받은쪽지ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.받은쪽지ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.받은쪽지ToolStripMenuItem.Name = "받은쪽지ToolStripMenuItem";
            this.받은쪽지ToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.받은쪽지ToolStripMenuItem.Text = "받은 쪽지";
            this.받은쪽지ToolStripMenuItem.Click += new System.EventHandler(this.받은쪽지ToolStripMenuItem_Click_1);
            // 
            // 보낸쪽지ToolStripMenuItem
            // 
            this.보낸쪽지ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.보낸쪽지ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.보낸쪽지ToolStripMenuItem.Name = "보낸쪽지ToolStripMenuItem";
            this.보낸쪽지ToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.보낸쪽지ToolStripMenuItem.Text = "보낸 쪽지";
            this.보낸쪽지ToolStripMenuItem.Click += new System.EventHandler(this.보낸쪽지ToolStripMenuItem_Click_1);
            // 
            // pictureBoxRegistrantSearch
            // 
            this.pictureBoxRegistrantSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrantSearch.Image")));
            this.pictureBoxRegistrantSearch.Location = new System.Drawing.Point(459, 65);
            this.pictureBoxRegistrantSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRegistrantSearch.Name = "pictureBoxRegistrantSearch";
            this.pictureBoxRegistrantSearch.Size = new System.Drawing.Size(34, 20);
            this.pictureBoxRegistrantSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrantSearch.TabIndex = 20;
            this.pictureBoxRegistrantSearch.TabStop = false;
            this.pictureBoxRegistrantSearch.Click += new System.EventHandler(this.pictureBoxRegistrantSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(751, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "보낸 쪽지함";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(21, 98);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 34);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "쪽지 쓰기";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // MessageBoxForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 515);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBoxRegistrantSearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.titlesearch);
            this.Controls.Add(this.Fromsearch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MessageBoxForm2";
            this.Text = "MessageBoxForm2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader checkbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.PictureBox pictureBoxRegistrantSearch;
        public System.Windows.Forms.TextBox textsearch;
        public System.Windows.Forms.TextBox titlesearch;
        public System.Windows.Forms.TextBox Fromsearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 받은쪽지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보낸쪽지ToolStripMenuItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
    }
}