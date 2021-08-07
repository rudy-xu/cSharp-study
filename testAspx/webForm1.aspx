<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="shiyan1.WebForm1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .TextBox1 {
            width: 20px;
            height: 5px;
            right: 50%;
            left: 50%;
            margin-top: 20px;
            margin-right: 400px;
        }
        .Button1
        {
            width: 10px;
            height: 4px;
            right: 500px;
            left: 500px;
        }
    </style>
</head>

<body class="TextBox1">
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
    </div>
    <p>
        <asp:Button ID="Button1" runat="server" οnclick="Button1_Click" Text="计算" 
            Width="73px" Height="29px" />
    </p>
    </form>
</body>
</html>