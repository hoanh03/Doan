using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BUS_CTHoaDonBan
    {
        DAL_CTHoaDonBan daCTHDB = new DAL_CTHoaDonBan();
        public DataTable getCTHDB()
        {
            return daCTHDB.getCTHDB();
        }
        public int kiemtramatrung(int maCTHDB)
        {
            return daCTHDB.kiemtramatrung(maCTHDB);
        }
        public bool themCTHDB(DTO_CTHoaDonBan CTHDB)
        {
            return daCTHDB.themCTHDB(CTHDB);
        }
        public bool suaCTHDB(DTO_CTHoaDonBan CTHDB)
        {
            return daCTHDB.suaCTHDB(CTHDB);
        }
        public bool xoaCTHDB(int maCTHDB)
        {
            return daCTHDB.xoaCTHDB(maCTHDB);
        }
        public bool KiemTraTonTaiMaCTHDB(int maCTHDB)
        {
            return daCTHDB.KiemTraTonTaiMaCTHDB(maCTHDB);
        }
    }
}
