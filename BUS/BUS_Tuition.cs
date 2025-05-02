using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BUS
{
    public class BUS_Tuition
    {
        DAL_Tuition p;

        public BUS_Tuition(string maHS, DateTime duedate, decimal amount, string status)
        {
            p = new DAL_Tuition(maHS, duedate, amount, status);
        }

        public BUS_Tuition()
        {
             p = new DAL_Tuition();
        }
        public void DeleteByID(string tuitionID)
        {
            DAL_Tuition dal = new DAL_Tuition(); // thêm constructor rỗng trong DAL
            dal.DeleteByID(tuitionID);
        }
        public void addQuery()
        {
            p.addQuery();
        }

        public void updateQuery()
        {
            p.updateQuery();
        }

        public void deleteQuery()
        {
            p.deleteQuery();
        }

        public DataTable selectQuery()
        {
            return p.selectQuery();
        }
        public DataTable selectQuery_Student(string maHS)
        {
            return p.selectQuery_Student(maHS);
        }
        public DataTable selectStudentList()
        {
            return p.selectStudentList();
        }
    }
}
