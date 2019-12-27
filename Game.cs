using System;

// Fahim's Game of Life thingy
namespace GameOfLife
{
    public class Game
    {
        private int Generation = 0;
        private int MaxGenerations;

        static int w;
        static int h;

        private bool[,] Cells;
        private Canvas _canvas;

        public void Start()
        {
            
            // Make a random canvas to start from
            Random generator = new Random();
            int number;
            for (int i = 0; i < h; i++) {
                for (int j = 0; j < w; j++) {
                    number = generator.Next(2);
                    Cells[i, j] = ((number != 0));
                }
            }
            
            _canvas.Draw(Cells);

            System.Threading.Thread.Sleep(100);
            Update();
        }

        public void Update()
        {
            while (Generation <= MaxGenerations)
            {
                Console.WriteLine("This is Generation : " + Generation);
                Cells = Calculate(Cells);
                _canvas.Draw(Cells);

                Generation++;
                System.Threading.Thread.Sleep(300);
            }
        }

        public bool[,] Calculate(bool[,] cells)
        {
            
            bool[,] activeCells = new bool[h,w];
            
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    bool currentCell = cells[i, j];

                    int n = _canvas.GetNeighbors(cells, j, i);

                    if ( ((n == 3 || n == 2) && currentCell) || (n == 3 && !currentCell))
                    {
                        activeCells[i,j] = true;
                    }
                    else
                    {
                        activeCells[i, j] = false;
                    }
                    
                }
            }

            return activeCells;
        }

        public Game(int width, int height, int maxGenerations)
        {
            w = width;
            h = height;
            MaxGenerations = maxGenerations;
            
            _canvas = new Canvas(width,height);
            Cells = new bool[height,width];
        }
    }
}