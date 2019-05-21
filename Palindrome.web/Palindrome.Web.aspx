<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Palindrome.Web.aspx.cs" Inherits="Palindrome.Palindrome_Web" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter text to test for palindrome:
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Test" />
        </p>
        <p>
&nbsp;<asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
        </p>
    </form>
</body>
</html>
