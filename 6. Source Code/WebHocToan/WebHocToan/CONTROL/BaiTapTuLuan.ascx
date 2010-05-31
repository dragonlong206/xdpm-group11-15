<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BaiTapTuLuan.ascx.cs" Inherits="CONTROL_BaiTapTuLuan" %>


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
                                   <asp:Label ID="Label4" runat="server" Font-Bold="true" Text='<%# "   " + DataBinder.Eval(Container.DataItem, "NoiDungBaiTap")%>'></asp:Label>
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
