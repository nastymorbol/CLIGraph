using System;
using System.Linq;
using System.Threading;

namespace CLIGraphPlotter.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 80;
            int height = 40;
            
            if(!int.TryParse(args.ElementAtOrDefault(0), out width)) width = 80;
            if(!int.TryParse(args.ElementAtOrDefault(1), out height)) height = 40;

            CLIGraphPlotter pltr = new CLIGraphPlotter(width, height / 2);
            CLIGraphPlotter pltr2 = new CLIGraphPlotter(width, height / 2, 0, height / 2 + 1);

            Console.Clear();
            var random = new Random();
            while (true)
            {
                Console.CursorVisible = false;
                pltr.Update(random.NextDouble() * 100.0);
                pltr2.Update(random.NextDouble() * 100.0);
                Console.CursorVisible = true;
                Thread.Sleep(250);
            }
        }
    }
}
