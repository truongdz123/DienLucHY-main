using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DienLucHY
{
    class NhapKhachHang
    {
        public void NhapThongTin(ArrayList arrayList)
        {
            arrayList.Add(new KhachHang(MaKhachHang(arrayList),TenChuHo(),NgaySinh(),DiaChi()));
        }
        public string DiaChi()
        {
            Console.WriteLine("Nhập địa chỉ: ");
            string diachi = Console.ReadLine();
            Console.Clear();
            return diachi;
        }
        public string NgaySinh()
        {
            Console.WriteLine("Nhập ngày sinh: ");
            string ngay = Console.ReadLine();
            Console.Clear();
            return ngay;
        }
        public int MaKhachHang(ArrayList arrayList)
        {
            return arrayList.Count + 1000;
        }
        public string TenChuHo()
        {
            string ten;
            while (true)
            {
                Console.WriteLine("Nhập tên chủ hộ: ");
                ten = Console.ReadLine(); 
                Console.Clear();
                if (ten != "") break;
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ten.ToLower());
           
        }
        public int Sokwh()
        {
            int sokwh;
            while (true)
            {
                Console.WriteLine("Nhập số kwh: ");
                sokwh = int.Parse(Console.ReadLine());
                Console.Clear();
                if (sokwh > 0) break;
            }
            return sokwh;
        }
        public int ThanhTien(int sokwh)
        {
            if (sokwh <= 50) return sokwh * 1678;
            else if (sokwh <= 100) return 50 * 1678 + (sokwh - 50) * 1734;
            else if (sokwh <= 200) return 50 * 1678 + 50 * 1734 + (sokwh - 100) * 2014;
            else if (sokwh <= 300) return 50 * 1678 + 50 * 1734 + 100 * 2014 + (sokwh - 200) * 2536;
            else if (sokwh < 400) return 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + (sokwh - 300) * 2834;
            return 50 * 1678 + 50 * 1734 + 100 * 2014 + 100 * 2536 + 100 * 2834 + (sokwh - 400) * 2927;
        }
        public string ThanhToan()
        {
            Console.WriteLine("1.Thanh toán trực tiếp tại điểm giao dịch\n2.Thanh toán bằng ví điện tử\n3.Thanh toán bằng ATM");
            string chon = Console.ReadLine();

            string phuongthuc;
            switch (chon)
            {
                case "1": phuongthuc = "trực tiếp";
                    break;
                case "2":
                    phuongthuc = "Ví điện tử";
                    break;
                case "3":
                    phuongthuc = "ATM";
                    break;
                default:
                    phuongthuc = "";
                    break;
            }
            Console.Clear();
            return phuongthuc;
        }
        public string ThoiGian()
        {
            Console.WriteLine("Nhập thời gian :");
            string thoigian = Console.ReadLine();
            Console.Clear();
            return thoigian;
        }
    }
}
