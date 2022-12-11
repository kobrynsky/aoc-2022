namespace aoc_2022.day_02;

public class Day02
{
    public static Dictionary<(char, char), int> RoundResult1 = new()
    {
        { ('A', 'X'), 1 + 3 },
        { ('A', 'Y'), 2 + 6 },
        { ('A', 'Z'), 3 + 0 },
        
        { ('B', 'X'), 1 + 0 },
        { ('B', 'Y'), 2 + 3 },
        { ('B', 'Z'), 3 + 6 },
        
        { ('C', 'X'), 1 + 6 },
        { ('C', 'Y'), 2 + 0 },
        { ('C', 'Z'), 3 + 3 },
    };
    
    public static Dictionary<(char, char), int> RoundResult2 = new()
    {
        { ('A', 'X'), 3 + 0 },
        { ('A', 'Y'), 1 + 3 },
        { ('A', 'Z'), 2 + 6 },
        
        { ('B', 'X'), 1 + 0 },
        { ('B', 'Y'), 2 + 3 },
        { ('B', 'Z'), 3 + 6 },
        
        { ('C', 'X'), 2 + 0 },
        { ('C', 'Y'), 3 + 3 },
        { ('C', 'Z'), 1 + 6 },
    };


    //(1 for A/X Rock, 2 for B/Y Paper, and 3 C/Z for Scissors)
    //(0 if you lost, 3 if the round was a draw, and 6 if you won).
    public static void Solve_01()
    {
        //var lines = File.ReadAllLines("day02.txt");
        int maxPoints = 0;
        
        using (StreamReader reader = new StreamReader("day02.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null) {
                maxPoints += RoundResult1[(line[0], line[2])];
            }
        }

        Console.WriteLine($"Day 02 - 1: {maxPoints}");
    }
    
    public static void Solve_02()
    {
        int maxPoints = 0;
        
        using (StreamReader reader = new StreamReader("day02.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null) {
                maxPoints += RoundResult2[(line[0], line[2])];
            }
        }

        Console.WriteLine($"Day 02 - 2: {maxPoints}");
    }
}