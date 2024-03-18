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

namespace THUCHANH4
{
    public partial class Form1 : Form
    {
        string connect = @"Data Source=.;Initial Catalog=ThamMyVien;Integrated Security=True";
        private List<string> selectedItems = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'thamMyVienDataSet.tblDichVu' table. You can move, or remove it, as needed.
            this.tblDichVuTableAdapter.Fill(this.thamMyVienDataSet.tblDichVu);
            // TODO: This line of code loads data into the 'thamMyVienDataSet.tblBenhNhan' table. You can move, or remove it, as needed.
            this.tblBenhNhanTableAdapter.Fill(this.thamMyVienDataSet.tblBenhNhan);
            cbb_ma_benh_nhan.Text = "";
            cbb_dich_vu.Text = "";
        }

        private void cbb_ma_benh_nhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_ma_benh_nhan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedMaBenhNhan = cbb_ma_benh_nhan.Text.Trim();
            string tenBenhNhan = LayTenBenhNhan(selectedMaBenhNhan);
            tb_ten_benh_nhan.Text = tenBenhNhan;
        }

        private string LayTenBenhNhan(string maBenhNhan)
        {
            string tenBenhNhan = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    connection.Open();
                    string query = "SELECT TenBN FROM tblBenhNhan WHERE MaBN = @MaBN";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBN", maBenhNhan);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        tenBenhNhan = reader["TenBN"].ToString();
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi truy vấn CSDL: " + ex.Message);
            }
            return tenBenhNhan;
        }

        private void tb_ten_benh_nhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbb_dich_vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select = cbb_dich_vu.Text.Trim();
            if (!selectedItems.Contains(select))
            {
                selectedItems.Add(select);
            }
            lb_dsdv.Text = string.Join("\n", selectedItems);
        }


        private void tb_ngay_TextChanged(object sender, EventArgs e)
        {
            checkNgay();
        }

        private void tb_thang_TextChanged(object sender, EventArgs e)
        {
            checkNgay();
        }

        private void tb_nam_TextChanged(object sender, EventArgs e)
        {
            checkNgay();
        }

        private void checkNgay()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            errorProvider3.Clear();
            string ngay = tb_thang.Text.Trim();
            string thang = tb_ngay.Text.Trim();
            string nam = tb_nam.Text.Trim();
            if (!DateTime.TryParse($"{ngay}/{thang}/{nam}", out DateTime ngayThangNam))
            {
                errorProvider1.SetError(tb_ngay, "Ngày  không hợp lệ");
                errorProvider2.SetError(tb_thang, " tháng  không hợp lệ");
                errorProvider3.SetError(tb_nam, " năm không hợp lệ");
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            string ngay = tb_ngay.Text + "/" + tb_thang.Text + "/" + tb_nam.Text;
            string hoTen = tb_ten_benh_nhan.Text;
            string dsdv = string.Join(",", selectedItems);


            if(cbb_ma_benh_nhan.Text.Trim() != "" && 
                tb_ten_benh_nhan.Text.Trim() != "" &&
                tb_ngay.Text.Trim() != "" && 
                tb_thang.Text.Trim() != "" && 
                tb_nam.Text.Trim() != "" &&
                cbb_dich_vu.Text.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        // Chuẩn bị câu truy vấn SQL
                        string query = "INSERT INTO tblHopDong (ngay, MaBN, DichVU) VALUES (@Ngay, @MaBN, @DichVu)";
                        SqlCommand command = new SqlCommand(query, connection);
                        // Gán các tham số cho câu truy vấn SQL
                        command.Parameters.AddWithValue("@Ngay", $"{tb_nam.Text.Trim()}/{tb_thang.Text.Trim()}/{tb_ngay.Text.Trim()}");
                        command.Parameters.AddWithValue("@MaBN", cbb_ma_benh_nhan.Text.Trim());
                        command.Parameters.AddWithValue("@DichVu", dsdv);
                        // Thực thi câu truy vấn SQL
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm hợp đồng thành công!");

                        lb_kq.Text = "Họ tên: " + hoTen + "\n" +
                                    "Ngày tháng: " + ngay + "\n" +
                                    "Dịch vụ: " + dsdv;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm hợp đồng: " + ex.Message);
                    }
                }
            }

            else if(cbb_ma_benh_nhan.Text.Trim() != "" && tb_ten_benh_nhan.Text.Trim() != "")
            {
                using (SqlConnection connection = new SqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        // Chuẩn bị câu truy vấn SQL
                        string query = "INSERT INTO tblBenhNhan (MaBN, TenBN) VALUES (@MaBN, @TenBN)";
                        SqlCommand command = new SqlCommand(query, connection);
                        // Gán các tham số cho câu truy vấn SQL
                        command.Parameters.AddWithValue("@MaBN", cbb_ma_benh_nhan.Text.Trim());
                        command.Parameters.AddWithValue("@TenBN", tb_ten_benh_nhan.Text.Trim());
                        // Thực thi câu truy vấn SQL
                        command.ExecuteNonQuery();
                        MessageBox.Show("Thêm bệnh nhân thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm hợp đồng: " + ex.Message);
                    }
                }
            }

            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin !");
            }
        }

        private void btn_tiptuc_Click(object sender, EventArgs e)
        {
            if(cbb_ma_benh_nhan.Text.Trim() != "" || tb_ten_benh_nhan.Text.Trim() != "" ||
                tb_ngay.Text.Trim() != "" || tb_thang.Text.Trim() != "" || tb_nam.Text.Trim() != "" ||
                cbb_dich_vu.Text.Trim() != "")
            {
                cbb_ma_benh_nhan.Text = "";
                tb_ten_benh_nhan.Text = "";
                tb_ngay.Text = "";
                tb_thang.Text = "";
                tb_nam.Text = "";
                cbb_dich_vu.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
