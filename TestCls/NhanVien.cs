using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCls
{
    internal class NhanVien : Nguoi
    {
        private double BacLuong;
        private double LuongCoBan;
        private int SLNV;
        NhanVien[] Nv ;

        public double BacLuong1 { get => BacLuong; set => BacLuong = value; }
        public double LuongCoBan1 { get => LuongCoBan; set => LuongCoBan = value; }
        public int SLNV1 { get => SLNV; set => SLNV = value; }

        public NhanVien() : base()
        {
            
        }
        public NhanVien(string ht, string gt,string qq,int ns ,double bl, double Lcb) : base(ht,gt,qq,ns)
        {
            this.BacLuong = bl;
            this.LuongCoBan = Lcb;
        }
        public void NhapTT()
        {
            base.NhapTT();
            Console.WriteLine("Nhập Bậc Lương: ");BacLuong1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập Lương Cơ Bản: "); LuongCoBan1 = Convert.ToDouble(Console.ReadLine());
        }
        public void InTT()
        {   base.InTT();
            Console.WriteLine("Bậc Lương :{0}, Lương Cơ Bản :{1} , Tổng Lương : {2}",BacLuong1,LuongCoBan1,BangLuong());
        }
        public double BangLuong()
        {
            double Luong = BacLuong1 * LuongCoBan1;
            return Luong;
        }
        public void NhapNNV()
        {
            Console.WriteLine("Nhập số lượng Nhân Viên: ");
            
            NhanVien[] Nv = new NhanVien[SLNV];
            for (int i = 0; i < SLNV; i++)
            {
                Nv[i] = new NhanVien();
                Nv[i].NhapTT();

            }
            for (int i = 0; i < SLNV; i++)
            {
                Nv[i].InTT();

            }
            Console.WriteLine();
            for (int i = 0; i < SLNV; i++)
            {
                Console.WriteLine("Nhân Viên {0} Có Lương Là: {1}", Nv[i].HoTen1, Nv[i].BangLuong());

            }
        }

    }
}
