namespace DataStructures.Trees;

/// <summary>
/// Содержит алгоритмы работы с бинарными деревьями.
/// </summary>
public static class TreeHelper
{
    /// <summary>
    /// Зеркально отражает бинарное дерево по вертикальной оси.
    /// </summary>
    /// <param name="tree">Корень дерева для отражения.</param>
    /// <returns>Корень отражённого дерева.</returns>
    public static Node? Swap(Node? tree)
    {
        if (tree == null) return null;

        var temp = tree.Left;
        tree.Left = Swap(tree.Right);
        tree.Right = Swap(temp);

        return tree;
    }
}
