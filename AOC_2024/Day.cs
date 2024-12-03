namespace AOC_2024;

public abstract class Day : IDay
{
    private int DayNumber { get; }
    protected List<string> Inputs { get; } = [];

    protected Day(int dayNumber)
    {
        DayNumber = dayNumber;
        ReadInput();
    }

    public abstract int CalcPartOne();
    public abstract int CalcPartTwo();

    public void Run()
    {
        Console.WriteLine($"Answer of part one of day {DayNumber}: {CalcPartOne()}");
        Console.WriteLine($"Answer of part two of day {DayNumber}: {CalcPartTwo()}");
    }

    private void ReadInput()
    {
        using StreamReader sr = new StreamReader($"../../../{DayNumber}/day_{DayNumber}.txt");

        while (sr.ReadLine() is { } line) 
        {
            line = line.Trim(); 
            
            if (!string.IsNullOrEmpty(line))
            {
                Inputs.Add(line);
            }
        }
    }
}