using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThueXeDien
{
    public partial class Form1 : Form
    {
        private List<XeDien> dsXeDien = new List<XeDien>();
        int viTri = -1;
        private Timer countdownTimer;

        public Form1()
        {
            InitializeComponent();
            // Khởi tạo Timer
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 giây
            countdownTimer.Tick += CountdownTimer_Tick; // Gán sự kiện Tick

            // Thêm cột cho dgvXe
            //dgvXe.Columns.Add("maXe", "Mã Xe");
            //dgvXe.Columns.Add("trangThai", "Trạng Thái");

            //// Thêm cột cho dgvXeChay
            //dgvXeChay.Columns.Add("maXe", "Mã Xe");
            //dgvXeChay.Columns.Add("thoiGianConLai", "Thời Gian Còn Lại");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ? ", " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa ? ", " Xác nhận ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (viTri >= 0 && viTri < dsXeDien.Count)
                {
                    dsXeDien.RemoveAt(viTri);
                    hienThiDulieu(dgvXe, dsXeDien);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một chiếc xe để xóa!", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }

        private void hienThiDulieu(DataGridView dgv, List<XeDien> dsXeDien)
        {
            dgv.Rows.Clear(); // Xóa các dòng cũ
            foreach (XeDien xe in dsXeDien)
            {
                // Kiểm tra trạng thái và gán giá trị hiển thị cho cột "Trạng thái"
                string trangThaiHienThi = xe.TrangThai ? "Đang thuê" : "Chưa thuê";

                // Thêm hàng mới vào DataGridView
                dgv.Rows.Add(xe.MaXe, trangThaiHienThi);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Tạo đối tượng XeDien với trạng thái false (Sẵn sàng)
            XeDien xe = new XeDien(txtMaXe.Text, false);

            // Thêm xe vào danh sách
            dsXeDien.Add(xe);

            // Thông báo thành công
            MessageBox.Show("Thêm thành công! ", "Thông báo", MessageBoxButtons.OK);

            // Hiển thị lại dữ liệu trong DataGridView
            hienThiDulieu(dgvXe, dsXeDien);
        }

        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            viTri = e.RowIndex;
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            if (viTri == -1)
            {
                MessageBox.Show("Vui lòng chọn một chiếc xe!", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            var selectedRow = dgvXe.Rows[viTri]; // Sử dụng Rows thay vì SelectedRows
            string maXe = selectedRow.Cells["maXe"].Value.ToString();

            // Cập nhật trạng thái xe ở dgvXe
            selectedRow.Cells["trangThai"].Value = "Đang thuê";

            // Thêm xe vào dgvXeChay với thời gian đếm ngược
            dgvXeChay.Rows.Add(maXe, "15:00");

            // Bắt đầu đếm ngược
            countdownTimer.Start();
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dgvXeChay.Rows)
            {
                // Kiểm tra xem ô "thoiGianConLai" có giá trị không
                if (row.Cells["thoiGianConLai"].Value != null)
                {
                    string thoiGianConLai = row.Cells["ThoiGian"].Value.ToString();
                    TimeSpan time = TimeSpan.Parse(thoiGianConLai);

                    // Giảm 1 giây
                    time = time.Add(TimeSpan.FromSeconds(-1));
                    row.Cells["ThoiGian"].Value = time.ToString("mm':'ss");

                    // Kiểm tra nếu hết giờ
                    if (time.TotalSeconds <= 0)
                    {
                        MessageBox.Show("Xe " + row.Cells["maXe"].Value.ToString() + " đã hết thời gian thuê!");

                        // Loại bỏ xe khỏi DataGridView2 và cập nhật trạng thái trong DataGridView1
                        foreach (DataGridViewRow rowAll in dgvXe.Rows)
                        {
                            if (rowAll.Cells["maXe"].Value.ToString() == row.Cells["maXe"].Value.ToString())
                            {
                                rowAll.Cells["trangThai"].Value = "Chưa thuê";
                                break;
                            }
                        }
                        rowsToRemove.Add(row);
                    }
                }
            }

            // Xóa các hàng đã đánh dấu
            foreach (var row in rowsToRemove)
            {
                dgvXeChay.Rows.Remove(row);
            }
        }

       
    }

    }