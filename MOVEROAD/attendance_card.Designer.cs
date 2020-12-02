namespace MOVEROAD
{
    partial class attendance_card
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
            this.Today = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonInc = new System.Windows.Forms.Button();
            this.buttonDec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRead = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Today.Location = new System.Drawing.Point(550, 121);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(123, 22);
            this.Today.TabIndex = 2;
            this.Today.Text = "yyyyy-MM-dd";
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonStart.Location = new System.Drawing.Point(524, 155);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(174, 77);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "출근";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonFinish.Location = new System.Drawing.Point(524, 238);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(174, 77);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "퇴근";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(478, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(25, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "출퇴근 카드";
            // 
            // buttonInc
            // 
            this.buttonInc.Location = new System.Drawing.Point(246, 38);
            this.buttonInc.Name = "buttonInc";
            this.buttonInc.Size = new System.Drawing.Size(24, 26);
            this.buttonInc.TabIndex = 7;
            this.buttonInc.Text = "^";
            this.buttonInc.UseVisualStyleBackColor = true;
            this.buttonInc.Click += new System.EventHandler(this.buttonInc_Click);
            // 
            // buttonDec
            // 
            this.buttonDec.Location = new System.Drawing.Point(276, 38);
            this.buttonDec.Name = "buttonDec";
            this.buttonDec.Size = new System.Drawing.Size(24, 26);
            this.buttonDec.TabIndex = 8;
            this.buttonDec.Text = "v";
            this.buttonDec.UseVisualStyleBackColor = true;
            this.buttonDec.Click += new System.EventHandler(this.buttonDec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼모음T", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(171, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "현재 년-월";
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(429, 33);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(61, 37);
            this.buttonRead.TabIndex = 10;
            this.buttonRead.Text = "조회";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼모음T", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(564, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "현재 날짜";
            // 
            // attendance_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDec);
            this.Controls.Add(this.buttonInc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.Today);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "attendance_card";
            this.Text = "attendance_card";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInc;
        private System.Windows.Forms.Button buttonDec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label label4;
    }
}