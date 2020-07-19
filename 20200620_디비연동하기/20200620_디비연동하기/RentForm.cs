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

namespace BookRentalShop20
{
    public partial class RentalForm : MetroForm
    {

        string strConnString = "Data Source=192.168.200.150;Initial Catalog=bookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        string mode = "";
        public RentalForm()
        {
            InitializeComponent();
        }
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open(); // Db 열기
                string strQuery = "SELECT r.idx AS '대여번호', m.Idx AS '고객번호', "+
		                            "  t.Names AS '장르', "+
                                    "  b.Idx AS '책번호', r.rentalDate AS '대여일', " +
                                    "  r.returnDate AS '반납일' "+
                                    "  FROM rentaltbl AS r "+
                                    "  INNER JOIN membertbl AS m "+
                                    "  ON r.memberIdx = m.Idx "+
                                    "  INNER JOIN bookstbl AS b "+
                                    "  ON r.bookIdx = b.Idx "+
                                    "  INNER JOIN divtbl AS t "+
                                    "  ON b.division = t.division ";
                // SqlCommand cmd = new SqlCommand(strQuery, conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn); //데이타 가져오는 플러그 !!1
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "rentaltbl");//데이타 집합  //ds 통에다가 divtbl 이름으로 넣었다
                GrdRentaltbl.DataSource = ds;
                GrdRentaltbl.DataMember = "rentaltbl";  //그걸 다시 Grd 통에 넣는다 ,
            }
            DataGridViewColumn column = GrdRentaltbl.Columns[2]; //id컬럼
            column.Visible = false;
        }
        private void UpdateCbmemberidx()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = " SELECT Idx, Names FROM membertbl ORDER BY Names ASC ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                Cbmemberidx.DataSource = new BindingSource(temps, null);
                Cbmemberidx.DisplayMember = "Value";
                Cbmemberidx.ValueMember = "Key";
                Cbmemberidx.SelectedIndex = -1;
            }
        }
        private void UpdateCbbookindex()
        {
            using (SqlConnection conn = new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Idx, Names FROM bookstbl ORDER BY Names ASC ";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while (reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                Cbbookindex.DataSource = new BindingSource(temps, null);
                Cbbookindex.DisplayMember = "Value";
                Cbbookindex.ValueMember = "Key";
                Cbbookindex.SelectedIndex = -1;
            }
        }
        private void RentalForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            UpdateCbmemberidx();
            UpdateCbbookindex();
        }

        private void GrdRentaltbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >-1)
            {
                DataGridViewRow data = GrdRentaltbl.Rows[e.RowIndex];
                Txtidx.Text = data.Cells[0].Value.ToString();
                Txtidx.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                Txtidx.BackColor = Color.Red;

                Cbmemberidx.SelectedIndex = Cbmemberidx.FindString( data.Cells[1].Value.ToString());
                Cbbookindex.SelectedIndex = Cbbookindex.FindString( data.Cells[2].Value.ToString());
               
                DTPrent.CustomFormat = "yyyy-MM-dd";
                DTPrent.Format = DateTimePickerFormat.Custom;
                DTPreturn.CustomFormat = "yyyy-MM-dd";
                DTPreturn.Format = DateTimePickerFormat.Custom;
              
                //DTPrent.Value = DateTime.Parse( data.Cells[3].Value.ToString());
                //DTPreturn.Value = DateTime.Parse(data.Cells[4].Value.ToString());

                mode = "UPDATE";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearTextControls();
            mode = "INSERT";
        }

        private void ClearTextControls()
        {
            Txtidx.Text = Cbmemberidx.Text = Cbbookindex.Text = DTPrent.Text = DTPreturn.Text = "";
            Cbbookindex.SelectedIndex = -1;
            Cbmemberidx.SelectedIndex = -1;
            Txtidx.ReadOnly = true;
            Txtidx.BackColor = Color.Beige;
            DTPrent.CustomFormat = " ";
            DTPreturn.CustomFormat = " ";
            DTPrent.Format = DateTimePickerFormat.Custom;
            DTPreturn.Format = DateTimePickerFormat.Custom;
            Txtidx.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {//에러나면 여기  문제
            if (string.IsNullOrEmpty(Cbmemberidx.Text) || string.IsNullOrEmpty(Cbmemberidx.Text) || string.IsNullOrEmpty(DTPrent.Text) || string.IsNullOrEmpty(DTPreturn.Text))
            {
                MetroMessageBox.Show(this, "빈값은 저장할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            SaveProcess();
            UpdateData();
            ClearTextControls();
        }

        private void SaveProcess()
        {
            if (string.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using(SqlConnection conn =new SqlConnection(strConnString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";
                if (mode == "UPATE")
                {
                    strQuery =   "UPDATE dbo.rentaltbl " +
                                 "  SET memberIdx = @memberIdx " +
                                 "  ,bookIdx = @bookIdx " +
                                 "  ,rentalDate = @rentalDate " +
                                 "  ,returnDate = @returnDate " +
                                 "   WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    strQuery = "INSERT INTO dbo.rentaltbl " +
                               "  (memberIdx, bookIdx, rentalDate, returnDate) " +
                               "  VALUES(@memberIdx, @bookIdx, @rentalDate, @returnDate) ";
                }
                cmd.CommandText = strQuery;
                ////////////////////////////////////////////////////////////////회원번호
                SqlParameter parmmemberIdx = new SqlParameter("@memberIdx", SqlDbType.Int, 2);                                              //CommandText 를  파라미터
                parmmemberIdx.Value = Cbmemberidx.SelectedValue;
                cmd.Parameters.Add(parmmemberIdx);
                ///////////////////////////////////////////////////////////////// 책번호
                SqlParameter parmbookIdx = new SqlParameter("@bookIdx", SqlDbType.Int, 2);                                                 //CommandText 를  파라미터
                parmbookIdx.Value = Cbbookindex.SelectedValue;  // 아이템즈가 맞음 ! ??
                cmd.Parameters.Add(parmbookIdx);
                //////////////////////////////////////////////////////////////////대여일
                SqlParameter parmrentalDate = new SqlParameter("@rentalDate", SqlDbType.NVarChar, 45);                                            //CommandText 를  파라미터
                parmrentalDate.Value = DTPrent.Text;
                cmd.Parameters.Add(parmrentalDate);
                //////////////////////////////////////////////////////////////////반납일
                SqlParameter parmreturnDate = new SqlParameter("@returnDate", SqlDbType.NVarChar, 45);                                                //CommandText 를  파라미터
                parmreturnDate.Value = DTPreturn.Text;
                cmd.Parameters.Add(parmreturnDate);
                ////////////////////////////////////////////////////////////////// 순번
                if (mode == "UPDATE")
                {
                    SqlParameter parmIdx = new SqlParameter("@Idx", SqlDbType.Int, 2);                                                  //CommandText 를  파라미터
                    parmIdx.Value = Txtidx.Text;
                    cmd.Parameters.Add(parmIdx);

                }
                cmd.ExecuteNonQuery();

            }
        }

        private void Cbbookindex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }


        }

        private void DTPrent_ValueChanged(object sender, EventArgs e)
        {
            DTPrent.CustomFormat = "yyy-MM-dd";
            DTPrent.Format = DateTimePickerFormat.Custom;
        }

        private void DTPreturn_ValueChanged(object sender, EventArgs e)
        {
            DTPreturn.CustomFormat = "yyy-MM-dd";
            DTPreturn.Format = DateTimePickerFormat.Custom;
        }
    }

}
