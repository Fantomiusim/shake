using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Размер окна 
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            

            //Отрисовка рамочки
            HorizonalLine Upline = new HorizonalLine(0, 78, 0, '+');
            HorizonalLine Downline = new HorizonalLine(0, 78, 24, '+');
            VerticalLine Leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 78, '+');
            Upline.Drow();
            Downline.Drow();
            Leftline.Drow();
            Rightline.Drow();



            //Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            snake.Move();
            
            //Движение змейки
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                   
                }
                Thread.Sleep(100);
                snake.Move();
            }



            
        
        }
    }
}
