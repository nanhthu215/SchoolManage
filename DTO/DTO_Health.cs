using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_Health
    {
        private string MaHS, TinhTrangSucKhoe;
        private decimal CanNang, ChieuCao;
        private DateTime NgayKiemTra;

        public string maHS
        {
            get { return MaHS; }
            set { MaHS = value; }
        }

        public string TinhTrang
        {
            get { return TinhTrangSucKhoe; }
            set { TinhTrangSucKhoe = value; }
        }

        public decimal canNang
        {
            get { return CanNang; }
            set { CanNang = value; }
        }

        public decimal chieuCao
        {
            get { return ChieuCao; }
            set { ChieuCao = value; }
        }

        public DateTime ngayKiemTra
        {
            get { return NgayKiemTra; }
            set { NgayKiemTra = value; }
        }

        public DTO_Health(string maHS, decimal canNang, decimal chieuCao, string tinhTrang, DateTime ngayKiemTra)
        {
            this.MaHS = maHS;
            this.CanNang = canNang;
            this.ChieuCao = chieuCao;
            this.TinhTrangSucKhoe = tinhTrang;
            this.NgayKiemTra = ngayKiemTra;
        }
    }
}
