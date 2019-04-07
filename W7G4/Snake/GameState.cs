using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
using System.Xml.Serialization;

namespace Snake
{
    public class GameState
    {
       
        public Worm worm = new Worm('O');
        public Food food = new Food('@');
        public Wall wall = new Wall('#');
        bool anal = true;
        public void Run(string ass)
        {
            Thread thread = new Thread(MoveSnake);
            
            thread.Start();
           
                project(ass);
            food.GenerateLocation(worm.body, wall.body);
            
            wall.Draw();
            food.Draw();
            
            
            
        }

        public void MoveSnake()
        {
            while (anal)
            {
                worm.Clear();
               
                worm.Move();
                worm.Draw();
                ShowStatusBar(worm.body.Count.ToString());
                //worm.Draw();
                
                //CheckCollision();
                if(worm.IsIntersected(wall.body))
                {
                    
                    Console.Clear();
                    Console.SetCursorPosition(15, 20);
                    Console.Write("Game over!");
                    anal = false;
                }
                if (worm.IsIntersected(food.body))
                {
                    anal = true;
                    worm.Eat(food.body);
                    food.GenerateLocation(worm.body, wall.body);
                    food.Draw();
                }
                else if(worm.snakegavno(worm.body))
                {
                
                
                Console.Clear();
                Console.SetCursorPosition(15, 20);
                Console.Write("Game over!");
                    anal = false;
                }
                if ((Convert.ToInt32(worm.body.Count.ToString()) >=1 && (Convert.ToInt32(worm.body.Count.ToString()) <= 3)))
                Thread.Sleep(150);
                else if((Convert.ToInt32(worm.body.Count.ToString()) >= 4 && (Convert.ToInt32(worm.body.Count.ToString()) <= 7)))
                    Thread.Sleep(100);
                else if ((Convert.ToInt32(worm.body.Count.ToString()) >= 8 && (Convert.ToInt32(worm.body.Count.ToString()) <= 10)))
                    Thread.Sleep(50);
                else if ((Convert.ToInt32(worm.body.Count.ToString()) >= 11))
                    Thread.Sleep(10);



            }
        }

        public void Stop()
        {
            
            Console.Clear();
        }

        public GameState()
        {
            Console.SetWindowSize(57, 30);
            Console.SetBufferSize(57, 30);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorVisible = false;
        }

        public void ProcessKeyEvent(ConsoleKeyInfo consoleKeyInfo)
        {
            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Dx = 0;
                    worm.Dy = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.Dx = 0;
                    worm.Dy = 1;
                    break;
                case ConsoleKey.RightArrow:
                    worm.Dx = 1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Dx = -1;
                    worm.Dy = 0;
                    break;
                case ConsoleKey.Spacebar:
                    
                    break;

            }
        }
        void ShowStatusBar(string message)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("                                                         ");
            if ((Convert.ToInt32(worm.body.Count.ToString()) >= 1 && (Convert.ToInt32(worm.body.Count.ToString()) <= 3)))
            {
                Console.SetCursorPosition(4, 23);
                Console.WriteLine("Level is 1");
            }
            else if ((Convert.ToInt32(worm.body.Count.ToString()) >= 4 && (Convert.ToInt32(worm.body.Count.ToString()) <= 7)))

            {
                Console.SetCursorPosition(4, 23);
                Console.WriteLine("Level is 2");
            }
            else if ((Convert.ToInt32(worm.body.Count.ToString()) >= 8 && (Convert.ToInt32(worm.body.Count.ToString()) <= 10)))
            {
                Console.SetCursorPosition(4, 23);
                Console.WriteLine("Level is 3");
            }
            else if ((Convert.ToInt32(worm.body.Count.ToString()) >= 11 && (Convert.ToInt32(worm.body.Count.ToString()) <= 13)))
            {
                Console.SetCursorPosition(4, 23);
                Console.WriteLine("Level is 4");
            }
           
            int a = (10 * (Convert.ToInt32(message)));
            Console.SetCursorPosition(4, 24);
            Console.Write("Point is " + a);
        }
        void project(string gg)
        {
        string ff = gg;
        Console.SetCursorPosition(10, 27);
            Console.Write("Made by  "+ gg);
            }
        private void CheckCollision()
        {
         
        }
   


    }
}
