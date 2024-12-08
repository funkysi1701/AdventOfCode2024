namespace AdventOfCode2024;

public static class Day2
{
    public static int SolvePart1()
    {
        var data = LoadData();
        var result = new List<bool>();
        foreach (var list in data)
        {
            var boo = GetRowResult(list);
            result.Add(boo);
        }
        return result.Count(x => x);
    }

    public static int SolvePart2()
    {
        var data = LoadData();
        var result = new List<bool>();
        foreach (var list in data)
        {
            var check = false;
            for (int j = 0; j < list.Count; j++)
            {
                var tmpList = new List<int>(list);
                tmpList.RemoveAt(j);
                var boo = GetRowResult(tmpList);
                if (boo)
                {
                    result.Add(true);
                    check = true;
                    break;
                }
            }
            if (check)
                result.Add(false);
        }
        return result.Count(x => x);
    }

    private static bool GetRowResult(List<int> list)
    {
        var ascendingList = list.OrderBy(x => x).ToList();
        var descendingList = list.OrderByDescending(x => x).ToList();
        if (descendingList.SequenceEqual(list) || ascendingList.SequenceEqual(list))
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                var diff = list[i] - list[i + 1];
                diff = diff < 0 ? diff * -1 : diff;
                if (diff < 1 || diff > 3)
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }
    }

    private static List<List<int>> LoadData()
    {
        string? line;

        var listoflists = new List<List<int>>();
        StreamReader sr = new StreamReader("input2.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            var chars = line.Split(" ");
            var list = new List<int>();
            foreach (var c in chars)
            {
                list.Add(int.Parse(c));
            }
            listoflists.Add(list);
            line = sr.ReadLine();
        }
        sr.Close();
        return listoflists;
    }
}
