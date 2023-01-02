using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class DisplayDigit
    {
        public int ID { get; set; }

        public string[] Signals { get; set; }

        // PositionsID zu möglichen Signalen
        public Dictionary<int, HashSet<char>> SignalPositions { get; set; } = new Dictionary<int, HashSet<char>>();

        public int NumberOfSignals => Signals.Length;

        public void AddSignalPosition(int pos, char signal)
        {
            if (SignalPositions.ContainsKey(pos))
            {
                SignalPositions[pos].Add(signal);
            }
            else
            {
                SignalPositions.Add(pos, new HashSet<char>() { signal });
            }
        }

        public void RemoveSignalPosition(int pos, char signal)
        {
            if (SignalPositions.ContainsKey(pos))
            {
                SignalPositions[pos].Remove(signal);
            }
        }

        public HashSet<char> GetPossibleSignals(int pos)
        {
            if (!SignalPositions.ContainsKey(pos))
                Debug.Fail("Pos " + pos + " not found");

            return SignalPositions[pos];
        }

        public char GetResolvedSignal(int pos)
        {
            if (!SignalPositions.ContainsKey(pos))
                Debug.Fail("Pos " + pos + " not found");

            if (SignalPositions[pos].Count != 1)
                Debug.Fail("None or multiple resolved signals found");

            return SignalPositions[pos].First();
        }

        public HashSet<char> GetAllResolvedSignals()
        {
            HashSet<char> result = new HashSet<char>();
            foreach (HashSet<char> set in SignalPositions.Values)
            {
                if (set.Count == 1)
                {
                    result.Add(set.First());
                }
            }

            return result;
        }
    }
}
