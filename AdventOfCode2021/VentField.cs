using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2021
{
    class VentField
    {
        public int[,] Positions;

        internal void Create(int width, int height)
        {
            Positions = new int[width, height];

            for (int col = 0; col < Positions.GetLength(0); col++)
            {
                for (int row = 0; row < Positions.GetLength(1); row++)
                {
                    Positions[col, row] = 0;
                }
            }
        }

        public void parseVeint(string veint)
        {
            string pos1 = veint.Split(" -> ")[0];
            string pos2 = veint.Split(" -> ")[1];

            int x1 = Convert.ToInt32(pos1.Split(",")[0]);
            int y1 = Convert.ToInt32(pos1.Split(",")[1]);
            int x2 = Convert.ToInt32(pos2.Split(",")[0]);
            int y2 = Convert.ToInt32(pos2.Split(",")[1]);

            int lowerX = Math.Min(x1, x2);
            int higherX = Math.Max(x1, x2);
            int lowerY = Math.Min(y1, y2);
            int higherY = Math.Max(y1, y2);

            if (x1 != x2 && y1 != y2)
            {
                // diagonal line

                bool topLeftToBottomRight = x1 < x2 && y1 < y2;
                bool topRightToBottomLeft = x1 > x2 && y1 < y2;
                bool bottomLeftToTopRight = x1 < x2 && y1 > y2;
                bool bottomRightToTopLeft = x1 > x2 && y1 > y2;

                if (topLeftToBottomRight)
                {
                    int counterX = x1;
                    int counterY = y1;
                    while (counterX <= x2 && counterY <= y2)
                    {
                        Positions[counterX, counterY]++;
                        counterX++;
                        counterY++;
                    }
                }
                else if (topRightToBottomLeft)
                {
                    int counterX = x1;
                    int counterY = y1;
                    while (counterX >= x2 && counterY <= y2)
                    {
                        Positions[counterX, counterY]++;
                        counterX--;
                        counterY++;
                    }
                }
                else if (bottomLeftToTopRight)
                {
                    // TODO
                    int counterX = x1;
                    int counterY = y1;
                    while (counterX <= x2 && counterY >= y2)
                    {
                        Positions[counterX, counterY]++;
                        counterX++;
                        counterY--;
                    }
                }
                else if (bottomRightToTopLeft)
                {
                    // TODO
                    int counterX = x1;
                    int counterY = y1;
                    while (counterX >= x2 && counterY >= y2)
                    {
                        Positions[counterX, counterY]++;
                        counterX--;
                        counterY--;
                    }
                }

                //int counterX = lowerX;
                //int counterY = lowerY;
                //while (counterX <= higherX && counterY <= higherY)
                //{
                //    Positions[counterX, counterY]++;
                //    counterX++;
                //    counterY++;
                //}
            }
            else if (x1 != x2)
            {
                // horizontal line
                for (int col = lowerX; col <= higherX; col++)
                {
                    Positions[col, y1]++;
                }
            }
            else if (y1 != y2)
            {
                // vertical line
                for (int row = lowerY; row <= higherY; row++)
                {
                    Positions[x1, row]++;
                }
            }
        }

        public void Print()
        {
            StringBuilder output = new StringBuilder();
            for (int row = 0; row < Positions.GetLength(1); row++)
            {
                for (int col = 0; col < Positions.GetLength(0); col++)
                {
                    if (Positions[col, row] == 0)
                        output.Append(".");
                    else
                        output.Append(Positions[col, row]);
                }

                output.Append("\n");
            }

            Console.WriteLine(output.ToString());
        }

        public int GetNumberOfOverlaps()
        {
            int result = 0;
            for (int col = 0; col < Positions.GetLength(0); col++)
            {
                for (int row = 0; row < Positions.GetLength(1); row++)
                {
                    if (Positions[col, row] > 1)
                        result++;
                }
            }

            return result;
        }
    }
}
