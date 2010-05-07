<%@ Page Language="C#" MasterPageFile="~/VIEW/MASTERPAGE/MasterPage.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="VIEW_index" Title="Untitled Page" %>

<%@ Register src="../CONTROL/LyThuyet.ascx" tagname="LyThuyet" tagprefix="uc1" %>
<%@ Register src="../CONTROL/BaiTap.ascx" tagname="BaiTap" tagprefix="uc2" %>
<%@ Register src="../CONTROL/LimitAccess.ascx" tagname="LimitAccess" tagprefix="uc3" %>

<%@ Register src="../CONTROL/Welcome.ascx" tagname="Welcome" tagprefix="uc4" %>

<%@ Register src="../CONTROL/Error.ascx" tagname="Error" tagprefix="uc5" %>

<%@ Register src="../CONTROL/DangKy/DangKy.ascx" tagname="DangKy" tagprefix="uc6" %>




<%-- Add content controls here --%>
<asp:Content ID="Content1" ContentPlaceHolderID="cpRight" Runat="Server">

    <uc6:DangKy ID="DangKy1" runat="server" Visible=false />
    <uc5:Error ID="Error1" runat="server" Visible=false />
    <uc4:Welcome ID="Welcome1" runat="server" Visible=false />
    <uc2:BaiTap ID="BaiTap1" runat="server" Visible=false/>
    <uc3:LimitAccess ID="LimitAccess1" runat="server" Visible=false />
    <uc1:LyThuyet ID="LyThuyet1" runat="server" Visible=false/>

</asp:Content>
