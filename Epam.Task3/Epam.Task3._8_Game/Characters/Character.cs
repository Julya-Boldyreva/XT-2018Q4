using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game.Characters
{
    public abstract class Character
    {
        protected string name;
        protected double xCoord;
        protected double yCoord;

        public abstract void Show();

        public abstract void Die();

        public abstract void MoveOn(double x, double y);
    }
}
