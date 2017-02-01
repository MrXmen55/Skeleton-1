using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnightVSSkeleton
{
    class Knight: fighter
    {
        public Knight(PictureBox sprite) : base(sprite)
        {
            
        }

        protected override async void   Die()
        {
            base.Die();
            base.sprite.Image = Image.FromFile(@"C:\Users\Mrxmen55\Skeleton-1\Assets\Knight_Death.gif");
            await Task.Delay(900);
            sprite.Enabled = false;
        }

    }
}
