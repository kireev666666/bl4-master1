using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Lesson_4._1
{
    partial class Practice
    {
        //B4-P1/25. If_TimeOfDayGreeting
        public static void B4_P1_25_If_TimeOfDayGreeting()
        {

        }

        //B4-P2/25. If_NumbersComparing
        public static void B4_P2_25_If_NumbersComparing()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = x - y;
            if (c == 0)
                Console.WriteLine("Значения равны");
            else if (c > 0)
                Console.WriteLine("X больше Y на {0}", c);
            else Console.WriteLine("X меньше Y на {0}", -c);
            Console.ReadKey();
        }

        //B4-P3/25. If_PositiveNumbersComparing
        public static void B4_P3_25_If_PositiveNumbersComparing()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c = x - y;
            if (x >= 0 && y >= 0)
                if (c == 0)
                    Console.WriteLine("Значения равны");
                else if (c > 0)
                    Console.WriteLine("X больше Y на {0}", c);
                else Console.WriteLine("X меньше Y на {0}", -c);
            else Console.WriteLine("Одно из значений меньше нуля");
            Console.ReadKey();
        }

        //B4-P4/25. If_Akinator5Numbers
        public static void B4_P4_25_If_Akinator5Numbers()
        {
            string yes = "Да";
            Console.WriteLine("Загадайте число от 1 до 5");
            Console.WriteLine("Ваше число 1?(Отвечать только *Да* или *Нет*)");
            string Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Вы загадали число 1");
            }
            else Console.WriteLine("Ваше число 2?");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Вы загадали число 2");
            }
            else Console.WriteLine("Ваше число 3?");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Вы загадали число 3");
            }
            else Console.WriteLine("Ваше число 4?");
            Otvet = Console.ReadLine();
            if (Otvet == yes)
            {
                Console.WriteLine("Вы загадали число 4");
            }
            else Console.WriteLine("Вы загадали число 5");
        }

        //B4-P5/25. Switch_DayOfWeek
        public static void B4_P5_25_Switch_DayOfWeek()
        {
        }

        //B4-P6/25. Switch_GameNavigation
        public static void B4_P6_25_Switch_GameNavigation()
        {
            
        }

        //B4-P7/25. For_10OddEven
        public static void B4_P7_25_For_10OddEven()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("четное {0}", i);
                else Console.WriteLine("нечетное {0}", i);
            }
            ;
            Console.ReadKey();
        }


        //B4-P8/25. For_3DevideNumbers
        public static void B4_P8_25_For_3DevideNumbers()
        {
            for (int i = 30; i > 0; i--)
            {
                if (i % 3 == 0)
                    Console.WriteLine("{0}", i);
                else Console.ReadKey();
            }
        }


        //B4-P9/25. For_Matrix10x10
        public static void B4_P9_25_For_Matrix10x10()
        {
            int[,] a = new int[1, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.WriteLine("{0,4}", a[i, j] = i + j + 1);
                Console.ReadKey();

            }
        }


        //B4-P10/25. For_HelloWorld
        public static void B4_P10_25_For_HelloWorld()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine("Привет мир");
                Console.ReadKey();
            }
        }


        //B4_P11/25. For_Afrochildren
        public static void B4_P11_25_For_Afrochildren()
        {
            
        }


        //B4-P12/25. For_Minus10OddEven
        public static void B4_P12_25_For_Minus10OddEven()
        {
            for (int i = 0; i >= -10; i--)
            {
                if (i % 2 == 0)
                    Console.WriteLine("четное {0}", i);
                else Console.WriteLine("нечетное {0}", i);
            }
            ;
            Console.ReadKey();
        }


        //B4-P13/25 For_LettersCount
        public static void B4_P13_25_For_LettersCount()
        {
            Console.WriteLine("Введите слово");
            string word = Console.ReadLine();
            int n = 0;
            for (int j = 0; j < word.Length; j++)
            if (word[j] == 'а') n++;
            Console.WriteLine(n);
            Console.ReadKey();
        }


        //B4-P14/25 *For_AlphabetBack
        public static void B4_P14_25_For_AlphabetBack()
        {
            for (int i = 90; i >= 65; i--)
                Console.WriteLine((char)i);
            Console.ReadKey();
        }


        //B4-P15/25 While_OddEventNumber
        public static void B4_P15_25_While_OddEventNumber()
        {
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i < n)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }


        //B4-P16/25 DoWhile_OddEventNumber
        public static void B4_P16_25_DoWhile_OddEventNumber()
        {
            Console.WriteLine("Введите число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            do
            {
                if (i % 2 != 0)
                    Console.WriteLine(i);
                i++;
            } while (i < n);
            Console.ReadKey();
        }


        //B4-P17/25 While_HelloWorld
        public static void B4_P17_25_While_HelloWorld()
        {
            Console.WriteLine("Введите фразу");
            string n = Convert.ToString(Console.ReadLine());
            int i = 1;
            while (i < 7)
            {

                Console.WriteLine(n);
                i++;
            }
            Console.ReadKey();
        }


        //B4-P18/25 While_Multiplier
        public static void B4_P18_25_While_Multiplier()
        {
            Console.WriteLine("Введите первое число");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double z = Convert.ToDouble(Console.ReadLine());
            double i = Math.Pow(n, z);
            while (n <= z | n > z)
            {

                Console.WriteLine("{0} в степени {1} равно {2}", n, z, i);
                Console.ReadKey();
                break;
            }
        }


        //B4-P19/25 While_SolveNumberAdding
        public static void B4_P19_25_While_SolveNumberAdding()
        {
            
        }


        //B4-P20/25 While_DiceGame
        public static void B4_P20_25_While_DiceGame()
        {
            Console.WriteLine("Введите число от 1 до 6");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int z = 25;
            a += n;
            while (a < z)
            {

                Console.WriteLine("Введите число от 1 до 6");
                int x = Convert.ToInt32(Console.ReadLine());
                a += x;
                if (a < z)
                {
                    Console.WriteLine("Продолжаем игру, ваш ход {0}", a);
                }
                else Console.WriteLine("Вы дошли до конца поля");


            }
            Console.ReadKey();
        }


        //B4-P21/25 *While_DiceGameMultiplePlayers
        public static void dB4_P21_25_While_DiceGameMultiplePlayers()
        {
            Console.WriteLine("Первый игрок введите число от 1 до 6");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второй игрок введите число от 1 до 6");
            int b = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            int v = 0;
            int z = 25;
            a += n;
            v += b;
            while (a < z && v < z)
            {

                Console.WriteLine("Первый игрок введите число от 1 до 6, ваш ход {0}", a);
                int x = Convert.ToInt32(Console.ReadLine());
                a += x;
                Console.WriteLine("Второй игрок введите число от 1 до 6, ваш ход {0}", v);
                int m = Convert.ToInt32(Console.ReadLine());
                v += m;
                if (a < z & v < z)
                {
                    Console.WriteLine("Продолжаем игру, ваш ход {0},{1}", a, v);
                }
                else Console.WriteLine("Вы дошли до конца поля");


            }
            Console.ReadKey();
        }


        //B4-P22_25 *While_Akinator100Numbers
        public static void B4_P22_25_While_Akinator100Numbers()
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

                    else Console.WriteLine("Ваше число равно {0}", i);

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


        //B4-P23/25 IfElse_Calcultor
        public static void B4_P23_25_IfElse_Calcultor()
        {
            
        }


        //B4-P24_25 Switch_Calculator
        public static void B4_P24_25_Switch_Calculator()
        {
            
        }


        //B4-P25/25 Cycle_WordRevercse
        public static void B4_P25_25_Cycle_WordRevercse()
        {
            Console.WriteLine("Введите слово");
            string text = Console.ReadLine();
            var letters = text.ToCharArray();
            Array.Reverse(letters);
            Console.WriteLine(letters);
            Console.ReadKey();
        }
    }
}
