using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            String s = sr.ReadToEnd();
            string[] arr = s.Split(' ');//ввод в массив через пробел
           



               
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

                  
                }
            sr.Close();
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < aa.Length; i++)
                {
                    if (aa[i] > 0)
                    {
                    sw.Write("{0} ", aa[i]);

                }
                }
            sw.Close();



        }
    }
}
