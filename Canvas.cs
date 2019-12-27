using System;
using System.Linq;

namespace GameOfLife
{
    public class Canvas
    {
        private int width;
        private int height;

        
        public void Draw(bool[,] cells)
        {
            Console.Clear();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    bool currentCell = cells[i, j];
                    
                    Console.Write(currentCell ? "\u2588" : "\u2592");
                    if (j == width - 1) Console.WriteLine("\r");
                }
            }
            
            Console.WriteLine("\r");
        }
        
        public int GetNeighbors(bool[,] cells, int x, int y) {
            int NumOfAliveNeighbors = 0;

            for (int i = x - 1; i < x + 2; i++) {
                for (int j = y - 1; j < y + 2; j++) {
                    if (!((i < 0 || j < 0) || (i >= height || j >= width))) {
                        if (cells[i, j] == true) NumOfAliveNeighbors++;
                    }
                }
            }
            return NumOfAliveNeighbors;
        }
        
        public Canvas(int w, int h)
        {
            width = w;
            height = h;
        }
    }
}