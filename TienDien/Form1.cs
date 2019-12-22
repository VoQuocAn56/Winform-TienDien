using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TienDien
{
    public partial class Form1 : Form
    {
        private string TenChuHo;
        private string DiaChi;
        private int SCTDThangNay;
        private int SCTDThangTruoc;
        private bool KiemTraSCTD;
        private int DemSoClick;

        public Form1()
        {
            DemSoClick = 0;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTienDienMoi_Click(object sender, EventArgs e)
        {
            LayThongTin();
            TienDienMoi tienDien = new TienDienMoi(TenChuHo, DiaChi, SCTDThangNay, SCTDThangTruoc, 100);
            MessageBox.Show(tienDien.HienThi(), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txbDiaChi.Text = "";
            txbHoTenChuHo.Text = "";
            txbSCTDThangNay.Text = "0";
            txbSCTDThangTruoc.Text = "0";
        }

        private void btnTienDien_Click(object sender, EventArgs e)
        {
            LayThongTin();
            TienDien tienDien = new TienDien(TenChuHo, DiaChi, SCTDThangNay, SCTDThangTruoc);
            MessageBox.Show(tienDien.HienThi(), "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LayThongTin() {
            TenChuHo = txbHoTenChuHo.Text.ToString();
            DiaChi = txbHoTenChuHo.Text.ToString();
            do
            {
                try
                {
                    SCTDThangNay = int.Parse(txbSCTDThangNay.Text.ToString());
                    if (SCTDThangNay < 0)
                    {
                        MessageBox.Show("Số công tơ điện tháng này phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        KiemTraSCTD = true;
                    }
                    else KiemTraSCTD = false;
                }
                catch
                {
                    KiemTraSCTD = true;
                    MessageBox.Show("Dữ liệu số công tơ điện phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (KiemTraSCTD);

            do
            {
                try
                {
                    SCTDThangTruoc = int.Parse(txbSCTDThangTruoc.Text.ToString());

                    if (SCTDThangTruoc < 0)
                    {
                        MessageBox.Show("Số công tơ điện tháng trước phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        KiemTraSCTD = true;
                    }
                    else KiemTraSCTD = false;
                }
                catch
                {
                    KiemTraSCTD = true;
                    MessageBox.Show("Dữ liệu số công tơ điện phải là số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } while (KiemTraSCTD);
        }


    }
}
