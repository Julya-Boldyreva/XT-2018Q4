using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    public interface IHero
    {
        void Shoot(double xCoord, double yCoord);

        void EatFruit();
    }
}
