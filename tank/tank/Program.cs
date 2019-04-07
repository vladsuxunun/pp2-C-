using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace pistol
{
    class Program
    {
        static int i = 12;
        static int j = 12;

        static void Draw1()
        {

            string ss = "####";
            string ssa = "########";


            Console.SetCursorPosition((j), 4);
            Console.WriteLine(ss);
            Console.SetCursorPosition((j), 5);
            Console.WriteLine(ssa);
            Console.SetCursorPosition((j), 6);
            Console.WriteLine(ss);
            Console.SetCursorPosition((j - 5), 4);
            Console.WriteLine("    ");
            Console.SetCursorPosition((j - 9), 5);
            Console.WriteLine("        ");
            Console.SetCursorPosition((j - 5), 6);
            Console.WriteLine("    ");
            i++;
        }
        static void Draw2()
        {

            string ss = "####";
            string ssa = "########";


            Console.SetCursorPosition((j), 8);
            Console.WriteLine(ss);
            Console.SetCursorPosition((j), 9);
            Console.WriteLine(ssa);
            Console.SetCursorPosition((j), 10);
            Console.WriteLine(ss);
            Console.SetCursorPosition((j - 5), 8);
            Console.WriteLine("    ");
            Console.SetCursorPosition((j - 9), 9);
            Console.WriteLine("        ");
            Console.SetCursorPosition((j - 5), 10);
            Console.WriteLine("    ");
            j++;
        }

        static void Main(string[] args)
        {

            //while (true)
            ///{
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //if (keyInfo.Key == ConsoleKey.Spacebar)
            //{
            Thread thread3 = new Thread(pistolet2);
            thread3.Start();
            Thread thread2 = new Thread(pistolet1);
            thread2.Start();

            //}
            //}

        }

        static void pistolet1()
        {
            while (true)
            {
                Draw1();
                Thread.Sleep(1000);
                //Console.Clear();

            }
        }
        static void pistolet2()
        {
            while (true)
            {
                Draw2();
                Thread.Sleep(1500);
                //Console.Clear();

            }
        }
    }
}