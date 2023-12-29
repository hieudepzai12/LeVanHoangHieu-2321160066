using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Phanso p1;
            Phanso p2;
            p1= new Phanso();
            Console.WriteLine("Nhap thong tin phan so thu 1: ");
            Console.WriteLine("Nhap tu so: ");
            int tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            int mauso = int.Parse(Console.ReadLine());
            p1.setTuso(tuso);
            p2.setMauso(mauso);
            p1.toiGian()
            Console.WriteLine("Nhap thong tin phan so thu: ");
            Console.WriteLine("Nhap tu so: ");
            tuso = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            mauso = int.Parse(Console.ReadLine());
            Phanso p2 = new Phanso(tuso, mauso);
            p2.toiGian();
            Phanso tong = p1.cong(p2);
            Phanso hieu = p1.tru(p2);
            Phanso tich = p1.nhan(p2);
            Phanso thuong = p1.chia(p2);
            Console.WriteLine("Tong 2 phan so PS1[{0}/{1}], PS2[{2}/{3}]= KQ[{4}/{5}]",
                p1.getTuso(), p1.getMauso(), p2.getTuso(), p2.getMauso(), tong.getTuso(), tong.getMauso());
            Console.ReadKey();
        }
}
