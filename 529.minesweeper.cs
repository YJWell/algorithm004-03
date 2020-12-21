/*
 * @lc app=leetcode id=529 lang=csharp
 *
 * [529] Minesweeper
 */

// @lc code=start
public class Solution
{
    private int GetMineNumber(int row, int col, char[][] board)
    {
        int number = 0;
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                if (i == 0 && j == 0) continue;
                int r = row + i, c = col + j;
                if (r < 0 || r >= m || c < 0 || c < 0 || c >= n) continue;
                if (board[r][c] == 'M' || board[r][c] == 'X') count++;
            }
        }
        return number;
    }

    public char[][] UpdateBoard(char[][] board, int[] click)
    {
        int m = board.Length, n = board[0].Length;
        int row = click[0], col = click[1];

        if (board[row][col] == 'M')
        { // Mine
            board[row][col] = 'X';
            return;
        }
        int count = GetMineNumber(row, col, board);

        if (count > 0)
        { // If it is not a 'B', stop further DFS.
            board[row][col] = (char)(count + '0');
            return;
        }
        // Continue DFS to adjacent cells.
        board[row][col] = 'B';
        for (int i = -1; i < 2; i++)
        {
            for (int j = -1; j < 2; j++)
            {
                if (i == 0 && j == 0) continue;
                int r = row + i, c = col + j;
                if (r < 0 || r >= m || c < 0 || c < 0 || c >= n) continue;
                if (board[r][c] == 'E') updateBoard(board, new int[] { r, c });
            }
        }
        return board;
    }
}
// @lc code=end

