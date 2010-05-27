<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CapNhatAccount.ascx.cs" Inherits="CONTROL_ADMIN_CapNhatAccount" %>


<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>


<div class="column_four_section">
            <p>Administrator Pages.</p>   

      <div class="column_four_section">
			<h1><a href="#" target="_parent">&nbsp;Cập Nhật Tài Khoản</a></h1>
                    <p>
                        Chọn loại Account:
                        <asp:DropDownList ID="drlLoaiAccount" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="drlLoaiAccount_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
    
    </p>
                    <p>
                        Chọn Account:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="drlAccount" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="drlAccount_SelectedIndexChanged">
                        </asp:DropDownList>
    
    </p>
            
    <asp:Label ID="lbUsername" runat="server" Text="Username:" Width="120"></asp:Label>
    <asp:TextBox ID="txtUsername" runat="server" Width="170" > </asp:TextBox>
    <asp:Label ID="msgUsername" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbPassword" runat="server" Text="Password:" Width="120"></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" Width="170"></asp:TextBox>
    <asp:Label ID="msgPassword" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbEmail" runat="server" Text="Email:" Width="120"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" Width="170"  
                ></asp:TextBox>
    <asp:Label ID="msgEmail" runat="server" Text="" ></asp:Label>
    <p></p>
    <asp:Label ID="lbDangKy" runat="server" Text="" Width="120"></asp:Label>
            
    <asp:Button ID="btnDangKy" runat="server" Text="Cập Nhật" 
                onclick="btnCapNhat_Click" />
                  
</div>

    
  <cc1:msgBox ID="msgBox1" runat="server" />

</div>