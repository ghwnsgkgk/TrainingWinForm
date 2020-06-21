using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public object TxtCurrentDate { get; private set; }

        private void BtnMessage_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            // MessageBox.Show($"hellow world ! {dateTime}");
            TxtCurrentDate.Text = dateTime.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
