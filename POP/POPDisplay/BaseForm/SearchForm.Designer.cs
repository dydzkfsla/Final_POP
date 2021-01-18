
namespace POPDisplay.BaseForm
{
    partial class SearchForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.gb_SearchSimple = new System.Windows.Forms.GroupBox();
            this.gb_SearchDetail = new System.Windows.Forms.GroupBox();
            this.pnl_Sort = new System.Windows.Forms.Panel();
            this.rbn_Desc = new POPDisplay.ControlUser.RadioBtn();
            this.rbn_Asc = new POPDisplay.ControlUser.RadioBtn();
            this.pic_SortBtn = new System.Windows.Forms.PictureBox();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.pnl_AllInfo = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            this.gb_SearchDetail.SuspendLayout();
            this.pnl_Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).BeginInit();
            this.gb_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.Text = "Base(Search)";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.pnl_AllInfo);
            this.pnl_All.Controls.Add(this.gb_SearchSimple);
            this.pnl_All.Controls.Add(this.gb_SearchDetail);
            this.pnl_All.Controls.Add(this.gb_Search);
            this.pnl_All.Controls.Add(this.splitter1);
            this.pnl_All.Size = new System.Drawing.Size(1773, 952);
            // 
            // pic_CancleBtn
            // 
            this.pic_CancleBtn.Location = new System.Drawing.Point(1741, -1);
            // 
            // pic_MaxSizeBtn
            // 
            this.pic_MaxSizeBtn.Location = new System.Drawing.Point(1688, -1);
            // 
            // pic_MinSizeBtn
            // 
            this.pic_MinSizeBtn.Location = new System.Drawing.Point(1634, -1);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(284, 952);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // gb_SearchSimple
            // 
            this.gb_SearchSimple.Location = new System.Drawing.Point(5, 413);
            this.gb_SearchSimple.Name = "gb_SearchSimple";
            this.gb_SearchSimple.Size = new System.Drawing.Size(272, 223);
            this.gb_SearchSimple.TabIndex = 5;
            this.gb_SearchSimple.TabStop = false;
            this.gb_SearchSimple.Text = "간편검색";
            // 
            // gb_SearchDetail
            // 
            this.gb_SearchDetail.Controls.Add(this.pnl_Sort);
            this.gb_SearchDetail.Location = new System.Drawing.Point(5, 184);
            this.gb_SearchDetail.Name = "gb_SearchDetail";
            this.gb_SearchDetail.Size = new System.Drawing.Size(272, 223);
            this.gb_SearchDetail.TabIndex = 4;
            this.gb_SearchDetail.TabStop = false;
            this.gb_SearchDetail.Text = "세부검색";
            // 
            // pnl_Sort
            // 
            this.pnl_Sort.Controls.Add(this.comboBox1);
            this.pnl_Sort.Controls.Add(this.rbn_Desc);
            this.pnl_Sort.Controls.Add(this.rbn_Asc);
            this.pnl_Sort.Controls.Add(this.pic_SortBtn);
            this.pnl_Sort.Location = new System.Drawing.Point(6, 117);
            this.pnl_Sort.Name = "pnl_Sort";
            this.pnl_Sort.Size = new System.Drawing.Size(260, 100);
            this.pnl_Sort.TabIndex = 4;
            // 
            // rbn_Desc
            // 
            this.rbn_Desc.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbn_Desc.Location = new System.Drawing.Point(91, 4);
            this.rbn_Desc.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Desc.Name = "rbn_Desc";
            this.rbn_Desc.Size = new System.Drawing.Size(70, 26);
            this.rbn_Desc.TabIndex = 5;
            this.rbn_Desc.thisCheck = false;
            this.rbn_Desc.thisText = "내림";
            // 
            // rbn_Asc
            // 
            this.rbn_Asc.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbn_Asc.Location = new System.Drawing.Point(4, 4);
            this.rbn_Asc.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Asc.Name = "rbn_Asc";
            this.rbn_Asc.Size = new System.Drawing.Size(70, 26);
            this.rbn_Asc.TabIndex = 4;
            this.rbn_Asc.thisCheck = false;
            this.rbn_Asc.thisText = "오름";
            // 
            // pic_SortBtn
            // 
            this.pic_SortBtn.Image = global::POPDisplay.Properties.Resources.SortAsc_32x32;
            this.pic_SortBtn.Location = new System.Drawing.Point(207, 47);
            this.pic_SortBtn.Name = "pic_SortBtn";
            this.pic_SortBtn.Size = new System.Drawing.Size(50, 50);
            this.pic_SortBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_SortBtn.TabIndex = 3;
            this.pic_SortBtn.TabStop = false;
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.btn_Search);
            this.gb_Search.Location = new System.Drawing.Point(5, 3);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(272, 175);
            this.gb_Search.TabIndex = 3;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "검색조건";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Image = global::POPDisplay.Properties.Resources.Find_32x32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(197, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "찾기";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // pnl_AllInfo
            // 
            this.pnl_AllInfo.Location = new System.Drawing.Point(283, 0);
            this.pnl_AllInfo.Name = "pnl_AllInfo";
            this.pnl_AllInfo.Size = new System.Drawing.Size(1490, 952);
            this.pnl_AllInfo.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 25);
            this.comboBox1.TabIndex = 0;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1786, 1010);
            this.Name = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            this.gb_SearchDetail.ResumeLayout(false);
            this.pnl_Sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).EndInit();
            this.gb_Search.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pnl_AllInfo;
        public System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Panel pnl_Sort;
        public System.Windows.Forms.GroupBox gb_SearchSimple;
        public System.Windows.Forms.GroupBox gb_SearchDetail;
        public ControlUser.RadioBtn rbn_Desc;
        public ControlUser.RadioBtn rbn_Asc;
        public System.Windows.Forms.PictureBox pic_SortBtn;
        public System.Windows.Forms.GroupBox gb_Search;
        public System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.ComboBox comboBox1;
    }
}
