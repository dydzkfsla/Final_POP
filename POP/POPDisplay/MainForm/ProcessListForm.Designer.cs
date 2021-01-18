
namespace POPDisplay.MainForm
{
    partial class ProcessListForm
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
            this.processInfo4 = new POPDisplay.ControlUser.ProcessInfo();
            this.processInfo3 = new POPDisplay.ControlUser.ProcessInfo();
            this.processInfo2 = new POPDisplay.ControlUser.ProcessInfo();
            this.processInfo1 = new POPDisplay.ControlUser.ProcessInfo();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnl_AllInfo.SuspendLayout();
            this.pnl_Sort.SuspendLayout();
            this.gb_SearchSimple.SuspendLayout();
            this.gb_SearchDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).BeginInit();
            this.gb_Search.SuspendLayout();
            this.pnl_All.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_AllInfo
            // 
            this.pnl_AllInfo.Controls.Add(this.processInfo4);
            this.pnl_AllInfo.Controls.Add(this.processInfo3);
            this.pnl_AllInfo.Controls.Add(this.processInfo2);
            this.pnl_AllInfo.Controls.Add(this.processInfo1);
            // 
            // gb_SearchSimple
            // 
            this.gb_SearchSimple.Controls.Add(this.button3);
            this.gb_SearchSimple.Controls.Add(this.button2);
            this.gb_SearchSimple.Controls.Add(this.button1);
            this.gb_SearchSimple.Size = new System.Drawing.Size(272, 388);
            // 
            // gb_Search
            // 
            this.gb_Search.Controls.Add(this.textBox1);
            this.gb_Search.Controls.Add(this.comboBox3);
            this.gb_Search.Controls.Add(this.checkBox1);
            this.gb_Search.Controls.Add(this.label2);
            this.gb_Search.Controls.Add(this.comboBox2);
            this.gb_Search.Controls.SetChildIndex(this.btn_Search, 0);
            this.gb_Search.Controls.SetChildIndex(this.comboBox2, 0);
            this.gb_Search.Controls.SetChildIndex(this.label2, 0);
            this.gb_Search.Controls.SetChildIndex(this.checkBox1, 0);
            this.gb_Search.Controls.SetChildIndex(this.comboBox3, 0);
            this.gb_Search.Controls.SetChildIndex(this.textBox1, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.Text = "설비정보";
            // 
            // processInfo4
            // 
            this.processInfo4.BackColor = System.Drawing.Color.Silver;
            this.processInfo4.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo4.FrmBack = System.Drawing.Color.Silver;
            this.processInfo4.Location = new System.Drawing.Point(905, 15);
            this.processInfo4.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo4.Name = "processInfo4";
            this.processInfo4.PcsCode = "PcsCode";
            this.processInfo4.PcsName = "ProcessNameText";
            this.processInfo4.PcsPer = 0D;
            this.processInfo4.Size = new System.Drawing.Size(273, 373);
            this.processInfo4.TabIndex = 7;
            // 
            // processInfo3
            // 
            this.processInfo3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.processInfo3.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo3.FrmBack = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.processInfo3.Location = new System.Drawing.Point(609, 15);
            this.processInfo3.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo3.Name = "processInfo3";
            this.processInfo3.PcsCode = "PcsCode";
            this.processInfo3.PcsName = "ProcessNameText";
            this.processInfo3.PcsPer = 30D;
            this.processInfo3.Size = new System.Drawing.Size(273, 373);
            this.processInfo3.TabIndex = 6;
            // 
            // processInfo2
            // 
            this.processInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo2.FrmBack = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo2.Location = new System.Drawing.Point(313, 15);
            this.processInfo2.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo2.Name = "processInfo2";
            this.processInfo2.PcsCode = "PcsCode";
            this.processInfo2.PcsName = "ProcessNameText";
            this.processInfo2.PcsPer = 0D;
            this.processInfo2.Size = new System.Drawing.Size(273, 373);
            this.processInfo2.TabIndex = 5;
            // 
            // processInfo1
            // 
            this.processInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.processInfo1.FrmBack = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.processInfo1.Location = new System.Drawing.Point(17, 15);
            this.processInfo1.Margin = new System.Windows.Forms.Padding(4);
            this.processInfo1.Name = "processInfo1";
            this.processInfo1.PcsCode = "PcsCode";
            this.processInfo1.PcsName = "ProcessNameText";
            this.processInfo1.PcsPer = 0D;
            this.processInfo1.Size = new System.Drawing.Size(273, 373);
            this.processInfo1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(72, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(170, 25);
            this.comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "공정";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(147, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "가동중인 장비 제외";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "가동현황 보기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(260, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "장애설비 보기";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 61);
            this.button3.TabIndex = 2;
            this.button3.Text = "장애설비 보기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(18, 121);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(71, 25);
            this.comboBox3.TabIndex = 6;
            this.comboBox3.Text = "Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 25);
            this.textBox1.TabIndex = 7;
            // 
            // ProcessListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.ClientSize = new System.Drawing.Size(1786, 1010);
            this.Name = "ProcessListForm";
            this.pnl_AllInfo.ResumeLayout(false);
            this.pnl_Sort.ResumeLayout(false);
            this.gb_SearchSimple.ResumeLayout(false);
            this.gb_SearchDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_SortBtn)).EndInit();
            this.gb_Search.ResumeLayout(false);
            this.gb_Search.PerformLayout();
            this.pnl_All.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_CancleBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MaxSizeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MinSizeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlUser.ProcessInfo processInfo4;
        private ControlUser.ProcessInfo processInfo3;
        private ControlUser.ProcessInfo processInfo2;
        private ControlUser.ProcessInfo processInfo1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}
