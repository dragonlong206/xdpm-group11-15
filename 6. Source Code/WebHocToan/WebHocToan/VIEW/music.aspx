<%@ Page Language="C#" MasterPageFile="~/VIEW/MASTERPAGE/MasterPageGiaiTri.master" AutoEventWireup="true" CodeFile="music.aspx.cs" Inherits="VIEW_music" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpRight" Runat="Server">
<h1>Giải Trí Nhé</h1>
<br />
<br />
<center>
    <embed hspace="5" vspace="5" src="../mp3/mp3player.swf" 
    menu="false" quality="high" width="450" height="500" 
    name="index" allowScriptAccess="never" 
    type="application/x-shockwave-flash" 
    pluginspage="http://www.macromedia.com/go/getflashplayer" 
    flashvars="&config=../mp3/config.xml&file=../mp3/playlist.xml" 
    wmode="transparent" border="0">
    </embed>
</center>
</asp:Content>

