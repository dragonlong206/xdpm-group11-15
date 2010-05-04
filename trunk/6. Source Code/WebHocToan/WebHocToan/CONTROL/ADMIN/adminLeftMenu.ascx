<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adminLeftMenu.ascx.cs" Inherits="CONTROL_ADMIN_adminLeftMenu" %>

<div class="column_one_section">
        	<h1>Module Management </h1>
            <ul id="red" class="treeview-red">
                <li><span>Quản Lý Account</span>
                	<ul>
                        <li><a href="?ava=DanhSachAccount">Danh Sách Account</a></li>
                        <li><a href="?ava=ThemAccount">Thêm Account</a></li>
           			 </ul> 
                </li>
                <li><span>Quản Lý Bài Giảng</span>
                	<ul>
                        <li><a href="?ava=DanhSachBaiGiang">Danh Sách Bài Giảng</a></li>
                        <li><a href="?ava=CapNhatBaiGiang">Cập Nhật Bài Giảng</a></li>
                        <li><a href="?ava=ThemBaiGiang">Thêm Bài Giảng</a></li>
           			</ul> 
                </li>
                <li><span>Quản Lý Bài Tập</span>
                	<ul>
                        <li><a href="?ava=DanhSachBaiTap">Danh Sách Bài Tập</a></li>
                        <li><a href="?ava=ThemBaiTap">Thêm Bài Tập</a></li>
           			</ul> 
                </li>
                	
                <li><span>Quản Lý Comment</span>
                	<ul>
                        <li><a href="?ava=DanhSachComment">Danh Sách Comment</a></li>
           			</ul> 
                </li>

            </ul>                  
        </div>
        
        <div class="cleaner_with_divider">&nbsp;</div>
        
        <div class="column_one_section">
        
        	<h1>Site Setting</h1>
            <ul id="blue" class="treeview-red">
                <li><span>Quản Lý Template</span>
                	<ul>
                        <li><a href="#">Đổi Template</a></li>
                        <li><a href="#">Thêm Template</a></li>
           			 </ul> 
                </li>
            </ul>                  
        </div>
        
        <div class="cleaner_with_divider">&nbsp;</div>