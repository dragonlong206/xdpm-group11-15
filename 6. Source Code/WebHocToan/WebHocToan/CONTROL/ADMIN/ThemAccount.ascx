<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemAccount.ascx.cs" Inherits="CONTROL_ADMIN_ThemAccount" %>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Thêm Account</a></h1>
            <p>Administrator Pages.</p>   

      <div class="column_four_section">
			<h1><a href="#" target="_parent">Đăng Ký Tài Khoản</a></h1>
            <p>Bạn có thể dùng tài khoản Username: <strong>demo</strong> & Password: <strong>demo</strong> để đăng nhập.</p>
            
            
    <p>
        <asp:Label ID="lbtb1" runat="server" Text="Đăng ký thành công, bạn có thể đăng nhập với tài khoản: " Visible=false></asp:Label>
        <asp:Label ID="lbTaiKhoan" runat="server" Text="" Font-Bold="True" Visible=false></asp:Label>
        <asp:Label ID="lbtb2" runat="server" Text="." Visible=false></asp:Label>
    
    </p>
            
    <asp:Label ID="lbUsername" runat="server" Text="Username:" Width="120"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" Width="170" > </asp:TextBox>
    <asp:Label ID="msgUsername" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbPassword" runat="server" Text="Password:" Width="120"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="170"> </asp:TextBox>
    <asp:Label ID="msgPassword" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbConfirmPassword" runat="server" Text="Confirm Password:" Width="120"></asp:Label>
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Width="170" ></asp:TextBox>
    <asp:Label ID="msgConfirmPassword" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbEmail" runat="server" Text="Email:" Width="120"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" Width="170"  
                ></asp:TextBox>
    <asp:Label ID="msgEmail" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbDangKy" runat="server" Text="" Width="120"></asp:Label>
    <asp:Button ID="btnDangKy" runat="server" Text="Đăng Ký Hoàn Tất" 
                onclick="btnDangKy_Click" />
                  
</div>

    
  

</div>