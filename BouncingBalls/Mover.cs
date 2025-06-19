using System;
using System.Drawing;
using System.Numerics;

namespace BouncingBalls
{
    class Mover
    {
        static Random rnd = new Random();
        Vector2 location;
        Vector2 Velocity;

        //constructor method
        public Mover(int x, int y)
        {
            location = new Vector2(rnd.Next(x),rnd.Next(y));
            Velocity = new Vector2(rnd.Next(-10, 11), rnd.Next(-10,11));
        }

        public void Update()
        {
            Velocity.X = rnd.Next(-10, 11);
            Velocity.Y = rnd.Next(-10, 11);
            location = Vector2.Add(Velocity, location);
        }
        public void Display(Graphics e)
        {
            e.FillEllipse(Brushes.Aquamarine, location.X, location.Y, 100, 100);
        }
    }

}
