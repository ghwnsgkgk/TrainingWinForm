namespace _20200620_디비연동하기
{
    partial class LoginForm
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.LBLID = new System.Windows.Forms.Label();
            this.TxtuserID = new System.Windows.Forms.TextBox();
            this.LBLPW = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(104, 212);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(104, 59);
            this.BtnOK.TabIndex = 3;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Location = new System.Drawing.Point(101, 86);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(22, 18);
            this.LBLID.TabIndex = 1;
            this.LBLID.Text = "ID";
            // 
            // TxtuserID
            // 
            this.TxtuserID.Location = new System.Drawing.Point(193, 83);
            this.TxtuserID.MaxLength = 12;
            this.TxtuserID.Name = "TxtuserID";
            this.TxtuserID.Size = new System.Drawing.Size(192, 28);
            this.TxtuserID.TabIndex = 1;
            this.TxtuserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtuserID_KeyPress);
            // 
            // LBLPW
            // 
            this.LBLPW.AutoSize = true;
            this.LBLPW.Location = new System.Drawing.Point(101, 149);
            this.LBLPW.Name = "LBLPW";
            this.LBLPW.Size = new System.Drawing.Size(34, 18);
            this.LBLPW.TabIndex = 1;
            this.LBLPW.Text = "PW";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(193, 146);
            this.TxtPassword.MaxLength = 20;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '㉿';
            this.TxtPassword.Size = new System.Drawing.Size(192, 28);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(278, 212);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnCancel.Size = new System.Drawing.Size(107, 59);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 314);
            this.ControlBox = false;
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LBLPW);
            this.Controls.Add(this.TxtuserID);
            this.Controls.Add(this.LBLID);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.TextBox TxtuserID;
        private System.Windows.Forms.Label LBLPW;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button BtnCancel;
    }
}