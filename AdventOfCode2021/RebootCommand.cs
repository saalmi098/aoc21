using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class RebootCommand
    {
        public int FromX { get; set; }
        public int ToX { get; set; }
        public int FromY { get; set; }
        public int ToY { get; set; }
        public int FromZ { get; set; }
        public int ToZ { get; set; }

        public bool TurnOn { get; set; }
    }

    public class RebootCube
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int PosZ { get; set; }

        public bool TurnedOn { get; set; } = false;
    }
}
