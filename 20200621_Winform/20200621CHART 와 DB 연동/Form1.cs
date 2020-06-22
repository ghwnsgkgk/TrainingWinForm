using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _20200621CHART_와_DB_연동
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "using chart control";

            Random random = new Random();
            Chart1.Titles.Add("중간고사 성적");
            for (int i = 0; i < 10; i++)
            {
                Chart1.Series["Score"].Points.Add(random.Next(10,100));//????????????????????????????
            }
            Chart1.Series["Score"].LegendText = "수학점수";
            Chart1.Series["Score"].ChartType = SeriesChartType.Spline;
            Chart1.Series["Score"].ToolTip = "테스트"; //툴팁이 머였지 ? 그래프에 커서 올리면 설명나옴 



        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chart1.Series["Score"].Points.Clear();
            MetroMessageBox.Show(this,"데이터를 지웠습니다", "종료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
