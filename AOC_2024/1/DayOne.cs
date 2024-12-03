namespace AOC_2024._1;

public class DayOne(int dayNumber) : Day(dayNumber)
{
    public override int CalcPartOne()
    {
        var splitNumbers = Inputs.Select(x => x.Split("   ")).ToArray();
        
        var leftNumbers = splitNumbers.Select(x => x[0]).Select(int.Parse);
        var rightNumbers = splitNumbers.Select(x => x[1]).Select(int.Parse);
        var leftNumbersOrdered = leftNumbers.OrderBy(x => x);
        var rightNumbersOrdered = rightNumbers.OrderBy(x => x);
        var diffLeftRightNumbers = leftNumbersOrdered.Zip(rightNumbersOrdered, (x, y) => Math.Abs(y - x)).Sum();

        return diffLeftRightNumbers;
    }

    public override int CalcPartTwo()
    {
        var splitNumbers = Inputs.Select(x => x.Split("   ")).ToArray();
        
        var leftNumbers = splitNumbers.Select(x => x[0]).Select(int.Parse);
        var rightNumbers = splitNumbers.Select(x => x[1]).Select(int.Parse);

        var sumSimilarities =  leftNumbers
            .SelectMany(x => rightNumbers
                .Select(y => x.Equals(y) ? x : 0))
            .ToArray()
            .Sum();
        
        return sumSimilarities;
    }
}

// Learned:
// Using Math.Abs() to always receive a positive integer from a calculation between two numbers.
// Use Zip() to combine two sequences, transform the elements, and return a new element per sequence.
// Use SelectMany() to flatten resulting sequence, instead of resulting with An IEnumerable<IEnumerable> because of iterating over 2.