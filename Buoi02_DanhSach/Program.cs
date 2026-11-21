
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\n========== BUỔI 02 - CTDL&GT ==========");
            Console.WriteLine("CHƯƠNG 4 - DANH SÁCH");
            Console.WriteLine("1. Bài 1 - Mảng và chèn phần tử");
            Console.WriteLine("2. Bài 2 - Quản lý nhân viên");
            Console.WriteLine("3. Bài 4 - Danh sách liên kết đơn");
            Console.WriteLine("4. Bài 5 - Các phép toán trên danh sách");
            Console.WriteLine("\nCHƯƠNG 5 - STACK VÀ QUEUE");
            Console.WriteLine("5. Bài 1 - Kiểm tra biểu thức");
            Console.WriteLine("6. Bài 2 - Lịch sử trình duyệt");
            Console.WriteLine("7. Bài 3 - Function Call Stack");
            Console.WriteLine("8. Bài 4 - Hệ thống in ấn");
            Console.WriteLine("9. Bài 5 - Đường truyền dữ liệu");
            Console.WriteLine("10. Bài 6 - Hàng đợi khách hàng");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn bài: ");

            int chon = NhapSo();

            switch (chon)
            {
                case 1: Bai4_1(); break;
                case 2: Bai4_2(); break;
                case 3: Bai4_4(); break;
                case 4: Bai4_5(); break;
                case 5: Bai5_1(); break;
                case 6: Bai5_2(); break;
                case 7: Bai5_3(); break;
                case 8: Bai5_4(); break;
                case 9: Bai5_5(); break;
                case 10: Bai5_6(); break;
                case 0: return;
                default: Console.WriteLine("Lua chon khong hop le!"); break;
            }
        }
    }

    static int NhapSo()
    {
        int x;
        while (!int.TryParse(Console.ReadLine(), out x))
            Console.Write("Nhap lai so nguyen: ");
        return x;
    }

    // ================= CHUONG 4 =================

    // BAI 1: NHAP, HIEN THI VA CHEN PHAN TU VAO MANG
    static void Bai4_1()
    {
        Console.WriteLine("\n--- BAI 1: MANG VA CHEN PHAN TU ---");

        Console.Write("Nhap so phan tu n: ");
        int n = NhapSo();

        if (n <= 0)
        {
            Console.WriteLine("So phan tu phai lon hon 0.");
            return;
        }

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("a[" + i + "] = ");
            a[i] = NhapSo();
        }

        Console.Write("Danh sach vua nhap: ");
        HienThiMang(a);

        Console.Write("Nhap gia tri x can chen: ");
        int x = NhapSo();

        Console.Write("Nhap vi tri k can chen (0 den " + n + "): ");
        int k = NhapSo();

        if (k < 0 || k > n)
        {
            Console.WriteLine("Vi tri chen khong hop le.");
            return;
        }

        int[] tmp = new int[n + 1];

        for (int i = 0; i < k; i++)
            tmp[i] = a[i];

        tmp[k] = x;

        for (int i = k; i < n; i++)
            tmp[i + 1] = a[i];

        a = tmp;

        Console.Write("Mang sau khi chen: ");
        HienThiMang(a);
    }

    static void HienThiMang(int[] a)
    {
        foreach (int x in a)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    // BAI 2: QUAN LY NHAN VIEN
    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public int LuongCB;
        public int Thuong;

        public int ThucLinh()
        {
            return LuongCB + Thuong;
        }
    }

    static void Bai4_2()
    {
        Console.WriteLine("\n--- BAI 2: QUAN LY NHAN VIEN ---");

        Console.Write("Nhap so nhan vien: ");
        int n = NhapSo();

        if (n <= 0) return;

        NhanVien[] ds = new NhanVien[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhan vien thu " + (i + 1));

            Console.Write("Ma nhan vien: ");
            ds[i].MaNV = Console.ReadLine() ?? "";

            Console.Write("Ho va ten: ");
            ds[i].HoTen = Console.ReadLine() ?? "";

            Console.Write("Nam sinh: ");
            ds[i].NamSinh = NhapSo();

            Console.Write("Phong ban: ");
            ds[i].PhongBan = Console.ReadLine() ?? "";

            Console.Write("Luong co ban: ");
            ds[i].LuongCB = NhapSo();

            Console.Write("Thuong: ");
            ds[i].Thuong = NhapSo();
        }

        // a. Tinh tong thuc linh
        long tong = 0;

        foreach (NhanVien nv in ds)
            tong += nv.ThucLinh();

        Console.WriteLine("\na. Tong thuc linh: " + tong);

        // b. In nhan vien co luong co ban thap nhat
        int min = ds.Min(nv => nv.LuongCB);

        Console.WriteLine("\nb. Nhan vien co luong co ban thap nhat:");

        foreach (NhanVien nv in ds)
        {
            if (nv.LuongCB == min)
                InNhanVien(nv);
        }

        // c. Dem nhan vien co thuong >= 1200000
        int dem = 0;

        foreach (NhanVien nv in ds)
        {
            if (nv.Thuong >= 1200000)
                dem++;
        }

        Console.WriteLine("\nc. So nhan vien co thuong >= 1200000: " + dem);

        // d. Sap xep phong ban tang dan, ma nhan vien giam dan
        Array.Sort(ds, (a, b) =>
        {
            int kq = string.Compare(a.PhongBan, b.PhongBan,
                StringComparison.OrdinalIgnoreCase);

            if (kq == 0)
                return string.Compare(b.MaNV, a.MaNV,
                    StringComparison.OrdinalIgnoreCase);

            return kq;
        });

        Console.WriteLine("\nd. Danh sach sau khi sap xep:");

        foreach (NhanVien nv in ds)
            InNhanVien(nv);

        // e. Tang luong co ban 5%
        Console.WriteLine("\ne. Danh sach sau khi tang luong 5%:");

        for (int i = 0; i < n; i++)
        {
            ds[i].LuongCB = (int)Math.Round(ds[i].LuongCB * 1.05);
            InNhanVien(ds[i]);
        }
    }

    static void InNhanVien(NhanVien nv)
    {
        Console.WriteLine(
            "Ma: " + nv.MaNV +
            " | Ten: " + nv.HoTen +
            " | Nam sinh: " + nv.NamSinh +
            " | Phong ban: " + nv.PhongBan +
            " | Luong CB: " + nv.LuongCB +
            " | Thuong: " + nv.Thuong +
            " | Thuc linh: " + nv.ThucLinh());
    }

    // CAU TRUC NUT DANH SACH LIEN KET DON
    class Node
    {
        public int Data;
        public Node? Link;

        public Node(int data)
        {
            Data = data;
            Link = null;
        }
    }

    // BAI 4: DANH SACH LIEN KET DON
    static void Bai4_4()
    {
        Console.WriteLine("\n--- BAI 4: DANH SACH LIEN KET DON ---");

        Node? pHead = NhapDanhSach();

        Console.Write("Nhap x: ");
        int x = NhapSo();

        // a. Dem so phan tu bang x
        int dem = 0;
        Node? p = pHead;

        while (p != null)
        {
            if (p.Data == x)
                dem++;

            p = p.Link;
        }

        Console.WriteLine("So phan tu bang x: " + dem);

        // b. Tim so duong nho nhat
        int min = int.MaxValue;
        p = pHead;

        while (p != null)
        {
            if (p.Data > 0 && p.Data < min)
                min = p.Data;

            p = p.Link;
        }

        if (min == int.MaxValue)
            Console.WriteLine("Danh sach khong co so duong.");
        else
            Console.WriteLine("So duong nho nhat: " + min);

        // c. Xoa phan tu x xuat hien dau tien
        pHead = XoaPhanTuDauTien(pHead, x);

        Console.Write("Danh sach sau khi xoa x: ");
        HienThiDanhSach(pHead);
    }

    // BAI 5: CAC PHEP TOAN TREN DANH SACH LIEN KET
    static void Bai4_5()
    {
        Console.WriteLine("\n--- BAI 5: CAC PHEP TOAN TREN DANH SACH ---");

        Node? pHead = NhapDanhSach();

        Console.Write("Nhap x: ");
        int x = NhapSo();

        // a. Tim phan tu lon nhat
        if (pHead == null)
        {
            Console.WriteLine("Danh sach rong.");
            return;
        }

        int max = int.MinValue;
        int tong = 0;
        int demNguyenTo = 0;
        int demAm = 0;
        int demDuong = 0;
        int demKhong = 0;
        int demX = 0;
        int minDuong = int.MaxValue;

        Node? p = pHead;

        while (p != null)
        {
            int giaTri = p.Data;

            if (giaTri > max)
                max = giaTri;

            // b. Tinh tong
            tong += giaTri;

            // c. Dem so nguyen to
            if (LaSoNguyenTo(giaTri))
                demNguyenTo++;

            // d. Dem am, duong, khong
            if (giaTri < 0)
                demAm++;
            else if (giaTri > 0)
                demDuong++;
            else
                demKhong++;

            // e. Dem phan tu bang x
            if (giaTri == x)
                demX++;

            // f. Tim so duong nho nhat
            if (giaTri > 0 && giaTri < minDuong)
                minDuong = giaTri;

            p = p.Link;
        }

        Console.WriteLine("a. Phan tu lon nhat: " + max);
        Console.WriteLine("b. Tong cac phan tu: " + tong);
        Console.WriteLine("c. So luong so nguyen to: " + demNguyenTo);
        Console.WriteLine("d. So am: " + demAm);
        Console.WriteLine("   So duong: " + demDuong);
        Console.WriteLine("   So 0: " + demKhong);
        Console.WriteLine("e. So phan tu bang x: " + demX);

        if (minDuong == int.MaxValue)
            Console.WriteLine("f. Khong co so duong.");
        else
            Console.WriteLine("f. So duong nho nhat: " + minDuong);
    }

    static Node? NhapDanhSach()
    {
        Console.Write("Nhap so phan tu n: ");
        int n = NhapSo();

        Node? pHead = null;
        Node? pTail = null;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu " + (i + 1) + ": ");
            int x = NhapSo();

            Node p = new Node(x);

            if (pHead == null)
                pHead = p;
            else
                pTail!.Link = p;

            pTail = p;
        }

        Console.Write("Danh sach: ");
        HienThiDanhSach(pHead);

        return pHead;
    }

    static void HienThiDanhSach(Node? pHead)
    {
        Node? p = pHead;

        while (p != null)
        {
            Console.Write(p.Data + " ");
            p = p.Link;
        }

        Console.WriteLine();
    }

    static Node? XoaPhanTuDauTien(Node? pHead, int x)
    {
        if (pHead == null)
            return null;

        if (pHead.Data == x)
            return pHead.Link;

        Node p = pHead;

        while (p.Link != null && p.Link.Data != x)
            p = p.Link;

        if (p.Link != null)
            p.Link = p.Link.Link;

        return pHead;
    }

    static bool LaSoNguyenTo(int x)
    {
        if (x < 2)
            return false;

        for (int i = 2; i <= x / i; i++)
        {
            if (x % i == 0)
                return false;
        }

        return true;
    }

    // ================= CHUONG 5 =================

    // BAI 1: KIEM TRA BIỂU THỨC BANG STACK
    static void Bai5_1()
    {
        Console.WriteLine("\n--- BAI 1: KIEM TRA BIEU THUC ---");

        Console.Write("Nhap bieu thuc: ");
        string s = Console.ReadLine() ?? "";

        Stack<char> stack = new Stack<char>();
        bool hopLe = true;

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    hopLe = false;
                    break;
                }

                char dauMo = stack.Pop();

                if ((c == ')' && dauMo != '(') ||
                    (c == ']' && dauMo != '[') ||
                    (c == '}' && dauMo != '{'))
                {
                    hopLe = false;
                    break;
                }
            }
        }

        if (stack.Count != 0)
            hopLe = false;

        Console.WriteLine(hopLe
            ? "Bieu thuc hop le."
            : "Bieu thuc khong hop le.");
    }

    // BAI 2: MO PHONG LICH SU TRINH DUYET WEB
    static void Bai5_2()
    {
        Console.WriteLine("\n--- BAI 2: LICH SU TRINH DUYET WEB ---");

        Stack<string> back = new Stack<string>();
        Stack<string> forward = new Stack<string>();

        string hienTai = "Trang chu";

        while (true)
        {
            Console.WriteLine("\nTrang hien tai: " + hienTai);
            Console.WriteLine("1. Truy cap trang moi");
            Console.WriteLine("2. Back");
            Console.WriteLine("3. Forward");
            Console.WriteLine("0. Quay lai menu");
            Console.Write("Chon: ");

            int chon = NhapSo();

            if (chon == 0) break;

            if (chon == 1)
            {
                Console.Write("Nhap ten trang: ");
                string trang = Console.ReadLine() ?? "";

                back.Push(hienTai);
                hienTai = trang;
                forward.Clear();
            }
            else if (chon == 2)
            {
                if (back.Count > 0)
                {
                    forward.Push(hienTai);
                    hienTai = back.Pop();
                }
                else
                    Console.WriteLine("Khong co trang truoc.");
            }
            else if (chon == 3)
            {
                if (forward.Count > 0)
                {
                    back.Push(hienTai);
                    hienTai = forward.Pop();
                }
                else
                    Console.WriteLine("Khong co trang tiep theo.");
            }
            else
                Console.WriteLine("Lua chon khong hop le.");
        }
    }

    // BAI 3: MO PHONG FUNCTION CALL STACK
    static void Bai5_3()
    {
        Console.WriteLine("\n--- BAI 3: FUNCTION CALL STACK ---");

        Stack<string> stack = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n1. Goi ham");
            Console.WriteLine("2. Ket thuc ham");
            Console.WriteLine("3. Hien thi Stack");
            Console.WriteLine("0. Quay lai menu");
            Console.Write("Chon: ");

            int chon = NhapSo();

            if (chon == 0) break;

            if (chon == 1)
            {
                Console.Write("Nhap ten ham: ");
                string tenHam = Console.ReadLine() ?? "";

                stack.Push(tenHam);
                Console.WriteLine("Da dua khung ngan xep cua ham vao Stack.");
            }
            else if (chon == 2)
            {
                if (stack.Count > 0)
                    Console.WriteLine("Ket thuc ham: " + stack.Pop());
                else
                    Console.WriteLine("Stack rong, khong co ham de ket thuc.");
            }
            else if (chon == 3)
            {
                if (stack.Count == 0)
                    Console.WriteLine("Stack rong.");
                else
                {
                    Console.WriteLine("Cac ham dang hoat dong:");

                    foreach (string ham in stack)
                        Console.WriteLine(ham);
                }
            }
            else
                Console.WriteLine("Lua chon khong hop le.");
        }
    }

    // BAI 4: MO PHONG HE THONG IN AN
    static void Bai5_4()
    {
        Console.WriteLine("\n--- BAI 4: HE THONG IN AN ---");

        Queue<string> hangDoi = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n1. Them yeu cau in");
            Console.WriteLine("2. Xu ly yeu cau in");
            Console.WriteLine("3. Hien thi hang doi");
            Console.WriteLine("0. Quay lai menu");
            Console.Write("Chon: ");

            int chon = NhapSo();

            if (chon == 0) break;

            if (chon == 1)
            {
                Console.Write("Nhap ten tai lieu: ");
                string ten = Console.ReadLine() ?? "";

                hangDoi.Enqueue(ten);
                Console.WriteLine("Da them tai lieu vao hang doi.");
            }
            else if (chon == 2)
            {
                if (hangDoi.Count > 0)
                    Console.WriteLine("Dang in: " + hangDoi.Dequeue());
                else
                    Console.WriteLine("Khong co tai lieu can in.");
            }
            else if (chon == 3)
            {
                if (hangDoi.Count == 0)
                    Console.WriteLine("Hang doi rong.");
                else
                {
                    Console.WriteLine("Danh sach tai lieu cho in:");

                    foreach (string ten in hangDoi)
                        Console.WriteLine(ten);
                }
            }
            else
                Console.WriteLine("Lua chon khong hop le.");
        }
    }

    // BAI 5: MO PHONG DUONG TRUYEN DU LIEU
    static void Bai5_5()
    {
        Console.WriteLine("\n--- BAI 5: DUONG TRUYEN DU LIEU ---");

        Queue<string> goiTin = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n1. Gui goi tin");
            Console.WriteLine("2. Xu ly goi tin");
            Console.WriteLine("3. Hien thi cac goi tin");
            Console.WriteLine("0. Quay lai menu");
            Console.Write("Chon: ");

            int chon = NhapSo();

            if (chon == 0) break;

            if (chon == 1)
            {
                Console.Write("Nhap noi dung goi tin: ");
                string noiDung = Console.ReadLine() ?? "";

                goiTin.Enqueue(noiDung);
                Console.WriteLine("Da gui goi tin.");
            }
            else if (chon == 2)
            {
                if (goiTin.Count > 0)
                    Console.WriteLine("Dang xu ly goi tin: " + goiTin.Dequeue());
                else
                    Console.WriteLine("Khong co goi tin nao.");
            }
            else if (chon == 3)
            {
                if (goiTin.Count == 0)
                    Console.WriteLine("Hang doi rong.");
                else
                {
                    Console.WriteLine("Cac goi tin dang cho:");

                    foreach (string goi in goiTin)
                        Console.WriteLine(goi);
                }
            }
            else
                Console.WriteLine("Lua chon khong hop le.");
        }
    }

    // BAI 6: MO PHONG HANG DOI KHACH HANG
    static void Bai5_6()
    {
        Console.WriteLine("\n--- BAI 6: HANG DOI KHACH HANG ---");

        Queue<string> khachHang = new Queue<string>();

        while (true)
        {
            Console.WriteLine("\n1. Khach hang moi den");
            Console.WriteLine("2. Phuc vu khach hang");
            Console.WriteLine("3. Hien thi hang doi");
            Console.WriteLine("0. Quay lai menu");
            Console.Write("Chon: ");

            int chon = NhapSo();

            if (chon == 0) break;

            if (chon == 1)
            {
                Console.Write("Nhap ten khach hang: ");
                string ten = Console.ReadLine() ?? "";

                khachHang.Enqueue(ten);
                Console.WriteLine("Da them khach hang vao hang doi.");
            }
            else if (chon == 2)
            {
                if (khachHang.Count > 0)
                    Console.WriteLine("Dang phuc vu khach hang: " + khachHang.Dequeue());
                else
                    Console.WriteLine("Khong co khach hang dang cho.");
            }
            else if (chon == 3)
            {
                if (khachHang.Count == 0)
                    Console.WriteLine("Hang doi khong co khach.");
                else
                {
                    Console.WriteLine("Danh sach khach hang:");

                    foreach (string ten in khachHang)
                        Console.WriteLine(ten);
                }
            }
            else
                Console.WriteLine("Lua chon khong hop le.");
        }
    }
}
