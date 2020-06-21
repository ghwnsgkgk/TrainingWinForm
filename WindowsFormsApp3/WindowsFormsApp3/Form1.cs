using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime NOW = DateTime.Now;
            Textcurrendate.Text = NOW.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼 로드시 발생");
        }
    }
}
