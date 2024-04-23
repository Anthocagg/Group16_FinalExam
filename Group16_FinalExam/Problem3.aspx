<!--
# Name: Anthony Caggiano 
# email: caggiaaj @mail.uc.edu
# Assignment Title: Final Exam
# Due Date: 4/23
# Course: IS 3050
# Semester/Year: Spring 2024
# Brief Description: Final Project, Easy Medium Hard
# Citations: https://copilot.microsoft.com/ , https://stackoverflow.com/ , https://leetcode.com/
# Anything else that's relevant: N/A
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem3.aspx.cs" Inherits="Group16_FinalExam.Problem3" %>
 
<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem 3 - N-Queens</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>The n-queens puzzle is the problem of placing n queens on an n x n chessboard such that no two queens attack each other.</p>
            <p>The program contains methods for determining whether a queen can be safely placed on the chessboard (IsSafe), as well as a backtracking algorithm (Backtrack) to find all possible solutions by recursively exploring all valid placements of queens on the board. Finally, it returns the total count of valid solutions.</p>
            <asp:Literal ID="ltTotalSolutions" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
