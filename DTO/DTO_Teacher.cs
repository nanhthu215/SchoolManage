using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Teacher
    {//MaGV, HoTen, NgaySinh, GioiTinh, SDT, Email, DiaChi
        private string MaGV, HoTen, GioiTinh, SDT, Email, DiaChi;
        private DateTime NgaySinh;
        public string maGV
        {
            get { return MaGV; }
            set { MaGV = value; }
        }
        public string hoTen
        {
            get { return HoTen; }
            set { HoTen = value; }
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string sDT
        {
            get { return SDT; }
            set { SDT = value; }
        }
        public DateTime ngaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        public string gioiTinh
        {
            get { return GioiTinh; }
            set { GioiTinh = value; }
        }
        public string email
        {
            get { return Email; }
            set { Email = value; }
        }
        public DTO_Teacher(string maGV, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string email)
        {
            this.MaGV = maGV;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.Email = email;
        }
    }
}
