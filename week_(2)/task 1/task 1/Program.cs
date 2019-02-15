using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("file.txt");
            string a = (sr.ReadToEnd());
            string a1 = a;
            string a2 = a;
            string rev = "";
            for (int i = a2.Length - 1; i >= 0; i--)
            {
                rev += a2[i];
            }


            sr.Close();
            if (a2.Equals(rev))
            {
                Console.Write("YES");
            }
            else
            {
                Console.Write("NO");
            }
        }
    }
}
      //}
    //}
