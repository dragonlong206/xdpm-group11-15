var OxOc6b3=["ua","userAgent","isOpera","opera","isSafari","safari","isGecko","gecko","isWinIE","msie","compatMode","document","CSS1Compat","undefined","Microsoft.XMLHTTP","readyState","onreadystatechange","","length","all","childNodes","nodeType","\x0D\x0A","caller","onchange","oninitialized","command","commandui","commandvalue","returnValue","oncommand","string","_fireEventFunction","event","parentNode","_IsCuteEditor","True","readOnly","_IsRichDropDown","null","value","selectedIndex","nodeName","TR","cells","display","style","nextSibling","innerHTML","\x3Cimg src=\x22","/Load.ashx?type=image\x26file=t-minus.gif\x22\x3E","onclick","CuteEditor_CollapseTreeDropDownItem(this,\x22","\x22)","onmousedown","none","/Load.ashx?type=image\x26file=t-plus.gif\x22\x3E","CuteEditor_ExpandTreeDropDownItem(this,\x22","contains","UNSELECTABLE","on","tabIndex","-1","//TODO: event not found? throw error ?","contentWindow","contentDocument","parentWindow","id","frames","frameElement","//TODO:frame contentWindow not found?","preventDefault","arguments","parent","top","opener","srcElement","target","//TODO: srcElement not found? throw error ?","fromElement","relatedTarget","toElement","keyCode","clientX","clientY","offsetX","offsetY","button","ctrlKey","altKey","shiftKey","cancelBubble","stopPropagation","CuteEditor_GetEditor(this).ExecImageCommand(this.getAttribute(\x27Command\x27),this.getAttribute(\x27CommandUI\x27),this.getAttribute(\x27CommandArgument\x27),this)","CuteEditor_GetEditor(this).PostBack(this.getAttribute(\x27Command\x27))","this.onmouseout();CuteEditor_GetEditor(this).DropMenu(this.getAttribute(\x27Group\x27),this)","ResourceDir","Theme","/Load.ashx?type=theme\x26theme=","\x26file=all.png","/Images/blank2020.gif","IMG","alt","title","Command","Group","ThemeIndex","width","20px","height","src","backgroundImage","url(",")","backgroundPosition","0 -","px","onload","className","separator","CuteEditorButton","onmouseover","CuteEditor_ButtonCommandOver(this)","onmouseout","CuteEditor_ButtonCommandOut(this)","CuteEditor_ButtonCommandDown(this)","onmouseup","CuteEditor_ButtonCommandUp(this)","oncontextmenu","ondragstart","PostBack","ondblclick","_ToolBarID","_CodeViewToolBarID","_FrameID"," CuteEditorFrame"," CuteEditorToolbar","ActiveTab","Edit","Code","View","buttonInitialized","isover","CuteEditorButtonOver","CuteEditorButtonDown","CuteEditorDown","border","solid 1px #0A246A","backgroundColor","#b6bdd2","padding","1px","solid 1px #f5f5f4","inset 1px","IsCommandDisabled","CuteEditorButtonDisabled","IsCommandActive","CuteEditorButtonActive","cmd_fromfullpage","(","href","location",",DanaInfo=",",","+","scriptProperties","GetScriptProperty","/Load.ashx?type=scripts\x26file=Safar_Implementation","CuteEditorImplementation","function","POST","\x26getModified=1","status","Failed to load impl time!","GET","\x26modified=","responseText","Failed to load impl code!","cursor","body","InitializeCode","block","contentEditable"," \x3Cbr /\x3E ","designMode","no-drop","CuteEditorInitialize"];var _Browser_TypeInfo=null;function Browser__InitType(){if(_Browser_TypeInfo!=null){return ;} ;var Ox4={};Ox4[OxOc6b3[0]]=navigator[OxOc6b3[1]].toLowerCase();Ox4[OxOc6b3[2]]=(Ox4[OxOc6b3[0]].indexOf(OxOc6b3[3])>-1);Ox4[OxOc6b3[4]]=(Ox4[OxOc6b3[0]].indexOf(OxOc6b3[5])>-1);Ox4[OxOc6b3[6]]=(!Ox4[OxOc6b3[2]]&&Ox4[OxOc6b3[0]].indexOf(OxOc6b3[7])>-1);Ox4[OxOc6b3[8]]=(!Ox4[OxOc6b3[2]]&&Ox4[OxOc6b3[0]].indexOf(OxOc6b3[9])>-1);_Browser_TypeInfo=Ox4;} ;Browser__InitType();function Browser_IsWinIE(){return _Browser_TypeInfo[OxOc6b3[8]];} ;function Browser_IsGecko(){return _Browser_TypeInfo[OxOc6b3[6]];} ;function Browser_IsOpera(){return _Browser_TypeInfo[OxOc6b3[2]];} ;function Browser_IsSafari(){return _Browser_TypeInfo[OxOc6b3[4]];} ;function Browser_UseIESelection(){return _Browser_TypeInfo[OxOc6b3[8]];} ;function Browser_IsCSS1Compat(){return window[OxOc6b3[11]][OxOc6b3[10]]==OxOc6b3[12];} ;function CreateXMLHttpRequest(){try{if( typeof (XMLHttpRequest)!=OxOc6b3[13]){return  new XMLHttpRequest();} ;if( typeof (ActiveXObject)!=OxOc6b3[13]){return  new ActiveXObject(OxOc6b3[14]);} ;} catch(x){return null;} ;} ;function LoadXMLAsync(Oxa1d,Ox280,Ox22b,Oxa1e){var Oxe0=CreateXMLHttpRequest();function Oxa1f(){if(Oxe0[OxOc6b3[15]]!=4){return ;} ;Oxe0[OxOc6b3[16]]= new Function();var Ox288=Oxe0;Oxe0=null;Ox22b(Ox288);} ;Oxe0[OxOc6b3[16]]=Oxa1f;Oxe0.open(Oxa1d,Ox280,true);Oxe0.send(Oxa1e||OxOc6b3[17]);} ;function Element_GetAllElements(p){var arr=[];if(Browser_IsWinIE()){for(var i=0;i<p[OxOc6b3[19]][OxOc6b3[18]];i++){arr.push(p[OxOc6b3[19]].item(i));} ;return arr;} ;Ox238(p);function Ox238(Ox27){var Ox239=Ox27[OxOc6b3[20]];var Ox11=Ox239[OxOc6b3[18]];for(var i=0;i<Ox11;i++){var n=Ox239.item(i);if(n[OxOc6b3[21]]!=1){continue ;} ;arr.push(n);Ox238(n);} ;} ;return arr;} ;var __ISDEBUG=false;function Debug_Todo(msg){if(!__ISDEBUG){return ;} ;throw ( new Error(msg+OxOc6b3[22]+Debug_Todo[OxOc6b3[23]]));} ;function Window_GetElement(Ox1a1,Ox93,Ox236){var Ox27=Ox1a1[OxOc6b3[11]].getElementById(Ox93);if(Ox27){return Ox27;} ;var Ox2f=Ox1a1[OxOc6b3[11]].getElementsByName(Ox93);if(Ox2f[OxOc6b3[18]]>0){return Ox2f.item(0);} ;return null;} ;function CuteEditor_AddMainMenuItems(Ox662){} ;function CuteEditor_AddDropMenuItems(Ox662,Ox669){} ;function CuteEditor_AddTagMenuItems(Ox662,Ox66b){} ;function CuteEditor_AddVerbMenuItems(Ox662,Ox66b){} ;function CuteEditor_OnInitialized(editor){} ;function CuteEditor_OnCommand(editor,Ox66f,Ox670,Ox4e){} ;function CuteEditor_OnChange(editor){} ;function CuteEditor_FilterCode(editor,Ox262){return Ox262;} ;function CuteEditor_FilterHTML(editor,Ox27a){return Ox27a;} ;function CuteEditor_FireChange(editor){window.CuteEditor_OnChange(editor);CuteEditor_FireEvent(editor,OxOc6b3[24],null);} ;function CuteEditor_FireInitialized(editor){window.CuteEditor_OnInitialized(editor);CuteEditor_FireEvent(editor,OxOc6b3[25],null);} ;function CuteEditor_FireCommand(editor,Ox66f,Ox670,Ox4e){var Ox137=window.CuteEditor_OnCommand(editor,Ox66f,Ox670,Ox4e);if(Ox137==true){return true;} ;var Ox677={};Ox677[OxOc6b3[26]]=Ox66f;Ox677[OxOc6b3[27]]=Ox670;Ox677[OxOc6b3[28]]=Ox4e;Ox677[OxOc6b3[29]]=true;CuteEditor_FireEvent(editor,OxOc6b3[30],Ox677);if(Ox677[OxOc6b3[29]]==false){return true;} ;} ;function CuteEditor_FireEvent(editor,Ox679,Ox67a){if(Ox67a==null){Ox67a={};} ;var Ox67b=editor.getAttribute(Ox679);if(Ox67b){if( typeof (Ox67b)==OxOc6b3[31]){editor[OxOc6b3[32]]= new Function(OxOc6b3[33],Ox67b);} else {editor[OxOc6b3[32]]=Ox67b;} ;editor._fireEventFunction(Ox67a);} ;} ;function CuteEditor_GetEditor(element){for(var Ox42=element;Ox42!=null;Ox42=Ox42[OxOc6b3[34]]){if(Ox42.getAttribute(OxOc6b3[35])==OxOc6b3[36]){return Ox42;} ;} ;return null;} ;function CuteEditor_DropDownCommand(element,Oxa21){var editor=CuteEditor_GetEditor(element);if(editor[OxOc6b3[37]]){return ;} ;if(element.getAttribute(OxOc6b3[38])==OxOc6b3[36]){var Ox13b=element.GetValue();if(Ox13b==OxOc6b3[39]){Ox13b=OxOc6b3[17];} ;var Ox1fa=element.GetText();if(Ox1fa==OxOc6b3[39]){Ox1fa=OxOc6b3[17];} ;element.SetSelectedIndex(0);editor.ExecCommand(Oxa21,false,Ox13b,Ox1fa);} else {if(element[OxOc6b3[40]]){var Ox13b=element[OxOc6b3[40]];if(Ox13b==OxOc6b3[39]){Ox13b=OxOc6b3[17];} ;element[OxOc6b3[41]]=0;editor.ExecCommand(Oxa21,false,Ox13b,Ox1fa);} else {element[OxOc6b3[41]]=0;} ;} ;editor.FocusDocument();} ;function CuteEditor_ExpandTreeDropDownItem(src,Ox739){var Oxb3=null;while(src!=null){if(src[OxOc6b3[42]]==OxOc6b3[43]){Oxb3=src;break ;} ;src=src[OxOc6b3[34]];} ;var Ox1dd=Oxb3[OxOc6b3[44]].item(0);Oxb3[OxOc6b3[47]][OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[17];Ox1dd[OxOc6b3[48]]=OxOc6b3[49]+Ox739+OxOc6b3[50];Oxb3[OxOc6b3[51]]= new Function(OxOc6b3[52]+Ox739+OxOc6b3[53]);Oxb3[OxOc6b3[54]]= new Function(OxOc6b3[52]+Ox739+OxOc6b3[53]);} ;function CuteEditor_CollapseTreeDropDownItem(src,Ox739){var Oxb3=null;while(src!=null){if(src[OxOc6b3[42]]==OxOc6b3[43]){Oxb3=src;break ;} ;src=src[OxOc6b3[34]];} ;var Ox1dd=Oxb3[OxOc6b3[44]].item(0);Oxb3[OxOc6b3[47]][OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[55];Ox1dd[OxOc6b3[48]]=OxOc6b3[49]+Ox739+OxOc6b3[56];Oxb3[OxOc6b3[51]]= new Function(OxOc6b3[57]+Ox739+OxOc6b3[53]);Oxb3[OxOc6b3[54]]= new Function(OxOc6b3[57]+Ox739+OxOc6b3[53]);} ;function Element_Contains(element,Ox17c){if(!Browser_IsOpera()){if(element[OxOc6b3[58]]){return element.contains(Ox17c);} ;} ;for(;Ox17c!=null;Ox17c=Ox17c[OxOc6b3[34]]){if(element==Ox17c){return true;} ;} ;return false;} ;function Element_SetUnselectable(element){element.setAttribute(OxOc6b3[59],OxOc6b3[60]);element.setAttribute(OxOc6b3[61],OxOc6b3[62]);var arr=Element_GetAllElements(element);var len=arr[OxOc6b3[18]];if(!len){return ;} ;for(var i=0;i<len;i++){arr[i].setAttribute(OxOc6b3[59],OxOc6b3[60]);arr[i].setAttribute(OxOc6b3[61],OxOc6b3[62]);} ;} ;function Event_GetEvent(Ox23c){Ox23c=Event_FindEvent(Ox23c);if(Ox23c==null){Debug_Todo(OxOc6b3[63]);} ;return Ox23c;} ;function Frame_GetContentWindow(Ox340){if(Ox340[OxOc6b3[64]]){return Ox340[OxOc6b3[64]];} ;if(Ox340[OxOc6b3[65]]){if(Ox340[OxOc6b3[65]][OxOc6b3[66]]){return Ox340[OxOc6b3[65]][OxOc6b3[66]];} ;} ;var Ox1a1;if(Ox340[OxOc6b3[67]]){Ox1a1=window[OxOc6b3[68]][Ox340[OxOc6b3[67]]];if(Ox1a1){return Ox1a1;} ;} ;var len=window[OxOc6b3[68]][OxOc6b3[18]];for(var i=0;i<len;i++){Ox1a1=window[OxOc6b3[68]][i];if(Ox1a1[OxOc6b3[69]]==Ox340){return Ox1a1;} ;if(Ox1a1[OxOc6b3[11]]==Ox340[OxOc6b3[65]]){return Ox1a1;} ;} ;Debug_Todo(OxOc6b3[70]);} ;function Array_IndexOf(arr,Ox23e){for(var i=0;i<arr[OxOc6b3[18]];i++){if(arr[i]==Ox23e){return i;} ;} ;return -1;} ;function Array_Contains(arr,Ox23e){return Array_IndexOf(arr,Ox23e)!=-1;} ;function Event_FindEvent(Ox23c){if(Ox23c&&Ox23c[OxOc6b3[71]]){return Ox23c;} ;if(Browser_IsGecko()){return Event_FindEvent_FindEventFromCallers();} else {if(window[OxOc6b3[33]]){return window[OxOc6b3[33]];} ;return Event_FindEvent_FindEventFromWindows();} ;return null;} ;function Event_FindEvent_FindEventFromCallers(){var Ox188=Event_GetEvent[OxOc6b3[23]];for(var i=0;i<100;i++){if(!Ox188){break ;} ;var Ox23c=Ox188[OxOc6b3[72]][0];if(Ox23c&&Ox23c[OxOc6b3[71]]){return Ox23c;} ;Ox188=Ox188[OxOc6b3[23]];} ;} ;function Event_FindEvent_FindEventFromWindows(){var arr=[];return Ox245(window);function Ox245(Ox1a1){if(Ox1a1==null){return null;} ;if(Ox1a1[OxOc6b3[33]]){return Ox1a1[OxOc6b3[33]];} ;if(Array_Contains(arr,Ox1a1)){return null;} ;arr.push(Ox1a1);var Ox246=[];if(Ox1a1[OxOc6b3[73]]!=Ox1a1){Ox246.push(Ox1a1.parent);} ;if(Ox1a1[OxOc6b3[74]]!=Ox1a1[OxOc6b3[73]]){Ox246.push(Ox1a1.top);} ;if(Ox1a1[OxOc6b3[75]]){Ox246.push(Ox1a1.opener);} ;for(var i=0;i<Ox1a1[OxOc6b3[68]][OxOc6b3[18]];i++){Ox246.push(Ox1a1[OxOc6b3[68]][i]);} ;for(var i=0;i<Ox246[OxOc6b3[18]];i++){try{var Ox23c=Ox245(Ox246[i]);if(Ox23c){return Ox23c;} ;} catch(x){} ;} ;return null;} ;} ;function Event_GetSrcElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxOc6b3[76]]){return Ox23c[OxOc6b3[76]];} ;if(Ox23c[OxOc6b3[77]]){return Ox23c[OxOc6b3[77]];} ;Debug_Todo(OxOc6b3[78]);return null;} ;function Event_GetFromElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxOc6b3[79]]){return Ox23c[OxOc6b3[79]];} ;if(Ox23c[OxOc6b3[80]]){return Ox23c[OxOc6b3[80]];} ;return null;} ;function Event_GetToElement(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Ox23c[OxOc6b3[81]]){return Ox23c[OxOc6b3[81]];} ;if(Ox23c[OxOc6b3[80]]){return Ox23c[OxOc6b3[80]];} ;return null;} ;function Event_GetKeyCode(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[82]];} ;function Event_GetClientX(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[83]];} ;function Event_GetClientY(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[84]];} ;function Event_GetOffsetX(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[85]];} ;function Event_GetOffsetY(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[86]];} ;function Event_IsLeftButton(Ox23c){Ox23c=Event_GetEvent(Ox23c);if(Browser_IsWinIE()){return Ox23c[OxOc6b3[87]]==1;} ;if(Browser_IsGecko()){return Ox23c[OxOc6b3[87]]==0;} ;return Ox23c[OxOc6b3[87]]==0;} ;function Event_IsCtrlKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[88]];} ;function Event_IsAltKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[89]];} ;function Event_IsShiftKey(Ox23c){Ox23c=Event_GetEvent(Ox23c);return Ox23c[OxOc6b3[90]];} ;function Event_PreventDefault(Ox23c){Ox23c=Event_GetEvent(Ox23c);Ox23c[OxOc6b3[29]]=false;if(Ox23c[OxOc6b3[71]]){Ox23c.preventDefault();} ;} ;function Event_CancelBubble(Ox23c){Ox23c=Event_GetEvent(Ox23c);Ox23c[OxOc6b3[91]]=true;if(Ox23c[OxOc6b3[92]]){Ox23c.stopPropagation();} ;return false;} ;function Event_CancelEvent(Ox23c){Ox23c=Event_GetEvent(Ox23c);Event_PreventDefault(Ox23c);return Event_CancelBubble(Ox23c);} ;function CuteEditor_BasicInitialize(editor){var Ox151=Browser_IsOpera();var Ox702= new Function(OxOc6b3[93]);var Oxa25= new Function(OxOc6b3[94]);var Oxa26= new Function(OxOc6b3[95]);var Oxa27=editor.GetScriptProperty(OxOc6b3[96]);var Oxa28=editor.GetScriptProperty(OxOc6b3[97]);var Oxa29=Oxa27+OxOc6b3[98]+Oxa28+OxOc6b3[99];var Oxa2a=Oxa27+OxOc6b3[100];var images=editor.getElementsByTagName(OxOc6b3[101]);var len=images[OxOc6b3[18]];for(var i=0;i<len;i++){var img=images[i];if(img.getAttribute(OxOc6b3[102])&&!img.getAttribute(OxOc6b3[103])){img.setAttribute(OxOc6b3[103],img.getAttribute(OxOc6b3[102]));} ;var Ox12e=img.getAttribute(OxOc6b3[104]);var Ox669=img.getAttribute(OxOc6b3[105]);var Oxa2b=img.getAttribute(OxOc6b3[106]);if(parseInt(Oxa2b)>=0){img[OxOc6b3[46]][OxOc6b3[107]]=OxOc6b3[108];img[OxOc6b3[46]][OxOc6b3[109]]=OxOc6b3[108];img[OxOc6b3[110]]=Oxa2a;img[OxOc6b3[46]][OxOc6b3[111]]=OxOc6b3[112]+Oxa29+OxOc6b3[113];img[OxOc6b3[46]][OxOc6b3[114]]=OxOc6b3[115]+(Oxa2b*20)+OxOc6b3[116];img[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[17];} ;if(!Ox12e&&!Ox669){if(Ox151){img[OxOc6b3[117]]=CuteEditor_OperaHandleImageLoaded;} ;continue ;} ;if(img[OxOc6b3[118]]!=OxOc6b3[119]){img[OxOc6b3[118]]=OxOc6b3[120];img[OxOc6b3[121]]= new Function(OxOc6b3[122]);img[OxOc6b3[123]]= new Function(OxOc6b3[124]);img[OxOc6b3[54]]= new Function(OxOc6b3[125]);img[OxOc6b3[126]]= new Function(OxOc6b3[127]);} ;if(!img[OxOc6b3[128]]){img[OxOc6b3[128]]=Event_CancelEvent;} ;if(!img[OxOc6b3[129]]){img[OxOc6b3[129]]=Event_CancelEvent;} ;if(Ox12e){var Ox188=img.getAttribute(OxOc6b3[130])==OxOc6b3[36]?Oxa25:Ox702;if(img[OxOc6b3[51]]==null){img[OxOc6b3[51]]=Ox188;} ;if(img[OxOc6b3[131]]==null){img[OxOc6b3[131]]=Ox188;} ;} else {if(Ox669){if(img[OxOc6b3[51]]==null){img[OxOc6b3[51]]=Oxa26;} ;} ;} ;} ;var Ox76f=Window_GetElement(window,editor.GetScriptProperty(OxOc6b3[132]),true);var Ox770=Window_GetElement(window,editor.GetScriptProperty(OxOc6b3[133]),true);var Ox76b=Window_GetElement(window,editor.GetScriptProperty(OxOc6b3[134]),true);Ox76b[OxOc6b3[118]]+=OxOc6b3[135];Ox76f[OxOc6b3[118]]+=OxOc6b3[136];Ox770[OxOc6b3[118]]+=OxOc6b3[136];Element_SetUnselectable(Ox76f);Element_SetUnselectable(Ox770);var Ox7ef=editor.GetScriptProperty(OxOc6b3[137]);switch(Ox7ef){case OxOc6b3[138]:Ox76f[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[17];break ;;case OxOc6b3[139]:Ox770[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[17];break ;;case OxOc6b3[140]:break ;;} ;} ;function CuteEditor_OperaHandleImageLoaded(){var img=this;if(img[OxOc6b3[46]][OxOc6b3[45]]){img[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[55];setTimeout(function Oxa2d(){img[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[17];} ,1);} ;} ;function CuteEditor_ButtonOver(element){if(!element[OxOc6b3[141]]){element[OxOc6b3[128]]=Event_CancelEvent;element[OxOc6b3[123]]=CuteEditor_ButtonOut;element[OxOc6b3[54]]=CuteEditor_ButtonDown;element[OxOc6b3[126]]=CuteEditor_ButtonUp;Element_SetUnselectable(element);element[OxOc6b3[141]]=true;} ;element[OxOc6b3[142]]=true;element[OxOc6b3[118]]=OxOc6b3[143];} ;function CuteEditor_ButtonOut(){var element=this;element[OxOc6b3[118]]=OxOc6b3[120];element[OxOc6b3[142]]=false;} ;function CuteEditor_ButtonDown(){if(!Event_IsLeftButton()){return ;} ;var element=this;element[OxOc6b3[118]]=OxOc6b3[144];} ;function CuteEditor_ButtonUp(){if(!Event_IsLeftButton()){return ;} ;var element=this;if(element[OxOc6b3[142]]){element[OxOc6b3[118]]=OxOc6b3[143];} else {element[OxOc6b3[118]]=OxOc6b3[145];} ;} ;function CuteEditor_ColorPicker_ButtonOver(element){if(!element[OxOc6b3[141]]){element[OxOc6b3[128]]=Event_CancelEvent;element[OxOc6b3[123]]=CuteEditor_ColorPicker_ButtonOut;element[OxOc6b3[54]]=CuteEditor_ColorPicker_ButtonDown;Element_SetUnselectable(element);element[OxOc6b3[141]]=true;} ;element[OxOc6b3[142]]=true;element[OxOc6b3[46]][OxOc6b3[146]]=OxOc6b3[147];element[OxOc6b3[46]][OxOc6b3[148]]=OxOc6b3[149];element[OxOc6b3[46]][OxOc6b3[150]]=OxOc6b3[151];} ;function CuteEditor_ColorPicker_ButtonOut(){var element=this;element[OxOc6b3[142]]=false;element[OxOc6b3[46]][OxOc6b3[146]]=OxOc6b3[152];element[OxOc6b3[46]][OxOc6b3[148]]=OxOc6b3[17];element[OxOc6b3[46]][OxOc6b3[150]]=OxOc6b3[151];} ;function CuteEditor_ColorPicker_ButtonDown(){var element=this;element[OxOc6b3[46]][OxOc6b3[146]]=OxOc6b3[153];element[OxOc6b3[46]][OxOc6b3[148]]=OxOc6b3[17];element[OxOc6b3[46]][OxOc6b3[150]]=OxOc6b3[151];} ;function CuteEditor_ButtonCommandOver(element){element[OxOc6b3[142]]=true;if(element[OxOc6b3[154]]){element[OxOc6b3[118]]=OxOc6b3[155];} else {element[OxOc6b3[118]]=OxOc6b3[143];} ;} ;function CuteEditor_ButtonCommandOut(element){element[OxOc6b3[142]]=false;if(element[OxOc6b3[156]]){element[OxOc6b3[118]]=OxOc6b3[157];} else {if(element[OxOc6b3[154]]){element[OxOc6b3[118]]=OxOc6b3[155];} else {if(element[OxOc6b3[67]]!=OxOc6b3[158]){element[OxOc6b3[118]]=OxOc6b3[120];} ;} ;} ;} ;function CuteEditor_ButtonCommandDown(element){if(!Event_IsLeftButton()){return ;} ;element[OxOc6b3[118]]=OxOc6b3[144];} ;function CuteEditor_ButtonCommandUp(element){if(!Event_IsLeftButton()){return ;} ;if(element[OxOc6b3[154]]){element[OxOc6b3[118]]=OxOc6b3[155];return ;} ;if(element[OxOc6b3[142]]){element[OxOc6b3[118]]=OxOc6b3[143];} else {if(element[OxOc6b3[156]]){element[OxOc6b3[118]]=OxOc6b3[157];} else {element[OxOc6b3[118]]=OxOc6b3[120];} ;} ;} ;var CuteEditorGlobalFunctions=[CuteEditor_GetEditor,CuteEditor_ButtonOver,CuteEditor_ButtonOut,CuteEditor_ButtonDown,CuteEditor_ButtonUp,CuteEditor_ColorPicker_ButtonOver,CuteEditor_ColorPicker_ButtonOut,CuteEditor_ColorPicker_ButtonDown,CuteEditor_ButtonCommandOver,CuteEditor_ButtonCommandOut,CuteEditor_ButtonCommandDown,CuteEditor_ButtonCommandUp,CuteEditor_DropDownCommand,CuteEditor_ExpandTreeDropDownItem,CuteEditor_CollapseTreeDropDownItem,CuteEditor_OnInitialized,CuteEditor_OnCommand,CuteEditor_OnChange,CuteEditor_AddVerbMenuItems,CuteEditor_AddTagMenuItems,CuteEditor_AddMainMenuItems,CuteEditor_AddDropMenuItems,CuteEditor_FilterCode,CuteEditor_FilterHTML];function SetupCuteEditorGlobalFunctions(){for(var i=0;i<CuteEditorGlobalFunctions[OxOc6b3[18]];i++){var Ox188=CuteEditorGlobalFunctions[i];var name=Ox188+OxOc6b3[17];name=name.substr(8,name.indexOf(OxOc6b3[159])-8).replace(/\s/g,OxOc6b3[17]);if(!window[name]){window[name]=Ox188;} ;} ;} ;SetupCuteEditorGlobalFunctions();var __danainfo=null;var danaurl=window[OxOc6b3[161]][OxOc6b3[160]];var danapos=danaurl.indexOf(OxOc6b3[162]);if(danapos!=-1){var pluspos1=danaurl.indexOf(OxOc6b3[163],danapos+10);var pluspos2=danaurl.indexOf(OxOc6b3[164],danapos+10);if(pluspos1!=-1&&pluspos1<pluspos2){pluspos2=pluspos1;} ;__danainfo=danaurl.substring(danapos,pluspos2)+OxOc6b3[164];} ;function CuteEditor_GetScriptProperty(name){var Ox13b=this[OxOc6b3[165]][name];if(Ox13b&&__danainfo){if(name==OxOc6b3[96]){return Ox13b+__danainfo;} ;var Ox379=this[OxOc6b3[165]][OxOc6b3[96]];if(Ox13b.substr(0,Ox379.length)==Ox379){return Ox379+__danainfo+Ox13b.substring(Ox379.length);} ;} ;return Ox13b;} ;function CuteEditor_SetScriptProperty(name,Ox13b){if(Ox13b==null){this[OxOc6b3[165]][name]=null;} else {this[OxOc6b3[165]][name]=String(Ox13b);} ;} ;function CuteEditorInitialize(Oxa38,Oxa39){var editor=Window_GetElement(window,Oxa38,true);editor[OxOc6b3[165]]=Oxa39;editor[OxOc6b3[166]]=CuteEditor_GetScriptProperty;var Ox76b=Window_GetElement(window,editor.GetScriptProperty(OxOc6b3[134]),true);var editwin,editdoc;try{editwin=Frame_GetContentWindow(Ox76b);editdoc=editwin[OxOc6b3[11]];} catch(x){} ;var Oxa3a=false;var Oxa3b;var Oxa3c=false;var Oxa3d=editor.GetScriptProperty(OxOc6b3[96])+OxOc6b3[167];function Oxa3e(){if( typeof (window[OxOc6b3[168]])==OxOc6b3[169]){return ;} ;LoadXMLAsync(OxOc6b3[170],Oxa3d+OxOc6b3[171],Oxa3f);} ;function Oxa3f(Ox288){if(Ox288[OxOc6b3[172]]!=200){if(Ox288[OxOc6b3[172]]==0){return ;} ;alert(OxOc6b3[173]);return ;} ;LoadXMLAsync(OxOc6b3[174],Oxa3d+OxOc6b3[175]+Ox288[OxOc6b3[176]],Oxa40);} ;function Oxa40(Ox288){if(Ox288[OxOc6b3[172]]!=200){if(Ox288[OxOc6b3[172]]==0){return ;} ;alert(OxOc6b3[177]);return ;} ;CuteEditorInstallScriptCode(Ox288.responseText,OxOc6b3[168]);if(Oxa3a){Oxa41();} ;} ;function Oxa41(){if(Oxa3c){return ;} ;Oxa3c=true;try{window.CuteEditorImplementation(editor);} catch(x){alert(x);} ;try{editor[OxOc6b3[46]][OxOc6b3[178]]=OxOc6b3[17];} catch(x){} ;try{editdoc[OxOc6b3[179]][OxOc6b3[46]][OxOc6b3[178]]=OxOc6b3[17];} catch(x){} ;var Oxa42=editor.GetScriptProperty(OxOc6b3[180]);if(Oxa42){editor.Eval(Oxa42);} ;} ;function Oxa43(){if(!Element_Contains(window[OxOc6b3[11]].body,editor)){return ;} ;try{Ox76b=Window_GetElement(window,editor.GetScriptProperty(OxOc6b3[134]),true);editwin=Frame_GetContentWindow(Ox76b);editdoc=editwin[OxOc6b3[11]];var y=editdoc[OxOc6b3[179]];} catch(x){setTimeout(Oxa43,100);return ;} ;if(!editdoc[OxOc6b3[179]]){setTimeout(Oxa43,100);return ;} ;if(!Oxa3a){Ox76b[OxOc6b3[46]][OxOc6b3[45]]=OxOc6b3[181];if(Browser_IsOpera()){editdoc[OxOc6b3[179]][OxOc6b3[182]]=true;} else {if(Browser_IsGecko()){editdoc[OxOc6b3[179]][OxOc6b3[48]]=OxOc6b3[183];} ;editdoc[OxOc6b3[184]]=OxOc6b3[60];} ;Oxa3a=true;setTimeout(Oxa43,50);return ;} ;if( typeof (window[OxOc6b3[168]])==OxOc6b3[169]){Oxa41();} else {try{editdoc[OxOc6b3[179]][OxOc6b3[46]][OxOc6b3[178]]=OxOc6b3[185];} catch(x){} ;} ;} ;var Oxa44=0;var Ox42=CuteEditor_Find_DisplayNone(editor);if(Ox42){function Oxa45(){if(Ox42[OxOc6b3[46]][OxOc6b3[45]]!=OxOc6b3[55]){window.clearInterval(Oxa44);Oxa44=OxOc6b3[17];CuteEditorInitialize(Oxa38,Oxa39);} ;} ;Oxa44=setInterval(Oxa45,1000);} else {CuteEditor_BasicInitialize(editor);Oxa3e();Oxa43();} ;function CuteEditor_Find_DisplayNone(element){var Oxa47;for(var Ox42=element;Ox42!=null;Ox42=Ox42[OxOc6b3[34]]){if(Ox42[OxOc6b3[46]]&&Ox42[OxOc6b3[46]][OxOc6b3[45]]==OxOc6b3[55]){Oxa47=Ox42;break ;} ;} ;return Oxa47;} ;} ;function CuteEditorInstallScriptCode(Ox99e,Ox99f){eval(Ox99e);window[Ox99f]=eval(Ox99f);} ;window[OxOc6b3[186]]=CuteEditorInitialize;