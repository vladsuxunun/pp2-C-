using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tassk3
{
    class Program
    {
        // метод для вывода пробела
        public static void probel(int lvl)
        {
            // цикл
            for (int i = 0; i < lvl; i++)
                // вывод пробела
                Console.Write("     ");
        }
        public static void put(DirectoryInfo dir, int lvlspace)
        {
            // цикл fileinfo в директории
            foreach (FileInfo f in dir.GetFiles())
            {
                //вывод пробела 
                probel(lvlspace);
                // вывод папки или файла
                Console.WriteLine(f.Name);
            }
            //цикл информации директории в директории
            foreach (DirectoryInfo dr in dir.GetDirectories())
            {
                // вывод пробела
                probel(lvlspace);
                // вывод следующей аудитории
                Console.WriteLine(dr.Name);
                // вызов метода 
                put(dr, lvlspace + 1);
            }
        }
        static void Main(string[] args)
        {
            //указание директории
            DirectoryInfo direct = new DirectoryInfo(@"C:\Users\vlad\Desktop");
            // вызв метода
            put(direct, 0);
            Console.ReadKey();
        }
    }
}