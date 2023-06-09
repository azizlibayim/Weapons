using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iwanttosleep
{
    public abstract class Gun
    {


        public int TotalBulletCount { get; set; }
        public int CurrentBulletCount { get; set; }
        public abstract void Shoot();
        public abstract void Reload();
        public Gun(int totalbulletcount, int currentbulletcount)
        {
            TotalBulletCount = totalbulletcount;
            CurrentBulletCount = currentbulletcount;
            if (CurrentBulletCount <= 0)
            {
                throw new InvalidBulletException();
            }
            if (currentbulletcount > totalbulletcount)
            {
                throw new InvalidBulletException();
            }
            if (currentbulletcount == 0)
            {
                throw new InsufficientBulletException();
            }
        }
    }
}
public class InsufficientBulletException : Exception
{
    public InsufficientBulletException() : base("No bullets left!") { }
}
public class InvalidBulletException : Exception
{
    public InvalidBulletException() : base("Invalid input") { }
}


