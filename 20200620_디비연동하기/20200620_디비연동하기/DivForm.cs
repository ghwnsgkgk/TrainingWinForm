using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200620_디비연동하기
{
    public partial class DivForm : MetroForm
    {
        public DivForm()
        {
            InitializeComponent();
        }

        private void DivForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        string strConnString = "Data Source=192.168.200.150;Initial Catalog=bookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        private string mode ="";

        public object ClearTextControl { get; private set; }

        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                string sqlQuery = "SELECT Division " +
                                  " , Names " +
                                  " FROM dbo.divtbl ";  //이건 꼭 해줘야 되는 거니 ? 
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlQuery, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "divtbl");
                GrdDivTbl.DataSource = dataSet;
                GrdDivTbl.DataMember = "divtbl";
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdDivTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {
                DataGridViewRow data = GrdDivTbl.Rows[e.RowIndex]; // 이거 외우자 
                TxtDvision.Text = data.Cells[0].Value.ToString ();
                TxtName.Text = data.Cells[1].Value.ToString();
                TxtDvision.ReadOnly = true;
                TxtDvision.BackColor = Color.Beige;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(TxtDvision.Text) || string.IsNullOrEmpty(TxtName.Text)))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SaveProcess();
                UpdateData();
                ClearTextControls();
            }
            
        }

        private void ClearTextControls()
        {
           TxtDvision.Text = TxtName.Text = "";
            TxtDvision.ReadOnly = false;
            TxtDvision.BackColor = Color.White;
            TxtDvision.Focus();
        }

        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터르 저장하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn =new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

            }
        
        }

    }
}
