namespace Mazes;

public class MazeGenerator(int rows, int cols)
{
    private int rows = rows, cols = cols;
    private bool[,] maze = new bool[rows, cols];
    private Random random = new();

    public bool[,] GenerateMaze()
    {
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                maze[i, j] = false;
            }
        }

        GeneratePath(0, 0);

        maze[rows - 1, cols - 1] = true;
        return maze;
    }

    private void GeneratePath(int x, int y)
    {
        maze[x, y] = true;

        var directions = new List<(int dx, int dy)> { (0, 1), (1, 0), (0, -1), (-1, 0) };
        Shuffle(directions);

        foreach (var (dx, dy) in directions)
        {
            var nx = x + dx * 2;
            var ny = y + dy * 2;

            if (!IsInBounds(nx, ny) || maze[nx, ny])
            {
                continue;
            }
            
            maze[x + dx, y + dy] = true;
            GeneratePath(nx, ny);
        }
    }

    private void Shuffle<T>(IList<T> list)
    {
        for (var i = list.Count - 1; i > 0; i--)
        {
            var j = random.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    private bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < rows && y >= 0 && y < cols;
    }
}