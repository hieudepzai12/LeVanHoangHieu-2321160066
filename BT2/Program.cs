using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Account my = new Account("2321160066", "Le Van Hoang Hieu", 500);
            Account myFriend = new Account("2326160068", "Ngo Trung Hieu Kien", 1);
            
            Console.WriteLine(" Thong tin 2 tai khoan ban dau:");
            Console.WriteLine(" My Account:[id: {0}, name:{1}, balance; {2}]",
                my.getId(), my.getName(), my.getBalance());
            Console.WriteLine(" My friend Account:[id: {0}, name:{1}, balance; {2}]",
                myFriend.getId(), myFriend.getName(), myFriend.getBalance());

            my.debit(200);
            my.tranferTo(myFriend, 400);
            Console.WriteLine("Thong tin 2 tai khoan sau khi thuc hien giao dich: ");
            Console.WriteLine(" My Account:[id: {0}, name:{1}, balance; {2}]",
                my.getId(), my.getName(), my.getBalance());
            Console.WriteLine(" My friend Account:[id: {0}, name:{1}, balance; {2}]",
                myFriend.getId(), myFriend.getName(), myFriend.getBalance());
            Console.ReadKey();
        }
    }
}
