using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode2021
{
    public enum Direction
    {
        Left, Top, Right, Bottom
    }

    public class HeightMapPos
    {
        public string Height { get; set; }

        public int Row { get; set; }

        public int Col { get; set; }

        public bool IsChecked { get; set; }
        public HeightMapBasin Basin { get; set; }

        public bool HasNeighbour(HeightMapPos[,] map, Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    return Col > 0;
                case Direction.Right:
                    return Col < map.GetLength(1) - 1;
                case Direction.Top:
                    return Row > 0;
                case Direction.Bottom:
                    return Row < map.GetLength(0) - 1;
            }

            return false;
        }

        public HeightMapPos GetNeighbour(HeightMapPos[,] map, Direction dir)
        {
            switch (dir)
            {
                case Direction.Left:
                    if (Col <= 0 || map[Row, Col - 1].Height == ".")
                        return null;
                    return map[Row, Col - 1];

                case Direction.Right:
                    if (Col >= map.GetLength(1) - 1 || map[Row, Col + 1].Height == ".")
                        return null;
                    return map[Row, Col + 1];

                case Direction.Top:
                    if (Row <= 0 || map[Row - 1, Col].Height == ".")
                        return null;
                    return map[Row - 1, Col];

                case Direction.Bottom:
                    if (Row >= map.GetLength(0) - 1 || map[Row + 1, Col].Height == ".")
                        return null;
                    return map[Row + 1, Col];
            }

            Debug.Fail("no neighbor found");
            return null;
        }

        public override string ToString()
        {
            return "[" + Row + ", " + Col + "]: " + Height;
        }

        public override bool Equals(object obj)
        {
            HeightMapPos other = (HeightMapPos)obj;
            return Row == other.Row && Col == other.Col;
        }
    }
}
