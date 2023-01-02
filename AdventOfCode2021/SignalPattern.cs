using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class SignalPattern
    {
        public string Pattern { get; set; }

        public int Length => Pattern.Length;

        //public List<char> PossibleCharacters { get; set; } = new List<char>();

        public HashSet<char> GetNotResolvedCharacters(DisplayDigit master)
        {
            return Pattern.Where(s => !master.GetAllResolvedSignals().Contains(s)).ToHashSet();
        }

        //public char ResolvedCharacter { get; set; } = ' ';

        //public bool IsResolved => ResolvedCharacter != ' ';

        //public char ResolvedCharacter
        //{
        //    get
        //    {
        //        if (PossibleCharacters.Count > 1)
        //            return '%';
        //        else
        //            return PossibleCharacters[0];
        //    }
        //    set
        //    {
        //        PossibleCharacters.Clear();
        //        PossibleCharacters.Add(value);
        //    }
        //}

        //public bool IsResolved => PossibleCharacters.Count == 1;
    }
}
