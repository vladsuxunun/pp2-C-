using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {

            int cnt = int.Parse(Console.ReadLine());//вводим количество рядов со строками
            for (int i = 0; i < cnt; i++)//цикл рядов
            {
                for (int j = 0; j <= i; j++)//цикл строк
                    Console.Write("[*]");/* каждая другая строка после первой больше иметь значений на 1 ,если цикл рядов
                второй то цикл ряда выводит только 2 знака строки*/
                Console.WriteLine();


            }
        }
    }
}