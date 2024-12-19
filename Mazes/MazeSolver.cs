namespace Mazes;

public class MazeSolver(bool[,] maze, (int x, int y) start)
{
    private bool[,] maze = maze;
    private int rows = maze.GetLength(0), cols = maze.GetLength(1);
    private (int x, int y) start = start;

    public void Solve()
    {
        var visited = new bool[rows, cols];
        Console.WriteLine(FindExit(start.x, start.y, visited) ? "Exit found!" : "No exit found.");
    }

    private bool FindExit(int x, int y, bool[,] visited)
    {
        if (!IsInBounds(x, y) || visited[x, y] || !maze[x, y])
        {
            return false;
        }

        if ((x, y) == (rows - 1, cols - 1))
        {
            return true;
        }

        visited[x, y] = true;

        return FindExit(x + 1, y, visited) ||
               FindExit(x - 1, y, visited) ||
               FindExit(x, y + 1, visited) ||
               FindExit(x, y - 1, visited);
    }

    private bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < rows && y >= 0 && y < cols;
    }
}