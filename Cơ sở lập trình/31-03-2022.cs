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
            Console.Write("Nhap diem Toan: ");
            float toan = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Tin Hoc: ");
            float tin = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem Anh Van: ");
            float anhVan = float.Parse(Console.ReadLine());

            Console.WriteLine("xep loai: " + xepLoai(toan, tin, anhVan));
        }

        // hàm xếp loại học lực
        static string xepLoai(float toan, float tin, float anhVan)
        {
            float diemTB = (toan + tin + anhVan)/3;
            Console.WriteLine($"diem trung binh: {diemTB}");

            if (diemTB >= 8 && toan >= 8 && tin >= 8 && anhVan >= 8)
                return "gioi";
            else if (diemTB >= 7 && toan >= 7 && tin >= 7 && anhVan >= 7)
                return "kha";
            else if (diemTB >= 6)
                return "trung binh kha";
            else if (diemTB >= 6)
                return "trung binh";
            else
                return "kem";  
        }
    }
}
