namespace MOVEROAD
{
    partial class MessageReceiveForm
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
            this.FromtextBox = new System.Windows.Forms.TextBox();
            this.FromtitleBox = new System.Windows.Forms.TextBox();
            this.FromBox = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFromtime = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FromtextBox
            // 
            this.FromtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromtextBox.Location = new System.Drawing.Point(20, 87);
            this.FromtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromtextBox.Multiline = true;
            this.FromtextBox.Name = "FromtextBox";
            this.FromtextBox.ReadOnly = true;
            this.FromtextBox.Size = new System.Drawing.Size(598, 192);
            this.FromtextBox.TabIndex = 11;
            // 
            // FromtitleBox
            // 
            this.FromtitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromtitleBox.Location = new System.Drawing.Point(86, 52);
            this.FromtitleBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromtitleBox.Name = "FromtitleBox";
            this.FromtitleBox.ReadOnly = true;
            this.FromtitleBox.Size = new System.Drawing.Size(420, 21);
            this.FromtitleBox.TabIndex = 10;
            // 
            // FromBox
            // 
            this.FromBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FromBox.Location = new System.Drawing.Point(86, 21);
            this.FromBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FromBox.Name = "FromBox";
            this.FromBox.ReadOnly = true;
            this.FromBox.Size = new System.Drawing.Size(420, 21);
            this.FromBox.TabIndex = 9;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btndelete.ForeColor = System.Drawing.Color.White;
            this.btndelete.Location = new System.Drawing.Point(109, 284);
            this.btndelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(84, 27);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "삭제";
            this.btndelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "제목";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(18, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "보낸 사람";
            // 
            // labelFromtime
            // 
            this.labelFromtime.AutoSize = true;
            this.labelFromtime.BackColor = System.Drawing.Color.White;
            this.labelFromtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelFromtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.labelFromtime.Location = new System.Drawing.Point(399, 290);
            this.labelFromtime.Name = "labelFromtime";
            this.labelFromtime.Size = new System.Drawing.Size(60, 17);
            this.labelFromtime.TabIndex = 12;
            this.labelFromtime.Text = "보낸 시간";
            // 
            // btnReply
            // 
            this.btnReply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnReply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReply.ForeColor = System.Drawing.Color.White;
            this.btnReply.Location = new System.Drawing.Point(20, 284);
            this.btnReply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(84, 27);
            this.btnReply.TabIndex = 13;
            this.btnReply.Text = "답장";
            this.btnReply.UseVisualStyleBackColor = false;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(511, 293);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(38, 12);
            this.time.TabIndex = 14;
            this.time.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.pictureBox1.BackgroundImage = global::MOVEROAD.Properties.Resources.X;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(625, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MessageReceiveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.labelFromtime);
            this.Controls.Add(this.FromtextBox);
            this.Controls.Add(this.FromtitleBox);
            this.Controls.Add(this.FromBox);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessageReceiveForm";
            this.Text = "MessageReceiveForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FromtextBox;
        private System.Windows.Forms.TextBox FromtitleBox;
        private System.Windows.Forms.TextBox FromBox;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFromtime;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}