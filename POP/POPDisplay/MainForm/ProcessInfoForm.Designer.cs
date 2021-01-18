
namespace POPDisplay.MainForm
{
    partial class ProcessInfoForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.processInfo1 = new POPDisplay.ControlUser.ProcessInfo();
            this.processInfo2 = new POPDisplay.ControlUser.ProcessInfo();
            this.processInfo3 = new POPDisplay.ControlUser.ProcessInfo();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(272, 74);
            this.label1.Text = "공정현황";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.button8);
            this.pnl_All.Controls.Add(this.button7);
            this.pnl_All.Controls.Add(this.button6);
            this.pnl_All.Controls.Add(this.button5);
            this.pnl_All.Controls.Add(this.button4);
            this.pnl_All.Controls.Add(this.button2);
            this.pnl_All.Controls.Add(this.button1);
            this.pnl_All.Controls.Add(this.button3);
            this.pnl_All.Controls.Add(this.panel1);
            // 
            // processInfo1
            // 
            this.processInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo1.FrmBack = System.Drawing.Color.White;
            this.processInfo1.Location = new System.Drawing.Point(15, 20);
            this.processInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo1.Name = "processInfo1";
            this.processInfo1.PcsCode = "PcsCode";
            this.processInfo1.PcsName = "ProcessNameText";
            this.processInfo1.PcsPer = 0D;
            this.processInfo1.Size = new System.Drawing.Size(273, 373);
            this.processInfo1.TabIndex = 0;
            // 
            // processInfo2
            // 
            this.processInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.processInfo2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo2.FrmBack = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo2.Location = new System.Drawing.Point(334, 20);
            this.processInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo2.Name = "processInfo2";
            this.processInfo2.PcsCode = "PcsCode";
            this.processInfo2.PcsName = "ProcessNameText";
            this.processInfo2.PcsPer = 0D;
            this.processInfo2.Size = new System.Drawing.Size(273, 373);
            this.processInfo2.TabIndex = 1;
            // 
            // processInfo3
            // 
            this.processInfo3.BackColor = System.Drawing.Color.Silver;
            this.processInfo3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo3.FrmBack = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.processInfo3.Location = new System.Drawing.Point(653, 20);
            this.processInfo3.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo3.Name = "processInfo3";
            this.processInfo3.PcsCode = "PcsCode";
            this.processInfo3.PcsName = "ProcessNameText";
            this.processInfo3.PcsPer = 0D;
            this.processInfo3.Size = new System.Drawing.Size(273, 373);
            this.processInfo3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processInfo1);
            this.panel1.Controls.Add(this.processInfo3);
            this.panel1.Controls.Add(this.processInfo2);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2131, 798);
            this.panel1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(75, 856);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 129);
            this.button3.TabIndex = 14;
            this.button3.Text = "비가동공정 보기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(435, 856);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 129);
            this.button1.TabIndex = 15;
            this.button1.Text = "오류공정 보기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(806, 856);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 129);
            this.button2.TabIndex = 16;
            this.button2.Text = "가동 전환";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(1161, 856);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(300, 129);
            this.button4.TabIndex = 17;
            this.button4.Text = "비가동 전환";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(1525, 856);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 129);
            this.button5.TabIndex = 18;
            this.button5.Text = "오류등록";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(1896, 856);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 129);
            this.button6.TabIndex = 19;
            this.button6.Text = "정보보기";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Location = new System.Drawing.Point(2183, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 129);
            this.button7.TabIndex = 20;
            this.button7.Text = "△";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("나눔고딕", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.Location = new System.Drawing.Point(2183, 543);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 129);
            this.button8.TabIndex = 21;
            this.button8.Text = "▽";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // ProcessInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(2361, 1171);
            this.Name = "ProcessInfoForm";
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUser.ProcessInfo processInfo3;
        private ControlUser.ProcessInfo processInfo2;
        private ControlUser.ProcessInfo processInfo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}
