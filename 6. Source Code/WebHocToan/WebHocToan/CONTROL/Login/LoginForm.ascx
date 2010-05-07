<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginForm.ascx.cs" Inherits="CONTROL_Login_LoginForm" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>

<div class="column_one_section">
    <h1>Đăng Nhập</h1>

<asp:Label ID="Label1" runat="server" Text="Username" Width="60px" style="margin-left:5px"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Width="100px" style="margin-bottom:5px"></asp:TextBox>
            <p>
            <asp:Label ID="Label2" runat="server" Text="Password" Width="60px" style="margin-left:5px"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" Width="100px" TextMode="Password" style="margin-bottom:5px"></asp:TextBox>
            <p>
            <asp:CheckBox ID="chkRemember" Text="Remember Me" runat="server" AutoPostBack="True" style="margin-left:2px" />
            <asp:Button ID="btnLogin" runat="server" Text="Log In"  
                    onclick="btnLogin_Click" style="margin-bottom:5px" />
                    
            <p style="margin-left:5px"><a href="?ava=DangKy">Đăng ký</a> nếu chưa có tài khoản.</p>

</div>
<div class="cleaner_with_divider">&nbsp;</div>

    </ContentTemplate>

</asp:UpdatePanel>
    