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
            Console.WriteLine("Здраствуйте вас приветствует акинатор! Загадайте число от 1 до 100");
            Console.WriteLine("Ваше число меньше 50? Отвечайте пожалуйста только Да или Нет");
            string y = "Да";
            string n = "Нет";
            int a = 50;
            int i = 1;
            int t = 100;
            string Answer = Console.ReadLine();
            if (Answer == y)

                for (i = 1; i < a;)
                {
                    Console.WriteLine("Ваше число больше {0}?", i);
                    if (Console.ReadLine() == y)
                    {
                        i++;
                    }
                    
                    else  Console.WriteLine("Ваше число равно {0}", i); 
                    
                }

            else if (Answer == n) Console.WriteLine("Ваше число больше 50?");
            if (Console.ReadLine() == y)
                while (a < t)
                {
                    Console.WriteLine("Ваше число меньше {0}?", t);
                    if (Console.ReadLine() == y)
                    {
                        t--;
                    }
                    else Console.WriteLine("Ваше число равно {0}", t); 

                }
            else Console.WriteLine("Ваше число 50");

            Console.ReadKey();
               
        }    

    }    
            

}         
                         
                                                
                                      

                                        
