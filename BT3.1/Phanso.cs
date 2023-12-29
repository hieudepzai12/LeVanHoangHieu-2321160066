using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT3._1
{
    class Phanso
    {
        private int tuso;
        private int mauso;
        public Phanso()
        {
            tuso = 0;
            mauso = 0;
        }
        public Phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }
        public void setTuso(int tuso)
        {
            this.tuso = tuso;
        }
        public int getTuso()
        {
            return tuso;
        }
        public void setMauso(int mauso)
        {
            this.mauso = mauso;
        }
        public int getMauso()
        {
            return mauso;
        }
        public void toiGian()
        {
            int uscmax = TimUSCLN(tuso, mauso);
            tuso = tuso / uscmax;
            mauso = mauso / uscmax;
        }
        private int TimUSCLN(int a, int b)
        {
            int x = Math.Abs(a);
            int y = Math.Abs(b);
            while (x != y)
            {
                if (x > y)
                    x = x - y;
                else
                    y = y - x;
            }
            return x;
        }
        public Phanso cong(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso + ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso tru(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso - ps.tuso * mauso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso nhan(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.tuso;
            kq.mauso = mauso * ps.mauso;
            return kq;
        }
        public Phanso chia(Phanso ps)
        {
            Phanso kq = new Phanso();
            kq.tuso = tuso * ps.mauso;
            kq.mauso = mauso * ps.tuso;
            return kq;
        }
    }
}
