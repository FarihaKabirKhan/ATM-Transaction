using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMTrascation
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000, deposit, withdraw;
            int choise, pin = 0, x = 0;
            Console.WriteLine("Enter Your Pin Number");
            pin = int.Parse(Console.ReadLine());
            while (true)
            {
                Console.WriteLine("******Welcome to ATM service********\n");
                Console.WriteLine("1. Check Balance\n");
                Console.WriteLine("2. Withdraw Cash\n");
                Console.WriteLine("3. Deposit Cash\n");
                Console.WriteLine("4. Quit\n");
                Console.WriteLine("***************************\n\n");
                Console.WriteLine("Enter your Choice:");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        Console.WriteLine("\n Your Balance in Rs : {0}", amount);
                        break;
                    case 2:
                        Console.WriteLine("\n Enter the amount to withdraw: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine("\n please enter the amount in multiples of 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine("\n insufficent balance");
                        }
                        else
                        {
                            amount = amount - withdraw;
                            Console.WriteLine("\n\n please collect cash");
                            Console.WriteLine("\n your current balance is {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\n enter the amount to deposit");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("your balance is {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine("\n Thank you using ATM");
                        break;
                }
            }
            Console.WriteLine("\n\n Thanks for using our ATM service");
        }
     
    }
}
