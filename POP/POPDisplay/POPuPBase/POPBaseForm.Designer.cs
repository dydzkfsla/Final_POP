﻿
namespace POPDisplay.POPUpBase
{
    partial class POPBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pic_CancleBtn = new System.Windows.Forms.PictureBox();
            this.pic_MinSizeBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 74);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base(Title)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(20, 100);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(983, 908);
            this.panel1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(635, 758);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 129);
            this.button1.TabIndex = 15;
            this.button1.Text = "입력";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(144, 758);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 129);
            this.button3.TabIndex = 14;
            this.button3.Text = "취소";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pic_CancleBtn
            // 
            this.pic_CancleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_CancleBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_CancleBtn.Image = global::POPDisplay.Properties.Resources.Cancel_32x32;
            this.pic_CancleBtn.Location = new System.Drawing.Point(941, 12);
            this.pic_CancleBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pic_CancleBtn.Name = "pic_CancleBtn";
            this.pic_CancleBtn.Size = new System.Drawing.Size(75, 75);
            this.pic_CancleBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CancleBtn.TabIndex = 8;
            this.pic_CancleBtn.TabStop = false;
            this.pic_CancleBtn.Click += new System.EventHandler(this.pic_CancleBtn_Click);
            // 
            // pic_MinSizeBtn
            // 
            this.pic_MinSizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_MinSizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.pic_MinSizeBtn.Image = global::POPDisplay.Properties.Resources.Remove_32x32;
            this.pic_MinSizeBtn.Location = new System.Drawing.Point(848, 12);
            this.pic_MinSizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pic_MinSizeBtn.Name = "pic_MinSizeBtn";
            this.pic_MinSizeBtn.Size = new System.Drawing.Size(75, 75);
            this.pic_MinSizeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_MinSizeBtn.TabIndex = 10;
            this.pic_MinSizeBtn.TabStop = false;
            this.pic_MinSizeBtn.Click += new System.EventHandler(this.pic_MinSizeBtn_Click);
            // 
            // POPBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1023, 1021);
            this.Controls.Add(this.pic_CancleBtn);
            this.Controls.Add(this.pic_MinSizeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "POPBaseForm";
            this.Text = "POPBaseForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox pic_CancleBtn;
        public System.Windows.Forms.PictureBox pic_MinSizeBtn;
    }
}