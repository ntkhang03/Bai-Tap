using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong phan tu trong mang");
            int n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            Console.WriteLine("========================");
            nhapMang(A, n);
            //Console.WriteLine("== Mang ban dau la ==");
            //xuatMang(A, n);
            //Console.WriteLine("========================");
            //Console.WriteLine($"tong cac phan tu cua mang la: {tinhTongMang(A, n)}");

            //Console.WriteLine("========================");
            //thayThe(ref A, n);
            //Console.WriteLine("mang sau khi thay the la:");
            //xuatMang(A, n);

            //Console.WriteLine("========================");
            //Console.WriteLine($"trung binh cong cua cac phan tu chan la: {tbcPtuChan(A, n)}");

            //Console.WriteLine("========================");
            //Console.WriteLine($"phan tu nho nhat trong mang la: {timPtuNhoNhat(A, n)}");

            //Console.WriteLine("========================");
            //timVitriPtuAm(A, n);

            //Console.WriteLine("========================");
            //string toanDuong = kiemTraToanDuong(A, n) ? "toan" : "khong";
            //Console.WriteLine($"mang tren {toanDuong} duong");

            //Console.WriteLine($"phan tu lon nhat trong mang la: {timPtuLonNhat(A, n)}");

            //Console.WriteLine("== Mang sau khi sap xep la ==");
            //sapXepTangDan(A, n);
            //xuatMang(A, n);

            //Console.WriteLine("nhap so X muon tim vi tri: ");
            //int X = int.Parse(Console.ReadLine());
            //int viTri = timViTri(A, n, X);
            //if (viTri == -1) Console.WriteLine($"so {X} khong co trong mang");
            //else Console.WriteLine($"vi tri cua so {X} la: {viTri}");

            // Console.WriteLine("nhap so X muon dem so lan xuat hien: ");
            // int X = int.Parse(Console.ReadLine());
            // Console.WriteLine($"so {X} xuat hien {demSoLanXuatHien(A, n, X)} lan trong mang tren");

            //Console.WriteLine("== Mang dao nguoc la ==");
            //xuatMangNguoc(A, n);

            int dem = 0;
            int total = demVaTinhTongSNT(A, n, ref dem);
            Console.WriteLine($"co {dem} so nguyen to, tong la: {total}");
        }
        // 1. viet ham nhap mang so nguyen 
        static void nhapMang(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap phan tu tai vi tri {i}: ");
                A[i] = int.Parse(Console.ReadLine());
            }
        }
        // 2. viet ham xuat mang
        static void xuatMang(int[] A, int n)
        {
            for (int i = 0; i < n; i++) Console.WriteLine($"Gia tri tai vi tri {i}: {A[i]}");
        }

        // 3. viet ham tinh tong mang
        static int tinhTongMang(int[] A, int n)
        {
            int total = 0;
            foreach (int num in A) total += num;
            return total;
        }

        // 3. viet ham thay the cac so am bang 0
        static void thayThe(ref int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 0) A[i] = 0;
            }
        }

        // 4. viet ham tinh trung binh cong cac phan tu chan
        static float tbcPtuChan(int[] A, int n)
        {
            int total = 0;
            int dem = 0;
            foreach (int num in A)
            {
                if (num % 2 == 0)
                {
                    total += num;
                    dem++;
                }
            }
            return (float)total / dem;
        }

        // 5. viet ham tim vi tri va gia tri cac phan tu am trong mang
        static void timVitriPtuAm(int[] A, int n)
        {
            Console.WriteLine("Vi tri va gia tri cac phan tu am");
            for (int i = 0; i < n; i++)
            {
                if (A[i] < 0) Console.WriteLine($"vi tri: {i}, gia tri: {A[i]}");
            }
        }

        // 6. 
        // 7. viet ham tim phan tu nho nhat trong mang
        static int timPtuNhoNhat(int[] A, int n)
        {
            int min = A[0];
            foreach (int num in A) if (num < min) min = num;
            return min;
        }

        // 8. viet ham kiem tra mang toan duong
        static bool kiemTraToanDuong(int[] A, int n)
        {
            foreach (int num in A)
            {
                if (num < 0) return false;
            }
            return true;
        }
        // ... viet ham tim phan tu lon nhat trong mang
        static int timPtuLonNhat(int[] A, int n)
        {
            int max = A[0];
            foreach (int num in A)
            {
                if (num > max) max = num;
            }
            return max;
        }

        // 9. viet ham sap xep mang tang dan
        static int[] sapXepTangDan(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (A[i] > A[j])
                    {
                        int tmp = A[i];
                        A[i] = A[j];
                        A[j] = tmp;
                    }
                }
            }
            return A;
        }

        // 10. viet ham tim vi tri xuat hien cua phan tu X
        static int timViTri(int[] A, int n, int X)
        {
            for (int i = 0; i < n; i++)
            {
                if (A[i] == X) return i;
            }
            return -1;
        }

        // 11. viet ham dem so lan xuat hien cua mot so nguyen X trong mang
        static int demSoLanXuatHien(int[] A, int n, int X)
        {
            int dem = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] == X) dem++;
            }
            return dem;
        }

        // 12. viet ham xuat mang dao nguoc cac phan tu trong mang
        static void xuatMangNguoc(int[] A, int n)
        {
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine($"phan tu tai vi tri {i}: {A[i]}");
            }
        }

        // 13. viet ham dem so phan tu la so nguyen to va tinh tong cac phan tu nay
        static int demVaTinhTongSNT(int[] A, int n, ref int dem)
        {
            int total = 0;
            foreach (int num in A)
            {
                if (kiemTraSNT(num))
                {
                    total += num;
                    dem++;
                }
            }
            return total;
        }

        static bool kiemTraSNT(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i < num - 1; i++)
            {
                if (num % 2 == 0) return false;
            }
            return true;
        }
    }
}
