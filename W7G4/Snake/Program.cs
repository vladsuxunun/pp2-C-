using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            
            GameState game = new GameState();
            project1 gg = new project1();
            while (true)
            {
                Console.SetCursorPosition(1, 20);
               
                cpp();
                Console.SetCursorPosition(24, 20);
                gg.anton(Console.ReadLine());
                Console.SetCursorPosition(1, 20);
                Console.WriteLine("                                       ");
                
                break;
            }
            
            game.Run(gg.str());
            while (true)
            {
                

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.F2)
                {
                    Serialize(game);
                   

                }
                else if (consoleKeyInfo.Key == ConsoleKey.F3)
                {
                    game.Stop();
                    game = Deserialize();
                    game.Run(gg.str());
                }
                else
                {
                    game.ProcessKeyEvent(consoleKeyInfo);
                }
            }
        }
        
        static void cpp()
        {
            ;
            Console.WriteLine("please write your name");
        }
        
             static void fff()
        {
       
        }
        


        static void Serialize(GameState game)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameState));
            //string fname = string.Format("game_{0}.xml", DateTime.Now.ToString("yyyyMMddHHmmss"));
            string fname = string.Format("game.xml");
            using (FileStream fs = new FileStream(fname, FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(fs, game);
            }
        }

        static GameState Deserialize()
        {
            GameState gameState = null;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(GameState));
            string fname = string.Format("game.xml");
            using (FileStream fs = new FileStream(fname, FileMode.Open, FileAccess.Read))
            {
                gameState = xmlSerializer.Deserialize(fs) as GameState;
            }
            return gameState;
        }
    }
}
