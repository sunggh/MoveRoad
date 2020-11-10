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
            this.tb_depart_boss = new System.Windows.Forms.TextBox();
            this.tb_depart_memo = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "부서 명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "부서 장";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "부서 설명";
            // 
            // tb_depart_name
            // 
            this.tb_depart_name.Location = new System.Drawing.Point(107, 18);
            this.tb_depart_name.Name = "tb_depart_name";
            this.tb_depart_name.Size = new System.Drawing.Size(170, 21);
            this.tb_depart_name.TabIndex = 8;
            // 
            // tb_depart_boss
            // 
            this.tb_depart_boss.Location = new System.Drawing.Point(107, 51);
            this.tb_depart_boss.Name = "tb_depart_boss";
            this.tb_depart_boss.Size = new System.Drawing.Size(170, 21);
            this.tb_depart_boss.TabIndex = 9;
            // 
            // tb_depart_memo
            // 
            this.tb_depart_memo.Location = new System.Drawing.Point(28, 112);
            this.tb_depart_memo.Multiline = true;
            this.tb_depart_memo.Name = "tb_depart_memo";
            this.tb_depart_memo.Size = new System.Drawing.Size(249, 104);
            this.tb_depart_memo.TabIndex = 10;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(28, 232);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(105, 38);
            this.btn_add.TabIndex = 11;
            this.btn_add.Text = "추가하기";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(172, 232);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(105, 38);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // depart_add_event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 282);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_depart_memo);
            this.Controls.Add(this.tb_depart_boss);
            this.Controls.Add(this.tb_depart_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "depart_add_event";
            this.Text = "부서 등록";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_depart_name;
        private System.Windows.Forms.TextBox tb_depart_boss;
        private System.Windows.Forms.TextBox tb_depart_memo;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}