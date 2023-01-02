using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021
{
    internal class Packet
    {
        public long PacketVersion { get; set; }
        public long TypeId { get; set; }
        public string LengthTypeId { get; set; }

        public bool IsLiteral => TypeId == 4;

        public List<Packet> subPackets;

        public long Value { get; set; }
        public int Length { get; set; }
        public int Level { get; set; }

        public Packet()
        {
            PacketVersion = BinaryToDecimal(readAndRemoveNextBits(3));
            TypeId = BinaryToDecimal(readAndRemoveNextBits(3));
            Value = -1;
            subPackets = new List<Packet>();

            if (!IsLiteral)
            {
                LengthTypeId = readAndRemoveNextBits(1);
            }
        }

        public void Process()
        {
            Console.WriteLine(getTabs() + "Processing: PacketVersion=" + PacketVersion + ", TypeID=" + TypeId + ", IsLiteral=" + IsLiteral + ", IsOperator=" + !IsLiteral
                + (!IsLiteral ? ", LengthTypeId=" + LengthTypeId : ""));

            if (IsLiteral)
            {
                // literal
                string outputBinary = "";

                while (true)
                {
                    string prefixBit = readAndRemoveNextBits(1);
                    outputBinary += readAndRemoveNextBits(4);
                    if (prefixBit == "0")
                    {
                        break;
                    }
                }

                Value = BinaryToDecimal(outputBinary);
                Console.WriteLine(getTabs() + "literal value: " + Value);
            }
            else
            {
                // operator
                if (LengthTypeId == "0")
                {
                    // Länge der Subpackets in Bits (nächsten 15 Bits)
                    long totalLengthSubPackets = BinaryToDecimal(readAndRemoveNextBits(15));
                    Console.WriteLine(getTabs() + "length sub packets: " + totalLengthSubPackets);

                    int currentLengthSubPackets = 0;
                    while (currentLengthSubPackets < totalLengthSubPackets)
                    {
                        Packet sub = new Packet() { Level = this.Level + 1};
                        this.subPackets.Add(sub);
                        sub.Process();
                        currentLengthSubPackets += sub.GetLengthRecursive();
                    }
                }
                else if (LengthTypeId == "1")
                {
                    // Anzahl der direkten Subpackets (nächsten 11 Bits)
                    long countChildren = BinaryToDecimal(readAndRemoveNextBits(11));

                    for (int childIndex = 0; childIndex < countChildren; childIndex++)
                    {
                        Packet sub = new Packet() { Level = this.Level + 1 };
                        this.subPackets.Add(sub);
                        sub.Process();
                    }
                }

                // ...all sub-packets processed -> calculate value of operator packet
                switch(this.TypeId)
                {
                    case 0:
                        // sum
                        this.Value = this.subPackets.Sum(sub => sub.Value);
                        break;

                    case 1:
                        // product
                        if (this.subPackets.Count == 1)
                            this.Value = this.subPackets[0].Value;
                        else
                        {
                            long res = -1;
                            foreach (var sub in subPackets)
                            {
                                if (res == -1)
                                    res = sub.Value;
                                else
                                    res *= sub.Value;
                            }
                            Value = res;
                        }
                        break;

                    case 2:
                        // minimum
                        Value = subPackets.Min(sub => sub.Value);
                        break;

                    case 3:
                        // maximum
                        Value = subPackets.Max(sub => sub.Value);
                        break;

                    case 5:
                        // greater than
                        Value = (subPackets[0].Value > this.subPackets[1].Value) ? 1 : 0;
                        break;

                    case 6:
                        // less than
                        Value = (subPackets[0].Value < this.subPackets[1].Value) ? 1 : 0;
                        break;

                    case 7:
                        // equal
                        Value = (subPackets[0].Value == this.subPackets[1].Value) ? 1 : 0;
                        break;

                    default:
                        Debug.Fail("unknown type id");
                        break;
                }
            }
        }

        public long GetSumVersionNumbersRecursive()
        {
            long result = this.PacketVersion;
            foreach (var sub in subPackets)
            {
                result += sub.GetSumVersionNumbersRecursive();
            }

            return result;
        }

        private string getTabs()
        {
            string tabs = "";
            for (int i = 0; i < Level; i++)
            {
                tabs += "  ";
            }
            return tabs;
        }

        private int GetLengthRecursive()
        {
            int result = this.Length;
            foreach (var sub in subPackets)
            {
                result += sub.GetLengthRecursive();
            }

            return result;
        }

        public static string HexToBinary(string hex)
        {
            return String.Join(String.Empty, hex.Select(c => Convert.ToString(Convert.ToInt64(c.ToString(), 16), 2).PadLeft(4, '0')));
        }

        public static long BinaryToDecimal(string bin)
        {
            return Convert.ToInt64(bin, 2);
        }

        private string readAndRemoveNextBits(int count)
        {
            string bin = Program.Day16_inputBits.Substring(0, count);
            Program.Day16_inputBits = Program.Day16_inputBits.Remove(0, count);
            Length += count;
            return bin;
        }
    }
}
