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

namespace QLNhanSu
{
    public partial class frmLogin : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
        public static string LoaiTaiKhoan = "-1";
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            lblError.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                //check xem ttk & mk đã nhập hay chưa
                if (txtTenTaiKhoan.Text != null && txtTenTaiKhoan.Text.Trim() != "") { }

                else
                {
                    MessageBox.Show("Chưa nhập thông tin tài khoản!", "Thông báo");
                    txtTenTaiKhoan.Focus();
                    return;
                }

                if (txtMatKhau.Text != null && txtMatKhau.Text.Trim() != "") { }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu!", "Thông báo");
                    txtMatKhau.Focus();
                    return;
                }

                //check thông tin tk vs thông tin trong table TaiKhoan
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string TenTaiKhoan = txtTenTaiKhoan.Text.Trim();
                string MatKhau = txtMatKhau.Text.Trim();
                string query = "select * from tblTaiKhoan where TenTaiKhoan = '" + TenTaiKhoan + "' and MatKhau = '" + MatKhau + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd); 

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    LoaiTaiKhoan = ds.Tables[0].Rows[0]["LoaiTaiKhoan"].ToString();
                    frmMain frmMain = new frmMain(LoaiTaiKhoan);
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    //khong tim thay 
                    lblError.Text = "Thông tin tài khoản hoặc mật khẩu không chính xác!";
                }
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
