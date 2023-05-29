using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CTHoaDonNhap
    {
        DAL_CTHoaDonNhap daCTHDN = new DAL_CTHoaDonNhap();
        public DataTable getCTHDN()
        {
            return daCTHDN.getCTHDN();
        }
        public int kiemtramatrung(int maCTHDN)
        {
            return daCTHDN.kiemtramatrung(maCTHDN);
        }
        public bool themCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            return daCTHDN.themCTHDN(CTHDN);
        }
        public bool suaCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            return daCTHDN.suaCTHDN(CTHDN);
        }
        public bool xoaCTHDN(int maCTHDN)
        {
            return daCTHDN.xoaCTHDN(maCTHDN);
        }
        public bool KiemTraTonTaiMaCTHDN(int maCTHDN)
        {
           return daCTHDN.KiemTraTonTaiMaCTHDN(maCTHDN);
        }
        
    }
}
