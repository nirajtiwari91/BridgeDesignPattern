using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    public class BridgeShape : IShape //Abstraction class
    {
        private readonly IShape _shape;

        public BridgeShape(IShape shape)
        {
            _shape = shape;
        }

        public void Draw()
        {
            _shape.Draw();
        }
    }

}
