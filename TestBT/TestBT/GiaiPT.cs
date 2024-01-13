using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBT
{
    internal class GiaiPT
    {
        static void giaiptb1()
        {
            Console.WriteLine("Nhập số a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập số b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a != 0)

            {
                float x = -b / a;
                Console.WriteLine("Phương trình có nghiệm x =  " + x);
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình có vô số nghiệm");
                }
                else
                { Console.WriteLine("Phương trình vô nghiệm"); }
            }
            Console.ReadKey();
            Console.Clear();
        }
        static void giaiptbac2()
        {
            Console.WriteLine("Nhập so a :");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập so b :");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập so c");
            float c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm ");
                }
                Console.WriteLine("Phương trình có nột nghiệm x = " + (-c / b));
            }

            float delta = b * b - (4 * a * c);
            float x1;
            float x2;
            if (delta > 0)
            {
                x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                Console.Write("Phương trình có hai nghiệm: x1 = {0} và x2 = {1}", x1, x2);
            }

            else if (delta == 0)
            {
                x1 = (-b / (2 * a));
                Console.Write("Phương trình có nghiệm kép : x1 = x2 = {0}", x1);
            }
            else
            {
                Console.Write("Phương trình vô nghiệm!");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
