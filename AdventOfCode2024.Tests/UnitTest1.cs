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
    }
}
