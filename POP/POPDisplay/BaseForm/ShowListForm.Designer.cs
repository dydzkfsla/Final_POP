
namespace POPDisplay.BaseForm
{
    partial class ShowListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowListForm));
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gb_SearchSimple = new System.Windows.Forms.GroupBox();
            this.pnl_Sort = new System.Windows.Forms.Panel();
            this.rbn_Desc = new POPDisplay.ControlUser.RadioBtn();
            this.rbn_Asc = new POPDisplay.ControlUser.RadioBtn();
            this.pic_SortBtn = new System.Windows.Forms.PictureBox();
            this.gb_SearchDetail = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.gb_Search = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.pnl_Sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).BeginInit();
            this.gb_SearchDetail.SuspendLayout();
            this.gb_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(125, 31);
            this.label1.Text = "ShowList";
            // 
            // pnl_All
            // 
            this.pnl_All.Controls.Add(this.splitContainer1);
            this.pnl_All.Controls.Add(this.btn_Excel);
            this.pnl_All.Controls.Add(this.btn_Update);
            this.pnl_All.Controls.Add(this.btn_Delete);
            this.pnl_All.Controls.Add(this.btn_Add);
            this.pnl_All.Controls.Add(this.gb_SearchSimple);
            this.pnl_All.Controls.Add(this.gb_SearchDetail);
            this.pnl_All.Controls.Add(this.gb_Search);
            this.pnl_All.Controls.Add(this.splitter2);
            this.pnl_All.Controls.Add(this.splitter1);
            this.pnl_All.Size = new System.Drawing.Size(1806, 864);
            // 
            // pic_CancleBtn
            // 
            this.pic_CancleBtn.Location = new System.Drawing.Point(1774, -1);
            // 
            // pic_MaxSizeBtn
            // 
            this.pic_MaxSizeBtn.Location = new System.Drawing.Point(1721, -1);
            // 
            // pic_MinSizeBtn
            // 
            this.pic_MinSizeBtn.Location = new System.Drawing.Point(1667, -1);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "delete-1727486_1280.png");
            this.imgList.Images.SetKeyName(1, "icon-3160555_1280.png");
            this.imgList.Images.SetKeyName(2, "write-1727488_1280.png");
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Gold;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1806, 53);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Control;
            this.splitter2.Location = new System.Drawing.Point(0, 53);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(282, 811);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // btn_Excel
            // 
            this.btn_Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excel.Image = global::POPDisplay.Properties.Resources.ExportToXLS_32x32;
            this.btn_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excel.Location = new System.Drawing.Point(1718, 3);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(85, 44);
            this.btn_Excel.TabIndex = 15;
            this.btn_Excel.Text = "엑셀";
            this.btn_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excel.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.ImageIndex = 2;
            this.btn_Update.ImageList = this.imgList;
            this.btn_Update.Location = new System.Drawing.Point(1536, 3);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(85, 44);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "수정";
            this.btn_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.ImageIndex = 0;
            this.btn_Delete.ImageList = this.imgList;
            this.btn_Delete.Location = new System.Drawing.Point(1627, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(85, 44);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Add.ImageIndex = 1;
            this.btn_Add.ImageList = this.imgList;
            this.btn_Add.Location = new System.Drawing.Point(1445, 3);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(85, 44);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "등록";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Add.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(282, 53);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Size = new System.Drawing.Size(1524, 811);
            this.splitContainer1.SplitterDistance = 404;
            this.splitContainer1.TabIndex = 16;
            // 
            // gb_SearchSimple
            // 
            this.gb_SearchSimple.Location = new System.Drawing.Point(3, 470);
            this.gb_SearchSimple.Name = "gb_SearchSimple";
            this.gb_SearchSimple.Size = new System.Drawing.Size(272, 223);
            this.gb_SearchSimple.TabIndex = 11;
            this.gb_SearchSimple.TabStop = false;
            this.gb_SearchSimple.Text = "간편검색";
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
            // gb_SearchDetail
            // 
            this.gb_SearchDetail.Controls.Add(this.pnl_Sort);
            this.gb_SearchDetail.Location = new System.Drawing.Point(3, 241);
            this.gb_SearchDetail.Name = "gb_SearchDetail";
            this.gb_SearchDetail.Size = new System.Drawing.Size(272, 223);
            this.gb_SearchDetail.TabIndex = 10;
            this.gb_SearchDetail.TabStop = false;
            this.gb_SearchDetail.Text = "세부검색";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Image = global::POPDisplay.Properties.Resources.Find_32x32;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(191, 14);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 40);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "찾기";
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.btn_Search);
            this.gb_Search.Location = new System.Drawing.Point(3, 60);
            this.gb_Search.Name = "gb_Search";
            this.gb_Search.Size = new System.Drawing.Size(272, 175);
            this.gb_Search.TabIndex = 9;
            this.gb_Search.TabStop = false;
            this.gb_Search.Text = "검색조건";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 25);
            this.comboBox1.TabIndex = 6;
            // 
            // ShowListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1819, 922);
            this.Name = "ShowListForm";
            this.Load += new System.EventHandler(this.ShowListForm_Load);
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_Sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).EndInit();
            this.gb_SearchDetail.ResumeLayout(false);
            this.gb_Search.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Splitter splitter1;
        public System.Windows.Forms.Splitter splitter2;
        public System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.GroupBox gb_SearchSimple;
        public System.Windows.Forms.GroupBox gb_SearchDetail;
        public System.Windows.Forms.GroupBox gb_Search;
        public System.Windows.Forms.Panel pnl_Sort;
        public System.Windows.Forms.ComboBox comboBox1;
        public ControlUser.RadioBtn rbn_Desc;
        public ControlUser.RadioBtn rbn_Asc;
        public System.Windows.Forms.PictureBox pic_SortBtn;
        public System.Windows.Forms.Button btn_Search;
    }
}
