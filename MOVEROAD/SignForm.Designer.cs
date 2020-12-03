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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.textBoxMemo = new System.Windows.Forms.TextBox();
            this.buttonTurn = new System.Windows.Forms.Button();
            this.buttonSign = new System.Windows.Forms.Button();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.tabPageFromMe = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
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
            this.tabControlSign.Location = new System.Drawing.Point(-3, 0);
            this.tabControlSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSign.Name = "tabControlSign";
            this.tabControlSign.SelectedIndex = 0;
            this.tabControlSign.Size = new System.Drawing.Size(858, 519);
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
            this.tabPageNewInsert.Size = new System.Drawing.Size(850, 490);
            this.tabPageNewInsert.TabIndex = 0;
            this.tabPageNewInsert.Text = "신규 결재 등록";
            this.tabPageNewInsert.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonInsert.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonInsert.Location = new System.Drawing.Point(335, 389);
            this.buttonInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(185, 65);
            this.buttonInsert.TabIndex = 10;
            this.buttonInsert.Text = "등록하기";
            this.buttonInsert.UseVisualStyleBackColor = false;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // comboBoxDrafter
            // 
            this.comboBoxDrafter.FormattingEnabled = true;
            this.comboBoxDrafter.Location = new System.Drawing.Point(662, 71);
            this.comboBoxDrafter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDrafter.Name = "comboBoxDrafter";
            this.comboBoxDrafter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxDrafter.TabIndex = 9;
            // 
            // comboBoxWork
            // 
            this.comboBoxWork.FormattingEnabled = true;
            this.comboBoxWork.Location = new System.Drawing.Point(430, 71);
            this.comboBoxWork.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxWork.Name = "comboBoxWork";
            this.comboBoxWork.Size = new System.Drawing.Size(121, 23);
            this.comboBoxWork.TabIndex = 8;
            this.comboBoxWork.SelectedIndexChanged += new System.EventHandler(this.comboBoxWork_SelectedIndexChanged);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(125, 305);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(658, 54);
            this.textBoxComment.TabIndex = 7;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(125, 128);
            this.textBoxContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(658, 149);
            this.textBoxContent.TabIndex = 6;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(125, 70);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(175, 25);
            this.textBoxTitle.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(47, 305);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "코멘트";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(62, 128);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "내용";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(584, 70);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "결재자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(332, 69);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "업무 선택";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(62, 69);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "제목";
            // 
            // tabPageToMe
            // 
            this.tabPageToMe.Controls.Add(this.label11);
            this.tabPageToMe.Controls.Add(this.textBoxDetail_req);
            this.tabPageToMe.Controls.Add(this.label9);
            this.tabPageToMe.Controls.Add(this.label7);
            this.tabPageToMe.Controls.Add(this.textBoxMemo);
            this.tabPageToMe.Controls.Add(this.buttonTurn);
            this.tabPageToMe.Controls.Add(this.buttonSign);
            this.tabPageToMe.Controls.Add(this.dataGridViewRequest);
            this.tabPageToMe.Location = new System.Drawing.Point(4, 25);
            this.tabPageToMe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageToMe.Name = "tabPageToMe";
            this.tabPageToMe.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageToMe.Size = new System.Drawing.Size(850, 490);
            this.tabPageToMe.TabIndex = 1;
            this.tabPageToMe.Text = "결재 요청 내역";
            this.tabPageToMe.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(671, 21);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label11.Size = new System.Drawing.Size(122, 25);
            this.label11.TabIndex = 7;
            this.label11.Text = "내용 상세보기";
            // 
            // textBoxDetail_req
            // 
            this.textBoxDetail_req.Location = new System.Drawing.Point(668, 49);
            this.textBoxDetail_req.Multiline = true;
            this.textBoxDetail_req.Name = "textBoxDetail_req";
            this.textBoxDetail_req.ReadOnly = true;
            this.textBoxDetail_req.Size = new System.Drawing.Size(170, 267);
            this.textBoxDetail_req.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(14, 22);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "결재 내역";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(23, 362);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "메모";
            // 
            // textBoxMemo
            // 
            this.textBoxMemo.Location = new System.Drawing.Point(86, 340);
            this.textBoxMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMemo.Multiline = true;
            this.textBoxMemo.Name = "textBoxMemo";
            this.textBoxMemo.Size = new System.Drawing.Size(725, 62);
            this.textBoxMemo.TabIndex = 3;
            // 
            // buttonTurn
            // 
            this.buttonTurn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonTurn.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonTurn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonTurn.Location = new System.Drawing.Point(436, 424);
            this.buttonTurn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTurn.Name = "buttonTurn";
            this.buttonTurn.Size = new System.Drawing.Size(214, 48);
            this.buttonTurn.TabIndex = 2;
            this.buttonTurn.Text = "반려하기";
            this.buttonTurn.UseVisualStyleBackColor = false;
            this.buttonTurn.Click += new System.EventHandler(this.buttonTurn_Click);
            // 
            // buttonSign
            // 
            this.buttonSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.buttonSign.Font = new System.Drawing.Font("굴림", 10F);
            this.buttonSign.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSign.Location = new System.Drawing.Point(173, 424);
            this.buttonSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSign.Name = "buttonSign";
            this.buttonSign.Size = new System.Drawing.Size(214, 48);
            this.buttonSign.TabIndex = 1;
            this.buttonSign.Text = "결재하기";
            this.buttonSign.UseVisualStyleBackColor = false;
            this.buttonSign.Click += new System.EventHandler(this.buttonSign_Click);
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.AllowUserToAddRows = false;
            this.dataGridViewRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRequest.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewRequest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.GridColor = System.Drawing.Color.Black;
            this.dataGridViewRequest.Location = new System.Drawing.Point(11, 49);
            this.dataGridViewRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRequest.RowHeadersVisible = false;
            this.dataGridViewRequest.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewRequest.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewRequest.RowTemplate.Height = 27;
            this.dataGridViewRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequest.Size = new System.Drawing.Size(639, 267);
            this.dataGridViewRequest.TabIndex = 0;
            this.dataGridViewRequest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequest_CellDoubleClick);
            // 
            // tabPageFromMe
            // 
            this.tabPageFromMe.Controls.Add(this.label14);
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
            this.tabPageFromMe.Size = new System.Drawing.Size(850, 490);
            this.tabPageFromMe.TabIndex = 2;
            this.tabPageFromMe.Text = "내가 등록한 결재";
            this.tabPageFromMe.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(21, 425);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label14.Size = new System.Drawing.Size(57, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "메모";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(652, 223);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label13.Size = new System.Drawing.Size(122, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "내용 상세보기";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(652, 10);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label12.Size = new System.Drawing.Size(122, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "내용 상세보기";
            // 
            // textBoxDetail_turn
            // 
            this.textBoxDetail_turn.Location = new System.Drawing.Point(644, 254);
            this.textBoxDetail_turn.Multiline = true;
            this.textBoxDetail_turn.Name = "textBoxDetail_turn";
            this.textBoxDetail_turn.ReadOnly = true;
            this.textBoxDetail_turn.Size = new System.Drawing.Size(182, 143);
            this.textBoxDetail_turn.TabIndex = 7;
            // 
            // textBoxDetail_done
            // 
            this.textBoxDetail_done.Location = new System.Drawing.Point(644, 37);
            this.textBoxDetail_done.Multiline = true;
            this.textBoxDetail_done.Name = "textBoxDetail_done";
            this.textBoxDetail_done.ReadOnly = true;
            this.textBoxDetail_done.Size = new System.Drawing.Size(182, 177);
            this.textBoxDetail_done.TabIndex = 6;
            // 
            // textBoxSignTurnMemo
            // 
            this.textBoxSignTurnMemo.Location = new System.Drawing.Point(84, 413);
            this.textBoxSignTurnMemo.Multiline = true;
            this.textBoxSignTurnMemo.Name = "textBoxSignTurnMemo";
            this.textBoxSignTurnMemo.ReadOnly = true;
            this.textBoxSignTurnMemo.Size = new System.Drawing.Size(742, 55);
            this.textBoxSignTurnMemo.TabIndex = 5;
            // 
            // dataGridViewSignTurnList
            // 
            this.dataGridViewSignTurnList.AllowUserToAddRows = false;
            this.dataGridViewSignTurnList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSignTurnList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSignTurnList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewSignTurnList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSignTurnList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSignTurnList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignTurnList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSignTurnList.Location = new System.Drawing.Point(20, 254);
            this.dataGridViewSignTurnList.Name = "dataGridViewSignTurnList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSignTurnList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSignTurnList.RowHeadersVisible = false;
            this.dataGridViewSignTurnList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewSignTurnList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSignTurnList.RowTemplate.Height = 27;
            this.dataGridViewSignTurnList.Size = new System.Drawing.Size(617, 143);
            this.dataGridViewSignTurnList.TabIndex = 4;
            this.dataGridViewSignTurnList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSignTurnList_CellDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(21, 223);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "반려 내역";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(20, 10);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 2;
            this.label8.Text = "결재 내역";
            // 
            // dataGridViewSignList
            // 
            this.dataGridViewSignList.AllowUserToAddRows = false;
            this.dataGridViewSignList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSignList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSignList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewSignList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSignList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSignList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSignList.GridColor = System.Drawing.Color.Black;
            this.dataGridViewSignList.Location = new System.Drawing.Point(20, 37);
            this.dataGridViewSignList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSignList.Name = "dataGridViewSignList";
            this.dataGridViewSignList.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSignList.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSignList.RowHeadersVisible = false;
            this.dataGridViewSignList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewSignList.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSignList.RowTemplate.Height = 27;
            this.dataGridViewSignList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSignList.Size = new System.Drawing.Size(617, 177);
            this.dataGridViewSignList.TabIndex = 0;
            this.dataGridViewSignList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSignList_CellDoubleClick);
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(71)))), ((int)(((byte)(117)))));
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
        private System.Windows.Forms.Label label14;
    }
}