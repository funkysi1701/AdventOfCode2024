namespace AdventOfCode2024
{
    public class UnitTest1
    {
        [Fact]
        public void Day1Part1Example()
        {
            var result = Day1.SolvePart1();

            Assert.Equal(11, result);
        }

        [Fact]
        public void Day1Part2Example()
        {
            var result = Day1.SolvePart2();

            Assert.Equal(31, result);
        }

        [Fact]
        public void Day2Part1Example()
        {
            var result = Day2.SolvePart1();

            Assert.Equal(2, result);
        }

        [Fact]
        public void Day2Part2Example()
        {
            var result = Day2.SolvePart2();
            Assert.Equal(4, result);
        }

        [Fact]
        public void Day3Part1Example()
        {
            var result = Day3.SolvePart1();

            Assert.Equal(161, result);
        }

        [Fact]
        public void Day3Part2Example()
        {
            var result = Day3.SolvePart2();
            Assert.Equal(48, result);
        }

        [Fact]
        public void Day4Part1Example()
        {
            var result = Day4.SolvePart1();

            Assert.Equal(18, result);
        }

        [Fact]
        public void Day4Part2Example()
        {
            var result = Day4.SolvePart2();
            Assert.Equal(9, result);
        }

        [Fact]
        public void Day5Part1Example()
        {
            var day = new Day5();
            var result = day.SolvePart1();

            Assert.Equal(143, result);
        }

        [Fact]
        public void Day5Part2Example()
        {
            var day = new Day5();
            var result = day.SolvePart2();
            Assert.Equal(123, result);
        }
    }
}
