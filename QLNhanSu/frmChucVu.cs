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
    public partial class frmChucVu : Form
    {
        #region Variables
        public static string ConnectionString = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=QLNhanSu;Integrated Security=True";
        public static string LoaiTaiKhoan = "-1";
        public static string State = "-1";
        #endregion

        public frmChucVu()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }

        #region Public Functions;
        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    btnThem.Enabled = true;
                    btnSua.Enabled = true;
                    btnXoa.Enabled = true;
                    btnGhi.Enabled = false;
                    btnHuy.Enabled = false;

                    lblError.Text = "";
                    lblStatus.Text = "";
                    break;
                default:
                    break;
            }
        }

        public void GetData()
        {
            try
            {
                lblError.Text = "";
                //check thông tin tk vs thông tin trong table TaiKhoan
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "select * from tblChucVu order by TenChucVu";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvMain.DataSource = ds.Tables[0];
                    lblTongSo.Text = "Tổng số: " + (dgvMain.Rows.Count - 1) + " bản ghi";
                }
                else
                {
                    //khong tim thay 
                    dgvMain.DataSource = null;
                    lblTongSo.Text = "Tổng số: 0 bản ghi.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }


        #endregion
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            //ấn nhầm
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvMain.Rows[index];

            txtIDChucVu.Text = selectedRow.Cells["IDChucVu"].Value.ToString();
            txtMaChucVu.Text = selectedRow.Cells["MaChucVu"].Value.ToString();
            txtTenChucVu.Text = selectedRow.Cells["TenChucVu"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["GhiChu"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;

            txtGhiChu.Text = "";
            txtIDChucVu.Text = "";
            txtMaChucVu.Text = "";
            txtTenChucVu.Text = "";

            txtIDChucVu.Enabled = false;
            txtMaChucVu.Focus();
            State = "Insert";

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string query = "DELETE FROM tblChucVu where IDChucVu = '" + txtIDChucVu.Text.Trim() + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                var result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Lỗi xóa dữ liệu! Vui lòng thử lại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGhi.Enabled = true;
            btnHuy.Enabled = true;

            State = "Update";
            txtMaChucVu.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaChucVu.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã chức vụ!", "Thông báo");
                    txtMaChucVu.Focus();
                    return;
                }

                if (txtTenChucVu.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên chức vụ!", "Thông báo");
                    txtTenChucVu.Focus();
                    return;
                }

                if (State == "Insert")
                {
                    //thuc hien ghi du lieu
                    SqlConnection con = new SqlConnection(ConnectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string query = "insert into tblChucVu (MaChucVu, TenChucVu, GhiChu) values (N'" + txtMaChucVu.Text.Trim() + "', N'" + txtTenChucVu.Text.Trim() + "', N'" + txtGhiChu.Text.Trim() + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo");
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi dữ liệu! Vui lòng thử lại!","Thông báo");
                    }
                }
                else if (State == "Update")
                {
                    //thuc hien cap nhat du lieu
                    //thuc hien ghi du lieu
                    SqlConnection con = new SqlConnection(ConnectionString);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    string query = "UPDATE tblChucVu SET MaChucVu = N'"+txtMaChucVu.Text.Trim()+"', TenChucVu = N'"+txtTenChucVu.Text.Trim()+"', GhiChu = N'"+txtGhiChu.Text.Trim()+"' WHERE IDChucVu = '"+txtIDChucVu.Text.Trim()+"' ";

                    SqlCommand cmd = new SqlCommand(query, con);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu! Vui lòng thử lại!", "Thông báo");
                    }
                }

            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                //check thông tin tk vs thông tin trong table TaiKhoan
                SqlConnection con = new SqlConnection(ConnectionString);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string KeyWord = txtKWTimKiem.Text.Trim();
                string query = "select * from tblChucVu where TenChucVu LIKE N'%"+KeyWord+"%' ";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dgvMain.DataSource = ds.Tables[0];
                    lblTongSo.Text = "Tổng số: " + (dgvMain.Rows.Count - 1) + " bản ghi";
                }
                else
                {
                    //khong tim thay 
                    dgvMain.DataSource = null;
                    lblTongSo.Text = "Tổng số: 0 bản ghi.";
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
