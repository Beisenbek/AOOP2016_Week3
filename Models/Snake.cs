using Example1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1.Models
{
    public class Snake:Drawer
    {
        public Snake()
        {

        }

        public Snake(char sign, ConsoleColor color):base(sign,color)
        {
        }

        public void Move(int dx, int dy)
        {

            for(int i = body.Count - 1; i > 0; --i)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (Game.snake.body[0].x == Game.food.body[0].x &&
               Game.snake.body[0].y == Game.food.body[0].y)
            {
                Game.snake.body.Add(new Point
                {
                    x = Game.food.body[0].x,
                    y = Game.food.body[0].y
                });

                Game.food.body[0].x = new Random().Next(0, 48);
                Game.food.body[0].y = new Random().Next(0, 48);
            }
        }
    }
}
