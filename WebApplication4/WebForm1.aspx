<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    <h1>YazGel- Proje2</h1>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="47px" OnTextChanged="TextBox1_TextChanged1" Width="397px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button9" runat="server" Height="43px" OnClick="Button9_Click" Text="Onayla " Width="183px" />
        </p>
        <asp:Button ID="Button1" runat="server" Height="52px" OnClick="Button1_Click" Text="Ara" Width="179px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="51px" OnClick="Button2_Click" Text="Temizle" Width="209px" />
        &nbsp;&nbsp;
        &nbsp;
        <asp:Button ID="Button4" runat="server" Height="51px" OnClick="Button4_Click" Text="Create File" Width="160px" />
&nbsp;&nbsp;
        <asp:Button ID="Button5" runat="server" Height="50px" OnClick="Button5_Click" Text="Create Folder" Width="159px" />
        <br />
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="152px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="413px"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;&nbsp;<br />
        <br />
        <br />
        <br />
        <br />
    </form>
    </body>
</html>
