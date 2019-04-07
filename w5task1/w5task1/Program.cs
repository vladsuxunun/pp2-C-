using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace w5task1
{
    public class Book
    {
        
        public string name;
        public int amount;
         public int price;
        public Book()
        {

        }
        public Book(string name,int amount,int price)
        {
            this.name = name;
            this.amount = amount;
            this.price = price;


        }
        
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {
                Ser();
            }
            else if (a == 2)
            {
                Des();
            }

        }
        public static void Ser()
        {
            List<Book> books = new List<Book>();
            string name = Console.ReadLine();
            int amount = Convert.ToInt32(Console.ReadLine());
            int price = Convert.ToInt32(Console.ReadLine());


            Book kniga2 = new Book(name,amount,price);
            
            

            books.Add(kniga2);
            FileStream fs = new FileStream("student.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            xs.Serialize(fs, books);
            

           



            fs.Close();

        }




        public static void Des()
        {

            FileStream fs = new FileStream("student.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(List<Book>));
            
            List<Book> deserlisemark = xs.Deserialize(fs) as List<Book>;
            foreach (var mark in deserlisemark)
            {
                Console.WriteLine(mark);
            }
            fs.Close();

            

        }
    }


}

