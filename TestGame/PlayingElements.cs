using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    class PlayingElements
    {
        public int X { set; get; }
        public int Y { set; get; }
        public string NameOfElement { set; get; }

        public PlayingElements(int x, int y)
        {
            this.X = x;
            this.Y = y;
            NameOfElement = "";
        }
    }
}
