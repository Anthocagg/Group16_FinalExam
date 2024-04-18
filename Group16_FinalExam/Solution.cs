using Group16_FinalExam;
using System.Collections.Generic;
using System;
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