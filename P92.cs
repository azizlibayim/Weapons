using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iwanttosleep
{
    public class P92 : Gun, IZoom
    {
        public P92() : base(60, 60)
        {
            try
            {
                if (CurrentBulletCount <= 0)
                {
                    throw new InvalidBulletException();
                }
                if (CurrentBulletCount > TotalBulletCount)
                {
                    throw new InvalidBulletException();
                }
                if (CurrentBulletCount == 0)
                {
                    throw new InsufficientBulletException();
                }
            }
            catch (InvalidBulletException ex)
            { Console.WriteLine("Exception: " + ex.Message); }

        }

        public override void Shoot()
        {
            try
            {
                if (CurrentBulletCount > 1)
                    CurrentBulletCount = CurrentBulletCount - 1;
                Console.WriteLine("P92 shooting...");
                Console.WriteLine(CurrentBulletCount + "bullets left");
            }
            catch (InsufficientBulletException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }

        public override void Reload()
        {
            CurrentBulletCount = TotalBulletCount;
            Console.WriteLine("P92 Reloading...");
            Console.WriteLine("Reloaded, Current Bullet count is: " + CurrentBulletCount);
        }
        public void Zoom()
        {
            Console.WriteLine("P92 is zooming...");
        }

    }
}
