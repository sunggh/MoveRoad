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
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFinshTime = new System.Windows.Forms.DateTimePicker();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxRegistrant = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePickerSearchTask = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTaskKeword = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTask = new System.Windows.Forms.DataGridView();
            this.tabPageMaster = new System.Windows.Forms.TabPage();
            this.treeViewTaskMaster = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControlTask.SuspendLayout();
            this.tabPageRegistraion.SuspendLayout();
            this.tabPageManagement.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).BeginInit();
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
            this.tabPageRegistraion.Controls.Add(this.dateTimePickerStartTime);
            this.tabPageRegistraion.Controls.Add(this.dateTimePickerFinshTime);
            this.tabPageRegistraion.Controls.Add(this.buttonRegistration);
            this.tabPageRegistraion.Controls.Add(this.textBoxTask);
            this.tabPageRegistraion.Controls.Add(this.label7);
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
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(356, 142);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(121, 25);
            this.dateTimePickerStartTime.TabIndex = 37;
            this.dateTimePickerStartTime.ValueChanged += new System.EventHandler(this.dateTimePickerStartTime_ValueChanged);
            // 
            // dateTimePickerFinshTime
            // 
            this.dateTimePickerFinshTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerFinshTime.Location = new System.Drawing.Point(590, 144);
            this.dateTimePickerFinshTime.Name = "dateTimePickerFinshTime";
            this.dateTimePickerFinshTime.Size = new System.Drawing.Size(121, 25);
            this.dateTimePickerFinshTime.TabIndex = 36;
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
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(29, 205);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.Size = new System.Drawing.Size(555, 161);
            this.textBoxTask.TabIndex = 33;
            this.textBoxTask.Text = "상세 업무 내용 기재";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(507, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "종료시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 149);
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
            this.label5.Location = new System.Drawing.Point(26, 144);
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
            this.tabPageManagement.Controls.Add(this.groupBox2);
            this.tabPageManagement.Controls.Add(this.groupBox1);
            this.tabPageManagement.Controls.Add(this.label8);
            this.tabPageManagement.Controls.Add(this.dataGridViewTask);
            this.tabPageManagement.Location = new System.Drawing.Point(4, 25);
            this.tabPageManagement.Name = "tabPageManagement";
            this.tabPageManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageManagement.Size = new System.Drawing.Size(737, 383);
            this.tabPageManagement.TabIndex = 1;
            this.tabPageManagement.Text = "일일 업무 관리";
            this.tabPageManagement.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxRegistrant);
            this.groupBox2.Location = new System.Drawing.Point(330, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 57);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 31;
            this.label10.Text = "이름";
            // 
            // comboBoxRegistrant
            // 
            this.comboBoxRegistrant.FormattingEnabled = true;
            this.comboBoxRegistrant.Location = new System.Drawing.Point(46, 22);
            this.comboBoxRegistrant.Name = "comboBoxRegistrant";
            this.comboBoxRegistrant.Size = new System.Drawing.Size(121, 23);
            this.comboBoxRegistrant.TabIndex = 29;
            this.comboBoxRegistrant.Text = "등록자";
            this.comboBoxRegistrant.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegistrant_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.dateTimePickerSearchTask);
            this.groupBox1.Controls.Add(this.comboBoxTaskKeword);
            this.groupBox1.Location = new System.Drawing.Point(21, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 57);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 32;
            this.label11.Text = "업무";
            // 
            // dateTimePickerSearchTask
            // 
            this.dateTimePickerSearchTask.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSearchTask.Location = new System.Drawing.Point(12, 20);
            this.dateTimePickerSearchTask.Name = "dateTimePickerSearchTask";
            this.dateTimePickerSearchTask.Size = new System.Drawing.Size(112, 25);
            this.dateTimePickerSearchTask.TabIndex = 29;
            // 
            // comboBoxTaskKeword
            // 
            this.comboBoxTaskKeword.FormattingEnabled = true;
            this.comboBoxTaskKeword.Location = new System.Drawing.Point(176, 22);
            this.comboBoxTaskKeword.Name = "comboBoxTaskKeword";
            this.comboBoxTaskKeword.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTaskKeword.TabIndex = 30;
            this.comboBoxTaskKeword.Text = "업무 키워드";
            this.comboBoxTaskKeword.SelectedIndexChanged += new System.EventHandler(this.comboBoxTaskKeword_SelectedIndexChanged);
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
            // dataGridViewTask
            // 
            this.dataGridViewTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTask.Location = new System.Drawing.Point(21, 112);
            this.dataGridViewTask.Name = "dataGridViewTask";
            this.dataGridViewTask.RowHeadersWidth = 51;
            this.dataGridViewTask.RowTemplate.Height = 27;
            this.dataGridViewTask.Size = new System.Drawing.Size(694, 267);
            this.dataGridViewTask.TabIndex = 23;
            this.dataGridViewTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTask_CellContentClick);
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
            this.treeViewTaskMaster.Location = new System.Drawing.Point(58, 56);
            this.treeViewTaskMaster.Name = "treeViewTaskMaster";
            this.treeViewTaskMaster.Size = new System.Drawing.Size(614, 308);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTask)).EndInit();
            this.tabPageMaster.ResumeLayout(false);
            this.tabPageMaster.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTask;
        private System.Windows.Forms.TabPage tabPageRegistraion;
        private System.Windows.Forms.TabPage tabPageManagement;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMiddleClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridViewTask;
        private System.Windows.Forms.TabPage tabPageMaster;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TreeView treeViewTaskMaster;
        private System.Windows.Forms.DateTimePicker dateTimePickerFinshTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerSearchTask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxRegistrant;
        private System.Windows.Forms.ComboBox comboBoxTaskKeword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}