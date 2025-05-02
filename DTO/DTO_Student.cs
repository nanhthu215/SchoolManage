using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Student
    {
        private string MaHS, HoTen, DiaChi, SDT, MaLop, GioiTinh;
        private DateTime NgaySinh;
        public string maHS
        {
            get { return MaHS; }
            set { MaHS = value; }
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
        public string maLop
        {
            get { return MaLop; }
            set { MaLop = value; }
        }
        public DTO_Student(string maHS, string hoTen, string diaChi, string sDT, DateTime ngaySinh, string gioiTinh, string maLop)
        {
            this.MaHS = maHS;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.SDT = sDT;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.MaLop = maLop;
        }
    }
}
