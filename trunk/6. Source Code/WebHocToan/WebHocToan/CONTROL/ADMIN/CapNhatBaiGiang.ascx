<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CapNhatBaiGiang.ascx.cs" Inherits="CONTROL_ADMIN_CapNhatBaiGiang" %>

<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>

<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Cập Nhật Bài Giảng</a></h1>
            <p>Administrator Pages.</p> 
            Chọn Chương:   
                <asp:DropDownList ID="drlChuong" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSourceChuong" DataTextField="TenChuong" 
                DataValueField="IDChuong" 
                onselectedindexchanged="drlChuong_SelectedIndexChanged">
                </asp:DropDownList> 
            <asp:SqlDataSource ID="SqlDataSourceChuong" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Chuong]"></asp:SqlDataSource>
            <br />
            Chọn Bài Giảng: 
                <asp:DropDownList ID="drlBaiGiang" runat="server" 
                onselectedindexchanged="drlBaiGiang_SelectedIndexChanged" 
                AutoPostBack="True">
                </asp:DropDownList>
             <br />
            Tên Bài Giảng Mới: 
                <asp:TextBox ID="txtBaiGiangMoi" runat="server"></asp:TextBox>
    
            <br />
            Nội Dung Bài:
            <br />
            <CE:Editor ID="Editor1" runat="server" Height="600px">
            </CE:Editor>
            
            <br />
            <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật" 
                onclick="btnCapNhat_Click" />
    
</div>


<cc1:msgBox ID="msgBox1" runat="server" />



