namespace DataStructures.Trees;

/// <summary>
/// Представляет узел бинарного дерева.
/// </summary>
public class Node
{
    /// <summary>
    /// Значение, хранящееся в узле.
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Левый потомок.
    /// </summary>
    public Node? Left { get; set; }

    /// <summary>
    /// Правый потомок.
    /// </summary>
    public Node? Right { get; set; }

    /// <summary>
    /// Создаёт узел с заданным значением.
    /// </summary>
    /// <param name="value">Значение узла.</param>
    public Node(int value)
    {
        Value = value;
    }

    /// <summary>
    /// Cтроковое представление.
    /// </summary>
    public override string ToString() => Value.ToString();
}