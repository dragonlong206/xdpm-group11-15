<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LeftMenu.ascx.cs" Inherits="CONTROL_LeftMenu" %>

<div class="column_one_section">
        	<h1>Danh Mục Bài Giảng</h1>
            <ul id="red" class="treeview-red">
                <asp:Repeater ID="rptChuong" runat="server" 
                    onitemdatabound="rptChuong_ItemDataBound">
                    <ItemTemplate>
                        <li><span><%#Eval("TenChuong")%></span>
                            <ul>
                            
                                <asp:Repeater ID="rptBai" runat="server">
                                    <ItemTemplate>
                                        <li><span><%#Eval("TenBaiHoc")%></span>
                                        
                                        <ul>    
                                            <li><a href="?ava=LyThuyet&IDBaiHoc=<%#Eval("IDBaiHoc")%>">- Lý Thuyết</a></li>
                                            <li><a href="?ava=BaiTap&IDBaiHoc=<%#Eval("IDBaiHoc")%>">- Bài Tập</a></li>
                                        </ul>
                                        
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>

                            </ul>                     
                        
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
                
            </ul>                  
        </div>
        
        <div class="cleaner_with_divider">&nbsp;</div>