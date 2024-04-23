<!--
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
-->

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Problem2.aspx.cs" Inherits="Group16_FinalExam.Problem2" %>
 
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Problem 2 - Subsets</title>
    <style>
        h2 {
            font-size: 24px;
            margin-bottom: 10px;
        }
        p {
            font-size: 16px;
            margin-bottom: 10px;
        }
        pre {
            font-size: 14px;
            background-color: #f4f4f4;
            padding: 10px;
            border-radius: 5px;
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Problem 78 (Medium) - Subsets</h2>
            <p>
                Given a set of distinct integers, nums, return all possible subsets (the power set).
            </p>
            <p>
                A subset is a group of elements that can be present or absent from the original set. In other words, for the set <code>[1,2,3]</code>, the subsets are <code>[]</code>, <code>[1]</code>, <code>[2]</code>, <code>[1,2]</code>, <code>[3]</code>, <code>[1,3]</code>, <code>[2,3]</code>, and <code>[1,2,3]</code>.
            </p>
            <h2>Answer</h2>
            <asp:Literal ID="ltSubsets" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>


