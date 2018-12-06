using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    class Hero
    {
        public string name;
        int x;
        int y;

        public Hero(string name)
        {
            this.name = name;
        }

        public void MoveTo(int x, int y);
        {
            if (x >= 0 && x < Game.Width)
	        {
                this.x = x;
	        }

            if (y >= 0 && y < Game.Height)
	        {
                this.y = y;
            }
        }

        public void MoveOn(int x, int y);
        {
            if (x < Game.Width)
	        {
                this.x += x;

            }

            if (y < Game.Height)
	        {
                this.y += y;
            }
        }
    }
}