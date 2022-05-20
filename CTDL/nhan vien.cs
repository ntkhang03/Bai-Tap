using System;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            dslkNhanVien ds = new dslkNhanVien();
            ds.nhapDSLK_NhanVien();
            ds.xuatDSLK_NhanVien();
        }


        public class nhanVien
        {
            string maNV;
            string hoTenNV;
            int mucLuong;
            int heSoLuong;
            int luong;

            public nhanVien()
            {
            }

            public nhanVien(string MaNv, string HoTenNv, int MucLuong, int HeSoLuong)
            {
                maNV = MaNv;
                hoTenNV = HoTenNv;
                mucLuong = MucLuong;
                heSoLuong = HeSoLuong;
                luong = MucLuong * HeSoLuong;
            }

            public string MaNV
            {
                get { return maNV; }
                set { maNV = value; }
            }

            public string HoTenNV
            {
                get { return hoTenNV; }
                set { hoTenNV = value; }
            }

            public int MucLuong
            {
                get { return mucLuong; }
                set { mucLuong = value; }
            }

            public int HeSoLuong
            {
                get { return heSoLuong; }
                set { heSoLuong = value; }
            }
            
            
            public void nhapNhanVien()
            {
                Console.Write("Nhap ma nhan vien: ");
                maNV = Console.ReadLine();
                Console.Write("Nhap ho ten nhan vien: ");
                hoTenNV = Console.ReadLine();
                Console.Write("Nhap muc luong: ");
                mucLuong = int.Parse(Console.ReadLine());
                Console.Write("Nhap he so luong: ");
                heSoLuong = int.Parse(Console.ReadLine());
                luong = mucLuong * heSoLuong;

            }

            public void xuatNhanVien()
            {
                Console.WriteLine("Ma nhan vien: {0}", maNV);
                Console.WriteLine("Ho ten nhan vien: {0}", hoTenNV);
                Console.WriteLine("Muc luong: {0}", mucLuong);
                Console.WriteLine("He so luong: {0}", heSoLuong);
                Console.WriteLine("Luong: {0}", luong);
            }

        }


        public class Node
        {
            public nhanVien info;
            public Node pNext;

            public Node()
            {
            }

            public Node(nhanVien Info)
            {
                info = Info;
                pNext = null;
            }
        }


        public class dslkNhanVien
        {
            private Node pHead;
            private Node pTail;
            public Node Head
            {
                get { return pHead; }
                set { pHead = value; }
            }

            public Node Tail
            {
                get { return pTail; }
                set { pTail = value; }
            }

            public dslkNhanVien()
            {
                pHead = null;
                pTail = null;
            }

            public void inSertTail(nhanVien nv)
            {
                Node p = new Node(nv);
                if (pHead == null)
                {
                    pHead = p;
                    pTail = p;
                }
                else
                {
                    pTail.pNext = p;
                    pTail = p;
                }
            }


            public void nhapDSLK_NhanVien()
            {
                string c;
                do
                {
                    nhanVien nv = new nhanVien();
                    nv.nhapNhanVien();
                    inSertTail(nv);
                    Console.Write("Ban co muon nhap tiep khong (y/n): ");
                    c = Console.ReadLine();
                } while (c == "y");
            }


            public void xuatDSLK_NhanVien()
            {
                Node p = pHead;
                Console.WriteLine("\n\n\nDanh sach nhan vien la: ");
                while (p != null)
                {
                    Console.WriteLine();
                    p.info.xuatNhanVien();
                    p = p.pNext;
                }
            }

        }
    }
}
