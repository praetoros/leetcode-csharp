namespace Problems;

public class P506
{
    public static void Run()
    {
        // Test Cases
        Console.WriteLine(string.Join(",", FindRelativeRanks([5, 4, 3, 2, 1])));
        Console.WriteLine(string.Join(",", FindRelativeRanks([10, 3, 8, 9, 4])));
    }

    public static string[] FindRelativeRanks(int[] scores)
    {
        var scoreMap = new Dictionary<int, int>();
        for (int i = 0; i < scores.Length; i++)
        {
            scoreMap[scores[i]] = i;
        }

        Array.Sort(scores, (x, y) => y.CompareTo(x));
        string[] result = new string[scores.Length];
        for (int i = 0; i < scores.Length; i++)
        {
            result[scoreMap[scores[i]]] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };
        }

        return result;
    }
}
