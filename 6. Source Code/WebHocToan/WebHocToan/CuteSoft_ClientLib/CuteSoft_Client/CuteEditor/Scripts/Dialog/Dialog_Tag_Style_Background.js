var OxO7b89=["SetStyle","length","","GetStyle","GetText",":",";","cssText","inp_color","inp_color_Preview","tb_image","btnbrowse","sel_bgrepeat","sel_bgattach","sel_hor","tb_hor","sel_hor_unit","sel_ver","tb_ver","sel_ver_unit","outer","div_demo","onclick","value","disabled","selectedIndex","style","backgroundImage","backgroundColor","backgroundRepeat","backgroundAttachment","backgroundPositionX","options","backgroundPositionY","url(",")","background-image","backgroundPosition","none"];function pause(Ox49e){var Oxa1= new Date();var Ox49f=Oxa1.getTime()+Ox49e;while(true){Oxa1= new Date();if(Oxa1.getTime()>Ox49f){return ;} ;} ;} ;function StyleClass(Ox1fa){var Ox4a1=[];var Ox4a2={};if(Ox1fa){Ox4a7();} ;this[OxO7b89[0]]=function SetStyle(name,Ox4e,Ox4a4){name=name.toLowerCase();for(var i=0;i<Ox4a1[OxO7b89[1]];i++){if(Ox4a1[i]==name){break ;} ;} ;Ox4a1[i]=name;Ox4a2[name]=Ox4e?(Ox4e+(Ox4a4||OxO7b89[2])):OxO7b89[2];} ;this[OxO7b89[3]]=function GetStyle(name){name=name.toLowerCase();return Ox4a2[name]||OxO7b89[2];} ;this[OxO7b89[4]]=function Ox4a6(){var Ox1fa=OxO7b89[2];for(var i=0;i<Ox4a1[OxO7b89[1]];i++){var n=Ox4a1[i];var p=Ox4a2[n];if(p){Ox1fa+=n+OxO7b89[5]+p+OxO7b89[6];} ;} ;return Ox1fa;} ;function Ox4a7(){var arr=Ox1fa.split(OxO7b89[6]);for(var i=0;i<arr[OxO7b89[1]];i++){var p=arr[i].split(OxO7b89[5]);var n=p[0].replace(/^\s+/g,OxO7b89[2]).replace(/\s+$/g,OxO7b89[2]).toLowerCase();Ox4a1[Ox4a1[OxO7b89[1]]]=n;Ox4a2[n]=p[1];} ;} ;} ;function GetStyle(Ox130,name){return  new StyleClass(Ox130.cssText).GetStyle(name);} ;function SetStyle(Ox130,name,Ox4e,Ox4a8){var Ox4a9= new StyleClass(Ox130.cssText);Ox4a9.SetStyle(name,Ox4e,Ox4a8);Ox130[OxO7b89[7]]=Ox4a9.GetText();} ;function ParseFloatToString(Ox24){var Ox8=parseFloat(Ox24);if(isNaN(Ox8)){return OxO7b89[2];} ;return Ox8+OxO7b89[2];} ;var inp_color=Window_GetElement(window,OxO7b89[8],true);var inp_color_Preview=Window_GetElement(window,OxO7b89[9],true);var tb_image=Window_GetElement(window,OxO7b89[10],true);var btnbrowse=Window_GetElement(window,OxO7b89[11],true);var sel_bgrepeat=Window_GetElement(window,OxO7b89[12],true);var sel_bgattach=Window_GetElement(window,OxO7b89[13],true);var sel_hor=Window_GetElement(window,OxO7b89[14],true);var tb_hor=Window_GetElement(window,OxO7b89[15],true);var sel_hor_unit=Window_GetElement(window,OxO7b89[16],true);var sel_ver=Window_GetElement(window,OxO7b89[17],true);var tb_ver=Window_GetElement(window,OxO7b89[18],true);var sel_ver_unit=Window_GetElement(window,OxO7b89[19],true);var outer=Window_GetElement(window,OxO7b89[20],true);var div_demo=Window_GetElement(window,OxO7b89[21],true);btnbrowse[OxO7b89[22]]=function btnbrowse_onclick(){function Ox354(Ox137){if(Ox137){tb_image[OxO7b89[23]]=Ox137;} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox354,tb_image.value,tb_image);} else {editor.ShowSelectImageDialog(Ox354,tb_image.value);} ;} ;UpdateState=function UpdateState_Background(){tb_hor[OxO7b89[24]]=sel_hor_unit[OxO7b89[24]]=(sel_hor[OxO7b89[25]]>0);tb_ver[OxO7b89[24]]=sel_ver_unit[OxO7b89[24]]=(sel_ver[OxO7b89[25]]>0);div_demo[OxO7b89[26]][OxO7b89[7]]=element[OxO7b89[26]][OxO7b89[7]];} ;SyncToView=function SyncToView_Background(){tb_image[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[27]];FixTbImage();inp_color[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[28]];inp_color[OxO7b89[26]][OxO7b89[28]]=element[OxO7b89[26]][OxO7b89[28]];inp_color_Preview[OxO7b89[26]][OxO7b89[28]]=element[OxO7b89[26]][OxO7b89[28]];sel_bgrepeat[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[29]];sel_bgattach[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[30]];sel_hor[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[31]];sel_hor_unit[OxO7b89[25]]=0;if(sel_hor[OxO7b89[25]]==-1){if(ParseFloatToString(element[OxO7b89[26]].backgroundPositionX)){tb_hor[OxO7b89[23]]=ParseFloatToString(element[OxO7b89[26]].backgroundPositionX);for(var i=0;i<sel_hor_unit[OxO7b89[32]][OxO7b89[1]];i++){var Ox13b=sel_hor_unit[OxO7b89[32]][i][OxO7b89[23]];if(Ox13b&&element[OxO7b89[26]][OxO7b89[31]].indexOf(Ox13b)!=-1){sel_hor_unit[OxO7b89[25]]=i;break ;} ;} ;} ;} ;sel_ver[OxO7b89[23]]=element[OxO7b89[26]][OxO7b89[33]];sel_ver_unit[OxO7b89[25]]=0;if(sel_ver[OxO7b89[25]]==-1){if(ParseFloatToString(element[OxO7b89[26]].backgroundPositionY)){tb_ver[OxO7b89[23]]=ParseFloatToString(element[OxO7b89[26]].backgroundPositionY);for(var i=0;i<sel_ver_unit[OxO7b89[32]][OxO7b89[1]];i++){var Ox13b=sel_ver_unit[OxO7b89[32]][i][OxO7b89[23]];if(Ox13b&&element[OxO7b89[26]][OxO7b89[33]].indexOf(Ox13b)!=-1){sel_ver_unit[OxO7b89[25]]=i;break ;} ;} ;} ;} ;} ;SyncTo=function SyncTo_Background(element){if(tb_image[OxO7b89[23]]){element[OxO7b89[26]][OxO7b89[27]]=OxO7b89[34]+tb_image[OxO7b89[23]]+OxO7b89[35];} else {SetStyle(element.style,OxO7b89[36],OxO7b89[2]);} ;try{element[OxO7b89[26]][OxO7b89[28]]=inp_color[OxO7b89[23]]||OxO7b89[2];} catch(x){element[OxO7b89[26]][OxO7b89[28]]=OxO7b89[2];} ;element[OxO7b89[26]][OxO7b89[29]]=sel_bgrepeat[OxO7b89[23]]||OxO7b89[2];element[OxO7b89[26]][OxO7b89[30]]=sel_bgattach[OxO7b89[23]]||OxO7b89[2];element[OxO7b89[26]][OxO7b89[37]]=OxO7b89[2];if(sel_hor[OxO7b89[25]]>0){element[OxO7b89[26]][OxO7b89[31]]=sel_hor[OxO7b89[23]];} else {if(ParseFloatToString(tb_hor.value)){element[OxO7b89[26]][OxO7b89[31]]=ParseFloatToString(tb_hor.value)+sel_hor_unit[OxO7b89[23]];} else {element[OxO7b89[26]][OxO7b89[31]]=OxO7b89[2];} ;} ;if(sel_ver[OxO7b89[25]]>0){element[OxO7b89[26]][OxO7b89[33]]=sel_ver[OxO7b89[23]];} else {if(ParseFloatToString(tb_ver.value)){element[OxO7b89[26]][OxO7b89[33]]=ParseFloatToString(tb_ver.value)+sel_ver_unit[OxO7b89[23]];} else {element[OxO7b89[26]][OxO7b89[33]]=OxO7b89[2];} ;} ;} ;function FixTbImage(){var Ox13b=tb_image[OxO7b89[23]].replace(/^(\s+)/g,OxO7b89[2]).replace(/(\s+)$/g,OxO7b89[2]);if(Ox13b.substr(0,4).toLowerCase()==OxO7b89[34]){Ox13b=Ox13b.substr(4,Ox13b[OxO7b89[1]]-4);} ;if(Ox13b.substr(Ox13b[OxO7b89[1]]-1,1)==OxO7b89[35]){Ox13b=Ox13b.substr(0,Ox13b[OxO7b89[1]]-1);} ;if(Ox13b==OxO7b89[38]){Ox13b=OxO7b89[2];} ;tb_image[OxO7b89[23]]=Ox13b;} ;inp_color[OxO7b89[22]]=inp_color_Preview[OxO7b89[22]]=function inp_color_onclick(){SelectColor(inp_color,inp_color_Preview);} ;