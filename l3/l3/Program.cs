using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cl;
            int a = 0; int b = 0;
            do
            {

                display();
                cl = Console.ReadKey(false);
                switch (cl.KeyChar.ToString())
                {
                    case "1":
                        Console.Write("Введите a ");
                        a = int.Parse(Console.ReadLine());
                        break;
                    case "2":
                        Console.Write("Введите b ");
                        b = int.Parse(Console.ReadLine());
                        break;
                    case "3":
                       
                        break;
                    case "4":
                       
                        break;
                    case "5":
                       
                        break;
                    case "6":
                       
                        break;

                    default:
                        break;
                }
            } while (cl.Key != ConsoleKey.Escape);
        }

        static void display()
        {
            Console.Clear();
            Console.WriteLine("1. ввести А ");
            Console.WriteLine("2.  ввести В ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. ");
            Console.WriteLine("6. ");
            Console.WriteLine("esc. Выход");
        }
    
    }
}
