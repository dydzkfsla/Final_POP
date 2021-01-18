
namespace POPDisplay.BaseForm
{
    partial class ShowItemInfo
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.pnl_DetailInfo = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gb_SearchDetail.SuspendLayout();
            this.gb_Search.SuspendLayout();
            this.pnl_Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).BeginInit();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.pnl_DetailInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1524, 403);
            this.splitContainer2.SplitterDistance = 966;
            this.splitContainer2.TabIndex = 0;
            // 
            // pnl_DetailInfo
            // 
            this.pnl_DetailInfo.BackColor = System.Drawing.Color.White;
            this.pnl_DetailInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_DetailInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_DetailInfo.Name = "pnl_DetailInfo";
            this.pnl_DetailInfo.Size = new System.Drawing.Size(554, 33);
            this.pnl_DetailInfo.TabIndex = 0;
            // 
            // ShowItemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1819, 922);
            this.Name = "ShowItemInfo";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gb_SearchDetail.ResumeLayout(false);
            this.gb_Search.ResumeLayout(false);
            this.pnl_Sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).EndInit();
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.SplitContainer splitContainer2;
        public System.Windows.Forms.Panel pnl_DetailInfo;
    }
}
