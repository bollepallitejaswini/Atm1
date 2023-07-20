using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AException : Exception
    {
        public AException(int cmat)
        {
            cmat = cmat - 500;
            Console.WriteLine("");
            Console.WriteLine("Rs 500 deducted from your account as limit of no. of transactions is exceeded\n ");
            Console.Write("Total Amount Available: " + cmat);
            Console.WriteLine("");
        }

    }
    class Program
    {
        public static void withd(string atm, string with, int camt)
        {
            char wa;
            int count = 0;
            if ((atm == "y") && (with == "y"))
            {


                //for (int i = 0; i < 3; i++)
                //{
                do
                {
                    Console.Write("Enter transaction amount: ");
                    count++;
                    int n = Convert.ToInt32(Console.ReadLine());
                    camt = camt - (int)n;
                    Console.WriteLine("Total amount after transaction: " + camt);
                    if (count == 3)
                    {
                        throw new AException(camt);
                    }
                    Console.Write("do you want to withdraw again(y/n):");
                    wa = Convert.ToChar(Console.ReadLine());
                } while (wa == 'y');

                //}  

                Console.WriteLine("Total amount available after transaction: " + camt);
            }
            else
            {
                Console.WriteLine("Your accounts are created and details are saved ");
            }
        }

        static void Main(string[] args)
        {
            partial p = new ConsoleApp1.partial();
            Console.WriteLine("enter savings accno,name:");
            p.accno = int.Parse(Console.ReadLine());
            p.name = Console.ReadLine();
            Console.WriteLine("do you need atm card(y/n):");
            p.atm = Console.ReadLine();
            Console.Write("Enter Initial deposit amount:");
            p.camt = int.Parse(Console.ReadLine());
            Console.Write("do you want to withdraw money form our account(y/n):");
            p.with = Console.ReadLine();
            Program.withd(p.atm, p.with, p.camt);

            Console.WriteLine("enter current accno,name:");
            p.accno = int.Parse(Console.ReadLine());
            p.name = Console.ReadLine();
            Console.WriteLine("do you need atm card(y/n):");
            p.atm = Console.ReadLine();
            Console.Write("Enter Initial deposit amount:");
            p.camt = int.Parse(Console.ReadLine());
            Console.Write("do you want to withdraw money form our account(y/n):");
            p.with = Console.ReadLine();
            Program.withd(p.atm, p.with, p.camt);

            Console.WriteLine("enter child care accno,name and age:");
            p.accno = int.Parse(Console.ReadLine());
            p.name = Console.ReadLine();
            p.age = int.Parse(Console.ReadLine());
            Console.WriteLine("do you need atm card(y/n):");
            p.atm = Console.ReadLine();
            Console.Write("Enter Initial deposit amount:");
            p.camt = int.Parse(Console.ReadLine());
            Console.Write("do you want to withdraw money form our account(y/n):");
            p.with = Console.ReadLine();
            Program.withd(p.atm, p.with, p.camt);

        }
    }
}

