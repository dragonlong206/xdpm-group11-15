<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginInfo.ascx.cs" Inherits="CONTROL_Login_LoginInfo" %>

<div class="column_one_section">
    <h1>Welcome</h1>

    <asp:Label ID="Label2" runat="server" Text="Tài khoản: " style="margin-left:5px"></asp:Label>
    <asp:Label ID="txtUsername" runat="server" Text="" style="margin-bottom:10px" Font-Bold="True"></asp:Label>
    <p>
    <asp:Button ID="Button1" runat="server" Text="Log Out" onclick="Button1_Click" style="margin-left:5px" />
            
</div>
<div class="cleaner_with_divider">&nbsp;</div>