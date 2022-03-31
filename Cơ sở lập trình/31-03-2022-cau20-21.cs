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
            //Console.Write("Nhap vao can nang: ");
            //float heavy = float.Parse(Console.ReadLine());
            //Console.Write("Nhap vao chieu cao (m): ");
            //float height = float.Parse(Console.ReadLine());
            //Console.WriteLine($"Ket qua: nguoi " + tinhChiSoBMI(heavy, height));
            Console.Write("Nhap vao kw tieu thu: ");
            double tieuThu = double.Parse(Console.ReadLine());
            Console.WriteLine($"tong tien dien phai tra la: {tinhTienDien(tieuThu)}");
        }

        // 20.
        static string tinhChiSoBMI(float heavy, float height)
        {
            float BMI = heavy / (height * height);
            Console.WriteLine("BMI: " + BMI);
            if (BMI < 18)
                return "gay";
            else if (BMI < 25)
                return "binh thuong";
            else if (BMI < 30)
                return "beo phi do I";
            else if (BMI < 35)
                return "beo phi do II";
            else
                return "beo phi do III";
        }

        // 21. 
        static double tinhTienDien(double tieuThu)
        {
            double tongTien = 0;
            double bac1 = 3000;
            double bac2 = 5000;
            double bac3 = 7000;

            if (tieuThu <= 100)
                tongTien = tieuThu * bac1;
            else if (tieuThu <= 150)
                tongTien = (tieuThu - 100) * bac2 + 100 * bac1;
            else
                tongTien = (100 * bac1) + (50 * bac2) + ((tieuThu - 150)*bac3);

            return tongTien * 0.1 + tongTien;
        }
    }
}

