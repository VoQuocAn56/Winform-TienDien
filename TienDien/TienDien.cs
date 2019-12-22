using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    class TienDien
    {
        string HoTen;
        string DiaChi;
        int SCTDThangNay;
        int SCTDThangTruoc;

        public TienDien()
        {
            this.HoTen = "";
            this.DiaChi = "";
            this.SCTDThangNay = 0;
            this.SCTDThangTruoc = 0;
        }

        public TienDien(string HoTen, string DiaChi, int SCTDThangNay, int SCTDThangTruoc)
        {
            this.HoTen = HoTen;
            this.DiaChi = DiaChi;
            this.SCTDThangNay = SCTDThangNay;
            this.SCTDThangTruoc = SCTDThangTruoc;
        }

        public virtual string HienThi() {
            int SCTDTienThu = SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay);
            int ThanhTien = TinhTien(SCTDThangTruoc, SCTDThangNay);

            return string.Format("Họ tên chủ hộ: {0} " +
                "\nĐịa chỉ: {1} " +
                "\nSố công tơ điện tháng này: {2}" +
                "\nSố công tơ điện tháng trước: {3}" +
                "\nSố công tơ điện tiêu thụ: {4}" +
                "\nThành tiền: {5}"
                , new object[] { HoTen, DiaChi, SCTDThangNay, SCTDThangTruoc, SCTDTienThu, ThanhTien });
        }

        public int SoCongDienDaDung(int SCTDThangTruoc, int SCTDThangNay)
        {
            return SCTDThangNay - SCTDThangTruoc;
        }

        public virtual int TinhTien(int SCTDThangTruoc, int SCTDThangNay)
        {
            return SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay) * 1240;
        }
    }
}
