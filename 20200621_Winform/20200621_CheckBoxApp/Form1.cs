using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200621_CheckBoxApp
{
    public partial class Form1 : Form


        
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strTemp;
        private void UpdateLabel(string strTemp, bool @checked)
        {

            if (true)
            {
                strTemp = strTemp + ",";
                label1.Text = strTemp;
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*string fruit1 = "", fruit2 = "", fruit3 = "", fruit4 = ""; //강사님은 else 문을 적었는데 if 문 자체가 그 외에 것을 else처리해서
            if (checkBox1.Checked)
            {
                fruit1 = checkBox1.Text;
            }
            
             if (checkBox2.Checked)
            {
                fruit2 = checkBox2.Text;
            }

             if(checkBox3.Checked) 
            { 
                fruit3 = checkBox3.Text;
            }

             if(checkBox4.Checked)
            { 
                fruit4 = checkBox4.Text;
            }
            
            label1.Text = fruit1 + " " + fruit2 + " " + fruit3 + " " + fruit4;*/
        }






       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text,checkBox1.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = "좋아하는 과일";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
