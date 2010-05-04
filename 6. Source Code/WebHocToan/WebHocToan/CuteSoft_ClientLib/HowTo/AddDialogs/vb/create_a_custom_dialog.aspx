<%@ Page Language="vb" AutoEventWireup="false"%>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" > 
		<script language="JavaScript" type="text/javascript" >
			function ShowMyDialog(button)
			{
				//use CuteEditor_GetEditor(elementinsidetheEditor) to get the cute editor instance
				var editor=CuteEditor_GetEditor(button);
				//show the dialog page , and pass the editor as newwin.dialogArguments
				//(handler,url,args,feature)
				var newwin=editor.ShowDialog(null,"My_Custom_Text.html?_rand="+new Date().getTime()
					,editor,"dialogWidth:400px;dialogHeight:240px");
			}
		</script>

<html>
    <head>
		<title>ASP and ASP.NET WYSIWYG Editor - How to create a custom button which displays a dialog?</title>
		<link rel="stylesheet" href="../../example.css" type="text/css" />
	</head>
    <body >
        <form runat="server" ID="Form1">	
			<h2>How to create a custom button which displays a dialog?</h2> <hr>
			<br>
			In this example, first we get the location of Italic button. Then we add a custom dialog after it.
			<br><br>
			<CE:Editor id="Editor1" ThemeType="OfficeXP" AutoConfigure="Minimal" EditorWysiwygModeCss="example.css" runat="server" ></CE:Editor><br />
					
		
		</form>
	</body>
</html>

<script runat="server">

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'about Italic, see Full.config
        '<item type="image" name="Italic" imagename="Italic" />
        'get the pos after the Italic
        Dim pos As Integer

        pos = Editor1.ToolControls.IndexOf("Italic") + 1

        'Themes/%ThemeName%/Images/text.gif
        Dim ctrl As System.Web.UI.WebControls.WebControl
        ctrl = Editor1.CreateCommandButton("MyButton", "text.gif", "Insert My Custom Text")

        ctrl.Attributes("onclick") = "ShowMyDialog(this)"

        'add this custom button into the editor
        Editor1.InsertToolControl(pos, "MyButton", ctrl)
    End Sub
    
</script>