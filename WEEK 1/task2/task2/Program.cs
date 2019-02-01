using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        class kbtu//обьявление класса
        {
            public string name;//спецификатор доступа из вне класса,и строки name
            public int id;//спецификатор доступа из вне класса,и  пер id
        }
        static void Main(string[] args)
        {
            kbtu student = new kbtu();//объявление объекта
            student.name = "Aknur"; //используем оператор выбора строки члена объекта student
            student.id = 181488;//используем оператор выбора переменной  члена объекта student
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine("{0} {1} {2}", student.name, student.id, i);//вывод полей обьекта student
            }
        }
    }
}