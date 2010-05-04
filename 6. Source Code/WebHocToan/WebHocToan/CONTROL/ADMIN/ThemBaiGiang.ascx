<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemBaiGiang.ascx.cs" Inherits="CONTROL_ADMIN_ThemBaiGiang" %>

<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>

<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>



<div class="column_four_section">
			<h1><a href="#" target="_parent">Thêm Bài Giảng</a></h1>
            <p>Administrator Pages.</p>  
            
              
            Chọn Chương:<asp:DropDownList ID="drlChuong" 
                runat="server" DataSourceID="SqlDataSourceChuong" DataTextField="TenChuong" 
                DataValueField="IDChuong">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceChuong" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Chuong]"></asp:SqlDataSource>
            <br />
            <br />
            Tựa Đề:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTuaDe" runat="server" Width="500px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTuaDe" ErrorMessage="RequiredFieldValidator">(*)Tựa đề 
            không được trống</asp:RequiredFieldValidator>
            <br />
            <br />
            Nội Dung:<br />
            
    <CE:Editor ID="Editor1" runat="server" Height="800px">
    </CE:Editor>
            <br />
    <asp:Button ID="btnThem" runat="server" Text="Thêm" onclick="btnThem_Click" style="padding-left=100px" />
</div>
<cc1:msgBox ID="msgBox1" runat="server" />

