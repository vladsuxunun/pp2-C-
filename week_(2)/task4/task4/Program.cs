using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string secfolder = @"path/";
            string firstfolder = @"path1/";
            System.IO.Directory.CreateDirectory(firstfolder);
            System.IO.Directory.CreateDirectory(secfolder);
            System.IO.File.WriteAllText("path/sample.txt", "example map");
            if (!System.IO.Directory.Exists("path1/sample.txt"))
            {
                File.Copy(@"path/sample.txt", @"path1/sample.txt");

            }
            if (System.IO.Directory.Exists("path"))
            {
                System.IO.File.Delete(@"path/sample.txt");

            }


        }
    }
}

