namespace aoc_2022.day_01;

public class Day01
{
    public static void Solve_01()
    {
        var lines = File.ReadAllLines("day01.txt");
        int currentEqValue = 0;
        int maxEqValue = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                maxEqValue = currentEqValue > maxEqValue
                    ? currentEqValue
                    : maxEqValue;

                currentEqValue = 0;
            }
            else
            {
                currentEqValue += Int32.Parse(line);
            }
        }

        Console.WriteLine($"Day 01 - 1: {maxEqValue}");
    }
    
    public static void Solve_02()
    {
        var lines = File.ReadAllLines("day01.txt");
        int currentEqValue = 0;
        int firstMax = 0;
        int secondMax = 0;
        int thridMax = 0;

        foreach (var line in lines)
        {
            if (string.IsNullOrEmpty(line))
            {
                if (currentEqValue > firstMax)
                {
                    thridMax = secondMax;
                    secondMax = firstMax;
                    firstMax = currentEqValue;
                }
                else if (currentEqValue > secondMax)
                {
                    thridMax = secondMax;
                    secondMax = currentEqValue;
                }
                else if (currentEqValue > thridMax)
                {
                    thridMax = currentEqValue;
                }
                
                currentEqValue = 0;
            }
            else
            {
                currentEqValue += Int32.Parse(line);
            }
        }

        Console.WriteLine($"Day 01 - 2: {firstMax + secondMax + thridMax}");
    }
}