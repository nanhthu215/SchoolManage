using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Text;

namespace DAL
{
    public class DAL_Tuition
    {
        DTO_Tuition p;

        public DAL_Tuition(string maHS, DateTime duedate, decimal amount, string status)
        {
            p = new DTO.DTO_Tuition(maHS, duedate, amount, status);
        }

        public DAL_Tuition()
        {
        }

        public void addQuery()
        {
            string query = "INSERT INTO Tuition (MaHS, DueDate, Amount, Status) VALUES (@MaHS, @DueDate, @Amount, @Status)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", p.maHS),
                new SqlParameter("@DueDate", p.duedate),
                new SqlParameter("@Amount", p.amount),
                new SqlParameter("@Status", p.status),
            };
            Connection.actionQuery(query, parameters);
        }


        public void updateQuery()
        {
            string query = "UPDATE Tuition SET MaHS = @MaHS, DueDate = @DueDate, Amount = @Amount, Status = @Status WHERE TuitionID = @TuitionID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaHS", p.maHS),
                new SqlParameter("@DueDate", p.duedate),
                new SqlParameter("@Amount", p.amount),
                new SqlParameter("@Status", p.status)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery_Student(string MaHS)
        {
            string s = "select * from Tuition where MaHS = '" + MaHS + "'";
            return Connection.selectQuery(s);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM Tuition WHERE TuitionID = @TuitionID";
            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@TuitionID", p.tuition)
            };
            Connection.actionQuery(query, parameters);
        }

        public DataTable selectQuery()
        {
            string s = "select * from Tuition";
            return Connection.selectQuery(s);
        }
        public void DeleteByID(string tuitionID)
        {
            string query = "DELETE FROM Tuition WHERE TuitionID = @id";
            SqlParameter[] parameters =
            {
        new SqlParameter("@id", tuitionID)
            };
            Connection.actionQuery(query, parameters);
        }
        public DataTable selectStudentList()
        {
            string query = "SELECT MaHS, HoTen FROM HocSinh";
            return Connection.selectQuery(query);
        }
        public void MarkAsPaid(string tuitionID)
        {
            string query = "UPDATE Tuition SET Status = N'Đã thanh toán' WHERE TuitionID = @id";
            SqlParameter[] param = {
        new SqlParameter("@id", tuitionID)
    };
            Connection.actionQuery(query, param);
        }


    }
}
