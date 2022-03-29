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
            Console.WriteLine("Nhap so hang: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so cot: ");
            int n = int.Parse(Console.ReadLine());
            int[,] A = new int[m, n];
            int[,] B = new int[m, n];

            Console.WriteLine("\nNhap mang 2 chieu A:");
            nhapMangHaiChieu(A, m, n);
            
            Console.WriteLine("\nMang hai chieu A la: ");
            xuatMangHaiChieu(A, m, n);


            //Console.WriteLine($"\nTong cua mang 2 chieu la: {tinhTongMangHaiChieu(A, m, n)}");

            //Console.WriteLine($"Tong duong cheo chinh la: {tongDuongCheoChinh(A, m)}");

            //Console.WriteLine($"Tong duong cheo phu la: {tongDuongCheoPhu(A, m)}");

            //Console.WriteLine($"Tong phan tu cua tam giac tren la: {tongPtuTamGiacTren(A, m)}");

            //Console.WriteLine($"Tong phan tu cua tam giac duoi la: {tongPtuTamGiacDuoi(A, m)}");

            //string check = kiemTraPtuAm(A, m, n) ? "co" : "khong co";
            //Console.WriteLine($"Mang tren {check} phan tu am");

            //Console.WriteLine("\nNhap mang 2 chieu B:");
            //nhapMangHaiChieu(B, m, n);
            //Console.WriteLine("\nMang hai chieu B la: ");
            //xuatMangHaiChieu(B, m, n);
            //int[,] C = tong2MaTran(A, B, m, n);
            //Console.WriteLine($"\nTong cua hai mang la:");
            //xuatMangHaiChieu(C, m, n);


            Console.WriteLine("\nMa tran chuyen vi cua A la: ");
            int[,] maTranCVi = chuyenViMaTran(A, m, n);
            xuatMangHaiChieu(maTranCVi, n, m); // vì là ma trận chuyển vị nên hàng => cột và ngược lại nên truyền vào n, m

        }
        // 1. viết hàm nhập mảng 2 chiều
        static void nhapMangHaiChieu(int[,] A, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhap phan tu tai hang {i}, cot {j}: ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        // 2. viết hàm xuất mảng 2 chiều
        static void xuatMangHaiChieu(int[,] A, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{A[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        // 3. viết hàm tính tổng các phần tử trong mảng
        static int tinhTongMangHaiChieu(int[,] A, int m, int n)
        {
            int total = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    total += A[i, j];
                }
            }
            return total;
        }

        // 4. viết hàm tính tổng đường chéo chính
        static int tongDuongCheoChinh(int[,] A, int m)
        {
            int total = 0;
            for (int i = 0; i < m; i++) total += A[i, i];
            return total;
        }

        // 5. viết hàm tính tổng đường chéo phụ
        static int tongDuongCheoPhu(int[,] A, int m)
        {
            int total = 0;
            for (int i = 0; i < m; i++) total += A[i, m - i - 1];
            return total;
        }

        // 6. viết hàm tính tổng các phần tử của tam giác trên
        static int tongPtuTamGiacTren(int[,] A, int m)
        {
            int total = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = i; j < m; j++) total += A[i, j];
            }
            return total;
        }

        // 7. viết hàm tính tổng các phần tử của tam giác dưới
        static int tongPtuTamGiacDuoi(int[,] A, int m)
        {
            int total = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j <= i; j++) total += A[i, j];
            }
            return total;
        }

        // 8. viết hàm kiểm tra mảng có chứa phần tử âm không?
        static bool kiemTraPtuAm(int[,] A, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] < 0) return true;
                }
            }
            return false;
        }

        // 9. viết hàm tính tổng 2 ma trận
        static int[,] tong2MaTran(int[,] A, int[,] B, int m, int n)
        {
            int[,] C = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }

        // 10. viết hàm in ma trận chuyển vị
        static int[,] chuyenViMaTran(int[,] A, int m, int n)
        {
            int[,] chuyenVi = new int[n, m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    chuyenVi[j, i] = A[i, j];
                }
            }
            return chuyenVi;
        }
    }
}
