using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so luong hoc sinh: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr = nhapDanhSachHocSinh(n);
            Console.WriteLine("---------\nXuat tat ca ten chu hoa: ");
            xuatTenChuHoa(arr);

            Console.WriteLine("---------\nXuat ten va do dai cua ten: ");
            xuatTenVaDoDaiTen(arr);

            Console.WriteLine("---------\nXuat cac hoc sinh co ten trung voi ten muon tim kiem: ");
            Console.WriteLine("Nhap vao ten muon tim kiem");
            string X = Console.ReadLine();
            Console.WriteLine("");
            xuatTenHocSinhTrungVoiX(X, arr);
        }

        static string[] nhapDanhSachHocSinh(int n)
        {
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap vao ten hoc sinh thu {0}: ", i + 1);
                arr[i] = Console.ReadLine();
            }
            return arr;
        }

        static void xuatTenChuHoa(string[] arr)
        {
            foreach (string name in arr)
                Console.WriteLine(name.ToUpper());
        }

        static void xuatTenVaDoDaiTen(string[] arr)
        {
            foreach (string name in arr)
            {
                Console.WriteLine("Ten: {0} - Do dai: {1}", name, name.Length);
            }
        }

        // xuất tên học sinh trùng với tên muốn tìm kiếm
        static void xuatTenHocSinhTrungVoiX(string X, string[] arr)
        {
            foreach (string name in arr)
            {
                string[] splitName = name.Split(' ');
                if (splitName[splitName.Length - 1].ToLower() == X.ToLower())
                    Console.WriteLine(name);
            }
        }
    }
}
