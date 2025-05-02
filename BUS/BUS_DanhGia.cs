using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_DanhGia
    {
        DAL_DanhGia dc;

        public BUS_DanhGia(int Diem, string NhanXet)
        {
            dc = new DAL_DanhGia(Diem, NhanXet);
        }

        public void addQuery()
        {
            dc.addQuery();
        }

        public DataTable selectQuery()
        {
            return dc.selectQuery();
        }
    }
}
