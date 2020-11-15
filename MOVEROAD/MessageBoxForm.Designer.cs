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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBoxRegistrantSearch = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.받은쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보낸쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체쪽지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fromsearch
            // 
            this.Fromsearch.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Fromsearch.Location = new System.Drawing.Point(21, 47);
            this.Fromsearch.Name = "Fromsearch";
            this.Fromsearch.Size = new System.Drawing.Size(121, 22);
            this.Fromsearch.TabIndex = 1;
            this.Fromsearch.Text = "보낸 사람";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(148, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "받은 사람";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(275, 47);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "제목";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(458, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Text = "내용";
            // 
            // pictureBoxRegistrantSearch
            // 
            this.pictureBoxRegistrantSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrantSearch.Image")));
            this.pictureBoxRegistrantSearch.Location = new System.Drawing.Point(641, 47);
            this.pictureBoxRegistrantSearch.Name = "pictureBoxRegistrantSearch";
            this.pictureBoxRegistrantSearch.Size = new System.Drawing.Size(39, 25);
            this.pictureBoxRegistrantSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrantSearch.TabIndex = 8;
            this.pictureBoxRegistrantSearch.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(21, 111);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(687, 274);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.menuStrip1.Size = new System.Drawing.Size(745, 30);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 받은쪽지ToolStripMenuItem
            // 
            this.받은쪽지ToolStripMenuItem.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.받은쪽지ToolStripMenuItem.Name = "받은쪽지ToolStripMenuItem";
            this.받은쪽지ToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.받은쪽지ToolStripMenuItem.Text = "받은 쪽지";
            // 
            // 보낸쪽지ToolStripMenuItem
            // 
            this.보낸쪽지ToolStripMenuItem.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.보낸쪽지ToolStripMenuItem.Name = "보낸쪽지ToolStripMenuItem";
            this.보낸쪽지ToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.보낸쪽지ToolStripMenuItem.Text = "보낸 쪽지";
            // 
            // 전체쪽지ToolStripMenuItem
            // 
            this.전체쪽지ToolStripMenuItem.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.전체쪽지ToolStripMenuItem.Name = "전체쪽지ToolStripMenuItem";
            this.전체쪽지ToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.전체쪽지ToolStripMenuItem.Text = "전체 쪽지";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnDelete.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(109, 78);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnRead.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(197, 78);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(82, 27);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "읽음";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnNew.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(21, 78);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(82, 27);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "쪽지 쓰기";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBoxRegistrantSearch);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Fromsearch);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MessageBoxForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Fromsearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.PictureBox pictureBoxRegistrantSearch;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 받은쪽지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보낸쪽지ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 전체쪽지ToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnNew;
    }
}