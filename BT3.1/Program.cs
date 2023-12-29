using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //câu a
            Phanso p1;
            Phanso p2;

            Console.WriteLine("Nhap thong tin phan so thu 1: ");
            Console.WriteLine("Nhap tu so: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            int mauso = int.Parse(Console.ReadLine());

            p1 = new Phanso();
            p1.setTuso(tuso);
            p1.setMauso(mauso);
            p1.toiGian();

            Console.WriteLine("Nhap thong tin phan so thu: ");
            Console.WriteLine("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());
            p2 = new Phanso(tuso, mauso);
            p2.toiGian();

            Phanso tong = p1.cong(p2);
            Console.WriteLine("Tong cua 2 phan so la: {0}/{1} + {2}/{3} = {4}/{5}", p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            Phanso hieu = p1.tru(p2);
            Console.WriteLine("Hieu cua 2 phan so la: {0}/{1} - {2}/{3} = {4}/{5}", p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), hieu.getTuso(), hieu.getMauso());
            Phanso tich = p1.nhan(p2);
            Console.WriteLine("Tich cua 2 phan so la: {0}/{1} * {2}/{3} = {4}/{5}", p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tich.getTuso(), tich.getMauso());
            Phanso thuong = p1.chia(p2);
            Console.WriteLine("Thuong cua 2 phan so la: {0}/{1} / {2}/{3} = {4}/{5}", p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), thuong.getTuso(), thuong.getMauso());
            //cau b
            int N;
            N = nhapSonguyencoDK("Nhap so nguyen duong n: ", "Nhap so nguyen duong n: ");

            Phanso s = new Phanso(0,1);
            for (int i = 1; i <= N; i++)
                s = s.cong(new Phanso(1, i));

            Console.WriteLine("Ket qua cua day so: 1 + 1/2 + 1/3 + ... + 1/n = {0}/{1}", s.getTuso(), s.getMauso());

            Console.ReadKey();

        }
        static int nhapSonguyencoDK(string ghichu1, string ghichu2)
        {
            bool flag = true;
            int n;
            do
            {
                if (flag)
                {
                    Console.Write(ghichu1);
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.Write(ghichu2);
                    n = int.Parse(Console.ReadLine());
                }
                flag = false;
            } while (n < 1);
            return n;
        }
    }
}
   
