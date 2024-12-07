namespace AdventOfCode2024;

public class Day2
{
    public static int SolvePart1()
    {
        var data = LoadData();
        var result = new List<bool>();
        foreach (var list in data)
        {
            var ascendingList = list.OrderBy(x => x).ToList();
            var descendingList = list.OrderByDescending(x => x).ToList();
            if (descendingList.SequenceEqual(list) || ascendingList.SequenceEqual(list))
            {
                var rowResult = false;
                for (int i = 0; i < list.Count - 1; i++)
                {
                    var diff = list[i] - list[i + 1];
                    diff = diff < 0 ? diff * -1 : diff;
                    if (diff < 1 || diff > 3)
                    {
                        result.Add(false);
                        rowResult = true;
                        break;
                    }
                }
                if (!rowResult)
                    result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        return result.Count(x => x);
    }

    private static List<List<int>> LoadData()
    {
        string? line;

        var listoflists = new List<List<int>>();
        StreamReader sr = new StreamReader("input.txt");
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
