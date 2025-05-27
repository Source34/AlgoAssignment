namespace DataStructures.Grids;

/// <summary>
/// Содержит методы для работы с гридами.
/// </summary>
public static class PathHelper
{
    /// <summary>
    /// Вычисляет количество возможных путей от верхнего левого угла (0,0)
    /// до нижнего правого угла (m-1,n-1) в сетке размером m×n,
    /// разрешая перемещения только вправо и вниз.
    /// </summary>
    /// <param name="m">Количество строк (высота сетки).</param>
    /// <param name="n">Количество столбцов (ширина сетки).</param>
    /// <returns>Количество уникальных маршрутов.</returns>
    public static int GetPathCount(int m, int n)
    {
        if (m <= 0 || n <= 0)
            return 0;

        var dp = new int[m, n];

        for (int i = 0; i < m; i++) dp[i, 0] = 1;
        for (int j = 0; j < n; j++) dp[0, j] = 1;

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            }
        }

        return dp[m - 1, n - 1];
    }
}
