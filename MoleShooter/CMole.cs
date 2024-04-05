using MoleShooter.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoleShooter
{
    class CMole : CImageBase
    {

        private Rectangle _moleHotSpot = new Rectangle();

        public CMole()
            : base(Resources.Mole) 
        {
            _moleHotSpot.X = Left + 20;
            _moleHotSpot.Y = Top + 1;
            _moleHotSpot.Width = 30;
            _moleHotSpot.Height = 40;

        }


        public void Update(int x, int y)
        {
            Left = x;
            Top = y;
            _moleHotSpot.X = Left + 20;
            _moleHotSpot.Y = Top - 1;
        }

        public bool Hit(int x, int y) {
            Rectangle c = new Rectangle(x, y, 1, 1);

            if (_moleHotSpot.Contains(c))
            {
                return true;
            }
            return false;   
        }
    }
}
