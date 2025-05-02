using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Class
    {
        private string MaLop, TenLop, GVCN, NienKhoa;
        public string maLop
        {
            get { return MaLop; }
            set { MaLop = value; }
        }
        public string tenLop
        {
            get { return TenLop; }
            set { TenLop = value; }
        }
        public string gvcn
        {
            get { return GVCN; }
            set { GVCN = value; }
        }
        public string nienKhoa
        {
            get { return NienKhoa; }
            set { NienKhoa = value; }
        }
        public DTO_Class(string maLop, string tenLop, string gvcn, string nienKhoa)
        {
            this.MaLop = maLop;
            this.TenLop = tenLop;
            this.GVCN = gvcn;
            this.NienKhoa = nienKhoa;
        }
    }
}
