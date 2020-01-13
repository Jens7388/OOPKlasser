using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.Height = 40;
            box.Length = 60;
            box.Width = 20;
            box.CalculateVolume();
            box.CalculateSurface();
            box.PrintInfo();
            Console.ReadLine();
        }
    }
}

