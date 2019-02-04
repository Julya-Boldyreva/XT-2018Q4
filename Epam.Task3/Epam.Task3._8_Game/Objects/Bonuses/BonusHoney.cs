using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task3._8_Game
{
    public class BonusHoney : Bonus
    {
        public BonusHoney(bool onField, double xCoord, double yCoord)
        {
            this.onField = onField;
            this.xCoord = xCoord;
            this.yCoord = yCoord;
        }

        public override void Show()
        {
        }
    }
}
