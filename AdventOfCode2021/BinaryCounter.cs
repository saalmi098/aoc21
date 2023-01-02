using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AdventOfCode2021
{
    public class BinaryCounter
    {
        int counter0 = 0;
        int counter1 = 0;

        public List<char> Values = new List<char>();

        public void IncreaseCounter(char binaryNumber)
        {
            if (binaryNumber == '0')
                counter0++;
            else if (binaryNumber == '1')
                counter1++;
            else
                Debug.Fail("unknown binary number");
        }

        //public char GetMostCommon()
        //{
        //    if (counter0 > counter1)
        //        return '0';
        //    else if (counter1 > counter0)
        //        return '1';
        //    else
        //        return 'E';
        //}

        //public char GetLeastCommon()
        //{
        //    if (counter0 < counter1)
        //        return '0';
        //    else if (counter1 < counter0)
        //        return '1';
        //    else
        //        return 'E';
        //}

        public char GetMostCommon()
        {
            int count0 = 0;
            int count1 = 0;

            foreach (int value in Values)
            {
                if (value == '0')
                    count0++;
                else if (value == '1')
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

        public char GetLeastCommon()
        {
            int count0 = 0;
            int count1 = 0;

            foreach (int value in Values)
            {
                if (value == '0')
                    count0++;
                else if (value == '1')
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

        public void DecreaseCounter(int value, char binaryNumber)
        {
            if (binaryNumber == '0')
                counter0 -= value;
            else if (binaryNumber == '1')
                counter1 -= value;
            else
                Debug.Fail("unknown binary number");
        }
    }
}
