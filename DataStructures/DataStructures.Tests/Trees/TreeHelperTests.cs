using DataStructures.Trees;

namespace DataStructures.Tests.Trees;

/// <summary>
/// Набор тестов для TreeHelper.Swap.
/// </summary>
public class TreeHelperTests
{
    [Fact]
    public void Swap_NullRoot_ReturnsNull()
    {
        var result = TreeHelper.Swap(null);
        Assert.Null(result);
    }

    [Fact]
    public void Swap_SingleNode_DoesNotChange()
    {
        var node = new Node(1);
        var result = TreeHelper.Swap(node);

        Assert.Equal(1, result?.Value);
        Assert.Null(result?.Left);
        Assert.Null(result?.Right);
    }

    [Fact]
    public void Swap_SimpleTree_SwapsLeftAndRight()
    {
        var tree = new Node(1)
        {
            Left = new Node(2),
            Right = new Node(3)
        };

        var result = TreeHelper.Swap(tree);

        Assert.Equal(1, result?.Value);
        Assert.Equal(3, result?.Left?.Value);
        Assert.Equal(2, result?.Right?.Value);
    }

    [Fact]
    public void Swap_DeepTree_SwapsRecursively()
    {
        var tree = new Node(1)
        {
            Left = new Node(2)
            {
                Left = new Node(4),
                Right = new Node(5)
            },
            Right = new Node(3)
            {
                Left = new Node(6),
                Right = new Node(7)
            }
        };

        var result = TreeHelper.Swap(tree);

        Assert.Equal(1, result?.Value);
        Assert.Equal(3, result?.Left?.Value);
        Assert.Equal(7, result?.Left?.Left?.Value);
        Assert.Equal(6, result?.Left?.Right?.Value);

        Assert.Equal(2, result?.Right?.Value);
        Assert.Equal(5, result?.Right?.Left?.Value);
        Assert.Equal(4, result?.Right?.Right?.Value);
    }
}
