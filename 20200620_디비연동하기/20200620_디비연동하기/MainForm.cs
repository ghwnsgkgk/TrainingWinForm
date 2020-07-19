using BookRentalShop20;
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
                e.Cancel = false; //이게 값이 없는거니까 ok
            }
            else
            {
                e.Cancel = true; // 이게 값이 있는거니까 no
            }
        }
        /// <summary>
        /// 코딩의 메소드화
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


            private void ChildForm( Form form,string strFormTitle)
        {
            form.Text = strFormTitle;
            form.Dock = DockStyle.Fill;
            form.MdiParent = this;
            form.Show();
            form.WindowState = FormWindowState.Maximized;
            
        }

        private void 구분코드관리DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DivForm form = new DivForm();
            ChildForm(form, "구분코드관리");
        }

        private void 책대여관리RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RentalForm form = new RentalForm();
            ChildForm(form, "책대여관리");
        }
    }
}
