using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCls
{
    internal class Program
    {
        static void BubbleSort(NhanVien[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].BangLuong() > arr[j + 1].BangLuong())
                    {
                        // Hoán đổi vị trí
                        NhanVien temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        
            static void Main(string[] args)
            {
            NhanVien Nv = new NhanVien();    
            Nv.NhapNNV();
            Console.WriteLine();

            Console.WriteLine("Những Nhân Viên Nữ Có Tuổi lớn hơn 50");
                for (int i = 0; i < N; i++)
                {
                    if (Nv[i].GioiTinh1 == "nu" && Nv[i].TinhTuoi() > 50)
                    {
                        Nv[i].InTT();
                    }
                }
            Console.WriteLine();
            Console.WriteLine("Những nhân viên có lương <5000000");

            for (int i = 0; i < N; i++)
                {
                    if (Nv[i].BangLuong() < 5000000)
                    {
                        Nv[i].InTT();
                    }
                }
            Console.WriteLine();
            BubbleSort(Nv);
            Console.WriteLine("Danh sách nhân viên theo thứ tự tăng dần theo mức lương");
            for (int i = 0; i < N; i++)
            {
                Nv[i].InTT();

            }
            Console.WriteLine();
            Console.WriteLine("Thông Tin Những Nhân viên có Tên Là Nam");

            for (int i = 0; i < N; i++)
            {
                if (Nv[i].HoTen1 == "Nam")
                Nv[i].InTT();

            }
            Console.ReadKey();
        }
    }
}




    

