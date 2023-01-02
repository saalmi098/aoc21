using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    class Program
    {
        const string DAY = "20";
        const bool useExample = false;

        //static List<int> input = new List<int>();
        public static List<string> input = new List<string>();

        static void Main(string[] args)
        {
            string inp = "day" + DAY + "_input.txt";

            if (useExample)
                inp = "day" + DAY + "_input_example2.txt";

            using (StreamReader sr = new StreamReader(inp))
            {
                while (sr.Peek() != -1)
                {
                    input.Add(sr.ReadLine());
                }
            }

            Day20();

            Console.ReadLine();
        }

        public static string Day16_inputBits;
        static void Day16_Part01()
        {
            string inputHex = input[0];
            Day16_inputBits = Packet.HexToBinary(inputHex);
            Console.WriteLine("Input: " + inputHex + "\nBinary: " + Day16_inputBits);
            Console.WriteLine("-----------");
            Packet packet = new Packet() { Level = 0 };
            packet.Process();

            Console.WriteLine("Sum: " + packet.GetSumVersionNumbersRecursive());
        }

        static void Day16_Part02()
        {
            string inputHex = input[0];
            Day16_inputBits = Packet.HexToBinary(inputHex);
            Console.WriteLine("Input: " + inputHex + "\nBinary: " + Day16_inputBits);
            Console.WriteLine("-----------");
            Packet packet = new Packet() { Level = 0 };
            packet.Process();

            Console.WriteLine("Value: " + packet.Value);
        }

        static void Day17_Part01()
        {
            int[] targetX = input[0].Substring(input[0].IndexOf("x=") + 2, input[0].IndexOf(",") - input[0].IndexOf("x=") - 2).Split("..").Select(s => Convert.ToInt32(s)).ToArray();
            int[] targetY = input[0].Substring(input[0].IndexOf("y=") + 2).Split("..").Select(s => Convert.ToInt32(s)).ToArray();

            int maxYPos = int.MinValue;
            int bestVelocityX = 0;
            int bestVelocityY = 0;

            for (int testX = 1; testX < 1000; testX++)
            {
                for (int testY = 1000; testY > 0; testY--)
                {
                    Probe probe = new Probe() { PosX = 0, PosY = 0, VelocityX = testX, VelocityY = testY };

                    int highestYPosThisRun = int.MinValue;

                    while (probe.PosX <= targetX[1] && probe.PosY >= targetY[0])
                    {
                        probe.PosX += probe.VelocityX;
                        probe.PosY += probe.VelocityY;
                        probe.VelocityY--;

                        if (probe.VelocityX > 0)
                            probe.VelocityX--;
                        else if (probe.VelocityX < 0)
                            probe.VelocityX++;

                        if (probe.PosY > highestYPosThisRun)
                        {
                            highestYPosThisRun = probe.PosY;
                        }

                        if (probe.PosX >= targetX[0] && probe.PosX <= targetX[1] && probe.PosY >= targetY[0] && probe.PosY <= targetY[1])
                        {
                            // target reached
                            if (highestYPosThisRun > maxYPos)
                            {
                                maxYPos = highestYPosThisRun;
                                bestVelocityX = testX;
                                bestVelocityY = testY;
                            }

                            break;
                        }
                    }
                }
            }

            Console.WriteLine("Result: highest Y pos: " + maxYPos + " (best velocity: " + bestVelocityX + ", " + bestVelocityY + ")");
        }

        static void Day17_Part02()
        {
            int[] targetX = input[0].Substring(input[0].IndexOf("x=") + 2, input[0].IndexOf(",") - input[0].IndexOf("x=") - 2).Split("..").Select(s => Convert.ToInt32(s)).ToArray();
            int[] targetY = input[0].Substring(input[0].IndexOf("y=") + 2).Split("..").Select(s => Convert.ToInt32(s)).ToArray();

            HashSet<string> initialVelocities = new HashSet<string>();

            for (int testX = 1; testX < targetX[1] + 1; testX++)
            {
                for (int testY = 1000; testY >= targetY[0]; testY--)
                {
                    Probe probe = new Probe() { PosX = 0, PosY = 0, VelocityX = testX, VelocityY = testY };

                    while (probe.PosX <= targetX[1] && probe.PosY >= targetY[0])
                    {
                        probe.PosX += probe.VelocityX;
                        probe.PosY += probe.VelocityY;
                        probe.VelocityY--;

                        if (probe.VelocityX > 0)
                            probe.VelocityX--;
                        else if (probe.VelocityX < 0)
                            probe.VelocityX++;

                        if (probe.PosX >= targetX[0] && probe.PosX <= targetX[1] && probe.PosY >= targetY[0] && probe.PosY <= targetY[1])
                        {
                            // target reached
                            initialVelocities.Add(testX + "," + testY);
                            break;
                        }
                    }
                }
            }

            List<string> sorted = initialVelocities.ToList().OrderBy(s => s).ToList();
            Console.WriteLine("Result: possible velocities: " + sorted.Count);
        }

        static void Day18_Part01()
        {
            List<Snailfish> snailfishes = new List<Snailfish>();
            foreach (var line in input)
            {
                snailfishes.Add(new Snailfish(line));
            }
        }

        static void Day20()
        {
            string algorithm = input[0];
            input.RemoveRange(0, 2);

            Dictionary<(int x, int y), char> inputImg = new Dictionary<(int, int), char>();

            for (int row = 0; row < input.Count; row++)
            {
                for (int col = 0; col < input[row].Length; col++)
                {
                    inputImg.Add((col, row), input[row][col]);
                }
            }

            int steps = 0;
            int outerBounds = 0;

            Dictionary<(int x, int y), char> outputImg = null;

            do
            {
                int minX = inputImg.Min(kv => kv.Key.x), minY = inputImg.Min(kv => kv.Key.y), maxX = inputImg.Max(kv => kv.Key.x), maxY = inputImg.Max(kv => kv.Key.y);
                char infiniteChar = steps % 2 == 0 ? '.' : '#'; // Only works with real input - example must use "." (quick and hacky solution)

                // extend map
                for (int x = minX - 1; x <= maxX + 1; x++)
                {
                    inputImg.Add((x, minY - 1), infiniteChar); // top row
                    inputImg.Add((x, maxY + 1), infiniteChar); // bottom row
                }
                for (int y = minY; y <= maxY; y++)
                {
                    inputImg.Add((minX - 1, y), infiniteChar); // left row
                    inputImg.Add((maxX + 1, y), infiniteChar); // right row
                }

                outputImg = inputImg.ToDictionary(entry => entry.Key, entry => entry.Value);

                StringBuilder sb = new StringBuilder();
                foreach (var item in inputImg)
                {
                    sb.Clear();
                    var x = item.Key.x;
                    var y = item.Key.y;

                    char leftNeighbour = default;
                    char rightNeighbour = default;
                    char topNeighbour = default;
                    char bottomNeighbour = default;
                    if (inputImg.ContainsKey((x - 1, y)))
                        leftNeighbour = inputImg[(x - 1, y)];
                    if (inputImg.ContainsKey((x + 1, y)))
                        rightNeighbour = inputImg[(x + 1, y)];
                    if (inputImg.ContainsKey((x, y - 1)))
                        topNeighbour = inputImg[(x, y - 1)];
                    if (inputImg.ContainsKey((x, y + 1)))
                        bottomNeighbour = inputImg[(x, y + 1)];

                    // top row
                    if (topNeighbour != default)
                    {
                        sb.Append(leftNeighbour != default ? inputImg[(x - 1, y - 1)] : infiniteChar);
                        sb.Append(topNeighbour);
                        sb.Append(rightNeighbour != default ? inputImg[(x + 1, y - 1)] : infiniteChar);
                    }
                    else
                    {
                        sb.Append(infiniteChar);
                        sb.Append(infiniteChar);
                        sb.Append(infiniteChar);
                    }

                    // middle row
                    sb.Append(leftNeighbour != default ? leftNeighbour : infiniteChar);
                    sb.Append(item.Value);
                    sb.Append(rightNeighbour != default ? rightNeighbour : infiniteChar);

                    // bottom row
                    if (bottomNeighbour != default)
                    {
                        sb.Append(leftNeighbour != default ? inputImg[(x - 1, y + 1)] : infiniteChar);
                        sb.Append(bottomNeighbour);
                        sb.Append(rightNeighbour != default ? inputImg[(x + 1, y + 1)] : infiniteChar);
                    }
                    else
                    {
                        sb.Append(infiniteChar);
                        sb.Append(infiniteChar);
                        sb.Append(infiniteChar);
                    }

                    string bin = sb.ToString().Replace(".", "0").Replace("#", "1");
                    int dec = Convert.ToInt32(bin, 2);

                    if (outputImg.ContainsKey((x, y)))
                        outputImg[(x, y)] = algorithm[dec];
                    else
                        outputImg.Add((x, y), algorithm[dec]);
                }

                steps++;
                outerBounds--;

                //Day20_Part01_Output(outputImg, minX, minY, maxX, maxY);

                inputImg = outputImg.ToDictionary(entry => entry.Key, entry => entry.Value);

            } while (steps < 50);

            if (outputImg != null)
            {
                Console.WriteLine("Lit pixels: " + outputImg.Count(kv => kv.Value == '#'));
            }
        }

        static void Day20_Output(Dictionary<(int x, int y), char> outputImg, int minX, int minY, int maxX, int maxY)
        {
            // output
            Console.WriteLine("\n\nLit pixels: " + outputImg.Select(i => i.Value).Count(c => c == '#'));
            Console.WriteLine("Boundaries: Min=[" + minX + ", " + minY + "] Max=[" + maxX + ", " + maxY + "]");

            var sorted = outputImg.ToList();
            sorted.Sort((k1, k2) =>
            {
                int res = k1.Key.y.CompareTo(k2.Key.y);
                if (res != 0)
                    return res;

                return k1.Key.x.CompareTo(k2.Key.x);
            });

            bool first = true;
            int lastRow = -1;
            foreach (var kv in sorted)
            {
                if (first)
                {
                    lastRow = kv.Key.y;
                    first = false;
                }

                if (lastRow != kv.Key.y)
                {
                    Console.WriteLine();
                    lastRow = kv.Key.y;
                }

                Console.Write(kv.Value.ToString());
            }
        }

        static void Day21_Part01()
        {
            int player1Pos = Convert.ToInt32(input[0].Last().ToString());
            int player2Pos = Convert.ToInt32(input[1].Last().ToString());
            int player1Score = 0;
            int player2Score = 0;

            bool player1Turn = true;
            bool player1Won = false;
            int diceRolled = 1;

            while (true)
            {
                int steps = 3 * (diceRolled + 1);
                if (player1Turn)
                {
                    for (int i = 0; i < steps; i++)
                    {
                        player1Pos++;

                        if (player1Pos > 10)
                            player1Pos = 1;
                    }

                    player1Score += player1Pos;
                    if (player1Score >= 1000)
                    {
                        player1Won = true;
                        break;
                    }
                }
                else
                {
                    for (int i = 0; i < steps; i++)
                    {
                        player2Pos++;

                        if (player2Pos > 10)
                            player2Pos = 1;
                    }

                    player2Score += player2Pos;
                    if (player2Score >= 1000)
                    {
                        player1Won = false;
                        break;
                    }
                }

                diceRolled += 3;
                player1Turn = !player1Turn;
            }

            Console.WriteLine("Dice: " + diceRolled + 2);
            Console.WriteLine("Player 1 Score: " + player1Score);
            Console.WriteLine("Player 2 Score: " + player2Score);
            int looserScore = player1Won ? player2Score : player1Score;
            Console.WriteLine("Result: " + ((diceRolled + 2) * looserScore));
        }

        static void Day22_Part01()
        {
            List<RebootCommand> commands = new List<RebootCommand>();
            foreach (var line in input)
            {
                string tmpLine = line;
                RebootCommand cmd = new RebootCommand();
                cmd.TurnOn = line.Split(" ")[0] == "on";
                tmpLine = tmpLine.Substring(line.Split(" ")[0].Length + 1);

                string[] parts = tmpLine.Split(",");
                string fromTo = parts[0].Substring(2);
                cmd.FromX = Convert.ToInt32(fromTo.Split("..")[0]);
                cmd.ToX = Convert.ToInt32(fromTo.Split("..")[1]);

                fromTo = parts[1].Substring(2);
                cmd.FromY = Convert.ToInt32(fromTo.Split("..")[0]);
                cmd.ToY = Convert.ToInt32(fromTo.Split("..")[1]);

                fromTo = parts[2].Substring(2);
                cmd.FromZ = Convert.ToInt32(fromTo.Split("..")[0]);
                cmd.ToZ = Convert.ToInt32(fromTo.Split("..")[1]);

                if (cmd.FromX < -50 || cmd.FromY < -50 || cmd.FromZ < -50 || cmd.ToX > 50 || cmd.ToY > 50 || cmd.ToZ > 50)
                    continue;

                commands.Add(cmd);
            }

            Dictionary<string, RebootCube> cubes = new Dictionary<string, RebootCube>();

            foreach (var cmd in commands)
            {
                string coord;
                for (int x = cmd.FromX; x <= cmd.ToX; x++)
                {
                    for (int y = cmd.FromY; y <= cmd.ToY; y++)
                    {
                        for (int z = cmd.FromZ; z <= cmd.ToZ; z++)
                        {
                            coord = x + ";" + y + ";" + z;
                            if (!cubes.ContainsKey(coord))
                                cubes.Add(coord, new RebootCube() { PosX = x, PosY = y, PosZ = z });
                        }
                    }
                }

                var affectedCubes = cubes.Values.Where(c => c.PosX >= cmd.FromX && c.PosX <= cmd.ToX
                    && c.PosY >= cmd.FromY && c.PosY <= cmd.ToY
                    && c.PosZ >= cmd.FromZ && c.PosZ <= cmd.ToZ);

                foreach (var cube in affectedCubes)
                {
                    cube.TurnedOn = cmd.TurnOn;
                }
            }

            long result = cubes.Values.Count(c => c.TurnedOn);
            Console.WriteLine("Turned on: " + result);
        }

        static void Day24_Part01()
        {
            var variables = new Dictionary<string, int>() { { "x", 0 }, { "y", 0 }, { "z", 0 }, { "w", 0 } };

            foreach (var line in input)
            {
                string command = line.Split(" ")[0];
                string variable = line.Split(" ")[1];
                string parm = "";
                if (line.Split(" ").Length > 2)
                    parm = line.Split(" ")[2];

                if (!variables.ContainsKey(variable))
                    variables.Add(variable, 0);

                int value;
                switch (command)
                {
                    case "inp":
                        // TODO Stdin lesen
                        break;
                    case "add":
                        if (!int.TryParse(parm, out value))
                            value = variables[parm];

                        variables[variable] += value;

                        break;
                    case "mul":
                        if (!int.TryParse(parm, out value))
                            value = variables[parm];

                        variables[variable] *= value;

                        break;
                    case "div":
                        if (!int.TryParse(parm, out value))
                            value = variables[parm];

                        if (value == 0)
                        {
                            Console.WriteLine("div by 0!");
                            break;
                        }

                        double result = Math.Floor((double)(variables[variable] /= value));
                        variables[variable] *= Convert.ToInt32(result);
                        break;
                    case "mod":
                        if (!int.TryParse(parm, out value))
                            value = variables[parm];

                        if (variables[variable] < 0 || value <= 0)
                        {
                            Console.WriteLine("invalid mod!");
                            break;
                        }

                        variables[variable] %= value;

                        break;
                    case "eql":
                        if (!int.TryParse(parm, out value))
                            value = variables[parm];

                        variables[variable] = (variables[variable] == value) ? 1 : 0;

                        break;
                }
            }
            Console.WriteLine("done");
        }

        static void Day25_Part01()
        {
            char[,] map = new char[input.Count, input[0].Length];

            for (int row = 0; row < input.Count; row++)
            {
                for (int col = 0; col < input[row].Length; col++)
                {
                    map[row, col] = input[row][col];
                }
            }

            int stepCounter = 0;

            List<Tuple<int, int>> moved = new List<Tuple<int, int>>();

            while (true)
            {
                moved.Clear();
                char[,] mapCopy = map.Clone() as char[,];

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        if (map[row, col] == '>' && !moved.Contains(new Tuple<int, int>(row, col)))
                        {
                            if (col == map.GetLength(1) - 1)
                            {
                                if (mapCopy[row, 0] == '.')
                                {
                                    map[row, col] = '.';
                                    map[row, 0] = '>';
                                    moved.Add(new Tuple<int, int>(row, 0));
                                }
                            }
                            else if (mapCopy[row, col + 1] == '.')
                            {
                                map[row, col] = '.';
                                map[row, col + 1] = '>';
                                moved.Add(new Tuple<int, int>(row, col + 1));
                            }
                        }
                    }
                }

                mapCopy = map.Clone() as char[,];

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        if (map[row, col] == 'v' && !moved.Contains(new Tuple<int, int>(row, col)))
                        {
                            if (row == map.GetLength(0) - 1)
                            {
                                if (mapCopy[0, col] == '.')
                                {
                                    map[row, col] = '.';
                                    map[0, col] = 'v';
                                    moved.Add(new Tuple<int, int>(0, col));
                                }
                            }
                            else if (mapCopy[row + 1, col] == '.')
                            {
                                map[row, col] = '.';
                                map[row + 1, col] = 'v';
                                moved.Add(new Tuple<int, int>(row + 1, col));
                            }
                        }
                    }
                }

                stepCounter++;
                Console.WriteLine("Step " + stepCounter + " processed");

                if (moved.Count == 0)
                {
                    // stuck

                    Console.WriteLine("\nAfter step " + stepCounter);
                    for (int row = 0; row < map.GetLength(0); row++)
                    {
                        for (int col = 0; col < map.GetLength(1); col++)
                        {
                            Console.Write(map[row, col]);
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Result - Step " + stepCounter);
                    break;
                }
            }
        }
    }
}