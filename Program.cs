
using System;
using System.Collections.Generic;

using Kappa.Data;
using Kappa.Actors;

namespace Kappa.Main
{
    public static class Program
    {
        public static void Main()
        {
            var state = new State();
            state.Keyboard = new Keyboard();
            var director = new Director(state);  

            director.RunActors();
        }
    
/*        private static void Render(IEnumerable<Point> ps)
        {
            var maxH = Console.BufferHeight;
            var maxW = Console.BufferWidth;
            Console.Clear();
            foreach( var p in ps )
            {
                var x = p.X + _x;
                var y = p.Y + _y;
                if ( x >= 0 && x < maxW && y >= 0 && y < maxH )
                {
                    Console.SetCursorPosition( p.X + _x, p.Y + _y );
                    Console.Write('X');
                }
            }
        }*/
    }
}

