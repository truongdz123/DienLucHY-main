using System;
using System.Collections.Generic;
using System.Text;

namespace DienLucHY
{
    class KhachHang
    {
        private int makh;
        private string tenchuho;
        private int sokwh;
        private int thanhtien;
        private string phuongthucthanhtoan;
        private string thoigian;
        private string ngaysinh;
        private string diachi;
        public KhachHang()
        {

        }
        public KhachHang(int makh,string tenchuho,string ngaysinh,string diachi)
        {
            this.makh = makh;
            this.tenchuho = tenchuho;
            this.ngaysinh = ngaysinh;
            this.diachi = diachi;
            sokwh = 0;
            thanhtien = 0;
            phuongthucthanhtoan = "";
            thoigian = "";
        }
        override
            public string ToString()
        {
            return makh + "|" + tenchuho + "|" + sokwh + "|" + thanhtien + "|" + phuongthucthanhtoan+"|"+thoigian+"|"+ngaysinh+"|"+diachi;
        }
        public int Makh { get => makh; set => makh = value; }
        public string Tenchuho { get => tenchuho; set => tenchuho = value; }
        public int Sokwh { get => sokwh; set => sokwh = value; }
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Phuongthucthanhtoan { get => phuongthucthanhtoan; set => phuongthucthanhtoan = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
    }
}
