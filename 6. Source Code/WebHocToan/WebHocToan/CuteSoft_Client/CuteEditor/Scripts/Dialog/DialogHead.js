var OxO9be7=["ua","userAgent","isOpera","opera","isSafari","safari","isGecko","gecko","isWinIE","msie","isMac","Mac","compatMode","document","CSS1Compat","XMLHttpRequest","","caller","(","\x0A","attachEvent","on","\x0D\x0A","top","returnValue","_dialog_returnvalue","opener","dialogArguments","_dialog_arguments","length","element \x27","\x27 not found","all","childNodes","nodeType","UNSELECTABLE","tabIndex","-1","//TODO: event not found? throw error ?","preventDefault","event","arguments","parent","frames","srcElement","target","//TODO: srcElement not found? throw error ?","fromElement","relatedTarget","toElement","keyCode","which","clientX","clientY","offsetX","offsetY","button","ctrlKey","altKey","shiftKey","cancelBubble","stopPropagation","buttonInitialized","oncontextmenu","onmouseout","onmousedown","onmouseup","isover","className","CuteEditorButtonOver","CuteEditorButton","CuteEditorButtonDown","CuteEditorDown","border","style","solid 1px #0A246A","backgroundColor","#b6bdd2","padding","1px","solid 1px #f5f5f4","inset 1px","IsCommandDisabled","CuteEditorButtonDisabled","IsCommandActive","CuteEditorButtonActive","onerror","\x0D\x0A\x0D\x0A","href","location","view-source:","?\x26view-source=","_blank","ondblclick","onkeydown","//duplicated?\x0D\x0A","var ","=Window_GetElement(window,\x22","\x22,true);","Text","clipboardData","addEventListener","isdir","path","url","text","return this.getAttribute(\x27","\x27);","prototype","attributes","\x3C","tagName","specified"," ","name","=\x22","value","\x22","\x3E","innerHTML","\x3C/","AREA","BASE","BASEFONT","COL","FRAME","HR","IMG","BR","INPUT","ISINDEX","LINK","META","PARAM","00","0123456789ABCDEF","#","object","undefined","Microsoft.XMLHTTP","head","script","language","javascript","type","text/javascript","src","id","_cpinstalled","1","ResourceDir","/Load.ashx?type=script\x26file=ColorPicker.js","CuteEditorColorPickerInitialize","GET","onreadystatechange","readyState","responseText"," \x0D\x0A window.CuteEditorColorPickerInitialize=CuteEditorColorPickerInitialize","colorScript","oncolorselect","FireUIChanged","onclick","popupColorPicker"];var _Browser_TypeInfo=null;function Browser__InitType(){if(_Browser_TypeInfo!=null){return ;} ;var Ox4={};Ox4[OxO9be7[0]]=navigator[OxO9be7[1]].toLowerCase();Ox4[OxO9be7[2]]=(Ox4[OxO9be7[0]].indexOf(OxO9be7[3])>-1);Ox4[OxO9be7[4]]=(Ox4[OxO9be7[0]].indexOf(OxO9be7[5])>-1);Ox4[OxO9be7[6]]=(!Ox4[OxO9be7[2]]&&Ox4[OxO9be7[0]].indexOf(OxO9be7[7])>-1);Ox4[OxO9be7[8]]=(!Ox4[OxO9be7[2]]&&Ox4[OxO9be7[0]].indexOf(OxO9be7[9])>-1);Ox4[OxO9be7[10]]=navigator[OxO9be7[1]].indexOf(OxO9be7[11])!=-1;_Browser_TypeInfo=Ox4;} ;Browser__InitType();function Browser_IsWinIE(){return _Browser_TypeInfo[OxO9be7[8]];} ;function Browser_IsGecko(){return _Browser_TypeInfo[OxO9be7[6]];} ;function Browser_IsOpera(){return _Browser_TypeInfo[OxO9be7[2]];} ;function Browser_IsSafari(){return _Browser_TypeInfo[OxO9be7[4]];} ;function Browser_UseIESelection(){return _Browser_TypeInfo[OxO9be7[8]];} ;function Browser_IsCSS1Compat(){return window[OxO9be7[13]][OxO9be7[12]]==OxO9be7[14];} ;function Browser_IsIE7(){return _Browser_TypeInfo[OxO9be7[8]]&&window[OxO9be7[15]];} ;function GetStackTrace(){var Ox119=OxO9be7[16];for(var Ox228=GetStackTrace[OxO9be7[17]];Ox228!=null;Ox228=Ox228[OxO9be7[17]]){var Ox229=Ox228+OxO9be7[16];Ox229=Ox229.substr(0,Ox229.indexOf(OxO9be7[18]));Ox119+=Ox229+OxO9be7[19];} ;return Ox119;} ;function Event_Attach(obj,name,Ox22b){if(obj[OxO9be7[20]]){if(name.substr(0,2)!=OxO9be7[21]){name=OxO9be7[21]+name;} ;obj.attachEvent(name,Ox22b);} else {if(name.substr(0,2)==OxO9be7[21]){name=name.substring(2);} ;obj.addEventListener(name,Ox22b,false);} ;} ;var __ISDEBUG=false;function Debug_Todo(msg){if(!__ISDEBUG){return ;} ;throw ( new Error(msg+OxO9be7[22]+Debug_Todo[OxO9be7[17]]));} ;function Window_CloseDialog(Ox230){Ox230[OxO9be7[23]].close();} ;function Window_SetDialogReturnValue(Ox1a1,Ox4e){var Ox232=Ox1a1[OxO9be7[23]];Ox232[OxO9be7[24]]=Ox4e;Ox232[OxO9be7[13]][OxO9be7[25]]=Ox4e;var Ox233=Ox232[OxO9be7[26]];if(Ox233==null){return ;} ;try{Ox233[OxO9be7[13]][OxO9be7[25]]=Ox4e;} catch(x){} ;} ;function Window_GetDialogArguments(Ox1a1){var Ox232=Ox1a1[OxO9be7[23]];if(Ox232[OxO9be7[27]]){return Ox232[OxO9be7[27]];} ;var Ox233=Ox232[OxO9be7[26]];if(Ox233==null){return Ox232[OxO9be7[13]][OxO9be7[28]];} ;return Ox233[OxO9be7[13]][OxO9be7[28]];} ;function Window_GetElement(Ox1a1,Ox93,Ox236){var Ox27=Ox1a1[OxO9be7[13]].getElementById(Ox93);if(Ox27){return Ox27;} ;var Ox2f=Ox1a1[OxO9be7[13]].getElementsByName(Ox93);if(Ox2f[OxO9be7[29]]>0){return Ox2f.item(0);} ;if(Ox236){if(__ISDEBUG){alert(OxO9be7[30]+Ox93+OxO9be7[31]);} ;throw ( new Error(OxO9be7[30]+Ox93+OxO9be7[31]));} ;return null;} ;function Element_GetAllElements(p){var arr=[];if(Browser_IsWinIE()){for(var i=0;i<p[OxO9be7[32]][OxO9be7[29]];i++){arr.push(p[OxO9be7[32]].item(i));} ;return arr;} ;Ox238(p);function Ox238(Ox27){var Ox239=Ox27[OxO9be7[33]];var Ox11=Ox239[OxO9be7[29]];for(var i=0;i<Ox11;i++){var n=Ox239.item(i);if(n[OxO9be7[34]]!=1){continue ;} ;arr.push(n);Ox238(n);} ;} ;return arr;} ;function Element_SetUnselectable(element){element.setAttribute(OxO9be7[35],OxO9be7[21]);element.setAttribute(OxO9be7[36],OxO9be7[37]);var arr=Element_GetAllElements(element);var len=arr[OxO9be7[29]];if(!len){return ;} ;for(var i=0;i<len;i++){arr[i].setAttribute(OxO9be7[35],OxO9be7[21]);arr[i].setAttribute(OxO9be7[36],OxO9be7[37]);} ;} ;function Event_GetEvent(Ox23c){Ox23c=Event_FindEvent(Ox23c);if(Ox23c==null){Debug_Todo(OxO9be7[38]);} ;return Ox23c;} ;function Array_IndexOf(arr,Ox23e){for(var i=0;i<arr[OxO9be7[29]];i++){if(arr[i]==Ox23e){return i;} ;} ;return -1;} ;function Array_Contains(arr,Ox23e){return Array_IndexOf(arr,Ox23e)!=-1;} ;function clearArray(Ox241){for(var i=0;i<Ox241[OxO9be7[29]];i++){Ox241[i]=null;} ;} ;function Event_FindEvent(Ox23c){if(Ox23c&&Ox23c[OxO9be7[39]]){return Ox23c;} ;if(Browser_IsGecko()){return Event_FindEvent_FindEventFromCallers();} else {if(window[OxO9be7[40]]){return window[OxO9be7[40]];} ;return Event_FindEvent_FindEventFromWindows();} ;return null;} ;function Event_FindEvent_FindEventFromCallers(){var Ox188=Event_GetEvent[OxO9be7[17]];for(var i=0;i<100;i++){if(!Ox188){break ;} ;var Ox23c=Ox188[OxO9be7[41]][0];if(Ox23c&&Ox23c[OxO9be7[39]]){return Ox23c;} ;Ox188=Ox188[OxO9be7[17]];} ;} ;function Event_FindEvent_FindEventFromWindows(){var arr=[];return Ox245(window);function Ox245(Ox1a1){if(Ox1a1==null){return null;} ;if(Ox1a1[OxO9be7[40]]){return Ox1a1[OxO9be7[40]];} ;if(Array_Contains(arr,Ox1a1)){return null;} ;arr.push(Ox1a1);var Ox246=[];if(Ox1a1[OxO9be7[42]]!=Ox1a1){Ox246.push(Ox1a1.parent);} ;if(Ox1a1[OxO9be7[23]]!=Ox1a1[OxO9be7[42]]){Ox246.push(Ox1a1.top);} ;if(Ox1a1[OxO9be7[26]]){Ox246.push(Ox1a1.opener);} ;for(var i=0;i<Ox1a1[OxO9be7[43]][OxO9be7[29]];i++){Ox246.push(Ox1a1[OxO9be7[43]][i]);} ;for(var i=0;i<Ox246[OxO9be7[29]];i++){try{var Ox23c=Ox245(Ox246[i]);if(Ox23c){return Ox23c;} ;} catch(x){} ;} ;return null;} ;} ;function Event_GetSrcElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxO9be7[44]]){return Ox23c[OxO9be7[44]];} ;if(Ox23c[OxO9be7[45]]){return Ox23c[OxO9be7[45]];} ;Debug_Todo(OxO9be7[46]);return null;} ;function Event_GetFromElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxO9be7[47]]){return Ox23c[OxO9be7[47]];} ;if(Ox23c[OxO9be7[48]]){return Ox23c[OxO9be7[48]];} ;return null;} ;function Event_GetToElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxO9be7[49]]){return Ox23c[OxO9be7[49]];} ;if(Ox23c[OxO9be7[48]]){return Ox23c[OxO9be7[48]];} ;return null;} ;function Event_GetKeyCode(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[50]]||Ox23c[OxO9be7[51]];} ;function Event_GetClientX(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[52]];} ;function Event_GetClientY(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[53]];} ;function Event_GetOffsetX(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[54]];} ;function Event_GetOffsetY(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[55]];} ;function Event_IsLeftButton(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Browser_IsWinIE()){return Ox23c[OxO9be7[56]]==1;} ;if(Browser_IsGecko()){return Ox23c[OxO9be7[56]]==0;} ;return Ox23c[OxO9be7[56]]==0;} ;function Event_IsCtrlKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[57]];} ;function Event_IsAltKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[58]];} ;function Event_IsShiftKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxO9be7[59]];} ;function Event_PreventDefault(Ox23c){Ox23c=Event_GetEvent(Ox23c);Ox23c[OxO9be7[24]]=false;if(Ox23c[OxO9be7[39]]){Ox23c.preventDefault();} ;} ;function Event_CancelBubble(Ox23c){Ox23c=Event_GetEvent(Ox23c);Ox23c[OxO9be7[60]]=true;if(Ox23c[OxO9be7[61]]){Ox23c.stopPropagation();} ;return false;} ;function Event_CancelEvent(Ox23c){Ox23c=Event_GetEvent(Ox23c);Event_PreventDefault(Ox23c);return Event_CancelBubble(Ox23c);} ;function CuteEditor_ButtonOver(element){if(!element[OxO9be7[62]]){element[OxO9be7[63]]=Event_CancelEvent;element[OxO9be7[64]]=CuteEditor_ButtonOut;element[OxO9be7[65]]=CuteEditor_ButtonDown;element[OxO9be7[66]]=CuteEditor_ButtonUp;Element_SetUnselectable(element);element[OxO9be7[62]]=true;} ;element[OxO9be7[67]]=true;element[OxO9be7[68]]=OxO9be7[69];} ;function CuteEditor_ButtonOut(){var element=this;element[OxO9be7[68]]=OxO9be7[70];element[OxO9be7[67]]=false;} ;function CuteEditor_ButtonDown(){if(!Event_IsLeftButton()){return ;} ;var element=this;element[OxO9be7[68]]=OxO9be7[71];} ;function CuteEditor_ButtonUp(){if(!Event_IsLeftButton()){return ;} ;var element=this;if(element[OxO9be7[67]]){element[OxO9be7[68]]=OxO9be7[69];} else {element[OxO9be7[68]]=OxO9be7[72];} ;} ;function CuteEditor_ColorPicker_ButtonOver(element){if(!element[OxO9be7[62]]){element[OxO9be7[63]]=Event_CancelEvent;element[OxO9be7[64]]=CuteEditor_ColorPicker_ButtonOut;element[OxO9be7[65]]=CuteEditor_ColorPicker_ButtonDown;Element_SetUnselectable(element);element[OxO9be7[62]]=true;} ;element[OxO9be7[67]]=true;element[OxO9be7[74]][OxO9be7[73]]=OxO9be7[75];element[OxO9be7[74]][OxO9be7[76]]=OxO9be7[77];element[OxO9be7[74]][OxO9be7[78]]=OxO9be7[79];} ;function CuteEditor_ColorPicker_ButtonOut(){var element=this;element[OxO9be7[67]]=false;element[OxO9be7[74]][OxO9be7[73]]=OxO9be7[80];element[OxO9be7[74]][OxO9be7[76]]=OxO9be7[16];element[OxO9be7[74]][OxO9be7[78]]=OxO9be7[79];} ;function CuteEditor_ColorPicker_ButtonDown(){var element=this;element[OxO9be7[74]][OxO9be7[73]]=OxO9be7[81];element[OxO9be7[74]][OxO9be7[76]]=OxO9be7[16];element[OxO9be7[74]][OxO9be7[78]]=OxO9be7[79];} ;function CuteEditor_ButtonCommandOver(element){element[OxO9be7[67]]=true;if(element[OxO9be7[82]]){element[OxO9be7[68]]=OxO9be7[83];} else {element[OxO9be7[68]]=OxO9be7[69];} ;} ;function CuteEditor_ButtonCommandOut(element){element[OxO9be7[67]]=false;if(element[OxO9be7[84]]){element[OxO9be7[68]]=OxO9be7[85];} else {if(element[OxO9be7[82]]){element[OxO9be7[68]]=OxO9be7[83];} else {element[OxO9be7[68]]=OxO9be7[70];} ;} ;} ;function CuteEditor_ButtonCommandDown(element){if(!Event_IsLeftButton()){return ;} ;element[OxO9be7[68]]=OxO9be7[71];} ;function CuteEditor_ButtonCommandUp(element){if(!Event_IsLeftButton()){return ;} ;if(element[OxO9be7[82]]){element[OxO9be7[68]]=OxO9be7[83];return ;} ;if(element[OxO9be7[67]]){element[OxO9be7[68]]=OxO9be7[69];} else {if(element[OxO9be7[84]]){element[OxO9be7[68]]=OxO9be7[85];} else {element[OxO9be7[68]]=OxO9be7[70];} ;} ;} [CuteEditor_ButtonOver,CuteEditor_ColorPicker_ButtonOver];[Window_GetDialogArguments,Window_SetDialogReturnValue,Window_CloseDialog,Window_GetElement];function CancelEventIfNotDigit(){var Ox262=Event_GetKeyCode();if(Browser_IsWinIE()){if((Ox262>=48)&&(Ox262<=57)){return true;} ;} else {if((Ox262<48||Ox262>57)&&Ox262!=8&&(Ox262<35||Ox262>37)&&Ox262!=39&&Ox262!=46){} else {return true;} ;} ;return Event_CancelEvent();} ;window[OxO9be7[86]]=function window_onerror(Oxe7,b,Ox239){if(!__ISDEBUG){return false;} ;alert(Oxe7+OxO9be7[22]+b+OxO9be7[22]+Ox239+OxO9be7[87]+GetStackTrace());return true;} ;function DialogHandleDblClick(){if(Event_IsCtrlKey()){window[OxO9be7[89]][OxO9be7[88]]=OxO9be7[90]+window[OxO9be7[89]][OxO9be7[88]]+OxO9be7[91]+ new Date().getTime();} ;if(Event_IsShiftKey()){window.open(window[OxO9be7[89]].href,OxO9be7[92]);} ;} ;function DialogHandleKeyDown(){var Ox266=Event_GetKeyCode();if(Ox266==116){window[OxO9be7[89]].reload();} ;if(Ox266==27){Window_SetDialogReturnValue(window,false);Window_CloseDialog(window);} ;} ;Event_Attach(document,OxO9be7[93],DialogHandleDblClick);Event_Attach(document,OxO9be7[94],DialogHandleKeyDown);function Debug_ReportElements(Ox268){var Ox269={};var Ox26a=[];function Ox26b(Ox93){if(!Ox93){return ;} ;if(Ox269[Ox93]){Ox26a.push(OxO9be7[95]);} ;Ox269[Ox93]=true;Ox26a.push(OxO9be7[96]);Ox26a.push(Ox93);Ox26a.push(OxO9be7[97]);Ox26a.push(Ox93);Ox26a.push(OxO9be7[98]);Ox26a.push(OxO9be7[22]);} ;var arr=Element_GetAllElements(Ox268);for(var i=0;i<arr[OxO9be7[29]];i++){var Ox42=arr[i];Ox26b(Ox42.id);} ;var Ox1fa=Ox26a.join(OxO9be7[16]);window[OxO9be7[100]].setData(OxO9be7[99],Ox1fa);} ;if(document[OxO9be7[101]]){var rowprops=[OxO9be7[102],OxO9be7[103],OxO9be7[104],OxO9be7[105]];for(var rowpropi=0;rowpropi<rowprops[OxO9be7[29]];rowpropi++){try{HTMLElement[OxO9be7[108]].__defineGetter__(rowprops[rowpropi], new Function(OxO9be7[106]+rowprops[rowpropi]+OxO9be7[107]));} catch(x){} ;} ;} ;function outerHTML(element){var attr;var Ox270=element[OxO9be7[109]];var Ox24=OxO9be7[110]+element[OxO9be7[111]];for(var i=0;i<Ox270[OxO9be7[29]];i++){attr=Ox270[i];if(attr[OxO9be7[112]]){Ox24+=OxO9be7[113]+attr[OxO9be7[114]]+OxO9be7[115]+attr[OxO9be7[116]]+OxO9be7[117];} ;} ;if(!canHaveChildren(element)){return Ox24+OxO9be7[118];} ;return Ox24+OxO9be7[118]+element[OxO9be7[119]]+OxO9be7[120]+element[OxO9be7[111]]+OxO9be7[118];} ;function canHaveChildren(element){switch(element[OxO9be7[111]]){case OxO9be7[121]:;case OxO9be7[122]:;case OxO9be7[123]:;case OxO9be7[124]:;case OxO9be7[125]:;case OxO9be7[126]:;case OxO9be7[127]:;case OxO9be7[128]:;case OxO9be7[129]:;case OxO9be7[130]:;case OxO9be7[131]:;case OxO9be7[132]:;case OxO9be7[133]:return false;;} ;return true;} ;function RGBtoHex(Ox273,Ox274,Ox275){return toHex(Ox273)+toHex(Ox274)+toHex(Ox275);} ;function toHex(Ox277){if(Ox277==null){return OxO9be7[134];} ;Ox277=parseInt(Ox277);if(Ox277==0||isNaN(Ox277)){return OxO9be7[134];} ;Ox277=Math.max(0,Ox277);Ox277=Math.min(Ox277,255);Ox277=Math.round(Ox277);return OxO9be7[135].charAt((Ox277-Ox277%16)/16)+OxO9be7[135].charAt(Ox277%16);} ;var dec_pattern=/rgb\((\d{1,3})[,]\s*(\d{1,3})[,]\s*(\d{1,3})\)/gi;function revertColor(Ox27a){if(Ox27a.match(dec_pattern)){var Ox27b=Ox27a.replace(dec_pattern,function (Ox24,p1,Ox6b,Ox27c){return (OxO9be7[136]+RGBtoHex(p1,Ox6b,Ox27c)).toLowerCase();} );return Ox27b;} ;return Ox27a;} ;function isNull(Oxe7){return  typeof Oxe7==OxO9be7[137]&&!Oxe7;} ;function CreateXMLHttpRequest(){try{if( typeof (XMLHttpRequest)!=OxO9be7[138]){return  new XMLHttpRequest();} ;if( typeof (ActiveXObject)!=OxO9be7[138]){return  new ActiveXObject(OxO9be7[139]);} ;} catch(x){return null;} ;} ;function include(Oxc2,Ox280){var Ox281=document.getElementsByTagName(OxO9be7[140]).item(0);var Ox282=document.getElementById(Oxc2);if(Ox282){Ox281.removeChild(Ox282);} ;var Ox283=document.createElement(OxO9be7[141]);Ox283.setAttribute(OxO9be7[142],OxO9be7[143]);Ox283.setAttribute(OxO9be7[144],OxO9be7[145]);Ox283.setAttribute(OxO9be7[146],Ox280);Ox283.setAttribute(OxO9be7[147],Oxc2);Ox281.appendChild(Ox283);} ;function SelectColor(Ox285,Ox286){if(Ox285.getAttribute(OxO9be7[148])==OxO9be7[149]){return ;} ;var Ox287=editor.GetScriptProperty(OxO9be7[150])+OxO9be7[151];if(!window[OxO9be7[152]]){var Ox288=CreateXMLHttpRequest();if(Ox288){Ox288.open(OxO9be7[153],Ox287,true,null,null);Ox288[OxO9be7[154]]=function (){if(Ox288[OxO9be7[155]]<4){return ;} ;var Ox262=Ox288[OxO9be7[156]];Ox288=null;eval(Ox262+OxO9be7[157]);Ox289();} ;Ox288.send(OxO9be7[16]);} else {include(OxO9be7[158],Ox287);setTimeout(Ox289,100);} ;} else {Ox289();} ;function Ox289(){Ox285.setAttribute(OxO9be7[148],OxO9be7[149]);Ox285[OxO9be7[116]]=OxO9be7[16];window.CuteEditorColorPickerInitialize(Ox285,window.editor);Ox285[OxO9be7[159]]=function (Oxd5){if(Oxd5!=null&&Oxd5!==false){Ox285[OxO9be7[116]]=Oxd5.toUpperCase();Ox285[OxO9be7[74]][OxO9be7[76]]=Oxd5;if(Ox286){Ox286[OxO9be7[74]][OxO9be7[76]]=Oxd5;} ;if(window[OxO9be7[160]]){window.FireUIChanged();} ;} ;} ;Ox285[OxO9be7[161]]=Ox285[OxO9be7[162]];if(Ox286){Ox286[OxO9be7[161]]=function (){setTimeout(Ox285.popupColorPicker,100);} ;} ;setTimeout(Ox285.popupColorPicker,100);} ;} ;function row_click(src){} ;function do_Close(){Window_SetDialogReturnValue(window,null);Window_CloseDialog(window);} ;var isDemoMode=false;