﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbCSharpOne
{
    class Program
    {

        public static double weight;
        public static double height;


        //студент Медведев Александр
        static void Main(string[] args)
        {
            //PointOneLesTwo();
            //GetQtyOfDigits();
            //PointThree();
            //PointFour();
            //PointTwo();
            //PointFive();
            //PointSix();
            PointSeven();
        }

        static void PointSeven()
        {
            //Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)
            Console.WriteLine("Введите число а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetNumbersFromAtoB(a, b));
            Console.WriteLine($"Сумма чисел от { a } до {b}: { GetSumOfNumbersFromAtoB(a, b) }");
            Console.ReadLine();
        }

        static string GetNumbersFromAtoB(int a, int b)
        {
            if (a>b)
            {
                return "";
            } else if(a < b)
            {
               return a.ToString() + ' ' + GetNumbersFromAtoB(++a, b);
            }
            return "";

        }

        static int GetSumOfNumbersFromAtoB(int a, int b)
        {
            if (a > b)
            {
                return a + GetSumOfNumbersFromAtoB(--a, b);
            }
            else if (a < b)
            {
                return a + GetSumOfNumbersFromAtoB(++a, b);
            }
            return 0;

        }


        static void PointSix()
        {
            /*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, 
            которое делится на сумму своих цифр.Реализовать подсчёт времени выполнения программы, используя структуру DateTime.*/
            DateTime start = DateTime.Now;

            long qty = 0;
            for (int i = 1; i < 1000000000; i++)
            {
                if (i % Sum(i) == 0)
                {
                    qty++;
                }
            }

            var result = DateTime.Now - start;
            Console.WriteLine($"Программа выполнилась за { result }, количество хороших чисел: {qty}");
            Console.ReadLine();

            //программа выполнилась за 00:01:46.4873903, количество хороших чисел: 61574509

        }

        static void PointFive()
        {
            /*а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
                нужно ли человеку похудеть, набрать вес или всё в норме.
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.*/

            double imt = getImt();
            Console.WriteLine($"Ваш ИМТ: {imt}");
            Console.ReadLine();
            if (imt > 25)
            {
                Console.WriteLine("Ваш имт выше нормы, надо худеть");
                Console.WriteLine($"Вам нужно похудеть на: { Program.weight - getWeight(25)} кг");
            } else if (imt < 18.5)
            {
                Console.WriteLine("Ваш имт ниже нормы, надо немного набрать вес");
                Console.WriteLine($"Вам нужно набрать: { getWeight(18.5) - Program.weight} кг");
            } else
            {
                Console.WriteLine("Ваш имт в норме");
            }
            Console.ReadLine();
        }

        static void PointFour()
        {
            /* Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль.На выходе истина, если прошел авторизацию, 
            и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: 
            пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while ограничить 
            ввод пароля тремя попытками. */

            int tries = 0;
            string login, password;
            do {
                Console.WriteLine("Введите Логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите Пароль");
                password = Console.ReadLine();
                tries++;
            } while (tries < 3 && !CheckCredentials(login, password));
            if(CheckCredentials(login, password))
            {
                Console.WriteLine($"Добро пожаловать. Количество попыток: { tries }");
            } else
            {
                Console.WriteLine("Посторонним вход запрещён");
            }
            Console.ReadLine();
        }

        static bool CheckCredentials(string login, string password)
        {
            return login == "root" && password == "GeekBrains";
        }

        static void PointThree() {
            //С клавиатуры вводятся числа, пока не будет введен 0.Подсчитать сумму всех нечетных положительных чисел.
            int stopNumber;
            do {
                Console.WriteLine("Введите целое число");
                stopNumber = Convert.ToInt32(Console.ReadLine()); 
            } while (stopNumber != 0);
            Console.WriteLine("Конец");
            Console.ReadLine();
        }

        static void GetQtyOfDigits()
        {
            //Написать метод подсчета количества цифр числа.
            Console.WriteLine("Введи целое число и мы определим сколько в нём цифр");
            string number = Console.ReadLine();
            int qtyOfDigits = 0;
            foreach (char digit in number)
            {
                qtyOfDigits++;
            }
            Console.WriteLine($"количество цифр: { qtyOfDigits }");
            Console.ReadLine();

        }

        static long Sum(long a)
        {
            long s = 0;
            while (a > 0)
            {
                s = s + a % 10;
                a = a / 10;
            }
            return s;
        }

        static void PointOneLesTwo()
        {

            Console.WriteLine("дай мне первое целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("дай мне второе целое число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("дай мне третье целое число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное число: { GetMaxOfThree(a, b, c)}");
            Console.ReadLine();
        }

        static double getWeight(double imt)
        {
            // имт = вес / h2
            return imt * Math.Pow(Program.height, 2);
        }

        static int GetMaxOfThree(int a, int b, int c)
        {
            int max;
            if(c > a && c > b)
            {
                max = c;
            } else if (a > b)
            {
                max = a;
            } else
            {
                max = b;
            }

            return max;
        }

        #region Lesson 1 HW
        //    static void Main(string[] args)
        //    {
        //        //PointOne();
        //        //PointTwo();
        //        //PointThree();
        //        //PointFour();
        //        PointFive();
        //    }

        //    static void PointOne()
        //    {
        //        /* Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
        //        а) используя склеивание;
        //        б) используя форматированный вывод;
        //        в) используя вывод со знаком $.
        //        */
        //        Console.WriteLine("Как Вас зовут?");
        //        string name = Console.ReadLine();
        //        Console.WriteLine("Какая у Вас фамилия?");
        //        string surname = Console.ReadLine();
        //        Console.WriteLine("Укажите возраст");
        //        string age = Console.ReadLine();
        //        Console.WriteLine("Какой у Вас рост?");
        //        string height = Console.ReadLine();
        //        Console.WriteLine("Какой у Вас Вес?");
        //        string weight = Console.ReadLine();

        //        Console.Write(@"Как Вам сформировать вывод информации?
        //            введите 1, если используя склеивание
        //            введите 2, если используя форматированный вывод
        //            введите 3, если используя вывод со знаком $
        //        ");
        //        string choice = Console.ReadLine();
        //        Console.ForegroundColor = ConsoleColor.Yellow;

        //        if(String.Compare(choice, "1") == 0)
        //        {
        //            Console.WriteLine("Вы выбрали склеивание. " + "Привет " + name + " " + surname + "! Вам " + age + ", Ваш рост " + height + ", Ваш вес " + weight);
        //        } else if (String.Compare(choice, "2") == 0)
        //        {
        //            Console.WriteLine("Вы выбрали форматированный вывод. Привет {0} {1}! Вам {2}, Ваш рост {3}, Ваш вес {4}.", name, surname, age, height, weight);
        //        } else if (String.Compare(choice, "3") == 0)
        //        {
        //            Console.WriteLine($"Вы выбрали используя вывод со знаком $. Привет {name} {surname}! Вам {age}, Ваш рост {height}, Ваш вес {weight}.");
        //        }

        //        Console.ReadLine();
        //    }

        static double getImt()
        {
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.WriteLine("Введите, пожалуйста, свой вес в кг");
            double weight = Program.weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, свой рост в метрах");
            double height = Program.height = Convert.ToDouble(Console.ReadLine());
            return weight / (height * height);
        }
        //    static void PointThree()
        //    {
        //        /* 
        //        *а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
        //        *r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
        //        б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода. 
        //        */
        //        Console.WriteLine(@"Эта программа подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле: 
        //            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)");
        //        Console.WriteLine("Введите координату x первой точки");
        //        double x1 = Double.Parse(Console.ReadLine());
        //        Console.WriteLine("Введите координату y первой точки");
        //        double y1 = Double.Parse(Console.ReadLine());
        //        Console.WriteLine("Введите координату x второй точки");
        //        double x2 = Double.Parse(Console.ReadLine());
        //        Console.WriteLine("Введите координату y второй точки");
        //        double y2 = Double.Parse(Console.ReadLine());
        //        Console.WriteLine($"Расстояние между точками ({x1},{y1}) и ({x2},{y2}) составляет " + "{0:f2}", CalcDistanceBetween2Points(x1,y1,x2,y2));
        //        Console.ReadLine();
        //    }
        //    static double CalcDistanceBetween2Points(double x1, double y1, double x2, double y2)
        //    {
        //        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1, 2));
        //    }
        //    static void PointFour()
        //    {
        //        /* Написать программу обмена значениями двух переменных:
        //        а) с использованием третьей переменной;
        //        б) *без использования третьей переменной.
        //        */
        //        int a = 5;
        //        int b = 9;
        //        int t = a;
        //        a = b; b = t;

        //        a = a + b;
        //        b = a - b;
        //        a = a - b;
        //    }

        //    static void PointFive()
        //    {
        //        /* а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //        б) *Сделать задание, только вывод организовать в центре экрана.
        //        в) **Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y).
        //        */
        //        string credentials = "Александр Медведев, Химки";
        //        int strLength = credentials.Length;
        //        PrintCredentials(credentials, Console.WindowWidth / 2 - strLength / 2, Console.WindowHeight / 2);
        //    }

        //    static void PrintCredentials(string credentials, int x, int y)
        //    {
        //        Console.SetCursorPosition(x, y);
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine(credentials);
        //        Console.ReadLine();
        //    }
        //}

        //class Study
        //{
        //    //Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).
        //    static void Print(string msg, ConsoleColor foregroundcolor)
        //    {
        //        Console.ForegroundColor = foregroundcolor;
        //        Console.WriteLine(msg);

        //    }
        //    static void Pause()
        //    {
        //        Console.WriteLine("Пауза :)");
        //    }
        #endregion
    }
}
