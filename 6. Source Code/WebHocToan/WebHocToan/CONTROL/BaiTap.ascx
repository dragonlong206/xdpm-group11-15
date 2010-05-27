<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BaiTap.ascx.cs" Inherits="CONTROL_BaiTap" %>

  <div class="column_four_section">
			<h1><a href="#" target="_parent"><asp:Literal ID="ltrTenBai" runat="server"></asp:Literal> - Bài Tập</a></h1>
       
	        Danh sách Bài Tập<br />
<asp:GridView ID="grQuestions" runat="server" AllowPaging="true" PageSize="10" AutoGenerateColumns="false">
           <Columns>
               <asp:TemplateField>
                   <ItemTemplate>
                       <table>
                           <tr>
                               <td>
                                   <asp:Label ID="lblQuestionName" runat="server" Font-Bold="true" Text='<%# "Bài Tập  " + DataBinder.Eval(Container.DataItem, "IDBaiTap")+ ": " + DataBinder.Eval(Container.DataItem, "TenBaiTap") %>'></asp:Label>
                               </td>
                           </tr>
                           <tr>
                               <td>
                                   <asp:Label ID="lblChoice1" runat="server" Text='<%# "A. " + DataBinder.Eval(Container.DataItem, "CauHoiA") %>'></asp:Label>
                               </td>
                               
                           </tr>
                           <tr>
                               <td>
                                   <asp:Label ID="Label1" runat="server" Text='<%# "B. " + DataBinder.Eval(Container.DataItem, "CauHoiB") %>'></asp:Label>
                               </td>
                               
                           </tr>
                           <tr>
                               <td>
                                   <asp:Label ID="Label2" runat="server" Text='<%# "C. " + DataBinder.Eval(Container.DataItem, "CauHoiC") %>'></asp:Label>
                               </td>
                               
                           </tr>
                           <tr>
                               <td>
                                   <asp:Label ID="Label3" runat="server" Text='<%# "D. " + DataBinder.Eval(Container.DataItem, "CauHoiD") %>'></asp:Label>
                               </td>
                               
                           </tr>
                           <tr>
                               <td>Chọn đáp án: 
                                   <asp:DropDownList ID="ddlChoices" runat="server">
                                       <asp:ListItem>A</asp:ListItem>
                                       <asp:ListItem>B</asp:ListItem>
                                       <asp:ListItem>C</asp:ListItem>
                                       <asp:ListItem>D</asp:ListItem>
                                   </asp:DropDownList>
                               </td>
                           </tr>
                       </table>
                   </ItemTemplate>
               </asp:TemplateField>
           </Columns>
       </asp:GridView>

            <br />
            <br />
&nbsp;<asp:Literal ID="ltrNoiDung" runat="server"></asp:Literal>
            
            
			<div class="post_comment">
                <a href="#"><span class="comment">18 comments</span></a>
            </div>        
</div>