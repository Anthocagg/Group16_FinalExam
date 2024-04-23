/*
# Name: Dylan Shira
# email: shiradv@mail.uc.edu
# Assignment Title: Final Exam
# Due Date: 4/23
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Final Project, Easy Medium Hard
# Citations: https://copilot.microsoft.com/ , https://stackoverflow.com/ , https://leetcode.com/
# Anything else that's relevant: N/A
*/

using System;
using System.Collections.Generic;
using System.Web.UI;

namespace Group16_FinalExam
{
    public partial class Problem2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var solution = new Solution();
                int[] nums = { 1, 2, 3 }; // Example input
                var subsets = solution.Subsets(nums);
                ltSubsets.Text = FormatSubsetsForDisplay(subsets); // Call FormatSubsetsForDisplay method
            }
        }

        private string FormatSubsetsForDisplay(IList<IList<int>> subsets)
        {
            var displayText = "<ul>";
            foreach (var subset in subsets)
            {
                displayText += "<li>[" + string.Join(",", subset) + "]</li>";
            }
            displayText += "</ul>";
            return displayText;

            // Problem 78 - subsets: use backtracking solutions to solve problems, then display the text with all the subsets for numbers 1-3

        }
        
    }
}
