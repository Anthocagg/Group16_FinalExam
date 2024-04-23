/*
# Name: Nirvan Tadayon
# email: tadayonn@mail.uc.edu
# Assignment Title: Final Exam
# Due Date: 4/23
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Final Project, Easy Medium Hard
# Citations: https://copilot.microsoft.com/ , https://stackoverflow.com/ , https://leetcode.com/
# Anything else that's relevant: N/A
*/

using System.Collections.Generic;

namespace Group16_FinalExam
{
    public class Solution
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(nums, 0, new List<int>(), result);
            return result;
        }

        private void Backtrack(int[] nums, int start, List<int> subset, IList<IList<int>> result)
        {
            result.Add(new List<int>(subset));

            for (int i = start; i < nums.Length; i++)
            {
                subset.Add(nums[i]);
                Backtrack(nums, i + 1, subset, result);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}