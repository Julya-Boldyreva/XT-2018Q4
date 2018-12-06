using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    class Game
    {
        int width;
        int height;

        public static int Width
        {
            get
            {
                return this.width;
            }
        }

        public static int Height
        {
            get
            {
                return this.height;
            }
        }

        public Game(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

    }
}
