using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kk = Convert.ToInt32(Console.ReadLine());//кол во чисел в массиве
            string a = Console.ReadLine();//ввод чисел в строку
            string[] arr = a.Split(' ');//ввод в массив через пробел
            if (kk == arr.Length)//если кол во соотвествут то продолжает
            {
                


            int cnt = 0;//подсчет чисел 
                int[] aa = new int[arr.Length];//массив
                for (int i = 0; i < arr.Length; i++)//цикл
                {
                    aa[i] = int.Parse(arr[i]);//string парсит в int
                }
                for (int i = 0; i < aa.Length; i++)//цикл
                {
                    for (int j = 2; j <= aa[i] / 2; j++)
                    {
                        if (aa[i] % j == 0 && aa[i] != j)//цикл делит и чекает j
                        {
                            aa[i] = 0;
                            break;
                        }
                    }

                    if (aa[i] > 0) cnt++;//подсчет простых чисел
                    { }
                }
                Console.WriteLine(cnt);//вывод 

                for (int i = 0; i < aa.Length; i++)
                {
                    if (aa[i] > 0)
                    {
                        Console.Write("{0} ", aa[i]);//вывод 

                    }
                }
            }



        }
    }
}