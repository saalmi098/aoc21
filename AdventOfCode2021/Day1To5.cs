using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2021
{
    public class Day1To5
    {
        //static void Day01_Part01()
        //{
        //    int previousValue = input[0];
        //    int countIncreased = 0;
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        if (input[i] > previousValue)
        //            countIncreased++;

        //        previousValue = input[i];
        //    }

        //    Console.WriteLine("Increased: " + countIncreased);
        //    Console.ReadLine();
        //}

        //static void Day01_Part02()
        //{
        //    int countIncreased = 0;
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        if (i + 3 >= input.Count)
        //            break;

        //        Measurement first = new Measurement();
        //        first.Measures.Add(input[i]);
        //        first.Measures.Add(input[i + 1]);
        //        first.Measures.Add(input[i + 2]);

        //        Measurement second = new Measurement();
        //        second.Measures.Add(input[i + 1]);
        //        second.Measures.Add(input[i + 2]);
        //        second.Measures.Add(input[i + 3]);

        //        if (second.Sum > first.Sum)
        //            countIncreased++;
        //    }

        //    Console.WriteLine("Increased: " + countIncreased);
        //    Console.ReadLine();
        //}

        //static void Day02_Part01()
        //{
        //    int posHorizontal = 0;
        //    int depth = 0;

        //    foreach (string line in input)
        //    {
        //        string[] parts = line.Split(' ');
        //        string command = parts[0];
        //        int value = Convert.ToInt32(parts[1]);

        //        if (command.Equals("forward"))
        //        {
        //            posHorizontal += value;
        //        }
        //        else if (command.Equals("down"))
        //        {
        //            depth += value;
        //        }
        //        else if (command.Equals("up"))
        //        {
        //            depth -= value;
        //        }
        //    }

        //    Console.WriteLine(depth * posHorizontal);
        //    Console.ReadKey();
        //}

        //static void Day02_Part02()
        //{
        //    int posHorizontal = 0;
        //    int depth = 0;
        //    int aim = 0;

        //    foreach (string line in input)
        //    {
        //        string[] parts = line.Split(' ');
        //        string command = parts[0];
        //        int value = Convert.ToInt32(parts[1]);

        //        if (command.Equals("forward"))
        //        {
        //            posHorizontal += value;
        //            depth += (aim * value);
        //        }
        //        else if (command.Equals("down"))
        //        {
        //            aim += value;
        //        }
        //        else if (command.Equals("up"))
        //        {
        //            aim -= value;
        //        }
        //    }

        //    Console.WriteLine(depth * posHorizontal);
        //    Console.ReadKey();
        //}

        //static void Day03_Part01()
        //{
        //    List<BinaryCounter> binaryCounters = new List<BinaryCounter>();
        //    for (int i = 0; i < 12; i++)
        //    {
        //        binaryCounters.Add(new BinaryCounter());
        //    }

        //    string currentSequence;
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        currentSequence = input[i];
        //        if (currentSequence.Length != 12)
        //        {
        //            Debug.Fail("length other than 12");
        //        }

        //        for (int j = 0; j < currentSequence.Length; j++)
        //        {
        //            binaryCounters[j].IncreaseCounter(currentSequence[j]);
        //        }
        //    }

        //    string gammaBin = string.Join("", binaryCounters.Select(b => b.GetMostCommon()));
        //    string epsilonBin = string.Join("", binaryCounters.Select(b => b.GetLeastCommon()));

        //    int gamma = Convert.ToInt32(gammaBin, 2);
        //    int epsilon = Convert.ToInt32(epsilonBin, 2);

        //    Console.WriteLine(gamma * epsilon);
        //    Console.ReadLine();
        //}

        //static void Day03_Part02()
        //{
        //    BinaryArray arrayOxygen = new BinaryArray();
        //    BinaryArray arrayCO2 = new BinaryArray();

        //    for (int line = 0; line < input.Count; line++)
        //    {
        //        arrayOxygen.AddRowValues(line, input[line].ToCharArray());
        //        arrayCO2.AddRowValues(line, input[line].ToCharArray());
        //    }

        //    // OXYGEN
        //    for (int col = 0; col < 12; col++)
        //    {
        //        char mostCommon = arrayOxygen.GetMostCommon(col);

        //        if (mostCommon == 'E')
        //        {
        //            // gleiche Anzahl
        //            arrayOxygen.Values.RemoveAll(v => v[col] != '1');
        //        }
        //        else
        //        {
        //            arrayOxygen.Values.RemoveAll(v => v[col] != mostCommon);
        //        }

        //        //Console.WriteLine("\n\n" + arrayOxygen.ToString());

        //        if (arrayOxygen.Values.Count == 1)
        //            break;
        //    }

        //    // CO2 TODO
        //    for (int col = 0; col < 12; col++)
        //    {
        //        char leastCommon = arrayCO2.GetLeastCommon(col);

        //        if (leastCommon == 'E')
        //        {
        //            // gleiche Anzahl
        //            arrayCO2.Values.RemoveAll(v => v[col] != '0');
        //        }
        //        else
        //        {
        //            arrayCO2.Values.RemoveAll(v => v[col] != leastCommon);
        //        }

        //        //Console.WriteLine("\n\n" + arrayCO2.ToString());

        //        if (arrayCO2.Values.Count == 1)
        //            break;
        //    }

        //    if (arrayOxygen.Values.Count > 1 || arrayCO2.Values.Count > 1)
        //    {
        //        Debug.Fail("multiple values found");
        //    }

        //    int oxygen = Convert.ToInt32(new string(arrayOxygen.Values[0]), 2);
        //    int c02scrubber = Convert.ToInt32(new string(arrayCO2.Values[0]), 2);
        //    Console.WriteLine(oxygen * c02scrubber);
        //    Console.ReadLine();
        //}

        //static void Day04_Part01()
        //{
        //    int[] gameNumbers = input[0].Split(',').Select(v => Convert.ToInt32(v)).ToArray();
        //    List<BingoField> fields = new List<BingoField>();

        //    for (int fieldStartLine = 2; fieldStartLine < input.Count; fieldStartLine += 6)
        //    {
        //        BingoField field = new BingoField();
        //        field.CreateField(input[fieldStartLine], input[fieldStartLine + 1], input[fieldStartLine + 2], input[fieldStartLine + 3], input[fieldStartLine + 4]);
        //        fields.Add(field);
        //    }

        //    foreach (int gameNumber in gameNumbers)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Next number: " + gameNumber);
        //        Console.ForegroundColor = ConsoleColor.White;

        //        BingoField winner = Day04_Part01_Play(fields, gameNumber);
        //        if (winner != null)
        //        {
        //            Console.WriteLine("Winner found!");
        //            Console.WriteLine("Sum: " + (winner.GetSumUnmarked() * gameNumber));
        //            break;
        //        }
        //    }

        //    Console.ReadLine();
        //}

        //static BingoField Day04_Part01_Play(List<BingoField> fields, int gameNumber)
        //{
        //    foreach (var field in fields)
        //    {
        //        field.MarkNumber(gameNumber);
        //        field.Print();

        //        if (field.HasWon())
        //        {
        //            return field;
        //        }
        //    }

        //    return null;
        //}

        //public static void Day04_Part02(List<string> input)
        //{
        //    int[] gameNumbers = input[0].Split(',').Select(v => Convert.ToInt32(v)).ToArray();
        //    List<BingoField> fields = new List<BingoField>();
        //    Dictionary<BingoField, bool> fieldsWon = new Dictionary<BingoField, bool>();

        //    for (int fieldStartLine = 2; fieldStartLine < input.Count; fieldStartLine += 6)
        //    {
        //        BingoField field = new BingoField();
        //        field.CreateField(input[fieldStartLine], input[fieldStartLine + 1], input[fieldStartLine + 2], input[fieldStartLine + 3], input[fieldStartLine + 4]);
        //        fields.Add(field);
        //        fieldsWon.Add(field, false);
        //    }

        //    BingoField last = null;

        //    foreach (int gameNumber in gameNumbers)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Red;
        //        Console.WriteLine("Next number: " + gameNumber);
        //        Console.ForegroundColor = ConsoleColor.White;

        //        // play gameNumber
        //        Day04_Part02_Play(fields, gameNumber, fieldsWon);

        //        if (fieldsWon.Count(e => e.Value == false) == 1)
        //        {
        //            // last player found -> save and wait until he finishes
        //            last = fieldsWon.Where(e => e.Value == false).First().Key;
        //        }

        //        if (last != null && last.HasWon())
        //        {
        //            Console.WriteLine("Last found!");
        //            Console.WriteLine("Sum: " + (last.GetSumUnmarked() * gameNumber));
        //            break;
        //        }
        //    }

        //    Console.ReadLine();
        //}

        //static void Day04_Part02_Play(List<BingoField> fields, int gameNumber, Dictionary<BingoField, bool> fieldsWon)
        //{
        //    foreach (var field in fields)
        //    {
        //        field.MarkNumber(gameNumber);
        //        //field.Print();

        //        if (field.HasWon())
        //        {
        //            fieldsWon[field] = true;
        //        }
        //    }
        //}

        //static void Day05_Part01()
        //{
        //    // find field size
        //    int width = -1;
        //    int height = -1;

        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        if (input[i].Contains("989"))
        //            ;

        //        string pos1 = input[i].Split(" -> ")[0];
        //        string pos2 = input[i].Split(" -> ")[1];

        //        int x1 = Convert.ToInt32(pos1.Split(",")[0]);
        //        int y1 = Convert.ToInt32(pos1.Split(",")[1]);
        //        int x2 = Convert.ToInt32(pos2.Split(",")[0]);
        //        int y2 = Convert.ToInt32(pos2.Split(",")[1]);

        //        if (Math.Max(x1, x2) > width)
        //            width = Math.Max(x1, x2);

        //        if (Math.Max(y1, y2) > height)
        //            height = Math.Max(y1, y2);
        //    }

        //    width++;
        //    height++;
        //    VentField field = new VentField();
        //    field.Create(width, height);

        //    // parse input
        //    for (int i = 0; i < input.Count; i++)
        //    {
        //        field.parseVeint(input[i]);
        //    }

        //    field.Print();
        //    Console.WriteLine("Overlaps: " + field.GetNumberOfOverlaps());
        //    Console.ReadLine();
        //}
    }
}
