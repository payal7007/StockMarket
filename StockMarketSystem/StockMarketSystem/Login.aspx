<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StockMarketSystem.Login" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Login</title>
</head>
<body>
    
        <h2>Login</h2>
        <form id="form1" runat="server" method="post" >
           
            Email<asp:TextBox ID="TextBox1" runat="server" Text="email " style="margin-left: 17px"></asp:TextBox>
            <p>
             Password<asp:TextBox ID="TextBox2" runat="server" Text="password " style="margin-left: 16px"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
            </p>
             <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
           
        </form>
     
</body>
</html>
