var OxOc6e4=["hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.bgColor=\x27#eeeeee\x27;","onmouseout","this.bgColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","Form1","Image1","FolderDescription","CreateDir","Copy","Move","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","row0","row0_cb","divpreview","Table3","Width","Height","bgColortext","bgColortext_Preview","Quality","Scale","Align","HSpace","VSpace","chk_Loop","chk_Autoplay","chk_Transparency","chk_FlashMenu","chk_Fullscreen","btn_zoom_in","btn_zoom_out","btn_Actualsize","Please choose a Flash movie to insert",".flv","checked","\x26autoPlay=true","[[_CuteEditorResource_]]flashplayer.swf?videoUrl=http://","hostname","location","\x26playerMode=simple","scale=\x27noborder\x27","Noborder","scale=\x27exactfit\x27","Exactfit","hspace=\x22","\x22 ","vspace=\x22","align=\x22","wmode=\x22transparent\x22","allowfullscreen=\x22true\x22","allowfullscreen=\x22false\x22","menu=\x22false\x22","loop=\x22false\x22","play=\x22false\x22","bgcolor=\x22","\x22","\x3Cembed src=\x22","\x22 width=\x22","\x22 height=\x22"," quality=\x22"," type=\x22application/x-shockwave-flash\x22 pluginspage=\x22http://www.macromedia.com/go/getflashplayer\x22 \x3E\x3C/embed\x3E\x0A","\x3Cobject xcodebase=","\x22http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab\x22"," height=\x22"," classid=","\x22clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\x22 \x3E"," \x3Cparam name=\x22Movie\x22 value=\x22","\x22 /\x3E"," \x3Cparam name=\x22Quality\x22 value=\x22","\x22/\x3E","\x3Cparam name=\x22wmode\x22 value=\x22transparent\x22/\x3E","\x3Cparam name=\x22allowFullScreen\x22 value=\x22true\x22/\x3E","\x3Cparam name=\x22allowFullScreen\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22menu\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22loop\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22play\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22scale\x22 value=\x22","\x3Cparam name=\x22bgcolor\x22 value=\x22","\x3C/object\x3E","zoom","style","onclick","display","none","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","border","1px solid #b0bec7","backgroundColor","#f0f0f0","position","absolute","width","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","top","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];var hiddenDirectory=Window_GetElement(window,OxOc6e4[0],true);var hiddenFile=Window_GetElement(window,OxOc6e4[1],true);var hiddenAlert=Window_GetElement(window,OxOc6e4[2],true);var hiddenAction=Window_GetElement(window,OxOc6e4[3],true);var hiddenActionData=Window_GetElement(window,OxOc6e4[4],true);function CreateDir_click(){if(isDemoMode){alert(OxOc6e4[5]);return false;} ;if(Event_GetSrcElement()[OxOc6e4[6]]){alert(OxOc6e4[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxOc6e4[8],OxOc6e4[9]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;hiddenAction[OxOc6e4[10]]=OxOc6e4[11];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxOc6e4[8],OxOc6e4[9]);if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxOc6e4[5]);return false;} ;if(Event_GetSrcElement()[OxOc6e4[6]]){alert(OxOc6e4[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxOc6e4[12],OxOc6e4[13]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;hiddenAction[OxOc6e4[10]]=OxOc6e4[14];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxOc6e4[12],OxOc6e4[13]);if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxOc6e4[5]);return false;} ;if(Event_GetSrcElement()[OxOc6e4[6]]){alert(OxOc6e4[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox218,OxOc6e4[12],OxOc6e4[13]);function Ox218(Ox379){if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;hiddenAction[OxOc6e4[10]]=OxOc6e4[15];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox379=prompt(OxOc6e4[12],OxOc6e4[13]);if(Ox379){hiddenActionData[OxOc6e4[10]]=Ox379;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxOc6e4[5]);return false;} ;if(Event_GetSrcElement()[OxOc6e4[6]]){alert(OxOc6e4[7]);return false;} ;return confirm(OxOc6e4[16]);} ;function EditImg_click(img){if(isDemoMode){alert(OxOc6e4[5]);return false;} ;if(img[OxOc6e4[6]]){alert(OxOc6e4[7]);return false;} ;var Ox37e=img[OxOc6e4[17]][OxOc6e4[17]];var Ox37f=Ox37e[OxOc6e4[18]];var name;var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxOc6e4[19])==OxOc6e4[20];} else {Ox380=Ox37e[OxOc6e4[19]];} ;if(Browser_IsIE7()){var Oxc3;if(Ox380){IEprompt(Ox218,OxOc6e4[8],Ox37f);} else {var i=Ox37f.lastIndexOf(OxOc6e4[21]);Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxOc6e4[21]));IEprompt(Ox218,OxOc6e4[22],Ox12);} ;function Ox218(Ox379){if(Ox379&&Ox379!=Ox37e[OxOc6e4[18]]){if(!Ox380){Ox379=Ox379+Oxc3;} ;hiddenAction[OxOc6e4[10]]=OxOc6e4[23];hiddenActionData[OxOc6e4[10]]=(Ox380?OxOc6e4[24]:OxOc6e4[25])+OxOc6e4[26]+Ox37e[OxOc6e4[27]]+OxOc6e4[26]+Ox379;window.PostBackAction();} ;} ;} else {if(Ox380){name=prompt(OxOc6e4[8],Ox37f);} else {var i=Ox37f.lastIndexOf(OxOc6e4[21]);var Oxc3=Ox37f.substr(i);var Ox12=Ox37f.substr(0,Ox37f.lastIndexOf(OxOc6e4[21]));name=prompt(OxOc6e4[22],Ox12);if(name){name=name+Oxc3;} ;} ;if(name&&name!=Ox37e[OxOc6e4[18]]){hiddenAction[OxOc6e4[10]]=OxOc6e4[23];hiddenActionData[OxOc6e4[10]]=(Ox380?OxOc6e4[24]:OxOc6e4[25])+OxOc6e4[26]+Ox37e[OxOc6e4[27]]+OxOc6e4[26]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxOc6e4[28],true);var Ox383=FoldersAndFiles.getElementsByTagName(OxOc6e4[29]);for(var i=0;i<Ox383[OxOc6e4[30]];i++){var Ox37e=Ox383[i];Ox37e[OxOc6e4[31]]= new Function(OxOc6e4[9],OxOc6e4[32]);Ox37e[OxOc6e4[33]]= new Function(OxOc6e4[9],OxOc6e4[34]);} ;} ;function row_click(Ox37e){var Ox380;if(Browser_IsOpera()){Ox380=Ox37e.getAttribute(OxOc6e4[19])==OxOc6e4[20];} else {Ox380=Ox37e[OxOc6e4[19]];} ;if(Ox380){if(Event_GetSrcElement()[OxOc6e4[35]]==OxOc6e4[36]){return ;} ;hiddenAction[OxOc6e4[10]]=OxOc6e4[37];hiddenActionData[OxOc6e4[10]]=Ox37e.getAttribute(OxOc6e4[27]);window.PostBackAction();} else {var Ox102=Ox37e.getAttribute(OxOc6e4[27]);hiddenFile[OxOc6e4[10]]=Ox102;var Ox280=Ox37e.getAttribute(OxOc6e4[38]);Window_GetElement(window,OxOc6e4[39],true)[OxOc6e4[10]]=Ox280;Actualsize();} ;} ;function reset_hiddens(){if(hiddenAlert[OxOc6e4[10]]){alert(hiddenAlert.value);} ;hiddenAlert[OxOc6e4[10]]=OxOc6e4[9];hiddenAction[OxOc6e4[10]]=OxOc6e4[9];hiddenActionData[OxOc6e4[10]]=OxOc6e4[9];} ;Event_Attach(window,OxOc6e4[40],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxOc6e4[40],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxOc6e4[41]]){return ;} ;var Ox388=document.getElementsByTagName(OxOc6e4[42]);for(var Ox389=0;Ox389<Ox388[OxOc6e4[30]];Ox389++){var Ox38a=Ox388[Ox389];if(((OxOc6e4[44]+Ox38a[OxOc6e4[45]]+OxOc6e4[44]).indexOf(OxOc6e4[43])!=-1)&&(Ox38a[OxOc6e4[46]])){ts_makeSortable(Ox38a);} ;} ;} ;function ts_makeSortable(Ox38c){if(Ox38c[OxOc6e4[47]]&&Ox38c[OxOc6e4[47]][OxOc6e4[30]]>0){var Ox38d=Ox38c[OxOc6e4[47]][0];} ;if(!Ox38d){return ;} ;for(var i=2;i<4;i++){var Ox38e=Ox38d[OxOc6e4[48]][i];var Ox27b=ts_getInnerText(Ox38e);Ox38e[OxOc6e4[49]]=OxOc6e4[50]+Ox27b+OxOc6e4[51];} ;} ;function ts_getInnerText(Ox27){if( typeof Ox27==OxOc6e4[52]){return Ox27;} ;if( typeof Ox27==OxOc6e4[53]){return Ox27;} ;if(Ox27[OxOc6e4[54]]){return Ox27[OxOc6e4[54]];} ;var Ox24=OxOc6e4[9];var Ox33a=Ox27[OxOc6e4[55]];var Ox11=Ox33a[OxOc6e4[30]];for(var i=0;i<Ox11;i++){switch(Ox33a[i][OxOc6e4[57]]){case 1:Ox24+=ts_getInnerText(Ox33a[i]);break ;;case 3:Ox24+=Ox33a[i][OxOc6e4[56]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox391){var Ox29e;for(var Ox392=0;Ox392<Ox391[OxOc6e4[55]][OxOc6e4[30]];Ox392++){if(Ox391[OxOc6e4[55]][Ox392][OxOc6e4[35]]&&Ox391[OxOc6e4[55]][Ox392][OxOc6e4[35]].toLowerCase()==OxOc6e4[58]){Ox29e=Ox391[OxOc6e4[55]][Ox392];} ;} ;var Ox393=ts_getInnerText(Ox29e);var Ox1dd=Ox391[OxOc6e4[17]];var Ox394=Ox1dd[OxOc6e4[59]];var Ox38c=getParent(Ox1dd,OxOc6e4[60]);if(Ox38c[OxOc6e4[47]][OxOc6e4[30]]<=1){return ;} ;var Ox395=ts_getInnerText(Ox38c[OxOc6e4[47]][1][OxOc6e4[48]][Ox394]);var Ox396=ts_sort_caseinsensitive;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox396=ts_sort_date;} ;if(Ox395.match(/^[?]/)){Ox396=ts_sort_currency;} ;if(Ox395.match(/^[\d\.]+$/)){Ox396=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox394;var Ox38d= new Array();var Ox397= new Array();for(var i=0;i<Ox38c[OxOc6e4[47]][0][OxOc6e4[30]];i++){Ox38d[i]=Ox38c[OxOc6e4[47]][0][i];} ;for(var j=1;j<Ox38c[OxOc6e4[47]][OxOc6e4[30]];j++){Ox397[j-1]=Ox38c[OxOc6e4[47]][j];} ;Ox397.sort(Ox396);if(Ox29e.getAttribute(OxOc6e4[61])==OxOc6e4[62]){var Ox398=OxOc6e4[63];Ox397.reverse();Ox29e.setAttribute(OxOc6e4[61],OxOc6e4[64]);} else {Ox398=OxOc6e4[65];Ox29e.setAttribute(OxOc6e4[61],OxOc6e4[62]);} ;for(i=0;i<Ox397[OxOc6e4[30]];i++){if(!Ox397[i][OxOc6e4[45]]||(Ox397[i][OxOc6e4[45]]&&(Ox397[i][OxOc6e4[45]].indexOf(OxOc6e4[66])==-1))){Ox38c[OxOc6e4[67]][0].appendChild(Ox397[i]);} ;} ;for(i=0;i<Ox397[OxOc6e4[30]];i++){if(Ox397[i][OxOc6e4[45]]&&(Ox397[i][OxOc6e4[45]].indexOf(OxOc6e4[66])!=-1)){Ox38c[OxOc6e4[67]][0].appendChild(Ox397[i]);} ;} ;var Ox399=document.getElementsByTagName(OxOc6e4[58]);for(var Ox392=0;Ox392<Ox399[OxOc6e4[30]];Ox392++){if(Ox399[Ox392][OxOc6e4[45]]==OxOc6e4[68]){if(getParent(Ox399[Ox392],OxOc6e4[42])==getParent(Ox391,OxOc6e4[42])){Ox399[Ox392][OxOc6e4[49]]=OxOc6e4[69];} ;} ;} ;Ox29e[OxOc6e4[49]]=Ox398;} ;function getParent(Ox27,Ox39b){if(Ox27==null){return null;} else {if(Ox27[OxOc6e4[57]]==1&&Ox27[OxOc6e4[35]].toLowerCase()==Ox39b.toLowerCase()){return Ox27;} else {return getParent(Ox27.parentNode,Ox39b);} ;} ;} ;function ts_sort_date(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxOc6e4[48]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxOc6e4[48]][SORT_COLUMN_INDEX]);if(Ox39d[OxOc6e4[30]]==10){var Ox39f=Ox39d.substr(6,4)+Ox39d.substr(3,2)+Ox39d.substr(0,2);} else {var Ox3a0=Ox39d.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxOc6e4[70]+Ox3a0;} else {Ox3a0=OxOc6e4[71]+Ox3a0;} ;var Ox39f=Ox3a0+Ox39d.substr(3,2)+Ox39d.substr(0,2);} ;if(Ox39e[OxOc6e4[30]]==10){var Ox3a1=Ox39e.substr(6,4)+Ox39e.substr(3,2)+Ox39e.substr(0,2);} else {Ox3a0=Ox39e.substr(6,2);if(parseInt(Ox3a0)<50){Ox3a0=OxOc6e4[70]+Ox3a0;} else {Ox3a0=OxOc6e4[71]+Ox3a0;} ;var Ox3a1=Ox3a0+Ox39e.substr(3,2)+Ox39e.substr(0,2);} ;if(Ox39f==Ox3a1){return 0;} ;if(Ox39f<Ox3a1){return -1;} ;return 1;} ;function ts_sort_currency(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxOc6e4[48]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxOc6e4[9]);var Ox39e=ts_getInnerText(b[OxOc6e4[48]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxOc6e4[9]);return parseFloat(Ox39d)-parseFloat(Ox39e);} ;function ts_sort_numeric(Oxe7,b){var Ox39d=parseFloat(ts_getInnerText(Oxe7[OxOc6e4[48]][SORT_COLUMN_INDEX]));if(isNaN(Ox39d)){Ox39d=0;} ;var Ox39e=parseFloat(ts_getInnerText(b[OxOc6e4[48]][SORT_COLUMN_INDEX]));if(isNaN(Ox39e)){Ox39e=0;} ;return Ox39d-Ox39e;} ;function ts_sort_caseinsensitive(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxOc6e4[48]][SORT_COLUMN_INDEX]).toLowerCase();var Ox39e=ts_getInnerText(b[OxOc6e4[48]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} ;function ts_sort_default(Oxe7,b){var Ox39d=ts_getInnerText(Oxe7[OxOc6e4[48]][SORT_COLUMN_INDEX]);var Ox39e=ts_getInnerText(b[OxOc6e4[48]][SORT_COLUMN_INDEX]);if(Ox39d==Ox39e){return 0;} ;if(Ox39d<Ox39e){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var Form1=Window_GetElement(window,OxOc6e4[72],true);var hiddenDirectory=Window_GetElement(window,OxOc6e4[0],true);var hiddenFile=Window_GetElement(window,OxOc6e4[1],true);var hiddenAlert=Window_GetElement(window,OxOc6e4[2],true);var hiddenAction=Window_GetElement(window,OxOc6e4[3],true);var hiddenActionData=Window_GetElement(window,OxOc6e4[4],true);var Image1=Window_GetElement(window,OxOc6e4[73],true);var FolderDescription=Window_GetElement(window,OxOc6e4[74],true);var CreateDir=Window_GetElement(window,OxOc6e4[75],true);var Copy=Window_GetElement(window,OxOc6e4[76],true);var Move=Window_GetElement(window,OxOc6e4[77],true);var FoldersAndFiles=Window_GetElement(window,OxOc6e4[28],true);var Delete=Window_GetElement(window,OxOc6e4[78],true);var DoRefresh=Window_GetElement(window,OxOc6e4[79],true);var name_Cell=Window_GetElement(window,OxOc6e4[80],true);var size_Cell=Window_GetElement(window,OxOc6e4[81],true);var op_Cell=Window_GetElement(window,OxOc6e4[82],true);var row0=Window_GetElement(window,OxOc6e4[83],true);var row0_cb=Window_GetElement(window,OxOc6e4[84],true);var divpreview=Window_GetElement(window,OxOc6e4[85],true);var Table3=Window_GetElement(window,OxOc6e4[86],true);var Width=Window_GetElement(window,OxOc6e4[87],true);var Height=Window_GetElement(window,OxOc6e4[88],true);var bgColortext=Window_GetElement(window,OxOc6e4[89],true);var bgColortext_Preview=Window_GetElement(window,OxOc6e4[90],true);var Quality=Window_GetElement(window,OxOc6e4[91],true);var Scale=Window_GetElement(window,OxOc6e4[92],true);var Align=Window_GetElement(window,OxOc6e4[93],true);var HSpace=Window_GetElement(window,OxOc6e4[94],true);var VSpace=Window_GetElement(window,OxOc6e4[95],true);var TargetUrl=Window_GetElement(window,OxOc6e4[39],true);var chk_Loop=Window_GetElement(window,OxOc6e4[96],true);var chk_Autoplay=Window_GetElement(window,OxOc6e4[97],true);var chk_Transparency=Window_GetElement(window,OxOc6e4[98],true);var chk_FlashMenu=Window_GetElement(window,OxOc6e4[99],true);var chk_Fullscreen=Window_GetElement(window,OxOc6e4[100],true);var btn_zoom_in=Window_GetElement(window,OxOc6e4[101],true);var btn_zoom_out=Window_GetElement(window,OxOc6e4[102],true);var btn_Actualsize=Window_GetElement(window,OxOc6e4[103],true);var editor=Window_GetDialogArguments(window);do_preview();function do_preview(){var Ox119=GetEmbed();if(Ox119){divpreview[OxOc6e4[49]]=Ox119;} ;} ;function do_insert(){if(TargetUrl[OxOc6e4[10]]==OxOc6e4[9]){alert(OxOc6e4[104]);return false;} ;var Ox119=GetEmbed();if(Ox119){editor.PasteHTML(Ox119);} ;Window_CloseDialog(window);} ;function GetEmbed(){var Oxda,Ox2b,Ox3da,Ox3db,Ox3dc,Ox280;Oxda=Width[OxOc6e4[10]]+OxOc6e4[9];Ox2b=Height[OxOc6e4[10]]+OxOc6e4[9];Ox3da=chk_Transparency[OxOc6e4[10]];Ox3dc=Quality[OxOc6e4[10]];Ox280=TargetUrl[OxOc6e4[10]];if(Ox280==OxOc6e4[9]){return OxOc6e4[9];} ;if(Ox280.indexOf(OxOc6e4[105])!=-1){var Ox3dd=chk_Autoplay[OxOc6e4[106]]?OxOc6e4[107]:OxOc6e4[9];Ox280=OxOc6e4[108]+window[OxOc6e4[110]][OxOc6e4[109]]+Ox280+OxOc6e4[111]+Ox3dd;} ;var Ox3de,Ox3df,Ox3e0,Ox3e1,Ox3e2,Ox3e3,Ox3e4,Ox3e5;switch(Scale[OxOc6e4[10]]){case OxOc6e4[113]:Ox3e4=OxOc6e4[112];break ;;case OxOc6e4[115]:Ox3e4=OxOc6e4[114];break ;;case OxOc6e4[9]:Ox3e4=OxOc6e4[9];break ;;} ;Ox3e5=OxOc6e4[9];if(HSpace[OxOc6e4[10]]){Ox3e5=Ox3e5+OxOc6e4[116]+HSpace[OxOc6e4[10]]+OxOc6e4[117];} ;if(VSpace[OxOc6e4[10]]){Ox3e5=Ox3e5+OxOc6e4[118]+VSpace[OxOc6e4[10]]+OxOc6e4[117];} ;if(Align[OxOc6e4[10]]){Ox3e5=Ox3e5+OxOc6e4[119]+Align[OxOc6e4[10]]+OxOc6e4[117];} ;Ox3de=chk_Transparency[OxOc6e4[106]]?OxOc6e4[120]:OxOc6e4[9];Ox3e0=chk_Fullscreen[OxOc6e4[106]]?OxOc6e4[121]:OxOc6e4[122];Ox3df=chk_FlashMenu[OxOc6e4[106]]?OxOc6e4[9]:OxOc6e4[123];Ox3e1=chk_Loop[OxOc6e4[106]]?OxOc6e4[9]:OxOc6e4[124];Ox3e2=chk_Autoplay[OxOc6e4[106]]?OxOc6e4[9]:OxOc6e4[125];Ox3e3=bgColortext[OxOc6e4[10]]==OxOc6e4[9]?OxOc6e4[9]:OxOc6e4[126]+bgColortext[OxOc6e4[10]]+OxOc6e4[127];var Ox3e6=OxOc6e4[128]+Ox280+OxOc6e4[129]+Oxda+OxOc6e4[130]+Ox2b+OxOc6e4[117]+Ox3e5+OxOc6e4[131]+Ox3dc+OxOc6e4[117]+Ox3de+OxOc6e4[44]+Ox3e1+OxOc6e4[44]+Ox3df+OxOc6e4[44]+Ox3e0+OxOc6e4[44]+Ox3e2+OxOc6e4[44]+Ox3e3+OxOc6e4[44]+Ox3e4+OxOc6e4[132];var Ox3e7=OxOc6e4[133]+OxOc6e4[134]+OxOc6e4[135]+Ox2b+OxOc6e4[129]+Oxda+OxOc6e4[117]+Ox3e5+OxOc6e4[136]+OxOc6e4[137]+OxOc6e4[138]+Ox280+OxOc6e4[139]+OxOc6e4[140]+Ox3dc+OxOc6e4[141];if(chk_Transparency[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[142];} ;if(chk_Fullscreen[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[143];} else {Ox3e7=Ox3e7+OxOc6e4[144];} ;if(!chk_FlashMenu[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[145];} ;if(!chk_Loop[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[146];} ;if(!chk_Loop[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[146];} ;if(!chk_Autoplay[OxOc6e4[106]]){Ox3e7=Ox3e7+OxOc6e4[147];} ;if(Scale[OxOc6e4[10]]!=OxOc6e4[9]){Ox3e7=Ox3e7+OxOc6e4[148]+Scale[OxOc6e4[10]]+OxOc6e4[141];} ;if(bgColortext[OxOc6e4[10]]!=OxOc6e4[9]){Ox3e7=Ox3e7+OxOc6e4[149]+bgColortext[OxOc6e4[10]]+OxOc6e4[141];} ;Ox3e7=Ox3e7+Ox3e6+OxOc6e4[150];return Ox3e7;} ;function do_Close(){Window_CloseDialog(window);} ;divpreview[OxOc6e4[152]][OxOc6e4[151]]=1;function Zoom_In(){if(Browser_IsWinIE()){if(divpreview[OxOc6e4[152]][OxOc6e4[151]]!=0){divpreview[OxOc6e4[152]][OxOc6e4[151]]*=1.2;} else {divpreview[OxOc6e4[152]][OxOc6e4[151]]=1.2;} ;} ;} ;function Zoom_Out(){if(Browser_IsWinIE()){if(divpreview[OxOc6e4[152]][OxOc6e4[151]]!=0){divpreview[OxOc6e4[152]][OxOc6e4[151]]*=0.8;} else {divpreview[OxOc6e4[152]][OxOc6e4[151]]=0.8;} ;} ;} ;function Actualsize(){if(Browser_IsWinIE()){divpreview[OxOc6e4[152]][OxOc6e4[151]]=1;} ;do_preview();} ;bgColortext[OxOc6e4[153]]=bgColortext_Preview[OxOc6e4[153]]=function bgColortext_onclick(){SelectColor(bgColortext,bgColortext_Preview);} ;btn_zoom_in[OxOc6e4[152]][OxOc6e4[154]]=btn_zoom_out[OxOc6e4[152]][OxOc6e4[154]]=btn_Actualsize[OxOc6e4[152]][OxOc6e4[154]]=OxOc6e4[155];if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox218,Ox219,Ox21a){that=this;this[OxOc6e4[156]]=function (Ox21b){val=document.getElementById(OxOc6e4[157])[OxOc6e4[10]];_dialogPromptID[OxOc6e4[152]][OxOc6e4[154]]=OxOc6e4[155];document.getElementById(OxOc6e4[157])[OxOc6e4[10]]=OxOc6e4[9];if(Ox21b){val=OxOc6e4[9];} ;Ox218(val);return false;} ;if(Ox21a==undefined){Ox21a=OxOc6e4[9];} ;if(_dialogPromptID==null){var Ox21c=document.getElementsByTagName(OxOc6e4[158])[0];tnode=document.createElement(OxOc6e4[159]);tnode[OxOc6e4[46]]=OxOc6e4[160];Ox21c.appendChild(tnode);_dialogPromptID=document.getElementById(OxOc6e4[160]);tnode=document.createElement(OxOc6e4[159]);tnode[OxOc6e4[46]]=OxOc6e4[161];Ox21c.appendChild(tnode);_dialogPromptID[OxOc6e4[152]][OxOc6e4[162]]=OxOc6e4[163];_dialogPromptID[OxOc6e4[152]][OxOc6e4[164]]=OxOc6e4[165];_dialogPromptID[OxOc6e4[152]][OxOc6e4[166]]=OxOc6e4[167];_dialogPromptID[OxOc6e4[152]][OxOc6e4[168]]=OxOc6e4[169];_dialogPromptID[OxOc6e4[152]][OxOc6e4[170]]=OxOc6e4[171];} ;var Ox21d=OxOc6e4[172];Ox21d+=OxOc6e4[173]+Ox219+OxOc6e4[174];Ox21d+=OxOc6e4[175];Ox21d+=OxOc6e4[176]+Ox21a+OxOc6e4[177];Ox21d+=OxOc6e4[178];Ox21d+=OxOc6e4[179];Ox21d+=OxOc6e4[180];Ox21d+=OxOc6e4[181];Ox21d+=OxOc6e4[182];_dialogPromptID[OxOc6e4[49]]=Ox21d;_dialogPromptID[OxOc6e4[152]][OxOc6e4[183]]=OxOc6e4[184];_dialogPromptID[OxOc6e4[152]][OxOc6e4[185]]=parseInt((document[OxOc6e4[158]][OxOc6e4[186]]-315)/2)+OxOc6e4[187];_dialogPromptID[OxOc6e4[152]][OxOc6e4[154]]=OxOc6e4[188];var Ox21e=document.getElementById(OxOc6e4[157]);try{var Ox21f=Ox21e.createTextRange();Ox21f.collapse(false);Ox21f.select();} catch(x){Ox21e.focus();} ;} ;} ;if(CreateDir){CreateDir[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(Copy){Copy[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(Move){Move[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(Delete){Delete[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(DoRefresh){DoRefresh[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(btn_zoom_in){btn_zoom_in[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(btn_zoom_out){btn_zoom_out[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;if(btn_Actualsize){btn_Actualsize[OxOc6e4[31]]= new Function(OxOc6e4[189]);} ;