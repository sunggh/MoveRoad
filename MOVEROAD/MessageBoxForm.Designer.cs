namespace MOVEROAD
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.Fromsearch = new System.Windows.Forms.TextBox();
            this.titlesearch = new System.Windows.Forms.TextBox();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.받은쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보낸쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.checkbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxRegistrantSearch = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // Fromsearch
            // 
            this.Fromsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fromsearch.Location = new System.Drawing.Point(18, 52);
            this.Fromsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fromsearch.Name = "Fromsearch";
            this.Fromsearch.Size = new System.Drawing.Size(106, 21);
            this.Fromsearch.TabIndex = 1;
            // 
            // titlesearch
            // 
            this.titlesearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.titlesearch.Location = new System.Drawing.Point(130, 52);
            this.titlesearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titlesearch.Name = "titlesearch";
            this.titlesearch.Size = new System.Drawing.Size(155, 21);
            this.titlesearch.TabIndex = 3;
            // 
            // textsearch
            // 
            this.textsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textsearch.Location = new System.Drawing.Point(291, 52);
            this.textsearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(155, 21);
            this.textsearch.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.받은쪽지ToolStripMenuItem,
            this.보낸쪽지ToolStripMenuItem,
            this.전체쪽지ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(745, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 받은쪽지ToolStripMenuItem
            // 
            this.받은쪽지ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.받은쪽지ToolStripMenuItem.Name = "받은쪽지ToolStripMenuItem";
            this.받은쪽지ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.받은쪽지ToolStripMenuItem.Text = "받은 쪽지";
            // 
            // 보낸쪽지ToolStripMenuItem
            // 
            this.보낸쪽지ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.보낸쪽지ToolStripMenuItem.Name = "보낸쪽지ToolStripMenuItem";
            this.보낸쪽지ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.보낸쪽지ToolStripMenuItem.Text = "보낸 쪽지";
            // 
            // 전체쪽지ToolStripMenuItem
            // 
            this.전체쪽지ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.전체쪽지ToolStripMenuItem.Name = "전체쪽지ToolStripMenuItem";
            this.전체쪽지ToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.전체쪽지ToolStripMenuItem.Text = "전체 쪽지";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(109, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(197, 78);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(82, 27);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "읽음";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // checkbox
            // 
            this.checkbox.Text = "";
            this.checkbox.Width = 22;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "보낸사람";
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
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.listView1.Location = new System.Drawing.Point(18, 110);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(715, 291);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(21, 78);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 27);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "쪽지 쓰기";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "보낸사람";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "제목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "내용";
            // 
            // pictureBoxRegistrantSearch
            // 
            this.pictureBoxRegistrantSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrantSearch.Image")));
            this.pictureBoxRegistrantSearch.Location = new System.Drawing.Point(452, 52);
            this.pictureBoxRegistrantSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxRegistrantSearch.Name = "pictureBoxRegistrantSearch";
            this.pictureBoxRegistrantSearch.Size = new System.Drawing.Size(34, 20);
            this.pictureBoxRegistrantSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrantSearch.TabIndex = 8;
            this.pictureBoxRegistrantSearch.TabStop = false;
            this.pictureBoxRegistrantSearch.Click += new System.EventHandler(this.pictureBoxRegistrantSearch_Click);
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBoxRegistrantSearch);
            this.Controls.Add(this.textsearch);
            this.Controls.Add(this.titlesearch);
            this.Controls.Add(this.Fromsearch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessageBoxForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxRegistrantSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 받은쪽지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보낸쪽지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체쪽지ToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ColumnHeader checkbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox Fromsearch;
        public System.Windows.Forms.TextBox titlesearch;
        public System.Windows.Forms.TextBox textsearch;
    }
}