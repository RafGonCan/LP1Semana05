using System;
using Spectre.Console;
using SoGoodLib;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SoGoodClass.SoGoodMethod();
            CanvasImage image = new CanvasImage("tux.jpg");
            image.MaxWidth(20);

            if (args.Length >= 2)
            {
                image = new CanvasImage(args[0]);
                image.MaxWidth(Convert.ToInt32(args[1]));
            }
            AnsiConsole.Write(image);
        }
    }
}
