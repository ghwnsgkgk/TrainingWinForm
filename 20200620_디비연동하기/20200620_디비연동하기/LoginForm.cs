using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200620_디비연동하기
{
    public partial class LoginForm : MetroForm
    {
        string strConnString = "Data Source=192.168.200.150;Initial Catalog=bookrentalshopDB;Persist Security Info=True;User ID=sa;Password=p@ssw0rd!";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            LoginProcess();
        }

        private void LoginProcess()
        
        {
            //if(TxtuserID. Text == null || TxtuserID.Text == "" || TxtPassword.Text == null || TxtPassword.Text == "")//간단하게하는방법
            if(string.IsNullOrEmpty(TxtuserID.Text)||string.IsNullOrEmpty(TxtPassword.Text))
            {
                MetroMessageBox.Show(this, "아이디/패스워드를 입력하세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strUserId = string.Empty; //??????????????????????이게 왜
            using (SqlConnection conn = new SqlConnection(strConnString))   //DB연결 공식 연결 변수선언 
            {
                conn.Open();  //변수로 문을 열고 
                SqlCommand cmd = new SqlCommand(); // 명령 변수 선언 
                cmd.Connection = conn;    // 명령변수랑 연결변수 연결!!
                cmd.CommandText = "SELECT userID " +    //명령변수에 명령어 입력 -쿼리문
                                  " FROM dbo.userTbl " +
                                  " WHERE userID = @userID AND password =@password ";
               //아이디
                SqlParameter parmUserId = new SqlParameter("@userID",SqlDbType.VarChar,12);
                parmUserId.Value = TxtuserID.Text;
                cmd.Parameters.Add(parmUserId);
                //비밀번호
                SqlParameter parmpassword = new SqlParameter("@password", SqlDbType.VarChar, 12);
                parmpassword.Value = TxtPassword.Text;
                cmd.Parameters.Add(parmpassword);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (strUserId != "")
                {
                    strUserId = reader["userID"].ToString(); //??????????????
                    MetroMessageBox.Show(this, "접속성공", " 로그인");
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this, "접속실패", "로그인실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }




        }

        private void TxtuserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LoginProcess();
            }
        }
    }
}
