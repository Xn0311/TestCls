using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCls
{
    internal class Nguoi
    {
        private string HoTen;
        private string GioiTinh;
        private string QueQuan;
        private int NamSinh;

        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }

        public Nguoi()
        {
            
        }
        public Nguoi(string ht, string gt, string qq, int ns)
        {
            this.HoTen = ht;
            this.GioiTinh = gt;
            this.QueQuan = qq;
            this.NamSinh = ns;
            
        }
        
        public void NhapTT()
        {
            Console.WriteLine("Nhập Họ Tên : ");HoTen1 = Console.ReadLine();
            Console.WriteLine("Nhập giới tính: ");GioiTinh1 = Console.ReadLine();
            Console.WriteLine("Nhập Quê Quán: ");QueQuan1 = Console.ReadLine();
            Console.WriteLine("Nhập Năm Sinh: ");NamSinh1 = Convert.ToInt32(Console.ReadLine());
        }
        public void InTT()
        {
            Console.WriteLine("Họ tên : {0}, Giới tính {1}, Năm sinh {2}, Năm sinh {3}",HoTen1,GioiTinh1,QueQuan1,NamSinh1);
        }
        public int TinhTuoi()
        {
            int namHienTai = DateTime.Now.Year;
            int tuoi = namHienTai - NamSinh1;
            return tuoi;
        }


    }
}
