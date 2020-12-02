namespace MOVEROAD
{
    partial class Messenger
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
            this.nameBOX = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.onlineList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBOX
            // 
            this.nameBOX.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameBOX.Location = new System.Drawing.Point(35, 12);
            this.nameBOX.Name = "nameBOX";
            this.nameBOX.Size = new System.Drawing.Size(522, 26);
            this.nameBOX.TabIndex = 0;
            this.nameBOX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameBOX_KeyDown);
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text.Location = new System.Drawing.Point(35, 358);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(522, 26);
            this.text.TabIndex = 2;
            this.text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(522, 308);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // onlineList
            // 
            this.onlineList.FormattingEnabled = true;
            this.onlineList.ItemHeight = 12;
            this.onlineList.Location = new System.Drawing.Point(563, 44);
            this.onlineList.Name = "onlineList";
            this.onlineList.Size = new System.Drawing.Size(170, 340);
            this.onlineList.TabIndex = 4;
            this.onlineList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "온라인";
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 412);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onlineList);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.text);
            this.Controls.Add(this.nameBOX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Messenger";
            this.Text = "Messenger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nameBOX;
        public System.Windows.Forms.TextBox text;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.ListBox onlineList;
        private System.Windows.Forms.Label label1;
    }
}