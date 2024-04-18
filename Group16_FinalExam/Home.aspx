<%@ Page Language="C#" AutoEventWireup="true" CodeBehind=Home.aspx.cs Inherits="Group16_FinalExam.Home" %>
 
<!DOCTYPE html>
 
<html xmlns=http://www.w3.org/1999/xhtml>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Problem1" runat="server" Text="Easy" OnClick="Problem1_Click" />
            <asp:Button ID="Problem2" runat="server" Text="Medium" OnClick="Problem2_Click"/>
            <asp:Button ID="Problem3" runat="server" Text="Hard" OnClick="Problem3_Click"/>
        </div>
    </form>
</body>
</html>