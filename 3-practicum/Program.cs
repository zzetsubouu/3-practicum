using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_practicum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1 - 25 вариант, задание 2 - 1 сделать квадрат
            //1 задание
            Console.Title = "Задание № 2 (Пьяник)";
            Console.WindowHeight = 40;
            Console.WindowWidth = 40;
            Console.BufferHeight = 40;
            Console.BufferWidth = 40;

            //отображние состояние CapsLock и NumLock
            if (Console.CapsLock == true)
            {
                Console.WriteLine("Caps Lock ON");
            }
            else
            {
                Console.WriteLine("Caps Lock OFF");
            }
            if (Console.NumberLock == true)
            {
                Console.WriteLine("NumLock ON");
            }
            else
            {
                Console.WriteLine("NumLock OFF");
            }

            //звуковой сигнал
            //1 способ
            //Console.Beep(659, 300);
            //Console.Beep(659, 300);
            //Console.Beep(659, 300);
            //2 способ
            //Console.WriteLine("\a");


            //задание 2
            Console.Write("Запрашиваю у пользователя n слов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите слово: ");
            string words = Console.ReadLine();
            Console.WriteLine("вывожу на экран введенные слова в порядке ……");
            for (int s = 0; s < n; s++)
            {
                Console.WriteLine($"{words} ");
            }

            

            Console.WriteLine("Введите символ: ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"На следующем этапе будет выведен квадрат из символов {symbol}, Нажмите любую клавишу для продолжения...");
            Console.ReadKey();
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Red;//цвет фона
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;

            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            int startX = Console.WindowWidth / 2;
            int startY = Console.WindowHeight / 2;

            for (int i = 0; i < 30; i++)  // Внешний цикл для строк
            {
                for (int j = 0; j < 30; j++)  // Внутренний цикл для столбцов
                {
                    Console.SetCursorPosition(startX - 30 / 2 + j, startY - 30 / 2 + i);
                    Console.Write(symbol);
                }
            }
            Console.ReadKey(true);
        }
    }
}
