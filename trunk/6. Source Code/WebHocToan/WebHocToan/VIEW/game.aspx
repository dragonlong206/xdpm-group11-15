<%@ Page Language="C#" MasterPageFile="~/VIEW/MASTERPAGE/MasterPageGiaiTri.master" AutoEventWireup="true" CodeFile="music.aspx.cs" Inherits="VIEW_music" Title="Untitled Page" %>


<asp:Content ID="Content1" ContentPlaceHolderID="cpRight" Runat="Server">

<h1>Chơi Game Nhé</h1>
<br />
<br />
<center>
    <h2>1. Chơi Cờ Caro</h2>
    <object width='345' height='370'>
    <param name='movie' value='../Game/co_caro-440.swf'></param>
    <embed src='../Game/co_caro-440.swf' type='application/x-shockwave-flash' width='345' height='370' ></embed>
    </object>
    <br />

    <h2>2. Chơi Bài Nào</h2>
    <object width='345' height='370'>
    <param name='movie' value='../Game/danhbai.swf'></param>
    <embed src='../Game/danhbai.swf' type='application/x-shockwave-flash' width='345' height='370' ></embed>
    </object>
    <br />
   
    <h2>2. Dũng Sĩ Diệt Rồng</h2>
    <object width='345' height='370'>
    <param name='movie' value='../Game/dragonfablefs.swf'></param>
    <embed src='../Game/dragonfablefs.swf' type='application/x-shockwave-flash' width='345' height='370' ></embed>
    </object>
    <br />

</center>
</asp:Content>

