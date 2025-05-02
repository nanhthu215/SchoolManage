using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_DanhGia
    {
        private string NhanXet;
        private int Diem;

        public string nhanxet
        {
            get { return NhanXet; }
            set { NhanXet = value; }
        }
        public int diem
        {
            get { return Diem; }
            set { Diem = value; }
        }

        public DTO_DanhGia(int Diem, string NhanXet )
        {
            this.diem = Diem;
            this.nhanxet = NhanXet;
        }
    }
}
