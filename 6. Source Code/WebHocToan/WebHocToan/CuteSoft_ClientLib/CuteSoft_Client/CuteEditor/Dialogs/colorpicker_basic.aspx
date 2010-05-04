<%@ Page Language="C#" Inherits="CuteEditor.EditorUtilityPage" %>
<script runat="server">
string GetDialogQueryString;
override protected void OnInit(EventArgs args)
{
	if(Context.Request.QueryString["Dialog"]=="Standard")
	{	
	if(Context.Request.QueryString["IsFrame"]==null)
	{
		string FrameSrc="colorpicker_basic.aspx?IsFrame=1&"+Request.ServerVariables["QUERY_STRING"];
		CuteEditor.CEU.WriteDialogOuterFrame(Context,"[[MoreColors]]",FrameSrc);
		Context.Response.End();
	}
	}
	string s="";
	if(Context.Request.QueryString["Dialog"]=="Standard")	
		s="&Dialog=Standard";
	
	GetDialogQueryString="Theme="+Context.Request.QueryString["Theme"]+s;	
	base.OnInit(args);
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta http-equiv="Page-Enter" content="blendTrans(Duration=0.1)" />
		<meta http-equiv="Page-Exit" content="blendTrans(Duration=0.1)" />
		<script type="text/javascript" src="Load.ashx?type=dialogscript&file=DialogHead.js"></script>
		<script type="text/javascript" src="Load.ashx?type=dialogscript&file=Dialog_ColorPicker.js"></script>
		<link href='Load.ashx?type=themecss&file=dialog.css&theme=[[_Theme_]]' type="text/css"
			rel="stylesheet" />
		<style type="text/css">
			.colorcell
			{
				width:16px;
				height:17px;
				cursor:hand;
			}
			.colordiv,.customdiv
			{
				border:solid 1px #808080;
				width:16px;
				height:17px;
				font-size:1px;
			}
		</style>
		<title>[[NamedColors]]</title>
		<script>
								
		var OxOdecd=["Green","#008000","Lime","#00FF00","Teal","#008080","Aqua","#00FFFF","Navy","#000080","Blue","#0000FF","Purple","#800080","Fuchsia","#FF00FF","Maroon","#800000","Red","#FF0000","Olive","#808000","Yellow","#FFFF00","White","#FFFFFF","Silver","#C0C0C0","Gray","#808080","Black","#000000","DarkOliveGreen","#556B2F","DarkGreen","#006400","DarkSlateGray","#2F4F4F","SlateGray","#708090","DarkBlue","#00008B","MidnightBlue","#191970","Indigo","#4B0082","DarkMagenta","#8B008B","Brown","#A52A2A","DarkRed","#8B0000","Sienna","#A0522D","SaddleBrown","#8B4513","DarkGoldenrod","#B8860B","Beige","#F5F5DC","HoneyDew","#F0FFF0","DimGray","#696969","OliveDrab","#6B8E23","ForestGreen","#228B22","DarkCyan","#008B8B","LightSlateGray","#778899","MediumBlue","#0000CD","DarkSlateBlue","#483D8B","DarkViolet","#9400D3","MediumVioletRed","#C71585","IndianRed","#CD5C5C","Firebrick","#B22222","Chocolate","#D2691E","Peru","#CD853F","Goldenrod","#DAA520","LightGoldenrodYellow","#FAFAD2","MintCream","#F5FFFA","DarkGray","#A9A9A9","YellowGreen","#9ACD32","SeaGreen","#2E8B57","CadetBlue","#5F9EA0","SteelBlue","#4682B4","RoyalBlue","#4169E1","BlueViolet","#8A2BE2","DarkOrchid","#9932CC","DeepPink","#FF1493","RosyBrown","#BC8F8F","Crimson","#DC143C","DarkOrange","#FF8C00","BurlyWood","#DEB887","DarkKhaki","#BDB76B","LightYellow","#FFFFE0","Azure","#F0FFFF","LightGray","#D3D3D3","LawnGreen","#7CFC00","MediumSeaGreen","#3CB371","LightSeaGreen","#20B2AA","DeepSkyBlue","#00BFFF","DodgerBlue","#1E90FF","SlateBlue","#6A5ACD","MediumOrchid","#BA55D3","PaleVioletRed","#DB7093","Salmon","#FA8072","OrangeRed","#FF4500","SandyBrown","#F4A460","Tan","#D2B48C","Gold","#FFD700","Ivory","#FFFFF0","GhostWhite","#F8F8FF","Gainsboro","#DCDCDC","Chartreuse","#7FFF00","LimeGreen","#32CD32","MediumAquamarine","#66CDAA","DarkTurquoise","#00CED1","CornflowerBlue","#6495ED","MediumSlateBlue","#7B68EE","Orchid","#DA70D6","HotPink","#FF69B4","LightCoral","#F08080","Tomato","#FF6347","Orange","#FFA500","Bisque","#FFE4C4","Khaki","#F0E68C","Cornsilk","#FFF8DC","Linen","#FAF0E6","WhiteSmoke","#F5F5F5","GreenYellow","#ADFF2F","DarkSeaGreen","#8FBC8B","Turquoise","#40E0D0","MediumTurquoise","#48D1CC","SkyBlue","#87CEEB","MediumPurple","#9370DB","Violet","#EE82EE","LightPink","#FFB6C1","DarkSalmon","#E9967A","Coral","#FF7F50","NavajoWhite","#FFDEAD","BlanchedAlmond","#FFEBCD","PaleGoldenrod","#EEE8AA","Oldlace","#FDF5E6","Seashell","#FFF5EE","PaleGreen","#98FB98","SpringGreen","#00FF7F","Aquamarine","#7FFFD4","PowderBlue","#B0E0E6","LightSkyBlue","#87CEFA","LightSteelBlue","#B0C4DE","Plum","#DDA0DD","Pink","#FFC0CB","LightSalmon","#FFA07A","Wheat","#F5DEB3","Moccasin","#FFE4B5","AntiqueWhite","#FAEBD7","LemonChiffon","#FFFACD","FloralWhite","#FFFAF0","Snow","#FFFAFA","AliceBlue","#F0F8FF","LightGreen","#90EE90","MediumSpringGreen","#00FA9A","PaleTurquoise","#AFEEEE","LightCyan","#E0FFFF","LightBlue","#ADD8E6","Lavender","#E6E6FA","Thistle","#D8BFD8","MistyRose","#FFE4E1","Peachpuff","#FFDAB9","PapayaWhip","#FFEFD5"];var colorlist=[{n:OxOdecd[0],h:OxOdecd[1]},{n:OxOdecd[2],h:OxOdecd[3]},{n:OxOdecd[4],h:OxOdecd[5]},{n:OxOdecd[6],h:OxOdecd[7]},{n:OxOdecd[8],h:OxOdecd[9]},{n:OxOdecd[10],h:OxOdecd[11]},{n:OxOdecd[12],h:OxOdecd[13]},{n:OxOdecd[14],h:OxOdecd[15]},{n:OxOdecd[16],h:OxOdecd[17]},{n:OxOdecd[18],h:OxOdecd[19]},{n:OxOdecd[20],h:OxOdecd[21]},{n:OxOdecd[22],h:OxOdecd[23]},{n:OxOdecd[24],h:OxOdecd[25]},{n:OxOdecd[26],h:OxOdecd[27]},{n:OxOdecd[28],h:OxOdecd[29]},{n:OxOdecd[30],h:OxOdecd[31]}];var colormore=[{n:OxOdecd[32],h:OxOdecd[33]},{n:OxOdecd[34],h:OxOdecd[35]},{n:OxOdecd[36],h:OxOdecd[37]},{n:OxOdecd[38],h:OxOdecd[39]},{n:OxOdecd[40],h:OxOdecd[41]},{n:OxOdecd[42],h:OxOdecd[43]},{n:OxOdecd[44],h:OxOdecd[45]},{n:OxOdecd[46],h:OxOdecd[47]},{n:OxOdecd[48],h:OxOdecd[49]},{n:OxOdecd[50],h:OxOdecd[51]},{n:OxOdecd[52],h:OxOdecd[53]},{n:OxOdecd[54],h:OxOdecd[55]},{n:OxOdecd[56],h:OxOdecd[57]},{n:OxOdecd[58],h:OxOdecd[59]},{n:OxOdecd[60],h:OxOdecd[61]},{n:OxOdecd[62],h:OxOdecd[63]},{n:OxOdecd[64],h:OxOdecd[65]},{n:OxOdecd[66],h:OxOdecd[67]},{n:OxOdecd[68],h:OxOdecd[69]},{n:OxOdecd[70],h:OxOdecd[71]},{n:OxOdecd[72],h:OxOdecd[73]},{n:OxOdecd[74],h:OxOdecd[75]},{n:OxOdecd[76],h:OxOdecd[77]},{n:OxOdecd[78],h:OxOdecd[79]},{n:OxOdecd[80],h:OxOdecd[81]},{n:OxOdecd[82],h:OxOdecd[83]},{n:OxOdecd[84],h:OxOdecd[85]},{n:OxOdecd[86],h:OxOdecd[87]},{n:OxOdecd[88],h:OxOdecd[89]},{n:OxOdecd[90],h:OxOdecd[91]},{n:OxOdecd[92],h:OxOdecd[93]},{n:OxOdecd[94],h:OxOdecd[95]},{n:OxOdecd[96],h:OxOdecd[97]},{n:OxOdecd[98],h:OxOdecd[99]},{n:OxOdecd[100],h:OxOdecd[101]},{n:OxOdecd[102],h:OxOdecd[103]},{n:OxOdecd[104],h:OxOdecd[105]},{n:OxOdecd[106],h:OxOdecd[107]},{n:OxOdecd[108],h:OxOdecd[109]},{n:OxOdecd[110],h:OxOdecd[111]},{n:OxOdecd[112],h:OxOdecd[113]},{n:OxOdecd[114],h:OxOdecd[115]},{n:OxOdecd[116],h:OxOdecd[117]},{n:OxOdecd[118],h:OxOdecd[119]},{n:OxOdecd[120],h:OxOdecd[121]},{n:OxOdecd[122],h:OxOdecd[123]},{n:OxOdecd[124],h:OxOdecd[125]},{n:OxOdecd[126],h:OxOdecd[127]},{n:OxOdecd[128],h:OxOdecd[129]},{n:OxOdecd[130],h:OxOdecd[131]},{n:OxOdecd[132],h:OxOdecd[133]},{n:OxOdecd[134],h:OxOdecd[135]},{n:OxOdecd[136],h:OxOdecd[137]},{n:OxOdecd[138],h:OxOdecd[139]},{n:OxOdecd[140],h:OxOdecd[141]},{n:OxOdecd[142],h:OxOdecd[143]},{n:OxOdecd[144],h:OxOdecd[145]},{n:OxOdecd[146],h:OxOdecd[147]},{n:OxOdecd[148],h:OxOdecd[149]},{n:OxOdecd[150],h:OxOdecd[151]},{n:OxOdecd[152],h:OxOdecd[153]},{n:OxOdecd[154],h:OxOdecd[155]},{n:OxOdecd[156],h:OxOdecd[157]},{n:OxOdecd[158],h:OxOdecd[159]},{n:OxOdecd[160],h:OxOdecd[161]},{n:OxOdecd[162],h:OxOdecd[163]},{n:OxOdecd[164],h:OxOdecd[165]},{n:OxOdecd[166],h:OxOdecd[167]},{n:OxOdecd[168],h:OxOdecd[169]},{n:OxOdecd[170],h:OxOdecd[171]},{n:OxOdecd[172],h:OxOdecd[173]},{n:OxOdecd[174],h:OxOdecd[175]},{n:OxOdecd[176],h:OxOdecd[177]},{n:OxOdecd[178],h:OxOdecd[179]},{n:OxOdecd[180],h:OxOdecd[181]},{n:OxOdecd[182],h:OxOdecd[183]},{n:OxOdecd[184],h:OxOdecd[185]},{n:OxOdecd[186],h:OxOdecd[187]},{n:OxOdecd[188],h:OxOdecd[189]},{n:OxOdecd[190],h:OxOdecd[191]},{n:OxOdecd[192],h:OxOdecd[193]},{n:OxOdecd[194],h:OxOdecd[195]},{n:OxOdecd[196],h:OxOdecd[197]},{n:OxOdecd[198],h:OxOdecd[199]},{n:OxOdecd[200],h:OxOdecd[201]},{n:OxOdecd[202],h:OxOdecd[203]},{n:OxOdecd[204],h:OxOdecd[205]},{n:OxOdecd[206],h:OxOdecd[207]},{n:OxOdecd[208],h:OxOdecd[209]},{n:OxOdecd[210],h:OxOdecd[211]},{n:OxOdecd[212],h:OxOdecd[213]},{n:OxOdecd[214],h:OxOdecd[215]},{n:OxOdecd[216],h:OxOdecd[217]},{n:OxOdecd[218],h:OxOdecd[219]},{n:OxOdecd[220],h:OxOdecd[221]},{n:OxOdecd[156],h:OxOdecd[157]},{n:OxOdecd[222],h:OxOdecd[223]},{n:OxOdecd[224],h:OxOdecd[225]},{n:OxOdecd[226],h:OxOdecd[227]},{n:OxOdecd[228],h:OxOdecd[229]},{n:OxOdecd[230],h:OxOdecd[231]},{n:OxOdecd[232],h:OxOdecd[233]},{n:OxOdecd[234],h:OxOdecd[235]},{n:OxOdecd[236],h:OxOdecd[237]},{n:OxOdecd[238],h:OxOdecd[239]},{n:OxOdecd[240],h:OxOdecd[241]},{n:OxOdecd[242],h:OxOdecd[243]},{n:OxOdecd[244],h:OxOdecd[245]},{n:OxOdecd[246],h:OxOdecd[247]},{n:OxOdecd[248],h:OxOdecd[249]},{n:OxOdecd[250],h:OxOdecd[251]},{n:OxOdecd[252],h:OxOdecd[253]},{n:OxOdecd[254],h:OxOdecd[255]},{n:OxOdecd[256],h:OxOdecd[257]},{n:OxOdecd[258],h:OxOdecd[259]},{n:OxOdecd[260],h:OxOdecd[261]},{n:OxOdecd[262],h:OxOdecd[263]},{n:OxOdecd[264],h:OxOdecd[265]},{n:OxOdecd[266],h:OxOdecd[267]},{n:OxOdecd[268],h:OxOdecd[269]},{n:OxOdecd[270],h:OxOdecd[271]},{n:OxOdecd[272],h:OxOdecd[273]}];
		
		</script>
	</head>
	<body>
		<div id="container">
			<div class="tab-pane-control tab-pane" id="tabPane1">
				<div class="tab-row">
					<h2 class="tab">
						<a tabindex="-1" href='colorpicker.aspx?<%=GetDialogQueryString%>'>
							<span style="white-space:nowrap;">
								[[WebPalette]]
							</span>
						</a>
					</h2>
					<h2 class="tab selected">
							<a tabindex="-1" href='colorpicker_basic.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[NamedColors]]
								</span>
							</a>
					</h2>
					<h2 class="tab">
							<a tabindex="-1" href='colorpicker_more.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[CustomColor]]
								</span>
							</a>
					</h2>
				</div>
				<div class="tab-page">			
					<table class="colortable" align="center">
						<tr>
							<td colspan="16" height="16"><p align="left">Basic:
								</p>
							</td>
						</tr>
						<tr>
							<script>
								var OxO30b1=["length","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E",""];var arr=[];for(var i=0;i<colorlist[OxO30b1[0]];i++){arr.push(OxO30b1[1]);arr.push(colorlist[i].n);arr.push(OxO30b1[2]);arr.push(colorlist[i].n);arr.push(OxO30b1[3]);arr.push(colorlist[i].h);arr.push(OxO30b1[4]);arr.push(colorlist[i].n);arr.push(OxO30b1[5]);arr.push(colorlist[i].h);arr.push(OxO30b1[6]);} ;document.write(arr.join(OxO30b1[7]));
							</script>
						</tr>
						<tr>
							<td colspan="16" height="12"><p align="left"></p>
							</td>
						</tr>
						<tr>
							<td colspan="16"><p align="left">Additional:
								</p>
							</td>
						</tr>
						<script>
							var OxO3a52=["length","\x3Ctr\x3E","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E","\x3C/tr\x3E",""];var arr=[];for(var i=0;i<colormore[OxO3a52[0]];i++){if(i%16==0){arr.push(OxO3a52[1]);} ;arr.push(OxO3a52[2]);arr.push(colormore[i].n);arr.push(OxO3a52[3]);arr.push(colormore[i].n);arr.push(OxO3a52[4]);arr.push(colormore[i].h);arr.push(OxO3a52[5]);arr.push(colormore[i].n);arr.push(OxO3a52[6]);arr.push(colormore[i].h);arr.push(OxO3a52[7]);if(i%16==15){arr.push(OxO3a52[8]);} ;} ;if(colormore%16>0){arr.push(OxO3a52[8]);} ;document.write(arr.join(OxO3a52[9]));
						</script>
						<tr>
							<td colspan="16" height="8">
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
								<input checked id="CheckboxColorNames" style="width: 16px; height: 20px" type="checkbox">
								<span style="width: 118px;">Use color names</span>
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
							</td>
						</tr>
						<tr>
							<td colspan="16" valign="middle" height="24">
							<span style="height:24px;width:50px;vertical-align:middle;">Color : </span>&nbsp;
							<input type="text" id="divpreview" size="7" maxlength="7" style="width:180px;height:24px;border:#a0a0a0 1px solid; Padding:4;"/>
					
							</td>
						</tr>
				</table>
			</div>
		</div>
		<div id="container-bottom">
			<input type="button" id="buttonok" value="[[OK]]" class="formbutton" style="width:70px"	onclick="do_insert();" /> 
			&nbsp;&nbsp;&nbsp;&nbsp; 
			<input type="button" id="buttoncancel" value="[[Cancel]]" class="formbutton" style="width:70px"	onclick="do_Close();" />	
		</div>
	</div>
	</body>
</html>

