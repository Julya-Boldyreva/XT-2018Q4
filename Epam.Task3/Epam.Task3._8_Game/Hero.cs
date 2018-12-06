using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    class Hero: IMovable, IShootable
    {
        public string name;
        int x;
        int y;

        public Hero()
        {
        }

        public void MoveIn(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void MoveTo(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}