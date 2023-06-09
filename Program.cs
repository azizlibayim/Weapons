namespace Iwanttosleep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AWP awp = new AWP();
            AK47 ak47 = new AK47();
            P92 p92 = new P92();
            M4 m4 = new M4();

            try
            {
                awp.Shoot();
                awp.Reload();
                awp.Zoom();
                ak47.Shoot();
                ak47.Reload();
                p92.Shoot();
                p92.Shoot();
                p92.Reload();
                p92.Zoom();
                m4.Shoot();
                m4.Reload();
            }
            catch (InsufficientBulletException ex)
            { Console.WriteLine("Exception: " + ex.Message); }
            catch (InvalidBulletException ex)
            { Console.WriteLine("Exception: " + ex.Message); }
        }
    }
}

