using System;
using System.Diagnostics.CodeAnalysis;

class Program
{// bài tập chương 2

    static void inmh()
    {
        // câu 1
        Console.WriteLine("Nhập Tên của bạn ");
        string name = Console.ReadLine();
        int n = name.Length;


        Console.WriteLine("Chào bạn " + name);
        Console.WriteLine("Tên của bạn có {0} kí tự", n);


        // câu 2
        Console.WriteLine("Nhập một số ");
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
        {
            Console.WriteLine("Số {0} là số chẵn", a);
        }
        else
        {
            Console.WriteLine("Số {0} là số lẻ", a);
        }
        //cau 
        Console.ReadKey();
        Console.Clear();
    }
    static Boolean ktnguyento(int n)
    {
        // so nguyen n < 2 khong phai la so nguyen to
        if (n < 2)
        {
            return false;
        }
        // check so nguyen to khi n >= 2
        int squareRoot = (int)Math.Sqrt(n);
        int i;
        for (i = 2; i <= squareRoot; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
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
    static bool soCP(int n)
    {
        int sqr = (int)Math.Sqrt(n);
        if (sqr * sqr == n)
        {
            return true;
        }
        else return false;

    } 
    static void hientNT()
    {
        Console.WriteLine("Nhập n");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Các số nguyên tố từ 0 đến {0}", n);
        for (int i = 0; i < n; i++)
        {
            if (ktnguyento(i))
            {

                Console.Write(" " + i);
            }
        }
        Console.ReadKey(); Console.Clear();
    }

    static void Swap(int a, int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    static void Bai2()
    {
        Console.Write("Nhập chiều dài : ");
        int ChieuDai = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập chiều rộng :");
        int ChieuRong = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Chu vi hình chữ nhật là : {0}", ((ChieuDai + ChieuRong) * 2));
        Console.WriteLine("Diện tích hình chữ nhật là : {0}",(ChieuDai*ChieuRong));
        Console.ReadKey();
        Console.Clear();

    }
    static void Bai4()
    {
        Console.WriteLine("Nhập một số");
        int n = Convert.ToInt32(Console.ReadLine());
        if (soCP(n))
        {
            Console.WriteLine("{0} là số chính phương ", n);
        }
        else
        {
            Console.WriteLine("{0} không phải số chính phương", n);
        }
        Console.ReadKey();
        Console.Clear();
    }
    static void Bai6()
    {
        Console.WriteLine("Nhập một số: ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (ktnguyento(n))
        {
            Console.WriteLine("{0} là số nguyên tố", n);
        }
        else { Console.WriteLine("{0} không phải số nguyên tố", n); }
    }
    static void Bai8()
    {
        int n, i = 0;

        Console.WriteLine("Nhập vào các phần tử của mảng :");
        n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];

        Console.WriteLine("Nhập {0} phần tử của mảng ", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Nhập phần tử thứ {0} : ", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Các phần tử trong mảng : ");
        for (i = 0; i < n; i++)
        {
            Console.Write("  " + a[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Các phần tử là số lẻ ở vị trí chẵn ");
        for (i = 1; i < n; i++)
        {
            if (n % 2 == 0 && i % 2 == 0)
            {
                Console.Write("  " + a[i]);
            }
        }
        Console.WriteLine();
        Console.WriteLine("Mảng sau khi sắp xếp :");
        Array.Sort(a);

        foreach (int number in a)
        {
            Console.Write(number + " ");
        }
        Console.ReadKey();
        Console.Clear();
    }
    static void KtTamGiac()
    {
        double a, b, c, S, h;

        Console.WriteLine("Nhập cạnh A :");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập cạnh B :");
        b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập cạnh C :");
        c = Convert.ToDouble(Console.ReadLine());
        double p = (a + b + c) / 2;

        // Một tam giác có hai cạnh cộng lại lơn hơn cạnh còn lại
        if (a + b > c && a + c > b && b + c > a)
        {   //Tam giác vuông là tam giác có bình phương một cạnh bằng tổng bình phương hai cạnh còn lại
            Console.WriteLine("Đây là một tam giác");
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                Console.WriteLine("Đây là tam giác vuông");
                S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            // Tam giác đều có 3 cạnh bằng nhau
            else if (a == b && b == c)
            {
                Console.WriteLine("Đây là tam giác đều");
                S = (a * b) / 2;
            }
            // tam giác cân là tam giác có 2 cạnh bằng nhau
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Đây là tam giác cân");
                S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));

            }
            //Tam giác tù là tam giác có một góc lớn hơn 90 độ
            else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
            {
                Console.WriteLine("Đây là tam giác tù");
                S = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            // lỗi không thể lấy kết quả s ở trong else if
            Console.WriteLine("Diện tích của tam giác : {0}");
        }
        else { Console.WriteLine("Ba cạnh {0} {1} {2} không phải ba cạnh của tam giác",a,b,c); }
        Console.ReadKey();
        Console.Clear();

    }
    static void CheckWithdrawalPossibility()
    {
        int[] denominations = { 10000, 20000, 50000, 100000, 200000, 500000 };
        int[] counts = new int[6];
        Console.WriteLine("Nhập vào số tiền bạn muốn rút :");
        int amount = Convert.ToInt32(Console.ReadLine());
        // bài toán theo thực tế nhưng khó kiểm soát do có quá nhiều vòng for
        for (int i = 0; i <= amount / denominations[0]; i++)
        {
            for (int j = 0; j <= amount / denominations[1]; j++)
            {
                for (int k = 0; k <= amount / denominations[2]; k++)
                {
                    for (int l = 0; l <= amount / denominations[3]; l++)
                    {
                        for (int m = 0; m <= amount / denominations[4]; m++)
                        {
                            for (int n = 0; n <= amount / denominations[5]; n++)
                            {
                                for (int o = 0; o <= amount / denominations[6]; o++)
                                {
                                    if ((i * denominations[0] + j * denominations[1] + k * denominations[2]) == amount)
                                    {
                                        Console.WriteLine("Máy ATM có thể thanh toán số tiền {0}đ với {1} tờ 10.000đ, {2} tờ 20.000đ và {3} tờ 50.000đ.", amount, i, j, k);

                                        Console.ReadKey();
                                        Console.Clear();
                                        return;
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }

        Console.WriteLine("Máy ATM không thể thanh toán số tiền {0}đ.", amount);
        Console.ReadKey();
        Console.Clear();
    }
    // bài kiểm tra ngày tháng năm
    static bool IsValidDate(int day, int month, int year)
    {
        try
        {
            DateTime dateTime = new DateTime(year, month, day);
            return true;
        }
        catch (ArgumentOutOfRangeException)
        {
            return false;
        }
    }

    static bool IsLeapYear(int year)
    {
        return DateTime.IsLeapYear(year);
    }
    static void KTTIime()
    {
        Console.WriteLine("Nhập giá trị ngày: ");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập giá trị tháng: ");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhập giá trị năm: ");
        int year = int.Parse(Console.ReadLine());

        bool isValidDate = IsValidDate(day, month, year);
        Console.WriteLine($"Ngày {day}/{month}/{year} {(isValidDate ? "hợp lệ" : "không hợp lệ")}");

        bool isLeapYear = IsLeapYear(year);
        Console.WriteLine($"Tháng 2 của năm {year} {(isLeapYear ? "có 29 ngày" : "có 28 ngày")}");
    }
    public static void menu()
    {
        do
        {
            Console.WriteLine("1. HELLO WORD");
            Console.WriteLine("2. GIẢI PT BẬC 1");
            Console.WriteLine("3. GIẢI PT BẬC 2");
            Console.WriteLine("4. KIỂM TRA SỐ NGUYÊN TỐ");
            Console.WriteLine("5. TÍNH CHU VI DIỆN TÍCH HÌNH CHỮ NHẬT");
            Console.WriteLine("6. KIỂM TRA SỐ CHÍNH PHƯƠNG");
            Console.WriteLine("7. BÀI TẬP VỀ MẢNG");
            Console.WriteLine("8. KIỂM TRA TAM GIÁC");
            Console.WriteLine("9. ATM ");
            Console.WriteLine("10. KIỂM TRA NGÀY THÁNG NĂM");
            int luachon;
            Console.Write("Nhập lựa chọn : ");
            luachon = Convert.ToInt32(Console.ReadLine());


            switch (luachon)
            {
                case 1:
                    inmh(); break;
                case 2:
                    giaiptb1(); break;
                case 3:
                    giaiptbac2(); break;
                case 4:
                    hientNT(); break;
                case 5:
                    Bai2(); break;
                case 6:
                    Bai4(); break;
                case 7:
                    Bai8(); break;
                case 8:
                    KtTamGiac(); break;
                case 9:
                    CheckWithdrawalPossibility(); break;
                case 10: 
                    KTTIime(); break;



            }
        } while (true);
    }
    public static void Main(string[] args)
    {
        menu();


        // bai tap giai pt bac nhat input a,b output ket luan 
        // giai phuong trinh bac 2 

        // bài thực hành số 1 làm bt 2 4 6 7 8 

    }
}
