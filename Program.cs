using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Bridge Design Pattern
            IShape BridgeCircleobj = new BridgeCircle();
            IShape BridgeSquareobj = new BridgeSquare();

            //// Using the Bridge to draw a circle
            BridgeShape circleBridge = new BridgeShape(BridgeCircleobj);
            circleBridge.Draw();

            //// Using the Bridge to draw a square
            BridgeShape squareBridge = new BridgeShape(BridgeSquareobj);
            squareBridge.Draw();

            Console.ReadLine();


            //Circle circle = new Circle();
            //Square square = new Square();

            //// Drawing a circle
            //circle.DrawCircle();

            //// Drawing a square
            //square.DrawSquare();
            //Console.ReadLine();

        }
    }
}
