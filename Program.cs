using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, h, g;
            string _w, _h, _g;
            
            Console.WriteLine("Set the game height");
            _h = Console.ReadLine();
            Console.WriteLine("Set the game width");
            _w = Console.ReadLine();
            Console.WriteLine("Set the maximum number of generations");
            _g = Console.ReadLine();

            if (!Int32.TryParse(_w, out int numw))
            {
                Console.WriteLine("Failed setting Width. Perhaps you wrote a invalid number? Defaulting to 10.");
                w = 10;
            }
            else
            {
                w = numw;
            }

            if (!Int32.TryParse(_h, out int numh))
            {
                Console.WriteLine("Failed setting Height. Perhaps you wrote a invalid number? Defaulting to 10.");
                h = 10;
            }
            else
            {
                h = numh;
            }
            
            if (!Int32.TryParse(_g, out int numg))
            {
                Console.WriteLine("Failed setting The number of generations. Perhaps you wrote a invalid number? Defaulting to 10.");
                g = 10;
            }
            else
            {
                g = numg;
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            
            
            
            Game game = new Game(w,h, g);
            game.Start();
            
            Console.WriteLine("Press any key to close this window");
            Console.ReadKey();
        }
    }
}