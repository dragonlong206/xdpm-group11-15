<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemBaiTapTuLuan.ascx.cs" Inherits="CONTROL_ADMIN_ThemBaiTapTuLuan" %>
<%@ Register assembly="CuteEditor" namespace="CuteEditor" tagprefix="CE" %>
<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>


<div class="column_four_section">
			<h1><a href="#" target="_parent">Thêm Bài Tập Tự Luận</a></h1>
            <p>Administrator Pages.</p>  
          
            <br />
                   Chọn Môn Học: 
    <asp:DropDownList ID="drlMonHoc" runat="server" AutoPostBack="True" DataTextField="TenMonHoc" 
                DataValueField="IDMonHoc" 
                onselectedindexchanged="drlMonHoc_SelectedIndexChanged">
    </asp:DropDownList>
            <br /> 
            <br />
            
              
            Chọn Chương:<asp:DropDownList ID="drlChuong" 
                runat="server" DataTextField="TenChuong" 
                DataValueField="IDChuong" 
                onselectedindexchanged="drlChuong_SelectedIndexChanged">
            </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="lblBaiHoc" runat="server" Text="    Bài Học:"></asp:Label>
    <asp:DropDownList ID="drlBaiHoc" runat="server" 
                onselectedindexchanged="drlBaiHoc_SelectedIndexChanged">
    </asp:DropDownList>
            <br />
            <br />
            <br />
            Tên Bài Tập:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
    <asp:Button ID="btnThem" runat="server" Text="Thêm" onclick="btnThem_Click" />
</div>
<cc1:msgBox ID="msgBox1" runat="server" />

