/*
# Name: Anthony Caggiano 
# email: caggiaaj @mail.uc.edu
# Assignment Title: Final Exam
# Due Date: 4/23
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Final Project, Easy Medium Hard
# Citations: https://copilot.microsoft.com/ , https://stackoverflow.com/ , https://leetcode.com/
# Anything else that's relevant: N/A
*/

using System;

namespace Group16_FinalExam
{
    internal class Solution3
    {
        internal int TotalNQueens(int n)
        {
            int count = 0;
            int[] board = new int[n];
            for (int i = 0; i < n; i++)
            {
                board[i] = -1;
            }
            Backtrack(board, 0, ref count);
            return count;
        }

        private bool IsSafe(int[] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i] == col || Math.Abs(board[i] - col) == row - i)
                    return false;
            }
            return true;
        }

        private void Backtrack(int[] board, int row, ref int count)
        {
            if (row == board.Length)
            {
                count++;
                return;
            }

            for (int col = 0; col < board.Length; col++)
            {
                if (IsSafe(board, row, col))
                {
                    board[row] = col;
                    Backtrack(board, row + 1, ref count);
                    board[row] = -1;
                }
            }
        }
    }
}
