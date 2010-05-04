<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<%@ Page Language="C#"%>
<HTML>
	<HEAD>
		<title>ASP and ASP.NET WYSIWYG Editor - Use CuteEditor as an image selector</title>
	</HEAD>
	<body>
		<form runat="server">
			<table border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="10" nowrap></td>
					<td width="20" nowrap></td>
					<td valign="top" width="760">
						<b>Use CuteEditor as an image selector</b>
						<hr>
						This example demonstrates how to use CuteEditor as an image selector.
						<br>
						<br>
						<asp:TextBox id="imageFld" Width="300" runat="server" /> 
						<INPUT type="button" value="Change Image" onclick="callInsertImage()" id="Change" runat="server" NAME="Change">   
						
						<div>
							<CE:Editor id="Editor1" runat="server" Width="1" Height="1" AutoConfigure="None" ShowHtmlMode="False" ShowPreviewMode="False" EnableContextMenu="false" ShowGroupMenuImage="False" ShowBottomBar="False" BackColor="White" BorderColor="White"></CE:Editor><br>
						</div>
					</td>
				<tr>
				</tr>
			</table>
		</form>
 
<Script Language="javascript"> 
    function callInsertImage()  
    {  
			var editor1 = document.getElementById('<%=Editor1.ClientID%>');
            editor1.FocusDocument();  
            var editdoc = editor1.GetDocument();  
            editor1.ExecCommand('new');
            editor1.ExecCommand('ImageGalleryByBrowsing');
            InputURL();
    }    
    
    function InputURL()
    { 
		var editor1 = document.getElementById('<%=Editor1.ClientID%>');
        var editdoc = editor1.GetDocument();  
        var imgs = editdoc.images;
        if(imgs.length>0)  
        {	document.getElementById("imageFld").value = imgs[imgs.length-1].src;
            editor1.ExecCommand('new');
            document.getElementById("imageFld").focus(); 
        }  
        else
        {
			setTimeout(InputURL,500); 
        }  
    }       
</script> 

	</body>
</HTML>
