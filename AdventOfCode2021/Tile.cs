using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Cost { get; set; }
        public Tile Parent { get; set; }

        public override bool Equals(object obj)
        {
            Tile other = (Tile)obj;
            return X == other.X && Y == other.Y;
        }

        public static List<Tile> GetWalkableTiles(List<string> map, Tile currentTile, Tile targetTile)
        {
            var maxX = map.First().Length - 1;
            var maxY = map.Count - 1;
            var possibleTiles = new List<Tile>();

            if (currentTile.Y > 0)
                possibleTiles.Add(new Tile { X = currentTile.X, Y = currentTile.Y - 1, Parent = currentTile, Cost = currentTile.Cost + Convert.ToInt32(map[currentTile.Y - 1][currentTile.X].ToString()) });
            if (currentTile.Y < maxY)
                possibleTiles.Add(new Tile { X = currentTile.X, Y = currentTile.Y + 1, Parent = currentTile, Cost = currentTile.Cost + Convert.ToInt32(map[currentTile.Y + 1][currentTile.X].ToString()) });

            if (currentTile.X > 0)
                possibleTiles.Add(new Tile { X = currentTile.X - 1, Y = currentTile.Y, Parent = currentTile, Cost = currentTile.Cost + Convert.ToInt32(map[currentTile.Y][currentTile.X - 1].ToString()) });
            if (currentTile.X < maxX)
                possibleTiles.Add(new Tile { X = currentTile.X + 1, Y = currentTile.Y, Parent = currentTile, Cost = currentTile.Cost + Convert.ToInt32(map[currentTile.Y][currentTile.X + 1].ToString()) });

            return possibleTiles.ToList();
        }
    }
}
