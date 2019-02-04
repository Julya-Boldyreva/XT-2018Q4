using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    public class Hero : Characters.Character, IHero
    {
        public int FruitsEaten;

        public Hero(string name, double xCoord, double yCoord)
        {
            this.name = name;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public override void Show()
        {
        }

        public override void Die()
        {
        }

        public override void MoveOn(double x, double y)
        {
        }

        public void Shoot(double xCoord, double yCoord)
        {
        }

        public void EatFruit()
        {
        }
    }
}