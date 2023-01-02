using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2021
{
    class Octopus
    {
        public static HashSet<Octopus> flashedOctopus = new HashSet<Octopus>();
        public static int flashCounter = 0;

        public int Row { get; set; }
        public int Col { get; set; }
        public int Energy { get; set; }
        public HashSet<Octopus> Neighbours { get; set; } = new HashSet<Octopus>();

        public void SetNeighbours(Octopus[,] map)
        {
            bool hasLeftNeighbour = Col > 0;
            bool hasRightNeighbour = Col < map.GetLength(1) - 1;
            bool hasTopNeighbour = Row > 0;
            bool hasBottomNeighbour = Row < map.GetLength(0) - 1;

            if (hasLeftNeighbour)
            {
                Octopus neighbour = map[Row, Col - 1];
                this.Neighbours.Add(neighbour); // Nachbar links setzen
                neighbour.Neighbours.Add(this); // am linken Nachbar rechts setzen
            }
            if (hasTopNeighbour)
            {
                Octopus neighbour = map[Row - 1, Col];
                this.Neighbours.Add(neighbour); // Nachbar oben setzen
                neighbour.Neighbours.Add(this); // am oberen Nachbar unten setzen
            }
            if (hasTopNeighbour && hasLeftNeighbour)
            {
                Octopus neighbour = map[Row - 1, Col - 1];
                this.Neighbours.Add(neighbour);
                neighbour.Neighbours.Add(this);
            }
            if (hasTopNeighbour && hasRightNeighbour)
            {
                Octopus neighbour = map[Row - 1, Col + 1];
                this.Neighbours.Add(neighbour);
                neighbour.Neighbours.Add(this);
            }
        }

        public void Process(int step)
        {
            if (flashedOctopus.Contains(this))
                return;

            Energy++;

            if (Energy > 9)
            {
                Energy = 0;
                flashedOctopus.Add(this);
                flashCounter++;

                foreach (var neighbour in this.Neighbours)
                {
                    neighbour.Process(step);
                }
            }
        }

        public static void Print(Octopus[,] map)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Octopus o = map[row, col];
                    Console.ForegroundColor = flashedOctopus.Contains(o) ? ConsoleColor.Green : ConsoleColor.White;
                    Console.Write(o.Energy);
                }
                Console.WriteLine();
            }
        }

        public override bool Equals(object obj)
        {
            Octopus other = (Octopus)obj;
            return other.Col == this.Col && other.Row == this.Row;
        }
    }
}
