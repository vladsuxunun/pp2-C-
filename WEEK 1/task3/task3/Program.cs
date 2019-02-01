using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void copynum()//создание метода
        {
            string s1 = Console.ReadLine();//ввод в строку
            string[] array = s1.Split(' ');//отделение строки s1 через каждый пробел и ввод в отделную ачейку массива
            string[] array2 = new string[(array.Length * 2)];//создание массива с клонами чисел
            int k = 0;//создание для пересчета
            for (int i = 0; i < array.Length; i++) //цикл от 0 до значение длины массива 
            {
                array2[k++] = array[i];/*присваивание чисел в адрес из array в array2 в разные адреса */
                array2[k++] = array[i]; /*присваивание чисел в адрес из array в array2 в разные адреса */

            }
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write("{0} ", array2[i]);//вывод массива клонами чисео
            }
        }



        static void Main(string[] args)
        {

            copynum();//вызов метода
        }
    }
}