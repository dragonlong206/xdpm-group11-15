<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ThemBaiTap.ascx.cs" Inherits="CONTROL_ADMIN_ThemBaiTap" %>
<%@ Register Assembly="msgBox" Namespace="BunnyBear" TagPrefix="cc1" %>
<%@ Register Assembly="CuteEditor" Namespace="CuteEditor" TagPrefix="CE" %>

<div class="column_four_section">
			<h1><a href="#" target="_parent">Thêm Bài Tập</a></h1>
            <p>Administrator Pages.</p>    
            Chọn Chương: 
    <asp:DropDownList ID="drlChuong" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataChuong" DataTextField="TenChuong" 
                DataValueField="IDChuong" 
                onselectedindexchanged="drlChuong_SelectedIndexChanged">
    </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataChuong" runat="server" 
                ConnectionString="<%$ ConnectionStrings:ConnectionString %>" 
                SelectCommand="SELECT * FROM [Chuong]"></asp:SqlDataSource>
    <br />
    <br />
            <asp:CheckBox ID="chbBaiTap" runat="server" AutoPostBack="True" 
                oncheckedchanged="chbBaiTap_CheckedChanged" 
                Text="Bài tập này có thuộc bài học hay không? (Checked: Có - Vui lòng chọn bài học)" />
    <br />
    <br />
    <asp:Label ID="lblBaiHoc" runat="server" Text="    Bài Học:" Visible="False"></asp:Label>
    <asp:DropDownList ID="drlBaiHoc" runat="server" Visible="False" 
                onselectedindexchanged="drlBaiHoc_SelectedIndexChanged">
    </asp:DropDownList>
    <br />
    <br />
    <asp:CheckBox ID="chbNoiDung" runat="server" 
                Text="Câu hỏi của bài tập đã có (Checked: Đã có nội dung bài tập)" 
                AutoPostBack="True" oncheckedchanged="cbtNoiDung_CheckedChanged" />
            <br />
            <br />
            <asp:Label ID="lblBaiTap" runat="server" Text="Chọn Bài Tập: " Visible="False"></asp:Label>
            <asp:DropDownList ID="drlNoiDung" runat="server" AutoPostBack="True" 
                Visible="False" onselectedindexchanged="drlNoiDung_SelectedIndexChanged">
            </asp:DropDownList>
            <br />

            <asp:Label ID="lblTenBaiTap" runat="server" Text="Nhập Tên Bài Tập : " 
                Visible="False"></asp:Label>

            <asp:TextBox ID="txtTenBaiTap" runat="server" Visible="False" Width="372px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ControlToValidate="txtTenBaiTap" ErrorMessage="RequiredFieldValidator">Tên 
            Bài tập không null</asp:RequiredFieldValidator>
    <br />
    Nhập Nội Dung:<br />
            <br />
            <asp:TextBox ID="txtNoiDung" runat="server" Height="150px" TextMode="MultiLine" 
                Width="499px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ControlToValidate="txtNoiDung" ErrorMessage="RequiredFieldValidator">Nội 
            dung bài tập không null</asp:RequiredFieldValidator>
    <br />
            Đáp Án A:
            <br />
&nbsp;<asp:TextBox ID="txtA" runat="server" Height="33px" 
             Width="493px"></asp:TextBox>
            <br />
            Đáp Án B:
            <br />
            <asp:TextBox ID="txtB" runat="server" Height="33px" 
              Width="493px"></asp:TextBox>
            <br />
            Đáp Án C:
            <br />
            <asp:TextBox ID="txtC" runat="server" Height="33px" 
              Width="493px"></asp:TextBox>
            <br />
            Đáp Án D:<br />
            <asp:TextBox ID="txtD" runat="server" Height="33px" 
               Width="493px"></asp:TextBox>
            <br />
            <br />
            Đáp Án Đúng<asp:DropDownList ID="drlDapAn" runat="server">
                <asp:ListItem Selected="True">A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
    <br />
    
    <asp:Button ID="btnbaitap" runat="server" Text="Thêm Bài Tập" 
                onclick="btnbaitap_Click" />
    <cc1:msgBox ID="MsgBox1" runat="server" />
</div>

