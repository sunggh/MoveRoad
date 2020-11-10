namespace MOVEROAD
{
    partial class EditUsers
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditUsers
            // 
            this.buttonEditUsers.Location = new System.Drawing.Point(534, 12);
            this.buttonEditUsers.Name = "buttonEditUsers";
            this.buttonEditUsers.Size = new System.Drawing.Size(255, 51);
            this.buttonEditUsers.TabIndex = 7;
            this.buttonEditUsers.Text = "사원 정보 수정";
            this.buttonEditUsers.UseVisualStyleBackColor = true;
            // 
            // buttonSearchUsers
            // 
            this.buttonSearchUsers.Location = new System.Drawing.Point(273, 12);
            this.buttonSearchUsers.Name = "buttonSearchUsers";
            this.buttonSearchUsers.Size = new System.Drawing.Size(255, 51);
            this.buttonSearchUsers.TabIndex = 6;
            this.buttonSearchUsers.Text = "사원 검색";
            this.buttonSearchUsers.UseVisualStyleBackColor = true;
            // 
            // buttonAddUsers
            // 
            this.buttonAddUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonAddUsers.Name = "buttonAddUsers";
            this.buttonAddUsers.Size = new System.Drawing.Size(255, 51);
            this.buttonAddUsers.TabIndex = 5;
            this.buttonAddUsers.Text = "사원 등록";
            this.buttonAddUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 369);
            this.dataGridView1.TabIndex = 9;
            // 
            // EditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditUsers);
            this.Controls.Add(this.buttonSearchUsers);
            this.Controls.Add(this.buttonAddUsers);
            this.Name = "EditUsers";
            this.Text = "EditUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditUsers;
        private System.Windows.Forms.Button buttonSearchUsers;
        private System.Windows.Forms.Button buttonAddUsers;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}