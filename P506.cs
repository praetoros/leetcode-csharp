namespace Problems;

public class P506
{
    public static void Run()
    {
        // Test Cases
        Console.WriteLine(string.Join(",", FindRelativeRanks([5,4,3,2,1])));
        Console.WriteLine(string.Join(",", FindRelativeRanks([10,3,8,9,4])));
    }

    public static string[] FindRelativeRanks(int[] scores) {
        var orderedScores = scores.OrderDescending();
        var rankMap = new Dictionary<int, string>();
        var ranks = new string[scores.Length];
        if (scores.Length > 0)
        {
            ranks[0] = "Gold Medal";
        }
        if (scores.Length > 1)
        {
            ranks[1] = "Silver Medal";
        }
        if (scores.Length > 2)
        {
            ranks[2] = "Bronze Medal";
        }
        for (int i = 3; i < scores.Length; i++)
        {
            ranks[i] = (i + 1).ToString();
        }

        var index = 0;
        foreach (var orderedScore in orderedScores)
        {
            rankMap[orderedScore] = ranks[index];
            index++;
        }

        var result = new string[scores.Length];
        index = 0;
        foreach (var score in scores)
        {
            result[index] = rankMap[score];
            index++;
        }

        return result;
    }
}
