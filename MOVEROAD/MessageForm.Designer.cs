﻿namespace MOVEROAD
{
    partial class MessageForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.ToBox = new System.Windows.Forms.TextBox();
            this.TotitleBox = new System.Windows.Forms.TextBox();
            this.TotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("서울남산 장체B", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "받는 사람";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("서울남산 장체B", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "제목";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btnSend.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(610, 354);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(96, 34);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = false;
            // 
            // ToBox
            // 
            this.ToBox.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ToBox.Location = new System.Drawing.Point(98, 26);
            this.ToBox.Name = "ToBox";
            this.ToBox.Size = new System.Drawing.Size(480, 22);
            this.ToBox.TabIndex = 3;
            // 
            // TotitleBox
            // 
            this.TotitleBox.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotitleBox.Location = new System.Drawing.Point(98, 65);
            this.TotitleBox.Name = "TotitleBox";
            this.TotitleBox.Size = new System.Drawing.Size(480, 22);
            this.TotitleBox.TabIndex = 4;
            this.TotitleBox.TextChanged += new System.EventHandler(this.TotitleBox_TextChanged);
            // 
            // TotextBox
            // 
            this.TotextBox.Font = new System.Drawing.Font("서울남산 장체B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotextBox.Location = new System.Drawing.Point(23, 109);
            this.TotextBox.Multiline = true;
            this.TotextBox.Name = "TotextBox";
            this.TotextBox.Size = new System.Drawing.Size(683, 239);
            this.TotextBox.TabIndex = 5;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.TotextBox);
            this.Controls.Add(this.TotitleBox);
            this.Controls.Add(this.ToBox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox ToBox;
        private System.Windows.Forms.TextBox TotitleBox;
        private System.Windows.Forms.TextBox TotextBox;
    }
}