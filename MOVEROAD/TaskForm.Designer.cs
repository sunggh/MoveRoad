using System.Drawing;

namespace MOVEROAD
{
    partial class TaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.buttonManagement = new System.Windows.Forms.Button();
            this.buttonMasterManagement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTaskKewordSearch = new System.Windows.Forms.PictureBox();
            this.textBoxTaskKeword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxRegistrantSearch = new System.Windows.Forms.PictureBox();
            this.textBoxRegistrant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskKewordSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonRegistration.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(52, 99);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(154, 36);
            this.buttonRegistration.TabIndex = 0;
            this.buttonRegistration.Text = "일일 업무등록";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // buttonManagement
            // 
            this.buttonManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonManagement.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonManagement.ForeColor = System.Drawing.Color.White;
            this.buttonManagement.Location = new System.Drawing.Point(52, 184);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(154, 36);
            this.buttonManagement.TabIndex = 1;
            this.buttonManagement.Text = "일일 업무관리";
            this.buttonManagement.UseVisualStyleBackColor = false;
            // 
            // buttonMasterManagement
            // 
            this.buttonMasterManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonMasterManagement.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonMasterManagement.ForeColor = System.Drawing.Color.White;
            this.buttonMasterManagement.Location = new System.Drawing.Point(52, 270);
            this.buttonMasterManagement.Name = "buttonMasterManagement";
            this.buttonMasterManagement.Size = new System.Drawing.Size(154, 36);
            this.buttonMasterManagement.TabIndex = 2;
            this.buttonMasterManagement.Text = "업무 마스터 관리";
            this.buttonMasterManagement.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTaskKewordSearch);
            this.groupBox1.Controls.Add(this.textBoxTaskKeword);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(256, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // pictureBoxTaskKewordSearch
            // 
            this.pictureBoxTaskKewordSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTaskKewordSearch.Image")));
            this.pictureBoxTaskKewordSearch.Location = new System.Drawing.Point(255, 183);
            this.pictureBoxTaskKewordSearch.Name = "pictureBoxTaskKewordSearch";
            this.pictureBoxTaskKewordSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTaskKewordSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTaskKewordSearch.TabIndex = 3;
            this.pictureBoxTaskKewordSearch.TabStop = false;
            // 
            // textBoxTaskKeword
            // 
            this.textBoxTaskKeword.Location = new System.Drawing.Point(68, 189);
            this.textBoxTaskKeword.Name = "textBoxTaskKeword";
            this.textBoxTaskKeword.Size = new System.Drawing.Size(171, 25);
            this.textBoxTaskKeword.TabIndex = 2;
            this.textBoxTaskKeword.Text = "업무 키워드 입력";
            this.textBoxTaskKeword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(68, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(313, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxRegistrantSearch);
            this.groupBox2.Controls.Add(this.textBoxRegistrant);
            this.groupBox2.Location = new System.Drawing.Point(256, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 67);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // pictureBoxRegistrantSearch
            // 
            this.pictureBoxRegistrantSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegistrantSearch.Image")));
            this.pictureBoxRegistrantSearch.Location = new System.Drawing.Point(255, 18);
            this.pictureBoxRegistrantSearch.Name = "pictureBoxRegistrantSearch";
            this.pictureBoxRegistrantSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRegistrantSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrantSearch.TabIndex = 7;
            this.pictureBoxRegistrantSearch.TabStop = false;
            // 
            // textBoxRegistrant
            // 
            this.textBoxRegistrant.Location = new System.Drawing.Point(68, 24);
            this.textBoxRegistrant.Name = "textBoxRegistrant";
            this.textBoxRegistrant.Size = new System.Drawing.Size(171, 25);
            this.textBoxRegistrant.TabIndex = 6;
            this.textBoxRegistrant.Text = "등록자 기반 검색";
            this.textBoxRegistrant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(269, 31);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "일일 업무 검색";
            // 
            // TaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonMasterManagement);
            this.Controls.Add(this.buttonManagement);
            this.Controls.Add(this.buttonRegistration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskKewordSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.Button buttonManagement;
        private System.Windows.Forms.Button buttonMasterManagement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxTaskKeword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBoxTaskKewordSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxRegistrantSearch;
        private System.Windows.Forms.TextBox textBoxRegistrant;
        private System.Windows.Forms.Label label1;
    }
}