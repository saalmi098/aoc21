using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class Snailfish
    {
        public string InputString { get; set; }
        public Pair Master { get; set; }

        public Snailfish(string inputString)
        {
            InputString = inputString;
            Master = new Pair();
            Master.Parse(InputString);
        }
    }

    internal class Pair
    {
        public string InputString { get; set; }
        public Item Item1 { get; set; }
        public Item Item2 { get; set; }

        public Pair()
        {
        }

        public void Parse(string input)
        {
            bool passedSeparator = false; // true, wenn "," bereits gefunden wurde
            bool isFirstLoop = true;

            foreach (char c in input)
            {
                if (c.ToString() == "[")
                {
                    // new pair

                    if (isFirstLoop)
                    {
                        // äußerstes Pair überspringen
                        continue;
                    }

                    if (!passedSeparator)
                    {
                        // item 1
                        Item i = new Item() { Pair = new Pair(), Type = ItemType.Pair };
                        //i.Pair.Parse(); // TODO AS Substring mitgeben oder verarbeiteten Teil aus Original-String löschen
                    }
                    else
                    {
                        // item 2
                    }
                }
                else if (c.ToString() == ",")
                {
                    // pair separator
                    passedSeparator = true;
                }
                else if (c.ToString() == "]")
                {
                    // end pair
                }
                else
                {
                    // regular number
                    Item i = new Item() { Number = Convert.ToInt32(c.ToString()), Type = ItemType.Number };

                    if (!passedSeparator)
                        this.Item1 = i;
                    else
                        this.Item2 = i;
                }

                isFirstLoop = false;
            }
        }
    }

    internal class Item
    {
        public ItemType Type { get; set; }
        public int Number { get; set; }
        public Pair Pair { get; set; }
    }

    internal enum ItemType
    {
        Number, Pair
    }
}
