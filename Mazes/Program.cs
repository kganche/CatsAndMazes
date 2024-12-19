using Mazes;

var generator = new MazeGenerator(11, 11);
var maze = generator.GenerateMaze();

var solver = new MazeSolver(maze, (0, 0));
solver.Solve();