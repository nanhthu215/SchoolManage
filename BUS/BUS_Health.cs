using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_Health
    {
        DAL_Health dh;

        public BUS_Health(string maHS, decimal canNang, decimal chieuCao, string tinhTrang, DateTime ngayKiemTra)
        {
            dh = new DAL_Health(maHS, canNang, chieuCao, tinhTrang, ngayKiemTra);
        }

        public void addQuery()
        {
            dh.addQuery();
        }

        public void updateQuery()
        {
            dh.updateQuery();
        }

        public void deleteQuery()
        {
            dh.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return dh.selectQuery();
        }
        public DataTable selectQuery_Student(string maHS)
        {
            return dh.selectQuery_Student(maHS);
        }
        public DataTable selectStudentList()
        {
            return dh.selectStudentList();
        }
    }
}
