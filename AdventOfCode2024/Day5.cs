using System.Data;

namespace AdventOfCode2024;

public class Day5
{
    private List<string> rules;
    private List<string> pages;

    public int SolvePart2()
    {
        LoadData();
        var invalidMiddlePages = new List<int>();

        foreach (var item in pages)
        {
            string[] page = item.Split(",");
            if (!IsValidOrder(page))
            {
                var correctedOrder = CorrectOrder(page);
                int middleIndex = correctedOrder.Length / 2;
                invalidMiddlePages.Add(int.Parse(correctedOrder[middleIndex]));
            }
        }

        return invalidMiddlePages.Sum();
    }

    private bool IsValidOrder(string[] page)
    {
        var pageSet = new HashSet<string>(page);
        var pageIndex = page.Select((p, i) => new { Page = p, Index = i }).ToDictionary(x => x.Page, x => x.Index);

        foreach (var rule in rules)
        {
            var parts = rule.Split("|");
            if (pageSet.Contains(parts[0]) && pageSet.Contains(parts[1]) && pageIndex[parts[0]] > pageIndex[parts[1]])
            {
                return false;
            }
        }

        return true;
    }

    private string[] CorrectOrder(string[] page)
    {
        var pageSet = new HashSet<string>(page);
        var dependencies = new Dictionary<string, List<string>>();

        foreach (var rule in rules)
        {
            var parts = rule.Split("|");
            if (pageSet.Contains(parts[0]) && pageSet.Contains(parts[1]))
            {
                if (!dependencies.TryGetValue(parts[1], out List<string>? value))
                {
                    value = [];
                    dependencies[parts[1]] = value;
                }

                value.Add(parts[0]);
            }
        }

        var sortedPages = new List<string>();
        var visited = new HashSet<string>();

        foreach (var p in page)
        {
            TopologicalSort(p, dependencies, visited, sortedPages);
        }

        sortedPages.Reverse();
        return [.. sortedPages];
    }

    private static void TopologicalSort(string page, Dictionary<string, List<string>> dependencies, HashSet<string> visited, List<string> sortedPages)
    {
        if (!visited.Contains(page))
        {
            visited.Add(page);
            if (dependencies.TryGetValue(page, out List<string>? value))
            {
                foreach (var dep in value)
                {
                    TopologicalSort(dep, dependencies, visited, sortedPages);
                }
            }
            sortedPages.Add(page);
        }
    }

    public int SolvePart1()
    {
        LoadData();
        var validMiddlePages = new List<int>();

        foreach (var item in pages)
        {
            string[] page = item.Split(",");
            if (IsValidOrder(page))
            {
                int middleIndex = page.Length / 2;
                validMiddlePages.Add(int.Parse(page[middleIndex]));
            }
        }

        return validMiddlePages.Sum();
    }

    private void LoadData()
    {
        string? line;
        rules = new();
        pages = new();
        using StreamReader sr = new StreamReader("input5.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            if (line.Contains("|"))
                rules.Add(line);
            if (line.Contains(","))
                pages.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }
}
