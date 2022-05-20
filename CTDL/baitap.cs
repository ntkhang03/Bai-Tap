using System;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            dslkPhanSo dsPSo = new dslkPhanSo();
            dsPSo.nhapdslkPhanSo();
            dsPSo.indslkPhanSo();
            dsPSo.tichdslkPhanSo();
        }


        public class phanso
        {
            int tu;
            int mau;

            public phanso()
            {
            }
            public phanso(int t, int m)
            {
                tu = t;
                mau = m;
            }

            public void nhapPhanSo()
            {
                Console.WriteLine("Nhap vao tu so: ");
                tu = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao mau so: ");
                mau = int.Parse(Console.ReadLine());
            }

            public void xuatPhanSo()
            {
                Console.WriteLine("Pso: {0}/{1}", tu, mau);
            }

            public int Tu {
                get { return tu; }
                set { tu = value; }
            }

            public int Mau
            {
                get { return mau; }
                set { mau = value; }
            }
        }


        public class Node
        {
            public phanso data;
            public Node pNext;

            public Node()
            {
            }
            
            public Node(phanso Data)
            {
                data = Data;
                pNext = null;
            }

        }


        public class dslkPhanSo
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

            public dslkPhanSo()
            {
                pHead = null;
                pTail = null;
            }


            public void inSertTail(phanso ps)
            {
                Node p = new Node(ps); 
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


            public void nhapdslkPhanSo()
            {
                string c;

                do
                {
                    phanso ps = new phanso();
                    ps.nhapPhanSo();
                    inSertTail(ps);
                    Console.Write("nhap tiep? (yes/no)");
                    c = Console.ReadLine();

                } while (c == "yes");
            }


            public void indslkPhanSo()
            {
                Node p = pHead;
                Console.WriteLine("\n\n\nnDanh sach phan so la: ");
                while (p != null)
                {
                    Console.Write("  ");
                    p.data.xuatPhanSo();
                    p = p.pNext;
                }
            }


            public void tichdslkPhanSo()
            {
                Node p = pHead;
                int tu = 1;
                int mau = 1;
                while (p != null)
                {
                    tu *= p.data.Tu;
                    mau *= p.data.Mau;
                    p = p.pNext;
                }
                phanso ps = new phanso(tu, mau);
                Console.WriteLine("\n\nTich cua danh sach phan so tren la: " + ps.Tu + "/" + ps.Mau);
            }
        }
    }
}
