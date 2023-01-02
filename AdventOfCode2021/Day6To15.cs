using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2021
{
    class Day6To15
    {
        //static void Day06_Part01()
        //{
        //    Dictionary<int, int> fishes = new Dictionary<int, int>();

        //    string[] inp = input[0].Split(",");
        //    for (int i = 0; i < inp.Length; i++)
        //    {
        //        fishes.Add(i, Convert.ToInt32(inp[i]));
        //    }

        //    int addNewFishes = 0;
        //    int totalDays = 256;

        //    for (int day = 1; day <= totalDays + 1; day++)
        //    {
        //        for (int n = 0; n < addNewFishes; n++)
        //        {
        //            fishes.Add(fishes.Count, 8);
        //        }
        //        addNewFishes = 0;

        //        //if (day == 1)
        //        //{
        //        //    Console.WriteLine("Initial state:\t" + string.Join(",", fishes.Select(e => e.Value)));
        //        //}
        //        //else
        //        //{
        //        //    Console.WriteLine("After " + (day - 1) + " days:\t" + string.Join(",", fishes.Select(e => e.Value)));
        //        //}

        //        for (int f = 0; f < fishes.Count; f++)
        //        {
        //            if (fishes[f] == 0)
        //            {
        //                // spawn
        //                addNewFishes++;
        //                fishes[f] = 6;
        //            }
        //            else
        //            {
        //                fishes[f]--;
        //            }
        //        }
        //    }

        //    //Console.WriteLine("After " + (totalDays) + " days:\t" + string.Join(",", fishes.Select(e => e.Value)));
        //    Console.WriteLine("Fish: " + fishes.Count);
        //    Console.ReadLine();
        //}

        //static void Day06_Part02()
        //{
        //    long[] fishes = new long[9];

        //    string[] inp = input[0].Split(",");
        //    for (int i = 0; i < inp.Length; i++)
        //    {
        //        int index = Convert.ToInt32(inp[i]);
        //        fishes[index]++;
        //    }

        //    int totalDays = 256;

        //    for (int day = 1; day <= totalDays; day++)
        //    {
        //        long fishes0 = fishes[0];

        //        for (int i = 0; i < fishes.Length - 1; i++)
        //        {
        //            if (i < 8)
        //            {
        //                fishes[i] = fishes[i + 1];
        //            }
        //        }

        //        fishes[6] += fishes0;
        //        fishes[8] = fishes0;
        //    }

        //    long sum = 0;
        //    foreach (var fish in fishes)
        //    {
        //        sum += fish;
        //    }
        //    Console.WriteLine("Fish: " + sum);
        //    Console.ReadLine();
        //}

        //static void Day07_Part01()
        //{
        //    int[] positions = new int[input[0].Split(",").Length];

        //    for (int i = 0; i < positions.Length; i++)
        //    {
        //        positions[i] = Convert.ToInt32(input[0].Split(",")[i]);
        //    }

        //    Array.Sort(positions);

        //    int minValue = positions.Min();
        //    int maxValue = positions.Max();

        //    int minFuel = Int32.MaxValue;
        //    int minFuelPos = -1;
        //    for (int testPos = minValue; testPos < maxValue; testPos++)
        //    {
        //        int fuelNeeded = 0;

        //        for (int i = 0; i < positions.Length; i++)
        //        {
        //            fuelNeeded += Math.Abs(positions[i] - testPos);
        //        }

        //        if (fuelNeeded < minFuel)
        //        {
        //            minFuel = fuelNeeded;
        //            minFuelPos = testPos;
        //        }
        //    }

        //    Console.WriteLine("Pos: " + minFuelPos + " - Fuel: " + minFuel);
        //    Console.ReadLine();
        //}

        //static void Day07_Part02()
        //{
        //    int[] positions = new int[input[0].Split(",").Length];

        //    for (int i = 0; i < positions.Length; i++)
        //    {
        //        positions[i] = Convert.ToInt32(input[0].Split(",")[i]);
        //    }

        //    Array.Sort(positions);

        //    int minValue = positions.Min();
        //    int maxValue = positions.Max();

        //    int minFuel = Int32.MaxValue;
        //    int minFuelPos = -1;
        //    for (int testPos = minValue; testPos < maxValue; testPos++)
        //    {
        //        int fuelNeeded = 0;

        //        for (int i = 0; i < positions.Length; i++)
        //        {
        //            int stepsNeeded = Math.Abs(positions[i] - testPos);
        //            for (int step = 1; step <= stepsNeeded; step++)
        //            {
        //                fuelNeeded += step;
        //            }
        //        }

        //        if (fuelNeeded < minFuel)
        //        {
        //            minFuel = fuelNeeded;
        //            minFuelPos = testPos;
        //        }
        //    }

        //    Console.WriteLine("Pos: " + minFuelPos + " - Fuel: " + minFuel);
        //    Console.ReadLine();
        //}

        //static void Day08_Part01()
        //{
        //    Dictionary<int, DisplayDigit> digits = new Dictionary<int, DisplayDigit>();
        //    digits.Add(1, new DisplayDigit() { ID = 1, Signals = new string[] { "c", "f" } });
        //    digits.Add(4, new DisplayDigit() { ID = 4, Signals = new string[] { "b", "c", "d", "f" } });
        //    digits.Add(7, new DisplayDigit() { ID = 7, Signals = new string[] { "a", "c", "f" } });
        //    digits.Add(8, new DisplayDigit() { ID = 8, Signals = new string[] { "a", "b", "c", "d", "e", "f", "g" } });

        //    int count = 0;
        //    for (int line = 0; line < input.Count; line++)
        //    {
        //        List<string> signalPatterns = new List<string>(); // für Teil2 (links von |)
        //        List<string> outputValues = new List<string>(); // 4 digit output values (rechts von |)

        //        string[] parts = input[line].Split(" | ");
        //        signalPatterns.AddRange(parts[0].Split(" "));
        //        outputValues.AddRange(parts[1].Split(" "));

        //        foreach (var outputValue in outputValues)
        //        {
        //            foreach (var digit in digits)
        //            {
        //                if (digit.Value.NumberOfSignals == outputValue.Length)
        //                    count++;
        //            }
        //        }
        //    }

        //    Console.WriteLine("Count: " + count);
        //    Console.ReadLine();
        //}

        //static void Day08_Part02()
        //{
        //    int sum = 0;
        //    for (int line = 0; line < input.Count; line++)
        //    {
        //        sum += Day08_Part02_ProcessLine(input[line]);
        //    }

        //    Console.WriteLine("Sum: " + sum);
        //    Console.ReadLine();
        //}

        //static int Day08_Part02_ProcessLine(string inputLine)
        //{
        //    List<SignalPattern> signalPatterns = new List<SignalPattern>();
        //    List<string> outputValues = new List<string>(); // 4 digit output values (rechts von |)

        //    string[] parts = inputLine.Split(" | ");
        //    signalPatterns.AddRange(parts[0].Split(" ").Select(v => new SignalPattern() { Pattern = v }));
        //    outputValues.AddRange(parts[1].Split(" "));

        //    // Master aufbauen (Ausgangs-8)
        //    DisplayDigit master = Day08_Part02_GetMaster(signalPatterns);

        //    // Zahlen aufbauen (0-9)
        //    List<DisplayDigit> digits = Day08_Part02_GetDigits(master);
        //    digits.Sort((d1, d2) => d1.GetAllResolvedSignals().Count.CompareTo(d2.GetAllResolvedSignals().Count));

        //    StringBuilder sb = new StringBuilder();

        //    foreach (var outputValue in outputValues)
        //    {
        //        bool digitFound = false;

        //        foreach (DisplayDigit digit in digits)
        //        {
        //            bool containsAll = true;
        //            foreach (var outputValueChar in outputValue)
        //            {
        //                if (!digit.GetAllResolvedSignals().Contains(outputValueChar))
        //                {
        //                    containsAll = false;
        //                    break;
        //                }
        //            }

        //            if (containsAll)
        //            {
        //                sb.Append(digit.ID);
        //                digitFound = true;
        //                break;
        //            }
        //        }

        //        if (digitFound)
        //        {
        //            continue;
        //        }

        //        if (!digitFound)
        //        {
        //            Debug.Fail("no digit found for " + outputValue);
        //        }
        //    }

        //    Console.WriteLine(sb.ToString());
        //    return Convert.ToInt32(sb.ToString());
        //}

        //static DisplayDigit Day08_Part02_GetMaster(List<SignalPattern> signalPatterns)
        //{
        //    DisplayDigit master = new DisplayDigit(); // Master = 8

        //    // ====== 1 finden (Length == 2) -> mögliche Pos: 3/6 (a/b) ======
        //    SignalPattern one = signalPatterns.First(s => s.Length == 2);
        //    if (one == null)
        //        Debug.Fail("signal pattern 1 not found");

        //    master.AddSignalPosition(3, one.Pattern[0]);
        //    master.AddSignalPosition(3, one.Pattern[1]);
        //    master.AddSignalPosition(6, one.Pattern[0]);
        //    master.AddSignalPosition(6, one.Pattern[1]);

        //    // ====== 7 finden (Length == 3) -> wir finden somit Pos. 1 (d) ======
        //    SignalPattern seven = signalPatterns.First(s => s.Length == 3);
        //    if (seven == null)
        //        Debug.Fail("signal pattern 7 not found");

        //    master.AddSignalPosition(1, seven.Pattern.Except(one.Pattern).First());
        //    //seven.ResolvedCharacter = seven.Pattern.Except(one.Pattern).First();
        //    signalPatterns.Remove(seven);

        //    // ====== 6 und 0/9 finden (Length == 6) ======
        //    // 6 => Zahl wo Pos. 3 (a/b) nicht vorkommt
        //    // 0/9 => andere Zahl
        //    List<SignalPattern> filter = signalPatterns.Where(s => s.Length == 6).ToList();
        //    if (filter.Count != 3)
        //        Debug.Fail("signal pattern 6/0/9 not found");

        //    SignalPattern six = null;
        //    foreach (var signal in filter)
        //    {
        //        bool containsAll = true;
        //        foreach (char c in one.Pattern)
        //        {
        //            if (!signal.Pattern.Contains(c))
        //            {
        //                containsAll = false;
        //                break;
        //            }
        //        }

        //        if (!containsAll)
        //        {
        //            six = signal;
        //            break;
        //        }
        //    }

        //    if (six == null)
        //        Debug.Fail("signal pattern 6 not found");

        //    // Pos. 3 = a, Pos. 6 = b setzen
        //    HashSet<char> intersect = six.Pattern.Intersect(master.GetPossibleSignals(3)).ToHashSet();
        //    if (intersect.Count > 1)
        //        Debug.Fail("multiple matches found for position 3/6");

        //    master.RemoveSignalPosition(6, one.Pattern.First(c => c != intersect.First())); // (Pos. 6: a löschen, b bleibt übrig)
        //    master.RemoveSignalPosition(3, one.Pattern.First(c => c == intersect.First())); // (Pos. 3: b löschen, a bleibt übrig)
        //    signalPatterns.Remove(six);

        //    // ====== 4 finden ======
        //    SignalPattern four = signalPatterns.First(s => s.Length == 4);
        //    if (four == null)
        //        Debug.Fail("signal pattern 4 not found");

        //    HashSet<char> except = four.Pattern.Except(master.GetAllResolvedSignals()).ToHashSet(); // (e/f)
        //    if (except.Count > 2)
        //        Debug.Fail("multiple matches found for position 2/4");

        //    foreach (var e in except)
        //    {
        //        // Pos. 2/4 = (e/f)
        //        master.AddSignalPosition(2, e);
        //        master.AddSignalPosition(4, e);
        //    }

        //    // 0/9 wieder aufgreifen
        //    filter = signalPatterns.Where(s => s.Length == 6).ToList();
        //    if (filter.Count != 2)
        //        Debug.Fail("multiple possibilities for 0/9 found");

        //    SignalPattern zero = null;
        //    foreach (var signal in filter)
        //    {
        //        bool containsAll = true;
        //        char charFound = ' ';
        //        foreach (char c in four.Pattern)
        //        {
        //            if (!signal.Pattern.Contains(c))
        //            {
        //                containsAll = false;
        //                charFound = c;
        //                break;
        //            }
        //        }

        //        if (!containsAll)
        //        {
        //            zero = signal;

        //            master.RemoveSignalPosition(2, charFound); // (Pos. 2: f löschen, e bleibt übrig)
        //            //master.RemoveSignalPosition(4, four.Pattern.First(c => !four.GetNotResolvedCharacters(master).Contains(c))); // (Pos. 4: e löschen, f bleibt übrig)
        //            master.RemoveSignalPosition(4, master.GetPossibleSignals(4).First(c => c != charFound)); // (Pos. 4: e löschen, f bleibt übrig)

        //            break;
        //        }
        //    }

        //    if (zero == null)
        //        Debug.Fail("signal pattern 0 not found");

        //    signalPatterns.Remove(zero);

        //    SignalPattern nine = filter.First(s => s != zero);
        //    if (nine == null)
        //        Debug.Fail("signal pattern 9 not found");

        //    signalPatterns.Remove(nine);

        //    // ====== 5 finden ======

        //    // 2,3,5 suchen
        //    filter = signalPatterns.Where(s => s.Length == 5).ToList();
        //    if (filter.Count != 3)
        //        Debug.Fail("multiple possibilities for 2/3/5 found");

        //    // 5 ist dort, wo Pos. 2 vorkommt (kennen wir bereits; 2 = e)
        //    SignalPattern five = filter.First(s => s.Pattern.Contains(master.GetPossibleSignals(2).First()));
        //    if (five == null)
        //        Debug.Fail("signal pattern 5 not found");

        //    // Pos. 7 finden - einziger Buchstabe der in der Zahl noch nicht verwendet wurde (7 = c) 
        //    master.AddSignalPosition(7, five.Pattern.First(c => !master.GetAllResolvedSignals().Contains(c)));
        //    signalPatterns.Remove(five);

        //    // Pos. 5 finden (letzte Position)
        //    SignalPattern eight = signalPatterns.First(s => s.Length == 7);
        //    if (eight == null)
        //        Debug.Fail("signal pattern 8 not found");
        //    master.AddSignalPosition(5, eight.Pattern.First(c => !master.GetAllResolvedSignals().Contains(c)));

        //    return master;
        //}

        //static List<DisplayDigit> Day08_Part02_GetDigits(DisplayDigit master)
        //{
        //    List<DisplayDigit> digits = new List<DisplayDigit>();

        //    DisplayDigit zero = new DisplayDigit { ID = 0 };
        //    zero.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    zero.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    zero.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    zero.AddSignalPosition(5, master.GetResolvedSignal(5));
        //    zero.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    zero.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit one = new DisplayDigit { ID = 1 };
        //    one.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    one.AddSignalPosition(6, master.GetResolvedSignal(6));

        //    DisplayDigit two = new DisplayDigit { ID = 2 };
        //    two.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    two.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    two.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    two.AddSignalPosition(5, master.GetResolvedSignal(5));
        //    two.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit three = new DisplayDigit { ID = 3 };
        //    three.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    three.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    three.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    three.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    three.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit four = new DisplayDigit { ID = 4 };
        //    four.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    four.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    four.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    four.AddSignalPosition(6, master.GetResolvedSignal(6));

        //    DisplayDigit five = new DisplayDigit { ID = 5 };
        //    five.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    five.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    five.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    five.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    five.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit six = new DisplayDigit { ID = 6 };
        //    six.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    six.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    six.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    six.AddSignalPosition(5, master.GetResolvedSignal(5));
        //    six.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    six.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit seven = new DisplayDigit { ID = 7 };
        //    seven.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    seven.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    seven.AddSignalPosition(6, master.GetResolvedSignal(6));

        //    DisplayDigit eight = new DisplayDigit { ID = 8 };
        //    eight.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    eight.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    eight.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    eight.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    eight.AddSignalPosition(5, master.GetResolvedSignal(5));
        //    eight.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    eight.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    DisplayDigit nine = new DisplayDigit { ID = 9 };
        //    nine.AddSignalPosition(1, master.GetResolvedSignal(1));
        //    nine.AddSignalPosition(2, master.GetResolvedSignal(2));
        //    nine.AddSignalPosition(3, master.GetResolvedSignal(3));
        //    nine.AddSignalPosition(4, master.GetResolvedSignal(4));
        //    nine.AddSignalPosition(6, master.GetResolvedSignal(6));
        //    nine.AddSignalPosition(7, master.GetResolvedSignal(7));

        //    digits.Add(zero);
        //    digits.Add(one);
        //    digits.Add(two);
        //    digits.Add(three);
        //    digits.Add(four);
        //    digits.Add(five);
        //    digits.Add(six);
        //    digits.Add(seven);
        //    digits.Add(eight);
        //    digits.Add(nine);

        //    return digits;
        //}

        //static void Day09_Part01()
        //{
        //    int[,] map = new int[input.Count, input[0].Length];

        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        for (int j = 0; j < input[i].Length; j++)
        //        {
        //            map[i, j] = Convert.ToInt32(input[i][j].ToString());
        //        }
        //    }

        //    List<int> result = new List<int>();

        //    for (int row = 0; row < map.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < map.GetLength(1); col++)
        //        {
        //            bool isLowerThanLeft = true;
        //            bool isLowerThanRight = true;
        //            bool isLowerThanTop = true;
        //            bool isLowerThanBottom = true;

        //            bool hasLeftNeighbour = col > 0;
        //            bool hasRightNeighbour = col < map.GetLength(1) - 1;
        //            bool hasTopNeighbour = row > 0;
        //            bool hasBottomNeighbour = row < map.GetLength(0) - 1;

        //            if (hasLeftNeighbour)
        //                isLowerThanLeft = map[row, col] < map[row, col - 1];
        //            if (hasRightNeighbour)
        //                isLowerThanRight = map[row, col] < map[row, col + 1];
        //            if (hasTopNeighbour)
        //                isLowerThanTop = map[row, col] < map[row - 1, col];
        //            if (hasBottomNeighbour)
        //                isLowerThanBottom = map[row, col] < map[row + 1, col];

        //            if (isLowerThanLeft && isLowerThanRight && isLowerThanTop && isLowerThanBottom)
        //                result.Add(map[row, col]);
        //        }
        //    }

        //    int sum = result.Sum() + result.Count;
        //    Console.WriteLine("Sum of risk levels: " + sum);
        //    Console.ReadLine();
        //}

        //static void Day09_Part02()
        //{
        //    HeightMapPos[,] map = new HeightMapPos[input.Count, input[0].Length];

        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        for (int j = 0; j < input[i].Length; j++)
        //        {
        //            map[i, j] = new HeightMapPos() { Height = input[i][j].ToString(), Row = i, Col = j, IsChecked = false };

        //            if (map[i, j].Height == "9")
        //                map[i, j].Height = "."; // 9 durch 0 ersetzen für bessere Lesbarkeit
        //        }
        //    }

        //    List<HeightMapBasin> basins = new List<HeightMapBasin>();

        //    for (int row = 0; row < map.GetLength(0); row++)
        //    {
        //        List<HeightMapPos> unresolved = new List<HeightMapPos>();

        //        for (int col = 0; col < map.GetLength(1); col++)
        //        {
        //            HeightMapPos pos = map[row, col];
        //            if (pos.Height == ".")
        //            {
        //                if (unresolved.Count > 0)
        //                {
        //                    HeightMapBasin basin = new HeightMapBasin();
        //                    foreach (var u in unresolved)
        //                    {
        //                        u.Basin = basin;
        //                        basin.Positions.Add(u);
        //                    }

        //                    basins.Add(basin);
        //                    unresolved.Clear();
        //                }

        //                continue;
        //            }

        //            HeightMapPos neighbourLeft = pos.GetNeighbour(map, Direction.Left);
        //            HeightMapPos neighbourTop = pos.GetNeighbour(map, Direction.Top);

        //            if (neighbourLeft != null && neighbourLeft.Basin != null && neighbourTop != null && neighbourTop.Basin != null
        //                && neighbourLeft.Basin != neighbourTop.Basin)
        //            {
        //                // 2 Nachbaren, mit unterschiedlichen Basin -> mergen (top wird gelöscht, left bleibt bestehen)
        //                HeightMapBasin leftBasin = neighbourLeft.Basin;
        //                HeightMapBasin topBasin = neighbourTop.Basin;

        //                foreach (var topBasinPos in topBasin.Positions)
        //                {
        //                    topBasinPos.Basin = leftBasin;
        //                    leftBasin.Positions.Add(topBasinPos);
        //                }

        //                basins.Remove(topBasin);
        //                topBasin = null;
        //            }

        //            if (neighbourLeft != null && neighbourLeft.Basin != null)
        //            {
        //                pos.Basin = neighbourLeft.Basin;
        //                pos.Basin.Positions.Add(pos);

        //                foreach (var u in unresolved)
        //                {
        //                    u.Basin = neighbourLeft.Basin;
        //                    neighbourLeft.Basin.Positions.Add(u);
        //                }

        //                unresolved.Clear();
        //            }
        //            else if (neighbourTop != null && neighbourTop.Basin != null)
        //            {
        //                pos.Basin = neighbourTop.Basin;
        //                pos.Basin.Positions.Add(pos);

        //                foreach (var u in unresolved)
        //                {
        //                    u.Basin = neighbourTop.Basin;
        //                    neighbourTop.Basin.Positions.Add(u);
        //                }

        //                unresolved.Clear();
        //            }
        //            else
        //            {
        //                unresolved.Add(pos);
        //            }
        //        }

        //        if (unresolved.Count > 0)
        //        {
        //            HeightMapBasin basin = new HeightMapBasin();
        //            foreach (var u in unresolved)
        //            {
        //                basin.Positions.Add(u);
        //                u.Basin = basin;
        //            }

        //            basins.Add(basin);
        //            unresolved.Clear();
        //        }
        //    }

        //    basins.Sort((b1, b2) => b2.Positions.Count.CompareTo(b1.Positions.Count));
        //    List<HeightMapBasin> largest = new List<HeightMapBasin>() { basins[0], basins[1], basins[2] };

        //    for (int i = 0; i < map.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < map.GetLength(1); j++)
        //        {
        //            HeightMapPos pos = map[i, j];

        //            if (basins.Any(b => b.Positions.Contains(pos)))
        //                Console.ForegroundColor = ConsoleColor.Green;
        //            else
        //                Console.ForegroundColor = ConsoleColor.White;

        //            Console.Write(map[i, j].Height);
        //        }
        //        Console.WriteLine();
        //    }

        //    int result = basins[0].Positions.Count * basins[1].Positions.Count * basins[2].Positions.Count;

        //    Console.WriteLine("Result: " + result);
        //    Console.ReadLine();
        //}

        //static void Day10_Part01()
        //{
        //    Dictionary<char, char> validPairs = new Dictionary<char, char>()
        //    {
        //        { '(', ')' }, { '[', ']' }, { '{', '}' }, { '<', '>' },
        //    };

        //    HashSet<char> startElements = new HashSet<char>() { '(', '[', '{', '<' };
        //    HashSet<char> endElements = new HashSet<char>() { ')', ']', '}', '>' };
        //    List<char> illegal = new List<char>();

        //    for (int row = 0; row < input.Count; row++)
        //    {
        //        Stack<char> stack = new Stack<char>();

        //        string line = input[row];

        //        for (int col = 0; col < line.Length; col++)
        //        {
        //            char @char = line[col];
        //            if (startElements.Contains(@char))
        //            {
        //                stack.Push(@char);
        //            }
        //            else if (endElements.Contains(@char))
        //            {
        //                char popped = stack.Pop();

        //                if (validPairs[popped] != @char)
        //                {
        //                    illegal.Add(@char);
        //                    break;
        //                }
        //            }
        //        }

        //        Console.WriteLine(stack.Count);

        //    }

        //    int sum = 0;
        //    foreach (var c in illegal)
        //    {
        //        if (c == ')')
        //            sum += 3;
        //        else if (c == ']')
        //            sum += 57;
        //        else if (c == '}')
        //            sum += 1197;
        //        else if (c == '>')
        //            sum += 25137;
        //        else
        //            Debug.Fail("unknown char: " + c);
        //    }

        //    Console.WriteLine("Sum: " + sum);
        //}

        //static void Day10_Part02()
        //{
        //    Dictionary<char, char> validPairs = new Dictionary<char, char>()
        //    {
        //        { '(', ')' }, { '[', ']' }, { '{', '}' }, { '<', '>' },
        //    };

        //    HashSet<char> startElements = new HashSet<char>() { '(', '[', '{', '<' };
        //    HashSet<char> endElements = new HashSet<char>() { ')', ']', '}', '>' };

        //    // find and remove corrupted rows
        //    List<string> removeRows = new List<string>();
        //    for (int row = 0; row < input.Count; row++)
        //    {
        //        Stack<char> stack = new Stack<char>();

        //        string line = input[row];

        //        for (int col = 0; col < line.Length; col++)
        //        {
        //            char @char = line[col];
        //            if (startElements.Contains(@char))
        //            {
        //                stack.Push(@char);
        //            }
        //            else if (endElements.Contains(@char))
        //            {
        //                char popped = stack.Pop();

        //                if (validPairs[popped] != @char)
        //                {
        //                    removeRows.Add(line);
        //                    break;
        //                }
        //            }
        //        }
        //    }

        //    foreach (string r in removeRows)
        //    {
        //        input.Remove(r);
        //    }

        //    // complete incomplete rows
        //    List<long> rowScores = new List<long>();
        //    for (int row = 0; row < input.Count; row++)
        //    {
        //        Stack<char> stack = new Stack<char>();

        //        string line = input[row];

        //        for (int col = 0; col < line.Length; col++)
        //        {
        //            char @char = line[col];
        //            if (startElements.Contains(@char))
        //            {
        //                stack.Push(@char);
        //            }
        //            else if (endElements.Contains(@char))
        //            {
        //                char popped = stack.Pop();

        //                if (validPairs[popped] != @char)
        //                    Debug.Fail("should not happen");
        //            }
        //        }

        //        long score = 0;
        //        StringBuilder added = new StringBuilder();
        //        while (stack.Count > 0)
        //        {
        //            char startEl = stack.Pop();
        //            char endEl = validPairs[startEl];
        //            added.Append(endEl);

        //            int toAdd = 0;
        //            if (endEl == ')')
        //                toAdd = 1;
        //            else if (endEl == ']')
        //                toAdd = 2;
        //            else if (endEl == '}')
        //                toAdd = 3;
        //            else if (endEl == '>')
        //                toAdd = 4;
        //            else
        //                Debug.Fail("unknown char " + endEl);

        //            score = (score * 5) + toAdd;
        //        }

        //        rowScores.Add(score);
        //        Console.WriteLine("appended: " + added.ToString() + "\tscore: " + score);
        //    }

        //    rowScores.Sort();
        //    long result = rowScores[rowScores.Count / 2];
        //    Console.WriteLine("Result: " + result);
        //}

        //static void Day11_Part01()
        //{
        //    Octopus[,] map = new Octopus[input.Count, input[0].Length];

        //    for (int row = 0; row < input.Count; row++)
        //    {
        //        for (int col = 0; col < input[0].Length; col++)
        //        {
        //            Octopus o = new Octopus() { Row = row, Col = col, Energy = Convert.ToInt32(input[row][col].ToString()) };
        //            map[row, col] = o;
        //        }
        //    }

        //    foreach (var oct in map)
        //    {
        //        oct.SetNeighbours(map);
        //    }

        //    int steps = 100;
        //    int currentStep = 0;

        //    Console.WriteLine("Before any steps:");
        //    Octopus.Print(map);

        //    while (currentStep < steps)
        //    {
        //        Octopus.flashedOctopus.Clear();

        //        foreach (var oct in map)
        //        {
        //            oct.Process(currentStep);
        //        }

        //        currentStep++;
        //        Console.WriteLine("\nAfter step {0}:", currentStep);
        //        Octopus.Print(map);
        //    }

        //    Console.WriteLine("Flashes: " + Octopus.flashCounter);
        //    Console.ReadLine();
        //}

        //static void Day11_Part02()
        //{
        //    Octopus[,] map = new Octopus[input.Count, input[0].Length];

        //    for (int row = 0; row < input.Count; row++)
        //    {
        //        for (int col = 0; col < input[0].Length; col++)
        //        {
        //            Octopus o = new Octopus() { Row = row, Col = col, Energy = Convert.ToInt32(input[row][col].ToString()) };
        //            map[row, col] = o;
        //        }
        //    }

        //    foreach (var oct in map)
        //    {
        //        oct.SetNeighbours(map);
        //    }

        //    int currentStep = 0;

        //    Console.WriteLine("Before any steps:");
        //    Octopus.Print(map);

        //    while (true)
        //    {
        //        if ((map.GetLength(0) * map.GetLength(1) == Octopus.flashedOctopus.Count))
        //        {
        //            break;
        //        }

        //        Octopus.flashedOctopus.Clear();

        //        foreach (var oct in map)
        //        {
        //            oct.Process(currentStep);
        //        }

        //        currentStep++;
        //    }

        //    Console.WriteLine("all flashed at: " + currentStep);
        //    Console.ReadLine();
        //}

        //static void Day12()
        //{
        //    // Unterschied zwischen Part01 und Part02 in GraphPoint.IsJumpable()

        //    Dictionary<string, GraphPoint> allGraphPoints = new Dictionary<string, GraphPoint>();

        //    foreach (string line in input)
        //    {
        //        string source = line.Split('-')[0];
        //        string dest = line.Split('-')[1];

        //        if (!allGraphPoints.ContainsKey(source))
        //        {
        //            GraphPoint p = new GraphPoint(source);
        //            allGraphPoints.Add(source, p);
        //        }
        //        if (!allGraphPoints.ContainsKey(dest))
        //        {
        //            GraphPoint p = new GraphPoint(dest);
        //            allGraphPoints.Add(dest, p);
        //        }

        //        allGraphPoints[source].Neighbours.Add(allGraphPoints[dest]);
        //        allGraphPoints[dest].Neighbours.Add(allGraphPoints[source]);
        //    }

        //    allGraphPoints["start"].Process(new List<GraphPoint>());

        //    List<List<GraphPoint>> toRemove = new List<List<GraphPoint>>();
        //    Console.WriteLine("Possible routes: " + GraphPoint.Routes.Count);

        //    //foreach (var route in GraphPoint.Routes.OrderBy(q => q))
        //    //{
        //    //    Console.WriteLine(route);
        //    //}

        //    Console.ReadLine();
        //}

        //static void Day13()
        //{
        //    List<Tuple<int, int>> dots = new List<Tuple<int, int>>();
        //    List<Tuple<char, int>> folds = new List<Tuple<char, int>>();

        //    foreach (var line in input)
        //    {
        //        if (line.StartsWith("fold"))
        //        {
        //            int index = line.IndexOf("=");
        //            folds.Add(new Tuple<char, int>(line[index - 1], Convert.ToInt32(line.Substring(index + 1))));
        //        }
        //        else if (!string.IsNullOrWhiteSpace(line))
        //        {
        //            int x = Convert.ToInt32(line.Split(",")[0]);
        //            int y = Convert.ToInt32(line.Split(",")[1]);
        //            dots.Add(new Tuple<int, int>(x, y));
        //        }
        //    }

        //    foreach (var fold in folds)
        //    {
        //        int foldPos = fold.Item2;
        //        Console.WriteLine("fold " + fold.Item1 + " at " + foldPos);

        //        List<Tuple<int, int>> toRemove = new List<Tuple<int, int>>();
        //        List<Tuple<int, int>> toAdd = new List<Tuple<int, int>>();
        //        if (fold.Item1 == 'x')
        //        {
        //            foreach (var dot in dots)
        //            {
        //                int y = dot.Item2;
        //                int oldX = dot.Item1;

        //                if (oldX < foldPos)
        //                    continue;

        //                int difference = oldX - foldPos;
        //                int newX = (foldPos) - difference;

        //                toRemove.Add(dot);
        //                Tuple<int, int> newDot = new Tuple<int, int>(newX, y);
        //                toAdd.Add(newDot);
        //            }
        //        }
        //        else if (fold.Item1 == 'y')
        //        {
        //            foreach (var dot in dots)
        //            {
        //                int x = dot.Item1;
        //                int oldY = dot.Item2;

        //                if (oldY < foldPos)
        //                    continue;

        //                int difference = oldY - foldPos;
        //                int newY = (foldPos) - difference;

        //                toRemove.Add(dot);
        //                Tuple<int, int> newDot = new Tuple<int, int>(x, newY);
        //                toAdd.Add(newDot);
        //            }
        //        }

        //        toAdd.ForEach(add => dots.Add(add));
        //        toRemove.ForEach(rem => dots.Remove(rem));
        //    }

        //    // Debug-Ausgaben
        //    int highestX = dots.Max(d => d.Item1);
        //    int highestY = dots.Max(d => d.Item2);

        //    char[,] map = new char[highestY + 1, highestX + 1];
        //    for (int i = 0; i < map.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < map.GetLength(1); j++)
        //        {
        //            map[i, j] = '.';
        //        }
        //    }

        //    List<string> skips = new List<string>();
        //    foreach (var dot in dots)
        //    {
        //        if (dot.Item1 < 0 || dot.Item2 < 0)
        //            skips.Add("skipped " + dot);
        //        else
        //        {
        //            map[dot.Item2, dot.Item1] = '#';
        //        }
        //    }

        //    for (int i = 0; i < map.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < map.GetLength(1); j++)
        //        {
        //            Console.Write(map[i, j]);
        //        }
        //        Console.WriteLine();
        //    }

        //    skips.ForEach(s => Console.WriteLine(s));
        //    Console.WriteLine(dots.Distinct().Count().ToString());
        //    Console.ReadLine();
        //}

        //static void Day14_Part01()
        //{
        //    string startString = input[0];
        //    Dictionary<string, string> insertRules = new Dictionary<string, string>();

        //    for (int i = 2; i < input.Count; i++)
        //    {
        //        string firstPart = input[i].Split(" -> ")[0];
        //        string secondPart = input[i].Split(" -> ")[1];
        //        insertRules.Add(firstPart, secondPart);
        //    }

        //    int totalSteps = 10;
        //    int currentStep = 0;

        //    StringBuilder tmpString = new StringBuilder();

        //    while (currentStep < totalSteps)
        //    {
        //        tmpString.Clear();

        //        for (int charPos = 0; charPos < startString.Length - 1; charPos++)
        //        {
        //            string pair = startString.Substring(charPos, 2);
        //            if (!insertRules.ContainsKey(pair))
        //                Console.WriteLine("pair " + pair + " not found!");

        //            tmpString.Append(pair[0].ToString());
        //            tmpString.Append(insertRules[pair]);
        //        }

        //        // letzten Char hinten anfügen
        //        tmpString.Append(startString.Last().ToString());
        //        currentStep++;
        //        //Console.WriteLine("After step " + currentStep + "\t: " + tmpString.ToString());
        //        startString = tmpString.ToString();
        //    }

        //    Dictionary<char, int> count = new Dictionary<char, int>();
        //    foreach (char c in startString)
        //    {
        //        if (!count.ContainsKey(c))
        //            count.Add(c, 0);

        //        count[c]++;
        //    }

        //    char mostCommon = count.OrderByDescending(p => p.Value).First().Key;
        //    char leastCommon = count.OrderByDescending(p => p.Value).Last().Key;
        //    Console.WriteLine("Most common: " + mostCommon + " (" + count[mostCommon]);
        //    Console.WriteLine("Least common: " + leastCommon + " (" + count[leastCommon]);
        //    Console.WriteLine("Result: " + (count[mostCommon] - count[leastCommon]));

        //    Console.ReadLine();
        //}

        //static void Day14_Part02()
        //{
        //    string startString = input[0];
        //    string lastChar = startString.Last().ToString();

        //    Dictionary<string, string> insertRules = new Dictionary<string, string>();
        //    Dictionary<string, long> pairCounter = new Dictionary<string, long>();
        //    HashSet<string> chars = new HashSet<string>();
        //    Dictionary<string, long> charCounter = new Dictionary<string, long>();
        //    Dictionary<string, long> increment = new Dictionary<string, long>();
        //    Dictionary<string, long> decrement = new Dictionary<string, long>();

        //    for (int i = 2; i < input.Count; i++)
        //    {
        //        string firstPart = input[i].Split(" -> ")[0];
        //        string secondPart = input[i].Split(" -> ")[1];
        //        insertRules.Add(firstPart, secondPart);

        //        pairCounter.Add(firstPart, 0);

        //        chars.Add(firstPart.Substring(0, 1));
        //        if (!charCounter.ContainsKey(firstPart.Substring(0, 1)))
        //            charCounter.Add(firstPart.Substring(0, 1), 0);
        //    }

        //    for (int charPos = 0; charPos < startString.Length - 1; charPos++)
        //    {
        //        string pair = startString.Substring(charPos, 2);
        //        pairCounter[pair]++;
        //    }

        //    int totalSteps = 40;
        //    int currentStep = 1;

        //    while (currentStep <= totalSteps)
        //    {
        //        foreach (var item in pairCounter)
        //        {
        //            string key = item.Key;
        //            if (pairCounter[key] > 0)
        //            {
        //                if (!decrement.ContainsKey(key))
        //                    decrement.Add(key, 0);
        //                decrement[key] += item.Value;

        //                string dictKey1 = key.Substring(0, 1) + insertRules[key];
        //                string dictKey2 = insertRules[key] + key.Substring(1, 1);

        //                if (!increment.ContainsKey(dictKey1))
        //                    increment.Add(dictKey1, 0);
        //                increment[dictKey1] += item.Value;

        //                if (!increment.ContainsKey(dictKey2))
        //                    increment.Add(dictKey2, 0);
        //                increment[dictKey2] += item.Value;
        //            }
        //        }

        //        foreach (var item in increment)
        //        {
        //            pairCounter[item.Key] += item.Value;
        //        }
        //        foreach (var item in decrement)
        //        {
        //            pairCounter[item.Key] -= item.Value;

        //            if (pairCounter[item.Key] < 0)
        //                Debug.Fail("less than zero");
        //        }
        //        increment.Clear();
        //        decrement.Clear();

        //        foreach (var item in chars)
        //        {
        //            long count = pairCounter.Where(p => p.Key.Substring(0, 1) == item).Sum(p => p.Value);
        //            charCounter[item] = count;
        //        }

        //        // Letzten Buchstaben hinzuzählen
        //        charCounter[lastChar]++;

        //        var sorted = charCounter.OrderBy(c => c.Value);

        //        Console.WriteLine("After step " + currentStep);

        //        foreach (var item in sorted)
        //        {
        //            Console.WriteLine(item.Key + " (" + item.Value + ")");
        //        }

        //        Console.WriteLine("least common element: " + sorted.First().Key + " (" + sorted.First().Value + ")");
        //        Console.WriteLine("most common element: " + sorted.Last().Key + " (" + sorted.Last().Value + ")");
        //        Console.WriteLine("Result: " + (sorted.Last().Value - sorted.First().Value));

        //        currentStep++;
        //    }
        //}

        //static void Day15_Part01()
        //{
        //    List<string> map = new List<string>(input);
        //    map.ForEach(l => Console.WriteLine(l));

        //    var start = new Tile() { X = 0, Y = 0 };
        //    var finish = new Tile() { X = map[0].Length - 1, Y = map.Count - 1 };
        //    //start.SetDistance(finish.X, finish.Y);

        //    var activeTiles = new List<Tile>(); // TODO activeTiles als sortierte Liste halten -> InsertionSort (orderBy entfernen)
        //    activeTiles.Add(start);
        //    var visitedTiles = new List<Tile>(); // TODO 2D Array

        //    while (activeTiles.Any())
        //    {
        //        var checkTile = activeTiles.OrderBy(x => x.Cost).First();
        //        activeTiles.Remove(checkTile);

        //        //
        //        // Check if we need to do stuff
        //        //

        //        // Check if this tile already has a cost associated with it ..
        //        if (visitedTiles.Contains(checkTile))
        //        {
        //            // ... if the current cost is already more than the cost of the stored tile ...
        //            var t = visitedTiles.First(c => c.Equals(checkTile));
        //            if (checkTile.Cost >= t.Cost)
        //            {
        //                // do no further processing
        //                continue;
        //            }
        //            // Update the stored tile's cost and parent
        //            t.Cost = checkTile.Cost;
        //            t.Parent = checkTile.Parent;
        //        }
        //        // Else add the current tile to the list
        //        else
        //        {
        //            visitedTiles.Add(checkTile);
        //        }

        //        //
        //        // Do stuff
        //        //

        //        activeTiles.AddRange(Tile.GetWalkableTiles(map, checkTile, finish));
        //    }


        //    // Destination reached
        //    Console.WriteLine("destination reached!");
        //    Console.WriteLine(visitedTiles.First(t => t.Equals(finish)).Cost);
        //}

        //static void Day15_Part02()
        //{
        //    List<string> enlargedMap = new List<string>(input);

        //    // map nach rechts vergrößern
        //    for (int iteration = 1; iteration <= 4; iteration++)
        //    {
        //        for (int i = 0; i < input.Count; i++)
        //        {
        //            StringBuilder sb = new StringBuilder();
        //            foreach (char c in input[i])
        //            {
        //                int originValue = Convert.ToInt32(c.ToString());
        //                int newValue = originValue + iteration;
        //                if (newValue > 9)
        //                    newValue -= 9;

        //                sb.Append(newValue);
        //            }

        //            //enlargedMap[i + (iteration * 10)] += sb.ToString();
        //            enlargedMap[i] += sb.ToString();
        //        }
        //    }

        //    // map nach unten vergrößern
        //    for (int iteration = 1; iteration <= 4; iteration++)
        //    {
        //        for (int i = 0; i < input.Count; i++)
        //        {
        //            StringBuilder sb = new StringBuilder();
        //            foreach (char c in enlargedMap[i])
        //            {
        //                int originValue = Convert.ToInt32(c.ToString());
        //                int newValue = originValue + iteration;
        //                if (newValue > 9)
        //                    newValue -= 9;

        //                sb.Append(newValue);
        //            }

        //            enlargedMap.Add(sb.ToString());
        //        }
        //    }

        //    List<string> map = new List<string>(enlargedMap);

        //    var start = new Tile() { X = 0, Y = 0 };
        //    var finish = new Tile() { X = map[0].Length - 1, Y = map.Count - 1 };

        //    var activeTiles = new PriorityQueue<Tile, int>();
        //    activeTiles.Enqueue(start, 0);
        //    Tile[,] visitedTiles = new Tile[map.Count, map[0].Length];

        //    for (int i = 0; i < visitedTiles.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < visitedTiles.GetLength(1); j++)
        //        {
        //            visitedTiles[i, j] = new Tile() { X = j, Y = i, Cost = -1, Parent = null };
        //        }
        //    }

        //    while (activeTiles.Count > 0)
        //    {
        //        var checkTile = activeTiles.Dequeue();

        //        //
        //        // Check if we need to do stuff
        //        //

        //        // Check if this tile already has a cost associated with it ..
        //        if (visitedTiles[checkTile.Y, checkTile.X].Cost != -1)
        //        //if (visitedTiles.Contains(checkTile))
        //        {
        //            // ... if the current cost is already more than the cost of the stored tile ...
        //            var t = visitedTiles[checkTile.Y, checkTile.X];
        //            if (checkTile.Cost >= t.Cost)
        //            {
        //                // do no further processing
        //                continue;
        //            }

        //            // Update the stored tile's cost and parent
        //            t.Cost = checkTile.Cost;
        //            t.Parent = checkTile.Parent;
        //        }
        //        // Else add the current tile to the list
        //        else
        //        {
        //            visitedTiles[checkTile.Y, checkTile.X] = checkTile;
        //        }

        //        //
        //        // Do stuff
        //        //

        //        foreach (var walkable in Tile.GetWalkableTiles(map, checkTile, finish))
        //        {
        //            activeTiles.Enqueue(walkable, walkable.Cost);
        //        }
        //    }

        //    // Destination reached
        //    Console.WriteLine("destination reached!");
        //    Console.WriteLine(visitedTiles[finish.Y, finish.X].Cost);
        //}
    }
}
