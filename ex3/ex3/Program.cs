static (int, int) MaxSumRange(int[] a)
{
    if (a.Length == 0)
        return (0, 0);

    int maxSum = a.Min();
    int maxRangeStart = 0;
    int maxRangeEnd = 0;
    int currentSum = 0;
    int currentStart = 0;

    for (int i = 0; i < a.Length; i++)
    {
        int currentEnd = i;

        if (currentSum <= 0)
        {
            currentStart = currentEnd;
            currentSum = a[i];
        }
        else
            currentSum += a[i];
        if (currentSum >= maxSum)
        {
            maxSum = currentSum;
            maxRangeStart = currentStart;
            maxRangeEnd = currentEnd;
        }
    }

    return (maxRangeStart, maxRangeEnd);
}


int[] a = { 3, -1, 4, -8, 2 };
(int val1, int val2) = MaxSumRange(a);
Console.WriteLine("{0} {1}", val1, val2);
Console.ReadLine();