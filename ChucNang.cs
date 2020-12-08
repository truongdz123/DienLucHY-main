using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DienLucHY
{
    class ChucNang
    {
        public void PhieuXuatThongTin(KhachHang khachHang)
        {
           
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", khachHang.Makh,khachHang.Tenchuho,khachHang.Sokwh,"KWH",khachHang.Thanhtien,khachHang.Phuongthucthanhtoan);
            Console.WriteLine("_______________________________________________________________________________________________________________________________");
        }
        public void XuatPhieuThongTin(ArrayList arrayList)
        {
            Console.WriteLine("_______________________________________________________________________________________________________________________________");
            Console.WriteLine("                                                          PHIẾU THÔNG TIN");
            Console.WriteLine("_______________________________________________________________________________________________________________________________");
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|{4,-20}|{5,-20}|", "MãKH","Tên chủ hộ","Số điện tiêu thụ","Đơn vị","Thành tiền","Phương thức TT");
            Console.WriteLine("_______________________________________________________________________________________________________________________________");
            foreach (KhachHang khachHang in arrayList)
            {
                PhieuXuatThongTin(khachHang);
            }
        }
        public void KhachHang(KhachHang khachhang)
        {
          
            
                Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|", khachhang.Makh, khachhang.Tenchuho, khachhang.Ngaysinh, khachhang.Diachi);
            Console.WriteLine("_____________________________________________________________________________________");

        }
        public void HienKhachHang(ArrayList arrayList)
        {
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("                                   THÔNG TIN KHÁCH HÀNG");
            Console.WriteLine("_____________________________________________________________________________________");
            Console.WriteLine("|{0,-20}|{1,-20}|{2,-20}|{3,-20}|",  "Mã KH", "Họ tên", "Ngày sinh", "Địa chỉ");
            Console.WriteLine("_____________________________________________________________________________________");
            foreach (KhachHang khachhang in arrayList)
            {
                KhachHang(khachhang);
            }
        }
        public void SuaThongTin(ArrayList arrayList, string keyword)
        {
            NhapKhachHang nhapKhachHang = new NhapKhachHang();
            bool kt = false;

            foreach (KhachHang khachHang in arrayList)
            {
                if (keyword.ToLower().Equals(khachHang.Makh.ToString()) || keyword.ToLower().Equals(khachHang.Tenchuho.ToLower())||keyword.ToLower().EndsWith(khachHang.Tenchuho.ToLower()))
                {

                    khachHang.Tenchuho = nhapKhachHang.TenChuHo();
                    khachHang.Diachi = nhapKhachHang.DiaChi();
                    khachHang.Ngaysinh = nhapKhachHang.NgaySinh();
                    kt = true;
                    Console.WriteLine("Sửa thông tin thành công");
                }
            }
            if (kt == false) Console.WriteLine("Không tìm thấy khách hàng");
        }
        public void XoaKhachHang(ArrayList arrayList,string keyword)
        {
            KhachHang kh = find(arrayList, keyword);
            if(kh == null)
            {
                Console.WriteLine("Khong tim thay");
            }
            else
            {
                arrayList.Remove(kh);
            }
            
        }
        public KhachHang find(ArrayList arrayList,string keyword)
        {
            KhachHang kq = null;
            foreach(KhachHang kh in arrayList)
            {
                if (kh.Tenchuho.Equals(keyword)||kh.Makh.Equals(keyword))
                {
                    kq = kh;
                }
            }
            return kq;
        }
        public void TinhTienDien(ArrayList arrayList, string keyword)
        {
            NhapKhachHang nhapKhachHang = new NhapKhachHang();
            bool kt = false;
            foreach(KhachHang khachhang in arrayList)
            {
                if (keyword.ToLower().Equals(khachhang.Makh.ToString()) || keyword.ToLower().Equals(khachhang.Tenchuho.ToLower()) || keyword.ToLower().EndsWith(khachhang.Tenchuho.ToLower()))
                {
                    khachhang.Sokwh = nhapKhachHang.Sokwh();
                    khachhang.Thanhtien = nhapKhachHang.ThanhTien(khachhang.Sokwh);
                    khachhang.Phuongthucthanhtoan = nhapKhachHang.ThanhToan();
                    kt = true;
                    Console.WriteLine("Thành công");
                    Console.WriteLine("So tien phai tra la: " + khachhang.Thanhtien);
                }
            }
            if (kt == false) Console.WriteLine("Không tìm thấy khách hàng");
        }
    }
}
