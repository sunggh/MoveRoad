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
            this.btn_totalpay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_payment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("함초롬바탕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "지급 급여 확인";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // DGV_payment
            // 
            this.DGV_payment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_payment.Location = new System.Drawing.Point(58, 67);
            this.DGV_payment.Name = "DGV_payment";
            this.DGV_payment.RowTemplate.Height = 23;
            this.DGV_payment.Size = new System.Drawing.Size(439, 371);
            this.DGV_payment.TabIndex = 2;
            // 
            // btn_totalpay
            // 
            this.btn_totalpay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.btn_totalpay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_totalpay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_totalpay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_totalpay.FlatAppearance.BorderSize = 2;
            this.btn_totalpay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.btn_totalpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_totalpay.Font = new System.Drawing.Font("함초롬바탕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_totalpay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_totalpay.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_totalpay.Location = new System.Drawing.Point(554, 154);
            this.btn_totalpay.Name = "btn_totalpay";
            this.btn_totalpay.Size = new System.Drawing.Size(192, 158);
            this.btn_totalpay.TabIndex = 4;
            this.btn_totalpay.Text = "급여 내역서 수정 및 출력";
            this.btn_totalpay.UseVisualStyleBackColor = false;
            // 
            // Paymentmanagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_totalpay);
            this.Controls.Add(this.DGV_payment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button btn_totalpay;
    }
}