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
            this.tabPageNewInsert = new System.Windows.Forms.TabPage();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.comboBoxDrafter = new System.Windows.Forms.ComboBox();
            this.comboBoxWork = new System.Windows.Forms.ComboBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageToMe = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDetail_req = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.buttonTurn = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.tabPageFromMe = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxDetail_turn = new System.Windows.Forms.TextBox();
            this.textBoxDetail_done = new System.Windows.Forms.TextBox();
            this.textBoxSignTurnMemo = new System.Windows.Forms.TextBox();
            this.dataGridViewSignTurnList = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewSignList = new System.Windows.Forms.DataGridView();
            this.tabControlSign.SuspendLayout();
            this.tabPageNewInsert.SuspendLayout();
            this.tabPageToMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.tabPageFromMe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignTurnList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSign
            // 
            this.tabControlSign.Controls.Add(this.tabPageNewInsert);
            this.tabControlSign.Controls.Add(this.tabPageToMe);
            this.tabControlSign.Controls.Add(this.tabPageFromMe);
            this.tabControlSign.Location = new System.Drawing.Point(13, 12);
            this.tabControlSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSign.Name = "tabControlSign";
            this.tabControlSign.SelectedIndex = 0;
            this.tabControlSign.Size = new System.Drawing.Size(825, 489);
            this.tabControlSign.TabIndex = 0;
            this.tabControlSign.SelectedIndexChanged += new System.EventHandler(this.tabControlSign_SelectedIndexChanged);
            // 
            // tabPageNewInsert
            // 
            this.tabPageNewInsert.Controls.Add(this.buttonInsert);
            this.tabPageNewInsert.Controls.Add(this.comboBoxDrafter);
            this.tabPageNewInsert.Controls.Add(this.comboBoxWork);
            this.tabPageNewInsert.Controls.Add(this.textBoxComment);
            this.tabPageNewInsert.Controls.Add(this.textBoxContent);
            this.tabPageNewInsert.Controls.Add(this.textBoxTitle);
            this.tabPageNewInsert.Controls.Add(this.label5);
            this.tabPageNewInsert.Controls.Add(this.label4);
            this.tabPageNewInsert.Controls.Add(this.label3);
            this.tabPageNewInsert.Controls.Add(this.label2);
            this.tabPageNewInsert.Controls.Add(this.label1);
            this.tabPageNewInsert.Location = new System.Drawing.Point(4, 25);
            this.tabPageNewInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNewInsert.Name = "tabPageNewInsert";
            this.tabPageNewInsert.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNewInsert.Size = new System.Drawing.Size(817, 460);
            this.tabPageNewInsert.TabIndex = 0;
            this.tabPageNewInsert.Text = "신규 결재 등록";
            this.tabPageNewInsert.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Location = new System.Drawing.Point(312, 370);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(192, 55);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "등록하기";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxDrafter
            // 
            this.comboBoxDrafter.FormattingEnabled = true;
            this.comboBoxDrafter.Location = new System.Drawing.Point(627, 51);
            this.comboBoxDrafter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDrafter.Name = "comboBoxDrafter";
            this.comboBoxDrafter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDrafter.TabIndex = 9;
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Location = new System.Drawing.Point(411, 51);
            this.comboBoxWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWork.TabIndex = 8;
            this.comboBoxWork.SelectedIndexChanged += new System.EventHandler(this.comboBoxWork_SelectedIndexChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(90, 285);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(658, 54);
            this.textBoxComment.TabIndex = 7;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(90, 108);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(658, 149);
            this.textBoxContent.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(90, 50);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(175, 25);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "코멘트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "결재자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(333, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "업무 선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // tabPageToMe
            // 
            this.tabPageToMe.Controls.Add(this.label11);
            this.tabPageToMe.Controls.Add(this.textBoxDetail_req);
            this.tabPageToMe.Controls.Add(this.label9);
            this.tabPageToMe.Controls.Add(this.label7);
            this.tabPageToMe.Controls.Add(this.label6);
            this.tabPageToMe.Controls.Add(this.textBoxMemo);
            this.tabPageToMe.Controls.Add(this.buttonTurn);
            this.tabPageToMe.Controls.Add(this.buttonSign);
            this.tabPageToMe.Controls.Add(this.dataGridViewRequest);
            this.tabPageToMe.Location = new System.Drawing.Point(4, 25);
            this.tabPageToMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageToMe.Name = "tabPageToMe";
            this.tabPageToMe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageToMe.Size = new System.Drawing.Size(817, 460);
            this.tabPageToMe.TabIndex = 1;
            this.tabPageToMe.Text = "결재 요청 내역";
            this.tabPageToMe.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(634, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "내용 상세보기";
            // 
            // textBoxDetail_req
            // 
            this.textBoxDetail_req.Location = new System.Drawing.Point(637, 25);
            this.textBoxDetail_req.Multiline = true;
            this.textBoxDetail_req.Name = "textBoxDetail_req";
            this.textBoxDetail_req.ReadOnly = true;
            this.textBoxDetail_req.Size = new System.Drawing.Size(174, 267);
            this.textBoxDetail_req.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "결재 내역";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "메모";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(66, 309);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(745, 62);
            this.textBoxMemo.TabIndex = 3;
            // 
            // buttonTurn
            // 
            this.buttonTurn.Location = new System.Drawing.Point(436, 393);
            this.buttonTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTurn.Name = "buttonTurn";
            this.buttonTurn.Size = new System.Drawing.Size(214, 48);
            this.buttonTurn.TabIndex = 2;
            this.buttonTurn.Text = "반려하기";
            this.buttonTurn.UseVisualStyleBackColor = true;
            this.buttonTurn.Click += new System.EventHandler(this.buttonTurn_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.Location = new System.Drawing.Point(173, 393);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(214, 48);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "결재하기";
            this.buttonSign.UseVisualStyleBackColor = true;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.AllowUserToAddRows = false;
            this.dataGridViewRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.RowHeadersWidth = 51;
            this.dataGridViewRequest.RowTemplate.Height = 27;
            this.dataGridViewRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequest.Size = new System.Drawing.Size(624, 267);
            this.dataGridViewRequest.TabIndex = 0;
            this.dataGridViewRequest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequest_CellClick);
            // 
            // tabPageFromMe
            // 
            this.tabPageFromMe.Controls.Add(this.label13);
            this.tabPageFromMe.Controls.Add(this.label12);
            this.tabPageFromMe.Controls.Add(this.textBoxDetail_turn);
            this.tabPageFromMe.Controls.Add(this.textBoxDetail_done);
            this.tabPageFromMe.Controls.Add(this.textBoxSignTurnMemo);
            this.tabPageFromMe.Controls.Add(this.dataGridViewSignTurnList);
            this.tabPageFromMe.Controls.Add(this.label10);
            this.tabPageFromMe.Controls.Add(this.label8);
            this.tabPageFromMe.Controls.Add(this.dataGridViewSignList);
            this.tabPageFromMe.Location = new System.Drawing.Point(4, 25);
            this.tabPageFromMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFromMe.Name = "tabPageFromMe";
            this.tabPageFromMe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageFromMe.Size = new System.Drawing.Size(817, 460);
            this.tabPageFromMe.TabIndex = 2;
            this.tabPageFromMe.Text = "내가 등록한 결재";
            this.tabPageFromMe.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(627, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "내용 상세보기";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(629, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "내용 상세보기";
            // 
            // textBoxDetail_turn
            // 
            this.textBoxDetail_turn.Location = new System.Drawing.Point(629, 229);
            this.textBoxDetail_turn.Multiline = true;
            this.textBoxDetail_turn.Name = "textBoxDetail_turn";
            this.textBoxDetail_turn.ReadOnly = true;
            this.textBoxDetail_turn.Size = new System.Drawing.Size(181, 156);
            this.textBoxDetail_turn.TabIndex = 7;
            // 
            // textBoxDetail_done
            // 
            this.textBoxDetail_done.Location = new System.Drawing.Point(630, 25);
            this.textBoxDetail_done.Multiline = true;
            this.textBoxDetail_done.Name = "textBoxDetail_done";
            this.textBoxDetail_done.ReadOnly = true;
            this.textBoxDetail_done.Size = new System.Drawing.Size(181, 177);
            this.textBoxDetail_done.TabIndex = 6;
            // 
            // textBoxSignTurnMemo
            // 
            this.textBoxSignTurnMemo.Location = new System.Drawing.Point(9, 390);
            this.textBoxSignTurnMemo.Multiline = true;
            this.textBoxSignTurnMemo.Name = "textBoxSignTurnMemo";
            this.textBoxSignTurnMemo.Size = new System.Drawing.Size(802, 55);
            this.textBoxSignTurnMemo.TabIndex = 5;
            // 
            // dataGridViewSignTurnList
            // 
            this.dataGridViewSignTurnList.AllowUserToAddRows = false;
            this.dataGridViewSignTurnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSignTurnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignTurnList.Location = new System.Drawing.Point(9, 229);
            this.dataGridViewSignTurnList.Name = "dataGridViewSignTurnList";
            this.dataGridViewSignTurnList.RowHeadersWidth = 51;
            this.dataGridViewSignTurnList.RowTemplate.Height = 27;
            this.dataGridViewSignTurnList.Size = new System.Drawing.Size(614, 155);
            this.dataGridViewSignTurnList.TabIndex = 4;
            this.dataGridViewSignTurnList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSignTurnList_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "반려 내역";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "결재 내역";
            // 
            // dataGridViewSignList
            // 
            this.dataGridViewSignList.AllowUserToAddRows = false;
            this.dataGridViewSignList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSignList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignList.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewSignList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSignList.Name = "dataGridViewSignList";
            this.dataGridViewSignList.RowHeadersWidth = 51;
            this.dataGridViewSignList.RowTemplate.Height = 27;
            this.dataGridViewSignList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSignList.Size = new System.Drawing.Size(617, 177);
            this.dataGridViewSignList.TabIndex = 0;
            this.dataGridViewSignList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSignList_CellClick);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 515);
            this.Controls.Add(this.tabControlSign);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.tabControlSign.ResumeLayout(false);
            this.tabPageNewInsert.ResumeLayout(false);
            this.tabPageNewInsert.PerformLayout();
            this.tabPageToMe.ResumeLayout(false);
            this.tabPageToMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.tabPageFromMe.ResumeLayout(false);
            this.tabPageFromMe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignTurnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSign;
        private System.Windows.Forms.TabPage tabPageNewInsert;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.ComboBox comboBoxDrafter;
        private System.Windows.Forms.ComboBox comboBoxWork;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageToMe;
        private System.Windows.Forms.TabPage tabPageFromMe;
        private System.Windows.Forms.TextBox textBoxMemo;
        private System.Windows.Forms.Button buttonTurn;
        private System.Windows.Forms.Button buttonSign;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewSignList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSignTurnMemo;
        private System.Windows.Forms.DataGridView dataGridViewSignTurnList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxDetail_req;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxDetail_turn;
        private System.Windows.Forms.TextBox textBoxDetail_done;
    }
}