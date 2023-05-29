using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_CTHoaDonNhap : DBConnect
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        //hiển thị dskh ra ngoài màn hình
        public DataTable getCTHDN()
        {
            _con.Open();
            da = new SqlDataAdapter("Select * from ChitietHDN", _con);
            dt = new DataTable();
            da.Fill(dt);
            _con.Close();
            return dt;
        }
        void thucthisql(string sql)
        {
            _con.Open();
            cmd = new SqlCommand(sql, _con);
            cmd.ExecuteNonQuery();
            _con.Close();
        }
        public int kiemtramatrung(int maCTHDN)
        {
            int i = 0;
            try
            {
                _con.Open();
                string sql = "SELECT COUNT(*) FROM ChitietHDN WHERE maCTHDN = @MaCTHDN";
                SqlCommand cmd = new SqlCommand(sql, _con);
                cmd.Parameters.AddWithValue("@MaCTHDN", maCTHDN);
                i = (int)cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // Xử lý lỗi kết nối
            }
            finally
            {
                _con.Close();
            }
            return i;
        }

        public bool themCTHDN(DTO_CTHoaDonNhap CTHDN)
        {

            string sql = "Insert into ChitietHDN values(N'" + CTHDN.maCTHDN + "',N'" + CTHDN.MaHDN + "',N'" + CTHDN.MaSP + "',N'" + CTHDN.soluong + "','" + CTHDN.gia + "','" + CTHDN.tongtien + "')";

            thucthisql(sql);
            return true;


        }
        public bool suaCTHDN(DTO_CTHoaDonNhap CTHDN)
        {
            //string ngay = string.Format("{0}/{1}/{2}", HDN.ngaynhap.Year, HDN.ngaynhap.Month, HDN.ngaynhap.Day);
            string sql = "Update ChitietHDN set maHDN = N'" + CTHDN.MaHDN + "', MaSP = '" + CTHDN.MaSP + "',soluong = '" + CTHDN.soluong + "',gia = '" + CTHDN.gia + "',tongtien = '" + CTHDN.tongtien + "' where maCTHDN = '" + CTHDN.maCTHDN + "'";

            thucthisql(sql);
            return true;
        }
        public bool xoaCTHDN(int maCTHDN)
        {
            {
                string sql = "Delete from ChitietHDN where maCTHDN = '" + maCTHDN + "'";

                thucthisql(sql);
                return true;
            }
        }
        public bool KiemTraTonTaiMaCTHDN(int maCTHDN)
        {
            _con.Open();
            string sql = "SELECT COUNT(*) FROM ChitietHDN WHERE maCTHDN = @maCTHDN";
            SqlCommand cmd = new SqlCommand(sql, _con);
            cmd.Parameters.AddWithValue("@maCTHDN", maCTHDN);
            int count = (int)cmd.ExecuteScalar();
            _con.Close();
            return count > 0;
        }
       
    }
}
