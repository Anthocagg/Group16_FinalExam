<!--
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
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem1.aspx.cs" Inherits="Group16_FinalExam.Problem1" %>
 
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem 1 - Island Perimeter</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Problem Description</h2>
            <p>
                Given a 2D grid representing an island, where 1 represents land and 0 represents water, calculate the perimeter of the island. The island is surrounded by water, and each cell is adjacent to its neighboring cells (horizontally or vertically).
            </p>
            <p>
                You need to implement the method <code>IslandPerimeter(int[][] grid)</code> that returns the total perimeter of the island.
            </p>
            <p>
                Example grid for testing:
                <pre>
                    int[][] grid = new int[][]
                    {
                        new int[] {0, 1, 0, 0},
                        new int[] {1, 1, 1, 0},
                        new int[] {0, 1, 0, 0},
                        new int[] {1, 1, 0, 0}
                    };
                </pre>
            </p>
            <h2>Answer</h2>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>


