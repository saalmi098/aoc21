using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode2021
{
    class BinaryArray
    {
        public List<char[]> Values = new List<char[]>();

        public char[] GetRowValues(int rowIndex)
        {
            return Values[rowIndex];
        }

        public List<int> GetColumnValues(int index)
        {
            throw new NotImplementedException();
        }

        public void AddRowValues(int rowIndex, char[] values)
        {
            Values.Add(values);
        }

        public void RemoveRow(int index)
        {
            Values.RemoveAt(index);
        }

        public char GetMostCommon(int colIndex)
        {
            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < Values.Count; i++)
            {
                char c = Values[i][colIndex];

                if (c == '0')
                    count0++;
                else if (c == '1')
                    count1++;
                else
                    Debug.Fail("unknown value");
            }

            if (count0 > count1)
                return '0';
            else if (count1 > count0)
                return '1';
            else
                return 'E';
        }

        public char GetLeastCommon(int colIndex)
        {
            int count0 = 0;
            int count1 = 0;

            for (int i = 0; i < Values.Count; i++)
            {
                char c = Values[i][colIndex];

                if (c == '0')
                    count0++;
                else if (c == '1')
                    count1++;
                else
                    Debug.Fail("unknown value");
            }

            if (count0 < count1)
                return '0';
            else if (count1 < count0)
                return '1';
            else
                return 'E';
        }

        public override string ToString()
        {
            string output = "";
            for (int i = 0; i < Values.Count; i++)
            {
                for (int j = 0; j < Values[i].Length; j++)
                {
                    output += Values[i][j];
                }

                output += "\n";
            }

            return output;
        }
    }
}
