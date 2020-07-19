namespace _20200620_디비연동하기
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메인관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구분코드관리DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자관리UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원관리MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.책관리BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.책대여관리RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메인관리MToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메인관리MToolStripMenuItem
            // 
            this.메인관리MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구분코드관리DToolStripMenuItem,
            this.사용자관리UToolStripMenuItem,
            this.회원관리MToolStripMenuItem,
            this.책관리BToolStripMenuItem,
            this.책대여관리RToolStripMenuItem});
            this.메인관리MToolStripMenuItem.Name = "메인관리MToolStripMenuItem";
            this.메인관리MToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.메인관리MToolStripMenuItem.Text = "메인관리(&M)";
            // 
            // 구분코드관리DToolStripMenuItem
            // 
            this.구분코드관리DToolStripMenuItem.Name = "구분코드관리DToolStripMenuItem";
            this.구분코드관리DToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.구분코드관리DToolStripMenuItem.Text = "구분코드관리(&D)";
            this.구분코드관리DToolStripMenuItem.Click += new System.EventHandler(this.구분코드관리DToolStripMenuItem_Click);
            // 
            // 사용자관리UToolStripMenuItem
            // 
            this.사용자관리UToolStripMenuItem.Name = "사용자관리UToolStripMenuItem";
            this.사용자관리UToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.사용자관리UToolStripMenuItem.Text = "사용자관리(&U)";
            // 
            // 회원관리MToolStripMenuItem
            // 
            this.회원관리MToolStripMenuItem.Name = "회원관리MToolStripMenuItem";
            this.회원관리MToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.회원관리MToolStripMenuItem.Text = "회원관리(&M)";
            // 
            // 책관리BToolStripMenuItem
            // 
            this.책관리BToolStripMenuItem.Name = "책관리BToolStripMenuItem";
            this.책관리BToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.책관리BToolStripMenuItem.Text = "책관리(&B)";
            // 
            // 책대여관리RToolStripMenuItem
            // 
            this.책대여관리RToolStripMenuItem.Name = "책대여관리RToolStripMenuItem";
            this.책대여관리RToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.책대여관리RToolStripMenuItem.Text = "책대여관리(&R)";
            this.책대여관리RToolStripMenuItem.Click += new System.EventHandler(this.책대여관리RToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 572);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "BookRental Shop v1.0";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메인관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구분코드관리DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자관리UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원관리MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 책관리BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 책대여관리RToolStripMenuItem;
    }
}

