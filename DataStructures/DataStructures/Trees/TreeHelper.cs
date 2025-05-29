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

        (tree.Left, tree.Right) = (Swap(tree.Right), Swap(tree.Left));

        return tree;
    }
}
