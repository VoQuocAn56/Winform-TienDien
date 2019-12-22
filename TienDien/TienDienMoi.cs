using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TienDien
{
    class TienDienMoi:TienDien
    {
        int DinhMuc;

        public TienDienMoi() : base()
        {
            DinhMuc = 0;
        }

        public TienDienMoi(string HoTen, string DiaChi, int SCTDThangNay, int SCTDThangTruoc, int dinhmuc)
            : base(HoTen, DiaChi, SCTDThangNay, SCTDThangTruoc)
        {
            DinhMuc = dinhmuc;
        }

        public override int TinhTien(int SCTDThangTruoc, int SCTDThangNay)
        {
            int SCTDTieuThu = SoCongDienDaDung(SCTDThangTruoc, SCTDThangNay);

            if (SCTDTieuThu < DinhMuc)
            {
                return base.TinhTien(SCTDThangTruoc, SCTDThangNay);
            }
            else
            {
                return SCTDTieuThu * 1600;
            }

        }

        public override string HienThi()
        {
            return base.HienThi();
        }
    }
   
}
