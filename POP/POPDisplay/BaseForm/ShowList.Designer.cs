
namespace POPDisplay.BaseForm
{
    partial class ShowList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.dataGridView1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 70;
            this.dataGridView1.Location = new System.Drawing.Point(5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(967, 853);
            this.dataGridView1.TabIndex = 0;
            // 
            // ShowList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1961, 1012);
            this.Name = "ShowList";
            this.Load += new System.EventHandler(this.ShowList_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
