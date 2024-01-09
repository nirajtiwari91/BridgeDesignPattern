using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class BridgeCircle :IShape //Implementation class
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Circle With Bridge Design Pattern");
        }
    }
}
