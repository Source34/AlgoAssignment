using DataStructures.Grids;

namespace DataStructures.Tests.Grids;

/// <summary>
/// Набор unit-тестов для метода GetPathCount.
/// </summary>
public class PathHelperTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    [InlineData(2, 2, 2)]
    [InlineData(3, 3, 6)]
    [InlineData(3, 2, 3)]
    [InlineData(5, 1, 1)]
    [InlineData(1, 5, 1)]
    [InlineData(4, 3, 10)]
    public void GetPathCount_ValidInputs_ReturnsExpected(int m, int n, int expected)
    {
        int result = PathHelper.GetPathCount(m, n);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(0, 5)]
    [InlineData(3, 0)]
    [InlineData(-1, 4)]
    public void GetPathCount_InvalidInputs_ReturnsZero(int m, int n)
    {
        int result = PathHelper.GetPathCount(m, n);
        Assert.Equal(0, result);
    }
}
