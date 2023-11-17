using static System.Console;

namespace SudokuSolver;

internal static class SudokuSolver
{
    private static readonly int[,] puzzle =
    {
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
        { 0, 0, 0, 0, 0, 0, 0, 0, 0, },
    };
    
    private static void Main()
    {   
        int[,] solvedPuzzle = Solve(puzzle);

        PrintPuzzle(solvedPuzzle);
    }

    private static void PrintPuzzle(int[,] puzzle, string title = "Solved Puzzle")
    {
        
        int topWidth = puzzle.GetLength(1) * 3 + puzzle.GetLength(1) / 3 - 1;
        
        // title
        int padding = (int)(Math.Ceiling(topWidth / 2f) - Math.Ceiling(title.Length / 2f));
        
        for(int i = 0; i < padding; i++) Write(" ");
        
        Write(title);
        WriteLine();
        
        // top border
        Write("+");
        PrintHorizontalBorder(topWidth - 2);
        Write("+");
        WriteLine();

        // numbers
        for (int i = 0; i < puzzle.GetLength(1); i++)
        {
            if (i % 3 == 0 && i != 0)
            {
                Write("|");
                PrintHorizontalBorder(topWidth - 2);
                Write("|\n");
            }

            for (int j = 0; j < puzzle.GetLength(0); j++)
            {
                // left boarder / seperator
                if (j % 3 == 0) Write("|");
                Write($" {puzzle[i, j]} ");
            }

            // right border
            Write("|");
            WriteLine();
        }

        // bottom border
        Write("+");
        PrintHorizontalBorder(topWidth - 2);
        Write("+");

        return;

        void PrintHorizontalBorder(int width)
        {
            for (int i = 0; i < width + 2; i++)
            {
                Write("-");
            }
        }
    }

    private static int[,] Solve(int[,] puzzle)
    {
        return puzzle;
    }
}