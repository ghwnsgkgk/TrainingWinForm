using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class clock : Form
    {
        public clock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void clock_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼 로드 발생시");
        }

       
        private void clock_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("폼 활성화시 발생시");

        }

        private void clock_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("폼 클로즈시 발생시");
        }
    }
}
