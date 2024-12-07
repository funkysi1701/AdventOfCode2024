namespace AdventOfCode2024;

public static class Day1
{
    public static int SolvePart1()
    {
        LoadData(out List<int> leftList, out List<int> rightList);
        var sortedLeftList = leftList.OrderBy(x => x);
        var sortedRightList = rightList.OrderBy(x => x);

        if (sortedLeftList.Count() != sortedRightList.Count())
        {
            throw new ArgumentException("Lists must have the same length");
        }

        var result = 0;
        for (int i = 0; i < sortedLeftList.Count(); i++)
        {
            var tmpResult = sortedLeftList.ElementAt(i) - sortedRightList.ElementAt(i);
            if (tmpResult < 0)
            {
                tmpResult *= -1;
            }

            result += tmpResult;
        }

        return result;
    }

    private static void LoadData(out List<int> leftList, out List<int> rightList)
    {
        string line;
        leftList = new List<int>();
        rightList = new List<int>();
        StreamReader sr = new StreamReader("input.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            var chars = line.Split("   ");
            leftList.Add(int.Parse(chars[0]));
            rightList.Add(int.Parse(chars[1]));

            line = sr.ReadLine();
        }
        sr.Close();
    }

    public static int SolvePart2()
    {
        LoadData(out List<int> leftList, out List<int> rightList);
        var sortedLeftList = leftList.OrderBy(x => x);
        var sortedRightList = rightList.OrderBy(x => x);

        if (sortedLeftList.Count() != sortedRightList.Count())
        {
            throw new ArgumentException("Lists must have the same length");
        }
        var result = 0;

        for (int i = 0; i < sortedLeftList.Count(); i++)
        {
            var element = sortedLeftList.ElementAt(i);
            var count = sortedRightList.Count(x => x == element);
            var tmpResult = element * count;
            result += tmpResult;
        }

        return result;
    }
}
