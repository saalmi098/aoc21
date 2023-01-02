using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class GraphPoint
    {
        public static GraphPoint END = new GraphPoint("end");
        //public static List<List<GraphPoint>> Routes = new List<List<GraphPoint>>();
        public static HashSet<string> Routes = new HashSet<string>();

        public string Name { get; set; }
        public CaveType Type { get; }

        public List<GraphPoint> Neighbours { get; set; } = new List<GraphPoint>();

        public GraphPoint(string name)
        {
            Name = name;
            Type = name.ToLower() == name ? CaveType.Small : CaveType.Large;
        }

        public void Process(List<GraphPoint> route)
        {
            //Console.WriteLine("Process " + this.Name + "\t(current route: " + (string.Join(",", route.Select(r => r.Name))));

            route.Add(this);

            if (route.Contains(END))
            {
                Routes.Add(string.Join(",", route.Select(r => r.Name)));
                return;
            }

            bool anyNeighbourJumpable = false;
            foreach (var neighbour in Neighbours)
            {
                if (neighbour.IsJumpable(route, this))
                {
                    anyNeighbourJumpable = true;
                    neighbour.Process(new List<GraphPoint>(route));
                }
            }

            if (!anyNeighbourJumpable)
            {
                route.Remove(this);
            }
        }

        public bool IsJumpable(List<GraphPoint> route, GraphPoint caller)
        {
            if (Name == "start")
                return false;

            if (Name == "end")
                return true;

            // PART 1
            //if (Type == CaveType.Small && route.Contains(this))
            //    return false;

            // PART 2
            if (Type == CaveType.Small)
            {
                int countCave = route.Count(g => g.Name == this.Name);
                if (countCave >= 2)
                    return false;

                Dictionary<string, int> counter = new Dictionary<string, int>();
                foreach (var point in route.Where(g => g.Type == CaveType.Small && g.Name != this.Name))
                {
                    if (!counter.ContainsKey(point.Name))
                        counter.Add(point.Name, 0);

                    counter[point.Name]++;
                }

                if (counter.Any(e => e.Value >= 2) && countCave >= 1)
                    return false;
            }

            return true;
        }

        public override bool Equals(object obj)
        {
            GraphPoint other = (GraphPoint)obj;
            return this.Name == other.Name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public enum CaveType { Small, Large }
}
