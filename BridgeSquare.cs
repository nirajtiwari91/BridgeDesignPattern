using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class BridgeSquare: IShape //Implementation class
    {
        public void Draw()
        {
            Console.WriteLine("Drawing Square With Bridge Design Pattern");
        }    
    }
}
