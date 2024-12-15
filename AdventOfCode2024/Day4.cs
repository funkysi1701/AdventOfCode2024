namespace AdventOfCode2024;

public static class Day4
{
    public static int SolvePart1()
    {
        var allHRows = LoadData();
        var x = allHRows.Count;
        var y = allHRows[0].Length;
        var count = 0;
        string[,] arrayOfLetters = new string[x, y];
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                arrayOfLetters[i, j] = allHRows[i].Substring(j, 1);
            }
        }
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y - 3; j++)
            {
                if (arrayOfLetters[i, j] == "X"
                    && arrayOfLetters[i, j + 1] == "M"
                    && arrayOfLetters[i, j + 2] == "A"
                    && arrayOfLetters[i, j + 3] == "S")
                {
                    count++;
                }

                if (arrayOfLetters[i, j] == "S"
                    && arrayOfLetters[i, j + 1] == "A"
                    && arrayOfLetters[i, j + 2] == "M"
                    && arrayOfLetters[i, j + 3] == "X")
                {
                    count++;
                }
            }
        }
        for (int i = 0; i < x - 3; i++)
        {
            for (int j = 0; j < y; j++)
            {
                if (arrayOfLetters[i, j] == "X"
                    && arrayOfLetters[i + 1, j] == "M"
                    && arrayOfLetters[i + 2, j] == "A"
                    && arrayOfLetters[i + 3, j] == "S")
                {
                    count++;
                }

                if (arrayOfLetters[i, j] == "S"
                    && arrayOfLetters[i + 1, j] == "A"
                    && arrayOfLetters[i + 2, j] == "M"
                    && arrayOfLetters[i + 3, j] == "X")
                {
                    count++;
                }
            }
        }
        for (int i = 0; i < x - 3; i++)
        {
            for (int j = 0; j < y - 3; j++)
            {
                if (arrayOfLetters[i, j] == "X"
                    && arrayOfLetters[i + 1, j + 1] == "M"
                    && arrayOfLetters[i + 2, j + 2] == "A"
                    && arrayOfLetters[i + 3, j + 3] == "S")
                {
                    count++;
                }

                if (arrayOfLetters[i, j] == "S"
                    && arrayOfLetters[i + 1, j + 1] == "A"
                    && arrayOfLetters[i + 2, j + 2] == "M"
                    && arrayOfLetters[i + 3, j + 3] == "X")
                {
                    count++;
                }
            }
        }

        for (int i = 0; i < x - 3; i++)
        {
            for (int j = y - 1; j > 2; j--)
            {
                if (arrayOfLetters[i, j] == "X"
                    && arrayOfLetters[i + 1, j - 1] == "M"
                    && arrayOfLetters[i + 2, j - 2] == "A"
                    && arrayOfLetters[i + 3, j - 3] == "S")
                {
                    count++;
                }

                if (arrayOfLetters[i, j] == "S"
                    && arrayOfLetters[i + 1, j - 1] == "A"
                    && arrayOfLetters[i + 2, j - 2] == "M"
                    && arrayOfLetters[i + 3, j - 3] == "X")
                {
                    count++;
                }
            }
        }

        return count;
    }

    private static List<string>? LoadData()
    {
        string? line;
        List<string>? listoflists = new();
        StreamReader sr = new StreamReader("input4.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            listoflists.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();
        return listoflists;
    }
}
