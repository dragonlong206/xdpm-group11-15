<%@ Page Language="VB"%>
<%@ Register TagPrefix="CE" Namespace="CuteEditor" Assembly="CuteEditor" %>

<html>
    <head>
		<title>ASP and ASP.NET WYSIWYG Editor - How to dynamically populate the tree view dropdown menu? </title>
		<link rel="stylesheet" href="../../../example.css" type="text/css" />
	</head>
    <body >
        <form runat="server">
			<h2>How to dynamically populate the tree view dropdown menu?</h2> <hr>
			<br />
			<h4>Populate the link tree view dropdown menu</h4>
			<CE:Editor EditorWysiwygModeCss="../../../example.css" id="Editor1" UseRelativeLinks="true" runat="server" ></CE:Editor><br />
			<hr>
			<h4>Add new tree view dropdown menu</h4>
			<CE:EDITOR id="Editor2" EditorWysiwygModeCss="../../../example.css" Autoconfigure="Minimal" runat="server"></CE:EDITOR>
	
		</form>
	</body>
</html>


<script runat="server">
	Public Sub Page_Load(sender As object, e As System.EventArgs)
	
		If Not Page.IsPostBack Then			
			Editor1.Text = "Type Here"
			Editor2.Text = "Type Here"
		End If
		
		
   		'Get the TreeDropDownList
		'check <item type="treedropdown" name="LinkTree" text="((Links))" width="50" command="InsertLink" />
		'check Common.config
		
		Dim tdd As CuteEditor.TreeDropDownList
		
		tdd = DirectCast(Editor1.ToolControls("LinkTree").Control, CuteEditor.TreeDropDownList)
	
		'clear the items from configuration files
		'see Configuration/Shared/Common.config
		'tdd.Items.Clear()
					
		'Add items by code
		Dim rootitem As CuteEditor.TreeListItem
		rootitem=new CuteEditor.TreeListItem("Root")
		
		rootitem.Selectable=false
		tdd.Items.Add(rootitem)
		rootitem.Items.Add("Asp<font color=red>.Net</font>","Asp.Net","http:'asp.net")
		rootitem.Items.Add("DotNetNuke.Net","DotNetNuke.Net","http:'DotNetNuke.com")
		rootitem.Items.Add("CuteSoft","CuteSoft","http:'CuteSoft.net")
	
	
		Dim tc as CuteEditor.ToolControl
		tc = Editor1.ToolControls("insertcustombutonhere")
		
		If Not tc Is Nothing Then
			
			Dim ddl As CuteEditor.TreeDropDownList
			ddl=new TreeDropDownList(Editor2)
			' ddl.RenderItemBorder=true
			ddl.CssClass="CuteEditorDropDown"

			'set the command and event handler
			ddl.Attributes("Command")="PasteHTML"
			'each item's value is just the parameter of Command
			ddl.Attributes("onchange")="CuteEditor_DropDownCommand(this,'"&ddl.Attributes("Command")&"')"

			'set the title
			ddl.RootItem.Text="MyTree"
			
			'Add items recursive
			AddItems(ddl.Items,"~/Uploads")			
			
			Dim index As Integer
	        index = Editor2.ToolControls.IndexOf("insertcustombutonhere") + 1
        
			Editor2.InsertToolControl(index,"MyTree",ddl)	

		End If
		
	End Sub
	
	Public Sub AddItems(ByVal items As CuteEditor.TreeListItemCollection,ByVal virpath As string)
		virpath=virpath.TrimEnd("/"c)
  
		Dim dir as string 
		dir=Server.MapPath(virpath)  
		
		Dim files() As String

		files=System.IO.Directory.GetFiles(dir)
		
		If files.Length=0 Then
			return 'Skip empty folder
		End If
		
		
        Dim diritem As CuteEditor.TreeListItem
        diritem = New CuteEditor.TreeListItem(System.IO.Path.GetFileName(dir))
		diritem.Selectable=false
		items.Add(diritem)
			
			
		dim subdir as string
		dim subfile as string
  
		'for each sub directories
		For each subdir in System.IO.Directory.GetDirectories(dir)
		
			dim subdirname as string
			dim subvirpath as string
			subdirname=System.IO.Path.GetFileName(subdir)
			subvirpath=virpath & "/" & subdirname
   
			' Recursive .
			AddItems( diritem.Items, subvirpath )
		Next
  
  
		For each subfile in files
		
			dim filename as string
			dim filepath as string
			dim filetype as string
			dim subdirname as string
			subdirname=System.IO.Path.GetFileName(subdir)
			
			filename=System.IO.Path.GetFileName(subfile)
			filepath=ResolveUrl(virpath).TrimEnd("/"c) & "/" & filename
			filetype=System.IO.Path.GetExtension(filename).ToLower()
			
			If filetype=".gif" or filetype=".jpg" or filetype=".png" Then
				Dim fileitem As CuteEditor.TreeListItem
				fileitem=new CuteEditor.TreeListItem(filename,"<img src='" & filepath & "' />")
				diritem.Items.Add(fileitem)
			End If
		Next
	
	End Sub	
	
</script>