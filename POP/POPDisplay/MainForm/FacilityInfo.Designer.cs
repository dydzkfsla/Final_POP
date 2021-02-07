namespace POPDisplay.MainForm
{
    partial class FacilityInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.processInfo1 = new POPDisplay.ControlUser.ProcessInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pnl_All.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Size = new System.Drawing.Size(155, 31);
            this.lbl_Title.Text = "SearchBase";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.button4);
            this.pnl_All.Controls.Add(this.button3);
            this.pnl_All.Controls.Add(this.button2);
            this.pnl_All.Controls.Add(this.button1);
            this.pnl_All.Controls.Add(this.panel1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.processInfo1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 671);
            this.panel1.TabIndex = 0;
            // 
            // processInfo1
            // 
            this.processInfo1.BackColor = System.Drawing.Color.White;
            this.processInfo1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo1.FrmBack = System.Drawing.Color.White;
            this.processInfo1.Location = new System.Drawing.Point(33, 14);
            this.processInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo1.Name = "processInfo1";
            this.processInfo1.PcsCode = "PcsCode";
            this.processInfo1.PcsName = "ProcessNameText";
            this.processInfo1.PcsPer = 0D;
            this.processInfo1.Size = new System.Drawing.Size(579, 374);
            this.processInfo1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 702);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 101);
            this.button1.TabIndex = 1;
            this.button1.Text = "설비 작동 시작";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 702);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 101);
            this.button2.TabIndex = 2;
            this.button2.Text = "설비 작동 멈춤";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(656, 702);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(256, 101);
            this.button3.TabIndex = 3;
            this.button3.Text = "설비 긴급 멈춤";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(969, 702);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 101);
            this.button4.TabIndex = 4;
            this.button4.Text = "설비 작동 완료";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FacilityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.ClientSize = new System.Drawing.Size(1300, 900);
            this.Name = "FacilityInfo";
            this.pnl_All.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private ControlUser.ProcessInfo processInfo1;
    }
}
