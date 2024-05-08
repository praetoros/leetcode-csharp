namespace Problems;

public class P997
{
    public static void Run()
    {
        // Test Cases
        Console.WriteLine(FindJudge(2, [[1, 2]]) == 2);
        Console.WriteLine(FindJudge(3, [[1, 3],[2,3]]) == 3);
        Console.WriteLine(FindJudge(3, [[1, 3],[2,3], [3,1]]) == -1);
    }

    public static int FindJudge(int n, int[][] trust)
    {
        int[] trusted = new int[n];
        bool[] trusting = new bool[n];

        foreach (var relationship in trust)
        {
            trusting[relationship[0] - 1] = true;
            ++trusted[relationship[1] - 1];
        }

        for (int i = 0; i < n; i++)
        {
            if (!trusting[i] && trusted[i] == n - 1)
            {
                return i + 1;
            }
        }

        return -1;
    }
}
