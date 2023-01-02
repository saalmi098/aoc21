using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021
{
    public class BingoField
    {
        public Position[,] Board = new Position[5, 5];

        public void CreateField(params string[] rowValues)
        {
            int rowCounter = 0;
            foreach (string row in rowValues)
            {
                int[] numbers = row.Split(' ').Where(s => !string.IsNullOrWhiteSpace(s))
                    .Select(v => Convert.ToInt32(v.Trim())).ToArray();

                for (int i = 0; i < numbers.Length; i++)
                {
                    Board[rowCounter, i] = new Position() { Number = numbers[i], IsMarked = false };
                }

                rowCounter++;
            }
        }

        public void Print()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.ForegroundColor = Board[i, j].IsMarked ? ConsoleColor.Green : ConsoleColor.White;

                    Console.Write(Board[i, j].Number.ToString("00") + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        internal void MarkNumber(int gameNumber)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Board[i, j].Number == gameNumber)
                    {
                        Board[i, j].IsMarked = true;
                    }
                }
            }
        }

        internal bool HasWon()
        {
            List<bool> resultRows = new List<bool>();
            List<bool> resultCols = new List<bool>();

            for (int row = 0; row < 5; row++)
            {
                bool rowFinished = true;
                for (int col = 0; col < 5; col++)
                {
                    if (!Board[row, col].IsMarked)
                    {
                        rowFinished = false;
                        break;
                    }
                }

                resultRows.Add(rowFinished);
                if (rowFinished)
                    break;
            }

            for (int col = 0; col < 5; col++)
            {
                bool colFinished = true;
                for (int row = 0; row < 5; row++)
                {
                    if (!Board[row, col].IsMarked)
                    {
                        colFinished = false;
                        break;
                    }
                }

                resultCols.Add(colFinished);
                if (colFinished)
                    break;
            }

            return resultRows.Any(b => b == true) || resultCols.Any(b => b == true);
        }

        public int GetSumUnmarked()
        {
            int sum = 0;
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (!Board[row, col].IsMarked)
                    {
                        sum += Board[row, col].Number;
                    }
                }
            }

            return sum;
        }
    }

    public class Position
    {
        public int Number { get; set; }
        public bool IsMarked { get; set; }
    }
}
