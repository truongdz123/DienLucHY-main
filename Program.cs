using System;
using System.Collections;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Text;

namespace DienLucHY
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("______________________________________________________________________");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("|                        ĐIỆN LỰC HƯNG YÊN                           |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      1.Nhập thông tin khách hàng                   |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      2.Tính tiền điện                              |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      3.Hiện phiếu thông tin                        |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      4.Hiện thông tin khách hàng                   |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      5.Sửa thông tin khách hàng                    |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      6.Xóa thông tin khách hàng                    |");
            Console.WriteLine("|____________________________________________________________________|");
            Console.WriteLine("|                      7.Thoát                                       |");
            Console.WriteLine("|____________________________________________________________________|");

        }
        public static void Chon(NhapKhachHang nhapKhachHang,ChucNang chucNang,ArrayList arrayList,DocGhiFile docGhiFile)
        {
            string chon;
            while (true)
            {
                Menu();
                chon = Console.ReadLine();
                Console.Clear();
                switch (chon)
                {
                    case "1":
                        nhapKhachHang.NhapThongTin(arrayList);
                        docGhiFile.GhiFileKhachHang(arrayList);
                        break;
                    case "2":
                        chucNang.HienKhachHang(arrayList);
                        Console.WriteLine("Nhập ID khách hàng: ");
                        string id = Console.ReadLine();
                        chucNang.TinhTienDien(arrayList, id);
                        docGhiFile.GhiFileKhachHang(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        chucNang.XuatPhieuThongTin(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        chucNang.HienKhachHang(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        chucNang.HienKhachHang(arrayList);
                        Console.WriteLine("Nhập khách hàng cần sửa: ");
                        string key = Console.ReadLine();
                        chucNang.SuaThongTin(arrayList, key);
                        docGhiFile.GhiFileKhachHang(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "6":
                        chucNang.HienKhachHang(arrayList);
                        Console.WriteLine("Nhập khách hàng cần xóa: ");
                        string keyword = Console.ReadLine();
                        chucNang.XoaKhachHang(arrayList, keyword);
                        docGhiFile.GhiFileKhachHang(arrayList);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    default:
                        Menu();
                        break;
                }
                if (chon =="7") break;
            }
        }

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            NhapKhachHang nhapKhachHang = new NhapKhachHang();
            DocGhiFile docGhiFile = new DocGhiFile();
            ChucNang chucNang = new ChucNang();
            ArrayList arrayList = new ArrayList();
            docGhiFile.DocFileKhachHang(arrayList);
            Chon(nhapKhachHang, chucNang, arrayList, docGhiFile);

            
        }
    }
}
