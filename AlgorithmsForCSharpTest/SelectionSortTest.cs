using Xunit;

namespace AlgorithmsForCSharpTest
{
    public static class SelectionSortTest
    {
        [Fact]
        private static void TestIntegerSort()
        {
            var values = new[] {-11, 12, -42, 0, 1, 90, 68, 6, -9};
            AlgorithmsForCSharp.Sort.SelectionSort.Sort(values);

            var expected = new[] {-42, -11, -9, 0, 1, 6, 12, 68, 90};
            Assert.Equal(expected, values);
        }

        [Fact]
        private static void TestStringSort()
        {
            var values = new[] {"Mary", "Marcin", "Ann", "James", "George", "Nicole"};
            AlgorithmsForCSharp.Sort.SelectionSort.Sort(values);

            var expected = new[] {"Ann", "George", "James", "Marcin", "Mary", "Nicole"};
            Assert.Equal(expected, values);
        }
    }
}