using System;

namespace BaiTap
{
    class Program
    {
        static void Main(string[] args)
        {
            DSLK_PhanSo dsPSo = new DSLK_PhanSo();
            dsPSo.nhapDSLK_PhanSo();
            dsPSo.inDSLK_PhanSo();
            dsPSo.tichDSLK_PhanSo();
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
                Console.WriteLine("Nhap tu so: ");
                tu = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap mau so: ");
                mau = int.Parse(Console.ReadLine());
            }

            public void xuatPhanSo()
            {
                Console.WriteLine("Phan so: {0}/{1}", tu, mau);
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


        public class DSLK_PhanSo
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

            public DSLK_PhanSo()
            {
                pHead = null;
                pTail = null;
            }

            //public void insertHead(phanso ps)
            //{
            //    // khai báo và khởi tạo  node
            //    Node p = new Node(ps);
            //    if (pHead == null)
            //    {
            //        pHead = p;
            //        pTail = p;
            //    }
            //    else
            //    {
            //        p.pNext = pHead;
            //        pHead = p;
            //    }
            //}

            //public void InsertAfter(phanso ps)
            //{
            //    Node p = new Node(ps);
            //    if (pHead == null)
            //    {
            //        pHead = p;
            //        pTail = p;
            //    }
            //    else
            //    {
            //        p.pNext = pHead.pNext;
            //        pHead.pNext = p;
            //    }
            //}


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


            public void nhapDSLK_PhanSo()
            {
                string c;

                do
                {
                    phanso ps = new phanso();
                    ps.nhapPhanSo();
                    inSertTail(ps);
                    Console.Write("con nhap phan so?  (yes/no)?");
                    c = Console.ReadLine();

                } while (c == "yes");
            }


            public void inDSLK_PhanSo()
            {
                Node p = pHead; // tạo node p cho p chạy từ đầu đến cuối danh sách
                Console.WriteLine("\n\nDanh sach phan so: ");
                while (p != null)
                {
                    Console.Write("-> ");
                    p.data.xuatPhanSo();
                    p = p.pNext;
                }
            }


            public void tichDSLK_PhanSo()
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
                Console.WriteLine("\n\nTich cua DSLK phan so la: " + ps.Tu + "/" + ps.Mau);
            }
        }
    }
}
