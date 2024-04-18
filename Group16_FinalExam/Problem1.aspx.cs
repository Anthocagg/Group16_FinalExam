using Group16_FinalExam;
using System.Web.UI;
using System;
 
namespace Group16_FinalExam
{
    public partial class Problem1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var solution2 = new Solution2();
            // Example grid for testing
            int[][] grid = new int[][]
            {
                new int[] {0, 1, 0, 0},
                new int[] {1, 1, 1, 0},
                new int[] {0, 1, 0, 0},
                new int[] {1, 1, 0, 0}
            };
            int perimeter = solution2.IslandPerimeter(grid);
            Label1.Text = "Island Perimeter: " + perimeter;
        }
    }
}