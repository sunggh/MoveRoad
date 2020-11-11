namespace MOVEROAD
{
    partial class SearchUsers
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
            this.buttonEditUsers = new System.Windows.Forms.Button();
            this.buttonSearchUsers = new System.Windows.Forms.Button();
            this.buttonAddUsers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepartName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditUsers
            // 
            this.buttonEditUsers.Location = new System.Drawing.Point(498, 12);
            this.buttonEditUsers.Name = "buttonEditUsers";
            this.buttonEditUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonEditUsers.TabIndex = 7;
            this.buttonEditUsers.Text = "사원 정보 수정";
            this.buttonEditUsers.UseVisualStyleBackColor = true;
            // 
            // buttonSearchUsers
            // 
            this.buttonSearchUsers.Location = new System.Drawing.Point(253, 12);
            this.buttonSearchUsers.Name = "buttonSearchUsers";
            this.buttonSearchUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonSearchUsers.TabIndex = 6;
            this.buttonSearchUsers.Text = "사원 검색";
            this.buttonSearchUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(235, 51);
            this.buttonAddUsers.TabIndex = 5;
            this.buttonAddUsers.Text = "사원 등록";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.textBoxAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDepartName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(488, 32);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "검색";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(335, 34);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 21);
            this.textBoxAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "나이";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(194, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 21);
            this.textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "성명";
            // 
            // textBoxDepartName
            // 
            this.textBoxDepartName.Location = new System.Drawing.Point(53, 34);
            this.textBoxDepartName.Name = "textBoxDepartName";
            this.textBoxDepartName.Size = new System.Drawing.Size(100, 21);
            this.textBoxDepartName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "부서명";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(721, 255);
            this.dataGridView1.TabIndex = 8;
            // 
            // SearchUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditUsers);
            this.Controls.Add(this.buttonSearchUsers);
            this.Controls.Add(this.buttonAddUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchUsers";
            this.Text = "SearchUsers";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditUsers;
        private System.Windows.Forms.Button buttonSearchUsers;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}