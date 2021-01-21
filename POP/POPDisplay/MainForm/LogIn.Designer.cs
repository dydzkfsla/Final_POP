
namespace POPDisplay.MainForm
{
    partial class LogIn
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
            this.pic_CancleBtn = new System.Windows.Forms.PictureBox();
            this.pic_MinSizeBtn = new System.Windows.Forms.PictureBox();
            this.pic_MaxSizeBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Pwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_CancleBtn
            // 
            this.pic_CancleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_CancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_CancleBtn.Image = global::POPDisplay.Properties.Resources.Cancel_32x32;
            this.pic_CancleBtn.Location = new System.Drawing.Point(1349, 15);
            this.pic_CancleBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pic_CancleBtn.Name = "pic_CancleBtn";
            this.pic_CancleBtn.Size = new System.Drawing.Size(60, 60);
            this.pic_CancleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CancleBtn.TabIndex = 3;
            this.pic_CancleBtn.TabStop = false;
            this.pic_CancleBtn.Click += new System.EventHandler(this.pic_CancleBtn_Click);
            // 
            // pic_MinSizeBtn
            // 
            this.pic_MinSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_MinSizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_MinSizeBtn.Image = global::POPDisplay.Properties.Resources.Remove_32x32;
            this.pic_MinSizeBtn.Location = new System.Drawing.Point(1205, 15);
            this.pic_MinSizeBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pic_MinSizeBtn.Name = "pic_MinSizeBtn";
            this.pic_MinSizeBtn.Size = new System.Drawing.Size(60, 60);
            this.pic_MinSizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MinSizeBtn.TabIndex = 5;
            this.pic_MinSizeBtn.TabStop = false;
            this.pic_MinSizeBtn.Click += new System.EventHandler(this.pic_MinSizeBtn_Click);
            // 
            // pic_MaxSizeBtn
            // 
            this.pic_MaxSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_MaxSizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_MaxSizeBtn.Image = global::POPDisplay.Properties.Resources.Add_32x32;
            this.pic_MaxSizeBtn.Location = new System.Drawing.Point(1277, 15);
            this.pic_MaxSizeBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pic_MaxSizeBtn.Name = "pic_MaxSizeBtn";
            this.pic_MaxSizeBtn.Size = new System.Drawing.Size(60, 60);
            this.pic_MaxSizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MaxSizeBtn.TabIndex = 4;
            this.pic_MaxSizeBtn.TabStop = false;
            this.pic_MaxSizeBtn.Click += new System.EventHandler(this.pic_MaxSizeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::POPDisplay.Properties.Resources.pistol_596564_1280;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1424, 881);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(258, 346);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "직원번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(258, 532);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 34);
            this.label2.TabIndex = 8;
            this.label2.Text = "비밀번호";
            // 
            // txt_ID
            // 
            this.txt_ID.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_ID.Location = new System.Drawing.Point(388, 343);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(648, 41);
            this.txt_ID.TabIndex = 9;
            // 
            // txt_Pwd
            // 
            this.txt_Pwd.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Pwd.Location = new System.Drawing.Point(388, 529);
            this.txt_Pwd.Name = "txt_Pwd";
            this.txt_Pwd.Size = new System.Drawing.Size(648, 41);
            this.txt_Pwd.TabIndex = 10;
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("나눔고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Login.Location = new System.Drawing.Point(567, 690);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(206, 85);
            this.btn_Login.TabIndex = 11;
            this.btn_Login.Text = "로그인";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 881);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Pwd);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic_CancleBtn);
            this.Controls.Add(this.pic_MinSizeBtn);
            this.Controls.Add(this.pic_MaxSizeBtn);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pic_CancleBtn;
        public System.Windows.Forms.PictureBox pic_MinSizeBtn;
        public System.Windows.Forms.PictureBox pic_MaxSizeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Pwd;
        private System.Windows.Forms.Button btn_Login;
    }
}