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
using System.Web.UI;

namespace Group16_FinalExam
{
    public partial class Problem3 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Instantiate the Solution3 class
                Solution3 solution = new Solution3(); // Corrected class name

                // Example usage:
                int n = 4; // Change the value of n as needed
                int totalSolutions = solution.TotalNQueens(n);

                // Display the total number of solutions
                ltTotalSolutions.Text = $"Total solutions for {n}-queens problem: {totalSolutions}";
            }
        }
    }
}
