<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CapNhatBaiTap.ascx.cs" Inherits="CONTROL_ADMIN_CapNhatBaiTap" %>


<%@ Register assembly="msgBox" namespace="BunnyBear" tagprefix="cc1" %>


<div class="column_four_section">
			<h1><a href="#" target="_parent">Cập Nhật Bài Tập</a></h1>
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
    <br />
    <br />
            <asp:CheckBox ID="chbBaiTap" runat="server" AutoPostBack="True" 
                oncheckedchanged="chbBaiTap_CheckedChanged" 
                Text="Bài tập này có thuộc bài học hay không? (Checked: Có - Vui lòng chọn bài học)" />
    <br />
    <br />
    <asp:Label ID="lblBaiHoc" runat="server" Text="    Bài Học:"></asp:Label>
    <asp:DropDownList ID="drlBaiHoc" runat="server" 
                onselectedindexchanged="drlBaiHoc_SelectedIndexChanged" 
                AutoPostBack="True">
    </asp:DropDownList>
    <br />
            <br />
            <asp:Label ID="lblBaiTap" runat="server" Text="Chọn Bài Tập: "></asp:Label>
            <asp:DropDownList ID="drlNoiDung" runat="server" AutoPostBack="True" 
                onselectedindexchanged="drlNoiDung_SelectedIndexChanged">
            </asp:DropDownList>
            <br />

            <asp:Label ID="lblTenBaiTap" runat="server" Text="Nhập Tên Bài Tập : "></asp:Label>

            <asp:TextBox ID="txtTenBaiTap" runat="server" Width="372px"></asp:TextBox>
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
            Đáp Án Đúng  : <asp:DropDownList ID="drlDapAn" runat="server">
                <asp:ListItem Selected="True">A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
    <br />
    
    <asp:Button ID="btnCapNhat" runat="server" Text="Cập Nhật Bài Tập" 
                onclick="btnCapNhat_Click" />
</div>
<cc1:msgBox ID="msgBox1" runat="server" />
