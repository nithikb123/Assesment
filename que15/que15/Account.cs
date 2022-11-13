using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que15
{
    internal class Account
    {
        public int Acc_no { get; set; }

        public string  Name { get; set; }

        public int Mobile_no { get; set; }

        public int Balance { get; set; }

        public void create()
        {
            Console.Write("Enter account no:");
            Acc_no = int.Parse(Console.ReadLine());
            Console.Write("Enter Name:");
            Name = Console.ReadLine();
            Console.Write("Enter mobile no:");
            Mobile_no = int.Parse(Console.ReadLine());
            Console.Write("Enter balance");
            Balance = int.Parse(Console.ReadLine());
        }

        public void deposit()
        {
            Console.Write("Enter Balance:");
            Balance += int.Parse(Console.ReadLine());
            Console.WriteLine($"New balance  is {Balance}");
        }

        public void withdraw()
        {
            Console.Write("Enter withdraw amount:");
            Balance -= int.Parse(Console.ReadLine());
            Console.WriteLine($"New balance  is {Balance}");
        }

        public void balance()
        {
            Console.WriteLine($"Balance is {Balance}");
        }
    }
    

}
