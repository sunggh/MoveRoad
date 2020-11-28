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
            this.tabControlTask = new System.Windows.Forms.TabControl();
            this.tabPageRegistraion = new System.Windows.Forms.TabPage();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMiddleClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageManagement = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxRegistrant = new System.Windows.Forms.TextBox();
            this.pictureBoxRegistrantSearch = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTaskKeword = new System.Windows.Forms.TextBox();
            this.pictureBoxTaskKewordSearch = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPageMaster = new System.Windows.Forms.TabPage();
            this.treeViewTaskMaster = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlTask.SuspendLayout();
            this.tabPageRegistraion.SuspendLayout();
            this.tabPageManagement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskKewordSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTask
            // 
            this.tabControlTask.Controls.Add(this.tabPageRegistraion);
            this.tabControlTask.Controls.Add(this.tabPageManagement);
            this.tabControlTask.Controls.Add(this.tabPageMaster);
            this.tabControlTask.Location = new System.Drawing.Point(0, 0);
            this.tabControlTask.Name = "tabControlTask";
            this.tabControlTask.SelectedIndex = 0;
            this.tabControlTask.Size = new System.Drawing.Size(745, 412);
            this.tabControlTask.TabIndex = 0;
            // 
            // tabPageRegistraion
            // 
            this.tabPageRegistraion.Controls.Add(this.buttonRegistration);
            this.tabPageRegistraion.Controls.Add(this.textBox1);
            this.tabPageRegistraion.Controls.Add(this.textBoxEndTime);
            this.tabPageRegistraion.Controls.Add(this.label7);
            this.tabPageRegistraion.Controls.Add(this.textBoxStartTime);
            this.tabPageRegistraion.Controls.Add(this.label6);
            this.tabPageRegistraion.Controls.Add(this.label5);
            this.tabPageRegistraion.Controls.Add(this.comboBoxSubClass);
            this.tabPageRegistraion.Controls.Add(this.label4);
            this.tabPageRegistraion.Controls.Add(this.comboBoxMiddleClass);
            this.tabPageRegistraion.Controls.Add(this.label3);
            this.tabPageRegistraion.Controls.Add(this.comboBoxDepartment);
            this.tabPageRegistraion.Controls.Add(this.label2);
            this.tabPageRegistraion.Controls.Add(this.label1);
            this.tabPageRegistraion.Location = new System.Drawing.Point(4, 25);
            this.tabPageRegistraion.Name = "tabPageRegistraion";
            this.tabPageRegistraion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistraion.Size = new System.Drawing.Size(737, 383);
            this.tabPageRegistraion.TabIndex = 0;
            this.tabPageRegistraion.Text = "일일 업무 등록";
            this.tabPageRegistraion.UseVisualStyleBackColor = true;
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonRegistration.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(590, 330);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(121, 36);
            this.buttonRegistration.TabIndex = 34;
            this.buttonRegistration.Text = "등록";
            this.buttonRegistration.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 221);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 145);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = "업무 내용 기재";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(590, 165);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(121, 25);
            this.textBoxEndTime.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "종료시간";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.Location = new System.Drawing.Point(356, 165);
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(121, 25);
            this.textBoxStartTime.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "시작시간";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label5.Font = new System.Drawing.Font("굴림", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(26, 165);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "업무 시작/종료 시간";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSubClass
            // 
            this.comboBoxSubClass.FormattingEnabled = true;
            this.comboBoxSubClass.Location = new System.Drawing.Point(590, 82);
            this.comboBoxSubClass.Name = "comboBoxSubClass";
            this.comboBoxSubClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxSubClass.TabIndex = 27;
            this.comboBoxSubClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label4.Font = new System.Drawing.Font("굴림", 9F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(497, 80);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "업무";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxMiddleClass
            // 
            this.comboBoxMiddleClass.FormattingEnabled = true;
            this.comboBoxMiddleClass.Location = new System.Drawing.Point(356, 82);
            this.comboBoxMiddleClass.Name = "comboBoxMiddleClass";
            this.comboBoxMiddleClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxMiddleClass.TabIndex = 25;
            this.comboBoxMiddleClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxMiddleClass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(263, 80);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "업무구분";
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(119, 82);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDepartment.TabIndex = 23;
            this.comboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartment_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(26, 80);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "부서선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.Font = new System.Drawing.Font("굴림", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "일일 업무 등록";
            // 
            // tabPageManagement
            // 
            this.tabPageManagement.Controls.Add(this.button1);
            this.tabPageManagement.Controls.Add(this.button2);
            this.tabPageManagement.Controls.Add(this.groupBox2);
            this.tabPageManagement.Controls.Add(this.groupBox1);
            this.tabPageManagement.Controls.Add(this.label8);
            this.tabPageManagement.Controls.Add(this.dataGridView1);
            this.tabPageManagement.Location = new System.Drawing.Point(4, 25);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagement.Size = new System.Drawing.Size(737, 383);
            this.tabPageManagement.TabIndex = 1;
            this.tabPageManagement.Text = "일일 업무 관리";
            this.tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.button1.Font = new System.Drawing.Font("굴림", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(629, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "삭제";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.button2.Font = new System.Drawing.Font("굴림", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(539, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "수정";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxRegistrant);
            this.groupBox2.Controls.Add(this.pictureBoxRegistrantSearch);
            this.groupBox2.Location = new System.Drawing.Point(298, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 57);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // textBoxRegistrant
            // 
            this.textBoxRegistrant.Location = new System.Drawing.Point(16, 24);
            this.textBoxRegistrant.Name = "textBoxRegistrant";
            this.textBoxRegistrant.Size = new System.Drawing.Size(171, 25);
            this.textBoxRegistrant.TabIndex = 8;
            this.textBoxRegistrant.Text = "등록자 기반 검색";
            this.textBoxRegistrant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxRegistrantSearch
            // 
            this.pictureBoxRegistrantSearch.Image = global::MOVEROAD.Properties.Resources.search;
            this.pictureBoxRegistrantSearch.Location = new System.Drawing.Point(193, 18);
            this.pictureBoxRegistrantSearch.Name = "pictureBoxRegistrantSearch";
            this.pictureBoxRegistrantSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxRegistrantSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRegistrantSearch.TabIndex = 9;
            this.pictureBoxRegistrantSearch.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTaskKeword);
            this.groupBox1.Controls.Add(this.pictureBoxTaskKewordSearch);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 57);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTaskKeword
            // 
            this.textBoxTaskKeword.Location = new System.Drawing.Point(51, 24);
            this.textBoxTaskKeword.Name = "textBoxTaskKeword";
            this.textBoxTaskKeword.Size = new System.Drawing.Size(171, 25);
            this.textBoxTaskKeword.TabIndex = 4;
            this.textBoxTaskKeword.Text = "업무 키워드 입력";
            this.textBoxTaskKeword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBoxTaskKewordSearch
            // 
            this.pictureBoxTaskKewordSearch.Image = global::MOVEROAD.Properties.Resources.search;
            this.pictureBoxTaskKewordSearch.Location = new System.Drawing.Point(228, 18);
            this.pictureBoxTaskKewordSearch.Name = "pictureBoxTaskKewordSearch";
            this.pictureBoxTaskKewordSearch.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxTaskKewordSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTaskKewordSearch.TabIndex = 5;
            this.pictureBoxTaskKewordSearch.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MOVEROAD.Properties.Resources.calendar;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 34);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label8.Font = new System.Drawing.Font("굴림", 10F);
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(26, 16);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Size = new System.Drawing.Size(140, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = "일일 업무 관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(694, 267);
            this.dataGridView1.TabIndex = 23;
            // 
            // tabPageMaster
            // 
            this.tabPageMaster.Controls.Add(this.treeViewTaskMaster);
            this.tabPageMaster.Controls.Add(this.label9);
            this.tabPageMaster.Location = new System.Drawing.Point(4, 25);
            this.tabPageMaster.Name = "tabPageMaster";
            this.tabPageMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMaster.Size = new System.Drawing.Size(737, 383);
            this.tabPageMaster.TabIndex = 2;
            this.tabPageMaster.Text = "업무 마스터 관리";
            this.tabPageMaster.UseVisualStyleBackColor = true;
            // 
            // treeViewTaskMaster
            // 
            this.treeViewTaskMaster.Location = new System.Drawing.Point(62, 66);
            this.treeViewTaskMaster.Name = "treeViewTaskMaster";
            this.treeViewTaskMaster.Size = new System.Drawing.Size(614, 281);
            this.treeViewTaskMaster.TabIndex = 33;
            this.treeViewTaskMaster.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewTaskMaster_AfterLabelEdit);
            this.treeViewTaskMaster.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewTaskMaster_AfterSelect);
            this.treeViewTaskMaster.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeViewTaskMaster_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label9.Font = new System.Drawing.Font("굴림", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(26, 16);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label9.Size = new System.Drawing.Size(157, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = "업무 마스터 관리";
            // 
            // TaskForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.tabControlTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.tabControlTask.ResumeLayout(false);
            this.tabPageRegistraion.ResumeLayout(false);
            this.tabPageRegistraion.PerformLayout();
            this.tabPageManagement.ResumeLayout(false);
            this.tabPageManagement.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrantSearch)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTaskKewordSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageMaster.ResumeLayout(false);
            this.tabPageMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTask;
        private System.Windows.Forms.TabPage tabPageRegistraion;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMiddleClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRegistrant;
        private System.Windows.Forms.PictureBox pictureBoxRegistrantSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTaskKeword;
        private System.Windows.Forms.PictureBox pictureBoxTaskKewordSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageMaster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeViewTaskMaster;
    }
}