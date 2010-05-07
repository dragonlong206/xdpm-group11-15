<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CapNhatBaiGiang.ascx.cs" Inherits="CONTROL_ADMIN_CapNhatBaiGiang" %>

<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>

<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Cập Nhật Bài Giảng</a></h1>
            <p>Administrator Pages.</p> 
           <br />
              Chọn Môn Học: 
    <asp:DropDownList ID="drlMonHoc" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataMonHoc" DataTextField="TenMonHoc" 
                DataValueField="IDMonHoc" 
                onselectedindexchanged="drlMonHoc_SelectedIndexChanged" 
                onload="drlMonHoc_Load">
    </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataMonHoc" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [MonHoc]"></asp:SqlDataSource>
            <br />   
            Chọn Chương: 
    <asp:DropDownList ID="drlChuong" runat="server" AutoPostBack="True" DataTextField="TenChuong" 
                DataValueField="IDChuong" 
                onselectedindexchanged="drlChuong_SelectedIndexChanged" 
                onload="drlChuong_Load" oninit="drlChuong_Init">
    </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSourceChuong" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Chuong]"></asp:SqlDataSource>
            <br />
            Chọn Bài Giảng: 
                <asp:DropDownList ID="drlBaiGiang" runat="server" 
                onselectedindexchanged="drlBaiGiang_SelectedIndexChanged" 
                AutoPostBack="True" onload="drlBaiGiang_Load">
                </asp:DropDownList>
             <br />
            Tên Bài Giảng Mới: 
                <asp:TextBox ID="txtBaiGiangMoi" runat="server" Width="653px"></asp:TextBox>
    
            <br />
            Nội Dung Bài:
            <br />
            <CE:Editor ID="Editor1" runat="server" Height="600px" onload="Editor1_Load">
            </CE:Editor>
            
            <br />
            <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật" 
                onclick="btnCapNhat_Click" />
    
</div>


<cc1:msgBox ID="msgBox1" runat="server" />



