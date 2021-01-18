
namespace POPDisplay.BaseForm
{
    partial class BaseForm
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
            this.components = new System.ComponentModel.Container();
            this.pnl_All = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_CancleBtn = new System.Windows.Forms.PictureBox();
            this.pic_MinSizeBtn = new System.Windows.Forms.PictureBox();
            this.pic_MaxSizeBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_All
            // 
            this.pnl_All.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_All.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_All.Location = new System.Drawing.Point(7, 144);
            this.pnl_All.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_All.Name = "pnl_All";
            this.pnl_All.Size = new System.Drawing.Size(2348, 1020);
            this.pnl_All.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(146, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 74);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base(Title)";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Time.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Time.Location = new System.Drawing.Point(1046, 9);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(271, 131);
            this.lbl_Time.TabIndex = 5;
            this.lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::POPDisplay.Properties.Resources.cowboy_2028626_1280;
            this.pictureBox1.Location = new System.Drawing.Point(7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pic_CancleBtn
            // 
            this.pic_CancleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_CancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_CancleBtn.Image = global::POPDisplay.Properties.Resources.Cancel_32x32;
            this.pic_CancleBtn.Location = new System.Drawing.Point(2279, -1);
            this.pic_CancleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pic_CancleBtn.Name = "pic_CancleBtn";
            this.pic_CancleBtn.Size = new System.Drawing.Size(75, 75);
            this.pic_CancleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CancleBtn.TabIndex = 0;
            this.pic_CancleBtn.TabStop = false;
            this.pic_CancleBtn.Click += new System.EventHandler(this.pic_CancleBtn_Click);
            // 
            // pic_MinSizeBtn
            // 
            this.pic_MinSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_MinSizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_MinSizeBtn.Image = global::POPDisplay.Properties.Resources.Remove_32x32;
            this.pic_MinSizeBtn.Location = new System.Drawing.Point(2101, -1);
            this.pic_MinSizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pic_MinSizeBtn.Name = "pic_MinSizeBtn";
            this.pic_MinSizeBtn.Size = new System.Drawing.Size(75, 75);
            this.pic_MinSizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MinSizeBtn.TabIndex = 2;
            this.pic_MinSizeBtn.TabStop = false;
            this.pic_MinSizeBtn.Click += new System.EventHandler(this.pic_MinSizeBtn_Click);
            // 
            // pic_MaxSizeBtn
            // 
            this.pic_MaxSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_MaxSizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_MaxSizeBtn.Image = global::POPDisplay.Properties.Resources.Add_32x32;
            this.pic_MaxSizeBtn.Location = new System.Drawing.Point(2190, -1);
            this.pic_MaxSizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pic_MaxSizeBtn.Name = "pic_MaxSizeBtn";
            this.pic_MaxSizeBtn.Size = new System.Drawing.Size(75, 75);
            this.pic_MaxSizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MaxSizeBtn.TabIndex = 1;
            this.pic_MaxSizeBtn.TabStop = false;
            this.pic_MaxSizeBtn.Click += new System.EventHandler(this.pic_MaxSizeBtn_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(2361, 1171);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_CancleBtn);
            this.Controls.Add(this.pic_MinSizeBtn);
            this.Controls.Add(this.pnl_All);
            this.Controls.Add(this.pic_MaxSizeBtn);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BaseForm";
            this.Text = "SearchBase";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseForm_FormClosing);
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnl_All;
        public System.Windows.Forms.PictureBox pic_CancleBtn;
        public System.Windows.Forms.PictureBox pic_MaxSizeBtn;
        public System.Windows.Forms.PictureBox pic_MinSizeBtn;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Timer timer1;
    }
}