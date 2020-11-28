using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    [Serializable()]
    class EmptyTile : Tile
    {
        public EmptyTile(int y, int x) : base(y, x)
        {
            
        }
    }
}
