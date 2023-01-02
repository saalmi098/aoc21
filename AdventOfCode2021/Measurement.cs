using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    class Measurement
    {
        public List<int> Measures { get; set; } = new List<int>();

        public int Sum => Measures.Sum();
    }
}
