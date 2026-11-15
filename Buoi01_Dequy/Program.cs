
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== BUOI 01 - DE QUY ==========");
            Console.WriteLine("1. Chuong 1");
            Console.WriteLine("2. Chuong 2");
            Console.WriteLine("3. Chuong 3");
            Console.WriteLine("0. Thoat");
            Console.Write("Chon chuong: ");

            string chon = Console.ReadLine() ?? "";

            switch (chon)
            {
                case "1":
                    MenuChuong1();
                    break;
                case "2":
                    MenuChuong2();
                    break;
                case "3":
                    MenuChuong3();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    DungManHinh();
                    break;
            }
        }
    }

    static void MenuChuong1()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== CHUONG 1 ==========");
            Console.WriteLine("1. Tim gia tri lon nhat va nho nhat trong 1000 so");
            Console.WriteLine("2. Bai toan FizzBuzz");
            Console.WriteLine("3. Dao nguoc chuoi");
            Console.WriteLine("4. Sap xep 1000 so");
            Console.WriteLine("5. Tim so Fibonacci thu n");
            Console.WriteLine("0. Quay lai");
            Console.Write("Chon bai: ");

            string chon = Console.ReadLine() ?? "";

            switch (chon)
            {
                case "1": Bai1_Chuong1(); break;
                case "2": Bai2_Chuong1(); break;
                case "3": Bai3_Chuong1(); break;
                case "4": Bai4_Chuong1(); break;
                case "5": Bai5_Chuong1(); break;
                case "0": return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            DungManHinh();
        }
    }

    static void MenuChuong2()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== CHUONG 2 ==========");
            Console.WriteLine("1. Thap Ha Noi");
            Console.WriteLine("2. Tim kiem nhi phan");
            Console.WriteLine("3. Kiem tra so nguyen to");
            Console.WriteLine("4. Liet ke so hoan hao");
            Console.WriteLine("5. Tim so Fibonacci");
            Console.WriteLine("6. Sap xep day so");
            Console.WriteLine("0. Quay lai");
            Console.Write("Chon bai: ");

            string chon = Console.ReadLine() ?? "";

            switch (chon)
            {
                case "1": Bai1_Chuong2(); break;
                case "2": Bai2_Chuong2(); break;
                case "3": Bai3_Chuong2(); break;
                case "4": Bai4_Chuong2(); break;
                case "5": Bai5_Chuong2(); break;
                case "6": Bai6_Chuong2(); break;
                case "0": return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            DungManHinh();
        }
    }

    static void MenuChuong3()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("========== CHUONG 3 ==========");
            Console.WriteLine("1. Tinh tong S(n) = 1 + 2 + ... + n");
            Console.WriteLine("2. Tinh tong binh phuong");
            Console.WriteLine("3. Tinh tong nghich dao");
            Console.WriteLine("4. Tinh luy thua");
            Console.WriteLine("5. Tim uoc le lon nhat");
            Console.WriteLine("6. Tim UCLN");
            Console.WriteLine("7. Dem so chu so");
            Console.WriteLine("8. Tinh can long nhau");
            Console.WriteLine("0. Quay lai");
            Console.Write("Chon bai: ");

            string chon = Console.ReadLine() ?? "";

            switch (chon)
            {
                case "1": Bai1_Chuong3(); break;
                case "2": Bai2_Chuong3(); break;
                case "3": Bai3_Chuong3(); break;
                case "4": Bai4_Chuong3(); break;
                case "5": Bai5_Chuong3(); break;
                case "6": Bai6_Chuong3(); break;
                case "7": Bai7_Chuong3(); break;
                case "8": Bai8_Chuong3(); break;
                case "0": return;
                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            DungManHinh();
        }
    }

    // ==================== CHUONG 1 ====================

    // Bai 1: Tim max va min trong 1000 so
    static void Bai1_Chuong1()
    {
        Console.WriteLine("\nBAI 1 - TIM MAX VA MIN");

        int[] a = new int[1000];
        Random rd = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(1, 10001);
        }

        int max = a[0];
        int min = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
                max = a[i];

            if (a[i] < min)
                min = a[i];
        }

        Console.WriteLine("1000 so duoc tao ngau nhien.");
        Console.WriteLine("Gia tri lon nhat: " + max);
        Console.WriteLine("Gia tri nho nhat: " + min);
    }

    // Bai 2: FizzBuzz
    static void Bai2_Chuong1()
    {
        Console.WriteLine("\nBAI 2 - FIZZBUZZ");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }

    // Bai 3: Dao nguoc chuoi
    static void Bai3_Chuong1()
    {
        Console.WriteLine("\nBAI 3 - DAO NGUOC CHUOI");
        Console.Write("Nhap chuoi: ");

        string s = Console.ReadLine() ?? "";
        char[] mang = s.ToCharArray();
        Array.Reverse(mang);

        Console.WriteLine("Chuoi sau khi dao nguoc: " + new string(mang));
    }

    // Bai 4: Sap xep 1000 so
    static void Bai4_Chuong1()
    {
        Console.WriteLine("\nBAI 4 - SAP XEP 1000 SO");

        int[] a = new int[1000];
        Random rd = new Random();

        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rd.Next(1, 10001);
        }

        Array.Sort(a);

        Console.WriteLine("1000 so sau khi sap xep tang dan:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");

            if ((i + 1) % 20 == 0)
                Console.WriteLine();
        }
    }

    // Bai 5: Tim so Fibonacci thu n
    static void Bai5_Chuong1()
    {
        Console.WriteLine("\nBAI 5 - SO FIBONACCI");

        int n = NhapSoNguyen("Nhap n (0 den 1000): ", 0, 1000);

        Console.WriteLine("So Fibonacci thu " + n + " la: " + Fibonacci(n));
    }

    // ==================== CHUONG 2 ====================

    // Bai 1: Thap Ha Noi
    static void Bai1_Chuong2()
    {
        Console.WriteLine("\nBAI 1 - THAP HA NOI");

        int n = NhapSoNguyen("Nhap so dia (1 den 15): ", 1, 15);

        ThapHaNoi(n, 'A', 'C', 'B');
    }

    static void ThapHaNoi(int n, char cotNguon, char cotDich, char cotTrungGian)
    {
        if (n == 1)
        {
            Console.WriteLine("Chuyen dia tu cot " + cotNguon + " sang cot " + cotDich);
            return;
        }

        ThapHaNoi(n - 1, cotNguon, cotTrungGian, cotDich);

        Console.WriteLine("Chuyen dia tu cot " + cotNguon + " sang cot " + cotDich);

        ThapHaNoi(n - 1, cotTrungGian, cotDich, cotNguon);
    }

    // Bai 2: Tim kiem nhi phan
    static void Bai2_Chuong2()
    {
        Console.WriteLine("\nBAI 2 - TIM KIEM NHI PHAN");

        int[] a = { 2, 5, 8, 12, 16, 23, 38, 45, 56, 72, 91 };

        Console.WriteLine("Day so:");
        InMang(a);

        int x = NhapSoNguyen("Nhap gia tri can tim: ", int.MinValue, int.MaxValue);

        int viTri = TimKiemNhiPhan(a, x);

        if (viTri == -1)
            Console.WriteLine("Khong tim thay " + x);
        else
            Console.WriteLine("Tim thay " + x + " tai vi tri " + viTri);
    }

    static int TimKiemNhiPhan(int[] a, int x)
    {
        int left = 0;
        int right = a.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (a[mid] == x)
                return mid;

            if (a[mid] < x)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return -1;
    }

    // Bai 3: Kiem tra so nguyen to
    static void Bai3_Chuong2()
    {
        Console.WriteLine("\nBAI 3 - KIEM TRA SO NGUYEN TO");

        int n = NhapSoNguyen("Nhap n: ", 0, int.MaxValue);

        if (LaSoNguyenTo(n))
            Console.WriteLine(n + " la so nguyen to.");
        else
            Console.WriteLine(n + " khong phai so nguyen to.");
    }

    static bool LaSoNguyenTo(int n)
    {
        if (n < 2)
            return false;

        for (int i = 2; i <= n / i; i++)
        {
            if (n % i == 0)
                return false;
        }

        return true;
    }

    // Bai 4: Liet ke so hoan hao
    static void Bai4_Chuong2()
    {
        Console.WriteLine("\nBAI 4 - SO HOAN HAO");

        int n = NhapSoNguyen("Nhap gioi han n: ", 1, 1000000);

        Console.WriteLine("Cac so hoan hao tu 1 den " + n + ":");

        for (int i = 2; i <= n; i++)
        {
            if (LaSoHoanHao(i))
                Console.Write(i + " ");
        }
    }

    static bool LaSoHoanHao(int n)
    {
        if (n < 2)
            return false;

        int tong = 1;

        for (int i = 2; i <= n / i; i++)
        {
            if (n % i == 0)
            {
                tong += i;

                if (i != n / i)
                    tong += n / i;
            }
        }

        return tong == n;
    }

    // Bai 5: Tim so Fibonacci
    static void Bai5_Chuong2()
    {
        Console.WriteLine("\nBAI 5 - DAY FIBONACCI");

        int n = NhapSoNguyen("Nhap so luong so Fibonacci: ", 1, 100);

        BigInteger a = 0;
        BigInteger b = 1;

        Console.WriteLine("Day Fibonacci:");

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            BigInteger c = a + b;
            a = b;
            b = c;
        }
    }

    // Bai 6: Sap xep day so
    static void Bai6_Chuong2()
    {
        Console.WriteLine("\nBAI 6 - SAP XEP DAY SO");

        int n = NhapSoNguyen("Nhap so phan tu: ", 1, 1000);

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            a[i] = NhapSoNguyen("Nhap a[" + i + "]: ", int.MinValue, int.MaxValue);
        }

        Console.WriteLine("Day ban dau:");
        InMang(a);

        Array.Sort(a);

        Console.WriteLine("Day sau khi sap xep tang dan:");
        InMang(a);
    }

    // ==================== CHUONG 3 ====================

    // Bai 1: Tinh tong 1 + 2 + ... + n
    static void Bai1_Chuong3()
    {
        Console.WriteLine("\nBAI 1 - TINH TONG S(n)");

        int n = NhapSoNguyen("Nhap n: ", 1, 1000000);

        Console.WriteLine("S(" + n + ") = " + Tong(n));
    }

    static long Tong(int n)
    {
        if (n == 1)
            return 1;

        return n + Tong(n - 1);
    }

    // Bai 2: Tinh tong binh phuong
    static void Bai2_Chuong3()
    {
        Console.WriteLine("\nBAI 2 - TONG BINH PHUONG");

        int n = NhapSoNguyen("Nhap n: ", 1, 1000000);

        Console.WriteLine("S = " + TongBinhPhuong(n));
    }

    static long TongBinhPhuong(int n)
    {
        if (n == 1)
            return 1;

        return (long)n * n + TongBinhPhuong(n - 1);
    }

    // Bai 3: Tinh tong nghich dao
    static void Bai3_Chuong3()
    {
        Console.WriteLine("\nBAI 3 - TONG NGHICH DAO");

        int n = NhapSoNguyen("Nhap n: ", 1, 10000);

        Console.WriteLine("S = " + TongNghichDao(n));
    }

    static double TongNghichDao(int n)
    {
        if (n == 1)
            return 1;

        return 1.0 / n + TongNghichDao(n - 1);
    }

    // Bai 4: Tinh luy thua
    static void Bai4_Chuong3()
    {
        Console.WriteLine("\nBAI 4 - TINH LUY THUA");

        double x = NhapSoThuc("Nhap co so x: ");
        int n = NhapSoNguyen("Nhap so mu n: ", 0, 1000);

        Console.WriteLine(x + "^" + n + " = " + LuyThua(x, n));
    }

    static double LuyThua(double x, int n)
    {
        if (n == 0)
            return 1;

        return x * LuyThua(x, n - 1);
    }

    // Bai 5: Tim uoc le lon nhat
    static void Bai5_Chuong3()
    {
        Console.WriteLine("\nBAI 5 - UOC LE LON NHAT");

        long n = NhapSoNguyenLong("Nhap so nguyen duong: ", 1, long.MaxValue);

        while (n % 2 == 0)
            n /= 2;

        Console.WriteLine("Uoc le lon nhat la: " + n);
    }

    // Bai 6: Tim UCLN
    static void Bai6_Chuong3()
    {
        Console.WriteLine("\nBAI 6 - TIM UCLN");

        long a = NhapSoNguyenLong("Nhap a: ", long.MinValue, long.MaxValue);
        long b = NhapSoNguyenLong("Nhap b: ", long.MinValue, long.MaxValue);

        BigInteger ucln = UCLN(BigInteger.Abs(new BigInteger(a)),
                               BigInteger.Abs(new BigInteger(b)));

        Console.WriteLine("UCLN(" + a + ", " + b + ") = " + ucln);
    }

    static BigInteger UCLN(BigInteger a, BigInteger b)
    {
        if (b == 0)
            return a;

        return UCLN(b, a % b);
    }

    // Bai 7: Dem so chu so
    static void Bai7_Chuong3()
    {
        Console.WriteLine("\nBAI 7 - DEM SO CHU SO");

        long n = NhapSoNguyenLong("Nhap so nguyen: ", long.MinValue, long.MaxValue);

        BigInteger x = BigInteger.Abs(new BigInteger(n));

        Console.WriteLine("So chu so: " + DemChuSo(x));
    }

    static int DemChuSo(BigInteger n)
    {
        if (n < 10)
            return 1;

        return 1 + DemChuSo(n / 10);
    }

    // Bai 8: Tinh can long nhau
    static void Bai8_Chuong3()
    {
        Console.WriteLine("\nBAI 8 - CAN LONG NHAU");

        int n = NhapSoNguyen("Nhap n: ", 1, 100);

        Console.WriteLine("Ket qua: " + CanLongNhau(n));
    }

    static double CanLongNhau(int n)
    {
        if (n == 1)
            return Math.Sqrt(1);

        return Math.Sqrt(n + CanLongNhau(n - 1));
    }

    // ==================== HAM DUNG CHUNG ====================

    static BigInteger Fibonacci(int n)
    {
        if (n <= 1)
            return n;

        BigInteger a = 0;
        BigInteger b = 1;

        for (int i = 2; i <= n; i++)
        {
            BigInteger c = a + b;
            a = b;
            b = c;
        }

        return b;
    }

    static void InMang(int[] a)
    {
        foreach (int x in a)
        {
            Console.Write(x + " ");
        }

        Console.WriteLine();
    }

    static int NhapSoNguyen(string thongBao, int min, int max)
    {
        int n;

        while (true)
        {
            Console.Write(thongBao);

            if (int.TryParse(Console.ReadLine(), out n) && n >= min && n <= max)
                return n;

            Console.WriteLine("Du lieu khong hop le. Vui long nhap lai!");
        }
    }

    static long NhapSoNguyenLong(string thongBao, long min, long max)
    {
        long n;

        while (true)
        {
            Console.Write(thongBao);

            if (long.TryParse(Console.ReadLine(), out n) && n >= min && n <= max)
                return n;

            Console.WriteLine("Du lieu khong hop le. Vui long nhap lai!");
        }
    }

    static double NhapSoThuc(string thongBao)
    {
        double n;

        while (true)
        {
            Console.Write(thongBao);

            if (double.TryParse(Console.ReadLine(), out n))
                return n;

            Console.WriteLine("Du lieu khong hop le. Vui long nhap lai!");
        }
    }

    static void DungManHinh()
    {
        Console.WriteLine("\nNhan phim bat ky de tiep tuc...");
        Console.ReadKey();
    }
}
