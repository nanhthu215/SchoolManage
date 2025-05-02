using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Tuition
    {
        private string MaHS, Status;
        private DateTime DueDate;
        private int TuitionID;
        private decimal Amount;
        public string maHS
        {
            get { return MaHS; }
            set { MaHS = value; }
        }
        public string status
        {
            get { return Status; }
            set { Status = value; }
        }
        public int tuition
        {
            get { return TuitionID; }
            set { TuitionID = value; }
        }
        public decimal amount
        {
            get { return Amount; }
            set { Amount = value; }
        }
        public DateTime duedate
        {
            get { return DueDate; }
            set { DueDate = value; }
        }
        public DTO_Tuition(string maHS, DateTime duedate, decimal amount, string status)
        {
            this.maHS = maHS;
            this.status = status;
            this.amount = amount;
            this.duedate = duedate;
        }
    }
}
