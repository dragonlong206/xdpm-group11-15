﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachBaiGiang.ascx.cs" Inherits="CONTROL_ADMIN_DanhSachBaiGiang" %>

<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>

<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Danh Sách Bài Giảng</a></h1>
            <p>Administrator Pages.</p>   
        <br />
              Chọn Môn Học: 
    <asp:DropDownList ID="drlMonHoc" runat="server" AutoPostBack="True" DataTextField="TenMonHoc" 
                DataValueField="IDMonHoc" 
                onselectedindexchanged="drlMonHoc_SelectedIndexChanged">
    </asp:DropDownList>
            <br />   
            Chọn Chương: 
    <asp:DropDownList ID="drlChuong" runat="server" AutoPostBack="True" DataTextField="TenChuong" 
                DataValueField="IDChuong" 
                onselectedindexchanged="drlChuong_SelectedIndexChanged">
    </asp:DropDownList>
             <br/>   
             Các Bài Học Trong Chương: 
             <br />
             <asp:GridView ID="grvBaiHoc" runat="server" AutoGenerateDeleteButton="True" 
                AutoGenerateEditButton="True" 
                onrowdeleting="grvBaiHoc_RowDeleting" onrowediting="grvBaiHoc_RowEditing">
            </asp:GridView>
             <br />
             
</div>
<cc1:msgBox ID="msgBox1" runat="server" />

</ContentTemplate>

</asp:UpdatePanel>

