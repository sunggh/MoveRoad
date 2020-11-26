namespace MOVEROAD
{
    partial class Paymentmanagement
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DGV_payment = new System.Windows.Forms.DataGridView();
            this.btn_overtime = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "지급 급여 확인";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 21);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // DGV_payment
            // 
            this.DGV_payment.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_payment.Location = new System.Drawing.Point(12, 55);
            this.DGV_payment.Name = "DGV_payment";
            this.DGV_payment.RowTemplate.Height = 23;
            this.DGV_payment.Size = new System.Drawing.Size(721, 345);
            this.DGV_payment.TabIndex = 2;
            // 
            // btn_overtime
            // 
            this.btn_overtime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_overtime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_overtime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_overtime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_overtime.FlatAppearance.BorderSize = 2;
            this.btn_overtime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_overtime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_overtime.Font = new System.Drawing.Font("함초롬바탕", 12F);
            this.btn_overtime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_overtime.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_overtime.Location = new System.Drawing.Point(639, 12);
            this.btn_overtime.Name = "btn_overtime";
            this.btn_overtime.Size = new System.Drawing.Size(94, 37);
            this.btn_overtime.TabIndex = 4;
            this.btn_overtime.Text = "초과 근무";
            this.btn_overtime.UseVisualStyleBackColor = false;
            this.btn_overtime.Click += new System.EventHandler(this.btn_overtime_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_refresh.FlatAppearance.BorderSize = 2;
            this.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("함초롬바탕", 12F);
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refresh.Location = new System.Drawing.Point(539, 12);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(94, 37);
            this.btn_refresh.TabIndex = 5;
            this.btn_refresh.Text = "새로고침";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Paymentmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_overtime);
            this.Controls.Add(this.DGV_payment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Paymentmanagement";
            this.Text = "PaymentForm";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_payment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView DGV_payment;
        private System.Windows.Forms.Button btn_overtime;
        private System.Windows.Forms.Button btn_refresh;
    }
}