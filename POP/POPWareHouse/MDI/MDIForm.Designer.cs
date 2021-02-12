namespace POPWareHouse.MDI
{
    partial class MDIForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_WorkOrder = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcb_Minmax = new System.Windows.Forms.PictureBox();
            this.pcb_Close = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_WorkOrder);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcb_Minmax);
            this.panel1.Controls.Add(this.pcb_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1300, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 900);
            this.panel1.TabIndex = 1;
            // 
            // lbl_WorkOrder
            // 
            this.lbl_WorkOrder.AutoSize = true;
            this.lbl_WorkOrder.Location = new System.Drawing.Point(3, 123);
            this.lbl_WorkOrder.Name = "lbl_WorkOrder";
            this.lbl_WorkOrder.Size = new System.Drawing.Size(0, 19);
            this.lbl_WorkOrder.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "선택 작업 코드";
            // 
            // pcb_Minmax
            // 
            this.pcb_Minmax.Image = global::POPWareHouse.Properties.Resources.Remove_32x32;
            this.pcb_Minmax.Location = new System.Drawing.Point(34, 12);
            this.pcb_Minmax.Name = "pcb_Minmax";
            this.pcb_Minmax.Size = new System.Drawing.Size(50, 50);
            this.pcb_Minmax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Minmax.TabIndex = 5;
            this.pcb_Minmax.TabStop = false;
            this.pcb_Minmax.Click += new System.EventHandler(this.pcb_Minmax_Click);
            // 
            // pcb_Close
            // 
            this.pcb_Close.Image = global::POPWareHouse.Properties.Resources.Cancel_32x32;
            this.pcb_Close.Location = new System.Drawing.Point(136, 12);
            this.pcb_Close.Name = "pcb_Close";
            this.pcb_Close.Size = new System.Drawing.Size(50, 50);
            this.pcb_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Close.TabIndex = 4;
            this.pcb_Close.TabStop = false;
            this.pcb_Close.Click += new System.EventHandler(this.pcb_Close_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MDIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MDIForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Minmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcb_Minmax;
        private System.Windows.Forms.PictureBox pcb_Close;
        private System.Windows.Forms.Label lbl_WorkOrder;
        private System.Windows.Forms.Label label1;
    }
}