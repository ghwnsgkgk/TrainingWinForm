namespace _20200621_Winform
{
    partial class Form1
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
            this.BtnFlat = new System.Windows.Forms.Button();
            this.BtnPopup = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BtnStandard = new System.Windows.Forms.Button();
            this.LblButtonStyle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnFlat
            // 
            this.BtnFlat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFlat.Font = new System.Drawing.Font("궁서", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnFlat.Location = new System.Drawing.Point(111, 64);
            this.BtnFlat.Name = "BtnFlat";
            this.BtnFlat.Size = new System.Drawing.Size(193, 138);
            this.BtnFlat.TabIndex = 0;
            this.BtnFlat.Text = "Flat";
            this.BtnFlat.UseVisualStyleBackColor = true;
            this.BtnFlat.Click += new System.EventHandler(this.BtnFlat_Click);
            // 
            // BtnPopup
            // 
            this.BtnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPopup.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPopup.Location = new System.Drawing.Point(333, 64);
            this.BtnPopup.Name = "BtnPopup";
            this.BtnPopup.Size = new System.Drawing.Size(203, 138);
            this.BtnPopup.TabIndex = 1;
            this.BtnPopup.Text = "Popup";
            this.BtnPopup.UseVisualStyleBackColor = true;
            this.BtnPopup.Click += new System.EventHandler(this.BtnPopup_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSystem.Font = new System.Drawing.Font("맑은 고딕", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSystem.Location = new System.Drawing.Point(333, 271);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(203, 135);
            this.BtnSystem.TabIndex = 3;
            this.BtnSystem.Text = "System";
            this.BtnSystem.UseVisualStyleBackColor = true;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnStandard
            // 
            this.BtnStandard.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnStandard.Location = new System.Drawing.Point(111, 271);
            this.BtnStandard.Name = "BtnStandard";
            this.BtnStandard.Size = new System.Drawing.Size(193, 135);
            this.BtnStandard.TabIndex = 2;
            this.BtnStandard.Text = "standard";
            this.BtnStandard.UseVisualStyleBackColor = true;
            this.BtnStandard.Click += new System.EventHandler(this.BtnStandard_Click);
            // 
            // LblButtonStyle
            // 
            this.LblButtonStyle.AutoSize = true;
            this.LblButtonStyle.Location = new System.Drawing.Point(24, 449);
            this.LblButtonStyle.Name = "LblButtonStyle";
            this.LblButtonStyle.Size = new System.Drawing.Size(54, 18);
            this.LblButtonStyle.TabIndex = 1;
            this.LblButtonStyle.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 479);
            this.Controls.Add(this.LblButtonStyle);
            this.Controls.Add(this.BtnSystem);
            this.Controls.Add(this.BtnPopup);
            this.Controls.Add(this.BtnStandard);
            this.Controls.Add(this.BtnFlat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnFlat;
        private System.Windows.Forms.Button BtnPopup;
        private System.Windows.Forms.Button BtnSystem;
        private System.Windows.Forms.Button BtnStandard;
        private System.Windows.Forms.Label LblButtonStyle;
    }
}

