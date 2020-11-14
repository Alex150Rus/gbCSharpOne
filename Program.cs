using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gbCSharpOne
{
    class Program
    {
        static void Main(string[] args)
        {
            pointOne();
        }

        static void pointOne()
        {
            /* Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
            а) используя склеивание;
            б) используя форматированный вывод;
            в) используя вывод со знаком $.
            */
            Console.WriteLine("Как Вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Какая у Вас фамилия?");
            string surname = Console.ReadLine();
            Console.WriteLine("Укажите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Какой у Вас рост?");
            string height = Console.ReadLine();
            Console.WriteLine("Какой у Вас Вес?");
            string weight = Console.ReadLine();

            Console.Write(@"Как Вам сформировать вывод информации?
                введите 1, если используя склеивание
                введите 2, если используя форматированный вывод
                введите 3, если используя вывод со знаком $
            ");
            string choice = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
           

            if(String.Compare(choice, "1") == 0)
            {
                Console.WriteLine("Вы выбрали склеивание. " + "Привет " + name + " " + surname + "! Вам " + age + ", Ваш рост " + height + ", Ваш вес " + weight);
            } else if (String.Compare(choice, "2") == 0)
            {
                Console.WriteLine("Вы выбрали форматированный вывод. Привет {0} {1}! Вам {2}, Ваш рост {3}, Ваш вес {4}.", name, surname, age, height, weight);
            } else if (String.Compare(choice, "3") == 0)
            {
                Console.WriteLine($"Вы выбрали используя вывод со знаком $. Привет {name} {surname}! Вам {age}, Ваш рост {height}, Ваш вес {weight}.");
            }

            Console.ReadLine();
        }
    }
}
