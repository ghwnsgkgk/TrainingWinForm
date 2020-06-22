using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;

namespace _20200620_디비연동하기
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if(MetroMessageBox.Show(this,"정말 종료하시겠습니까?", "종료", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes )
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
                e.Cancel = false;
            }
        }
    }
}
