<%@ Page Language="C#" MasterPageFile="~/VIEW/ADMIN/MASTERPAGE/MasterPage.master" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="VIEW_ADMIN_admin" Title="Untitled Page" %>

<%@ Register src="../../CONTROL/ADMIN/adminWelcome.ascx" tagname="adminWelcome" tagprefix="uc1" %>
<%@ Register src="../../CONTROL/ADMIN/DanhSachAccount.ascx" tagname="DanhSachAccount" tagprefix="uc2" %>
<%@ Register src="../../CONTROL/ADMIN/DanhSachBaiGiang.ascx" tagname="DanhSachBaiGiang" tagprefix="uc3" %>
<%@ Register src="../../CONTROL/ADMIN/DanhSachBaiTap.ascx" tagname="DanhSachBaiTap" tagprefix="uc4" %>
<%@ Register src="../../CONTROL/ADMIN/DanhSachComment.ascx" tagname="DanhSachComment" tagprefix="uc5" %>
<%@ Register src="../../CONTROL/ADMIN/ThemAccount.ascx" tagname="ThemAccount" tagprefix="uc6" %>
<%@ Register src="../../CONTROL/ADMIN/ThemBaiGiang.ascx" tagname="ThemBaiGiang" tagprefix="uc7" %>
<%@ Register src="../../CONTROL/ADMIN/ThemBaiTap.ascx" tagname="ThemBaiTap" tagprefix="uc8" %>
<%@ Register Src="../../CONTROL/ADMIN/CapNhatBaiGiang.ascx" TagName="CapNhatBaiGiang" TagPrefix="uc9" %>
<%@ Register Src="../../CONTROL/ADMIN/CapNhatBaiTap.ascx" TagName="CapNhatBaiTap" TagPrefix="uc10" %>
<%@ Register Src="../../CONTROL/ADMIN/ThemBaiTapTuLuan.ascx" TagName="ThemBaiTapTuLuan" TagPrefix="uc11" %>
<%@ Register Src="../../CONTROL/ADMIN/DanhSachBaiTapTuLuan.ascx" TagName="DanhSachBaiTapTuLuan" TagPrefix="uc12" %>
<%@ Register Src="../../CONTROL/ADMIN/CapNhatBaiTapTuLuan.ascx" TagName="CapNhatBaiTapTuLuan" TagPrefix="uc13" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpRight" Runat="Server">

    <uc13:CapNhatBaiTapTuLuan ID="CapNhatBaiTapTuLuan1" runat="server" Visible ="false" />
    <uc12:DanhSachBaiTapTuLuan ID="DanhSachBaiTapTuLuan1" runat="server" Visible="false" />
    <uc11:ThemBaiTapTuLuan ID="ThemBaiTapTuLuan1" runat="server" Visible=false />
    <uc10:CapNhatBaiTap ID="CapNhatBaiTap1" runat="server" Visible ="false" />
    <uc9:CapNhatBaiGiang ID="CapNhatBaiGiang1" runat="server" Visible="false" />
    <uc8:ThemBaiTap ID="ThemBaiTap1" runat="server" Visible=false />
    <uc7:ThemBaiGiang ID="ThemBaiGiang1" runat="server" Visible=false />
    <uc6:ThemAccount ID="ThemAccount1" runat="server" Visible=false />
    <uc5:DanhSachComment ID="DanhSachComment1" runat="server" Visible=false />
    <uc4:DanhSachBaiTap ID="DanhSachBaiTap1" runat="server" Visible=false />
    <uc3:DanhSachBaiGiang ID="DanhSachBaiGiang1" runat="server" Visible=false />
    <uc2:DanhSachAccount ID="DanhSachAccount1" runat="server" Visible=false />
    <uc1:adminWelcome ID="adminWelcome1" runat="server" Visible=false />


</asp:Content>

