namespace AdventOfCode2024;

public static class Day3
{
    public static int SolvePart1()
    {
        var data = LoadData();

        int count = 0;
        for (int c = 0; c < data?.Length; c++)
        {
            if (data[c] == 'm'
                && data[c + 1] == 'u'
                && data[c + 2] == 'l'
                && data[c + 3] == '('
                )
            {
                int x = 0;
                int y = 0;
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString() + data[c + 9].ToString() + data[c + 10].ToString(), out y)
                && data[c + 11] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString() + data[c + 9].ToString(), out y)
                && data[c + 10] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString() + data[c + 8].ToString() + data[c + 9].ToString(), out y)
                && data[c + 10] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString() + data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString(), out y)
                && data[c + 8] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString() + data[c + 7].ToString() + data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString() + data[c + 7].ToString(), out y)
                && data[c + 8] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString(), out y)
                && data[c + 7] == ')')
                {
                    count += (x * y);
                }
            }
        }

        return count;
    }

    public static int SolvePart2()
    {
        var data = LoadData(true);

        int count = 0;
        bool enabled = true;
        for (int c = 0; c < data?.Length; c++)
        {
            enabled = GetEnabledStatus(data, c, enabled);
            if (enabled && data[c] == 'm'
                && data[c + 1] == 'u'
                && data[c + 2] == 'l'
                && data[c + 3] == '('
                )
            {
                int x = 0;
                int y = 0;
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString() + data[c + 9].ToString() + data[c + 10].ToString(), out y)
                && data[c + 11] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString() + data[c + 9].ToString(), out y)
                && data[c + 10] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString() + data[c + 6].ToString(), out x)
                && data[c + 7] == ','
                && int.TryParse(data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString() + data[c + 8].ToString() + data[c + 9].ToString(), out y)
                && data[c + 10] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString() + data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString() + data[c + 5].ToString(), out x)
                && data[c + 6] == ','
                && int.TryParse(data[c + 7].ToString(), out y)
                && data[c + 8] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString() + data[c + 7].ToString() + data[c + 8].ToString(), out y)
                && data[c + 9] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString() + data[c + 7].ToString(), out y)
                && data[c + 8] == ')')
                {
                    count += (x * y);
                }
                if (int.TryParse(data[c + 4].ToString(), out x)
                && data[c + 5] == ','
                && int.TryParse(data[c + 6].ToString(), out y)
                && data[c + 7] == ')')
                {
                    count += (x * y);
                }
            }
        }

        return count;
    }

    private static bool GetEnabledStatus(string data, int c, bool currentStatus)
    {
        if (data[c] == 'd'
            && data[c + 1] == 'o'
            && data[c + 2] == 'n'
            && data[c + 3] == '\''
            && data[c + 4] == 't'
            && data[c + 5] == '('
            && data[c + 6] == ')'
            )
        {
            return false;
        }
        if (data[c] == 'd'
            && data[c + 1] == 'o'
            && data[c + 2] == '('
            && data[c + 3] == ')'
            )
        {
            return true;
        }

        return currentStatus;
    }

    private static string? LoadData(bool skipline = false)
    {
        string? line;

        StreamReader sr = new StreamReader("input3.txt");
        line = sr.ReadLine();
        if (skipline)
            line = sr.ReadLine();
        sr.Close();
        return line;
    }
}
