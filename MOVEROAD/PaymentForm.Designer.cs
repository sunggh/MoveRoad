namespace MOVEROAD
{
    partial class PaymentForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.Today = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "수당 선택";
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            "연장근무(금일 10시간 이상 근무 시)",
            "야간근무(금일 22시 이후 근무 시)",
            "휴일근무(토, 일, 공휴일만 적용 가능)"});
            this.comboBoxSelect.Location = new System.Drawing.Point(23, 66);
            this.comboBoxSelect.Name = "comboBoxSelect";
            this.comboBoxSelect.Size = new System.Drawing.Size(231, 20);
            this.comboBoxSelect.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(102, 91);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 21);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "추가";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(181, 91);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(73, 21);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(23, 92);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(73, 21);
            this.textBoxTime.TabIndex = 6;
            // 
            // Today
            // 
            this.Today.AutoSize = true;
            this.Today.Font = new System.Drawing.Font("굴림", 9F);
            this.Today.Location = new System.Drawing.Point(21, 21);
            this.Today.Name = "Today";
            this.Today.Size = new System.Drawing.Size(38, 12);
            this.Today.TabIndex = 8;
            this.Today.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "*초과근무 시작시간";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(291, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Today);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.label2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "초과 근무 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.Label Today;
        private System.Windows.Forms.Label label1;
    }
}