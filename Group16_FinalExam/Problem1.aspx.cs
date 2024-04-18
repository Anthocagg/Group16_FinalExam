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
                ltSubsets.Text = FormatSubsetsForDisplay(subsets);
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
        }
    }

    // Include the Solution class from the previous code here
}
