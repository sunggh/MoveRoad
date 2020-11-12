namespace MOVEROAD
{
    partial class SignForm
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
            this.tabControlSign = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxDrafter = new System.Windows.Forms.ComboBox();
            this.comboBoxSubClass = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.buttonTurn = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewSignDone = new System.Windows.Forms.DataGridView();
            this.dataGridViewSignList = new System.Windows.Forms.DataGridView();
            this.tabControlSign.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignDone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSign
            // 
            this.tabControlSign.Controls.Add(this.tabPage1);
            this.tabControlSign.Controls.Add(this.tabPage2);
            this.tabControlSign.Controls.Add(this.tabPage3);
            this.tabControlSign.Location = new System.Drawing.Point(11, 10);
            this.tabControlSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSign.Name = "tabControlSign";
            this.tabControlSign.SelectedIndex = 0;
            this.tabControlSign.Size = new System.Drawing.Size(722, 391);
            this.tabControlSign.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonInsert);
            this.tabPage1.Controls.Add(this.comboBoxDrafter);
            this.tabPage1.Controls.Add(this.comboBoxSubClass);
            this.tabPage1.Controls.Add(this.textBoxComment);
            this.tabPage1.Controls.Add(this.textBoxContent);
            this.tabPage1.Controls.Add(this.textBoxTitle);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(714, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "신규 결재 등록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(273, 296);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(168, 44);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "등록하기";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxDrafter
            // 
            this.comboBoxDrafter.FormattingEnabled = true;
            this.comboBoxDrafter.Location = new System.Drawing.Point(549, 41);
            this.comboBoxDrafter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDrafter.Name = "comboBoxDrafter";
            this.comboBoxDrafter.Size = new System.Drawing.Size(106, 20);
            this.comboBoxDrafter.TabIndex = 9;
            // 
            // comboBoxSubClass
            // 
            this.comboBoxSubClass.FormattingEnabled = true;
            this.comboBoxSubClass.Location = new System.Drawing.Point(360, 41);
            this.comboBoxSubClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSubClass.Name = "comboBoxSubClass";
            this.comboBoxSubClass.Size = new System.Drawing.Size(106, 20);
            this.comboBoxSubClass.TabIndex = 8;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(79, 228);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(576, 44);
            this.textBoxComment.TabIndex = 7;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(79, 86);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(576, 120);
            this.textBoxContent.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(79, 40);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(154, 21);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "코멘트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(499, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "결재자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "업무 선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxMemo);
            this.tabPage2.Controls.Add(this.buttonTurn);
            this.tabPage2.Controls.Add(this.buttonSign);
            this.tabPage2.Controls.Add(this.dataGridViewRequest);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(714, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "결재 요청 내역";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "메모";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(93, 217);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(545, 50);
            this.textBoxMemo.TabIndex = 3;
            // 
            // buttonTurn
            // 
            this.buttonTurn.Location = new System.Drawing.Point(371, 283);
            this.buttonTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTurn.Name = "buttonTurn";
            this.buttonTurn.Size = new System.Drawing.Size(187, 38);
            this.buttonTurn.TabIndex = 2;
            this.buttonTurn.Text = "반려하기";
            this.buttonTurn.UseVisualStyleBackColor = true;
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(141, 283);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(187, 38);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "결재하기";
            this.buttonSign.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(38, 43);
            this.dataGridViewRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 51;
            this.dataGridViewRequest.RowTemplate.Height = 27;
            this.dataGridViewRequest.Size = new System.Drawing.Size(634, 161);
            this.dataGridViewRequest.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.dataGridViewSignDone);
            this.tabPage3.Controls.Add(this.dataGridViewSignList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(714, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "내가 등록한 결재";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "결재 완료";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "결재 내역";
            // 
            // dataGridViewSignDone
            // 
            this.dataGridViewSignDone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignDone.Location = new System.Drawing.Point(21, 205);
            this.dataGridViewSignDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSignDone.Name = "dataGridViewSignDone";
            this.dataGridViewSignDone.RowHeadersWidth = 51;
            this.dataGridViewSignDone.RowTemplate.Height = 27;
            this.dataGridViewSignDone.Size = new System.Drawing.Size(665, 118);
            this.dataGridViewSignDone.TabIndex = 1;
            // 
            // dataGridViewSignList
            // 
            this.dataGridViewSignList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignList.Location = new System.Drawing.Point(21, 46);
            this.dataGridViewSignList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSignList.Name = "dataGridViewSignList";
            this.dataGridViewSignList.RowHeadersWidth = 51;
            this.dataGridViewSignList.RowTemplate.Height = 27;
            this.dataGridViewSignList.Size = new System.Drawing.Size(665, 117);
            this.dataGridViewSignList.TabIndex = 0;
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.tabControlSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.tabControlSign.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignDone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSign;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxDrafter;
        private System.Windows.Forms.ComboBox comboBoxSubClass;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button buttonTurn;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewSignDone;
        private System.Windows.Forms.DataGridView dataGridViewSignList;
    }
}