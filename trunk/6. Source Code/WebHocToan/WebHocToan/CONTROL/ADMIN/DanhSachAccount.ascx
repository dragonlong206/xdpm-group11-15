﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DanhSachAccount.ascx.cs" Inherits="CONTROL_ADMIN_DanhSachAccount" %>

<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Danh Sách Account</a></h1>
            <p>Administrator Pages.</p>
            Chọn loại Account: 
            <asp:DropDownList ID="drlLoaiAccount" runat="server" AutoPostBack="True" 
                onselectedindexchanged="drlLoaiAccount_SelectedIndexChanged">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="grvAccount" runat="server" AutoGenerateDeleteButton="True" 
                AutoGenerateEditButton="True" onrowdeleting="grvAccount_RowDeleting" 
                onrowediting="grvAccount_RowEditing">
            </asp:GridView>
            <cc1:msgBox ID="msgBox1" runat="server" />
            <br />
            
                
</div>