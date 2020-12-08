using System;
using System.Collections;
using System.IO;
using System.Text;

namespace DienLucHY
{
    class DocGhiFile
    {
        public void DocFileKhachHang(ArrayList arrayList)
        {
            if (File.Exists("khachhang.txt"))
            {
                StreamReader streamReader = new StreamReader("khachhang.txt");
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    if (line == "") break;
                    //makh + "|" + tenchuho + "|" + sokwh + "|" + thanhtien + "|" + phuongthucthanhtoan + "|" + thoigian + "|" + ngaysinh + "|" + diachi;
                    KhachHang khachhang = new KhachHang();
                    khachhang.Makh = int.Parse(line.Split("|")[0]);
                    khachhang.Tenchuho = line.Split("|")[1];
                    khachhang.Sokwh = int.Parse(line.Split("|")[2]);
                    khachhang.Thanhtien = int.Parse(line.Split("|")[3]);
                    khachhang.Phuongthucthanhtoan = line.Split("|")[4];
                    khachhang.Thoigian = line.Split("|")[5];
                    khachhang.Ngaysinh = line.Split("|")[6];
                    khachhang.Diachi = line.Split("|")[7];
                    arrayList.Add(khachhang);
                }
                streamReader.Close();
            }

        }
        public void GhiFileKhachHang(ArrayList arrayList)
        {
            StreamWriter streamWriter = new StreamWriter("khachhang.txt");
            foreach (KhachHang khachHang in arrayList)
            {
                streamWriter.WriteLine(khachHang.ToString());
            }
            streamWriter.Close();
        }
    }
}
