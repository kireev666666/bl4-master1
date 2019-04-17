using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            

                string yes = "Да";
                int i = 0;
                int a = 50;
                Console.WriteLine("Загадайте число от 1 до 100");
                Console.WriteLine("Ваше число больше 50 или меньше 50?(Отвечать только *Да* или *Нет*)");
                string Otvet = Console.ReadLine();
                if (Otvet == yes)
                {
                    a = a/2 + a;
                }
                else if (Otvet != yes) a = a/2;
            Console.WriteLine("Ваше число больше 75 или меньше 25?(Отвечать только *Да* или *Нет*)");
                Otvet = Console.ReadLine();
            if (Otvet == yes)
            
                {
                    a = a+ a/2 + a/5;
                }
                else if (Otvet != yes) a = a/2 - a/5;
            Console.WriteLine("Ваше число больше 85 или меньше 15?(Отвечать только *Да* или *Нет*)");
            Otvet = Console.ReadLine();
                if (Otvet == yes)
                {
                    a = a + a / 2 + a / 5 + 5;
                }
                else if (Otvet != yes) a = a / 2 - a / 5 - 5;
            Console.WriteLine("Ваше число больше 90 или меньше 10?(Отвечать только *Да* или *Нет*)");
            Otvet = Console.ReadLine();
                if (Otvet == yes)
                {
                a = a + a / 2 + a / 5 + 10; ;
                }
                else if (Otvet != yes) a = a / 2 - a / 5 - 10;
            Console.WriteLine("Ваше число больше 95 или меньше 5?(Отвечать только *Да* или *Нет*)");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Ваше число 96?");
            }
            else if (Otvet != yes) Console.WriteLine("Ваше число 97?");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Ваше число 96, 97");
            }
            else if (Otvet != yes) Console.WriteLine("Ваше число 99?");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Ваше число 99");
            }
            else if (Otvet != yes) Console.WriteLine("Ваше число 98");
            Console.ReadKey();

            }
            

        } 
                         
    }                                            
                                      

                                        
