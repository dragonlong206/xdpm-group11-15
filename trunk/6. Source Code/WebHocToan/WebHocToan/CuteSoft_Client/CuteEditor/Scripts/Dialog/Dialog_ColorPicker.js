var OxO2f7a=["=","; path=/;"," expires=",";","cookie","length","","#ffffff","CECC","onmouseover","event","srcElement","target","className","colordiv","style","onmouseout","onclick","CheckboxColorNames","checked","cname","backgroundColor","cvalue","[[_CuteEditorResource_]]Load.ashx?type=dialog\x26file=ColorPicker.Aspx\x26culture=[[_culture_]]","\x26[[DNN_Arg]]","dialogWidth:500px;dialogHeight:420px;help:0;status:0;resizable:1","dialogArguments","object","onchange","color","editor","divpreview","value","#","RecentColors","SPAN","[[ValidColor]]"];function SetCookie(name,Ox4e,Ox4f){var Ox50=name+OxO2f7a[0]+escape(Ox4e)+OxO2f7a[1];if(Ox4f){var Ox51= new Date();Ox51.setSeconds(Ox51.getSeconds()+Ox4f);Ox50+=OxO2f7a[2]+Ox51.toUTCString()+OxO2f7a[3];} ;document[OxO2f7a[4]]=Ox50;} ;function GetCookie(name){var Ox53=document[OxO2f7a[4]].split(OxO2f7a[3]);for(var i=0;i<Ox53[OxO2f7a[5]];i++){var Ox54=Ox53[i].split(OxO2f7a[0]);if(name==Ox54[0].replace(/\s/g,OxO2f7a[6])){return unescape(Ox54[1]);} ;} ;} ;function GetCookieDictionary(){var Ox124={};var Ox53=document[OxO2f7a[4]].split(OxO2f7a[3]);for(var i=0;i<Ox53[OxO2f7a[5]];i++){var Ox54=Ox53[i].split(OxO2f7a[0]);Ox124[Ox54[0].replace(/\s/g,OxO2f7a[6])]=unescape(Ox54[1]);} ;return Ox124;} ;function GetCookieArray(){var arr=[];var Ox53=document[OxO2f7a[4]].split(OxO2f7a[3]);for(var i=0;i<Ox53[OxO2f7a[5]];i++){var Ox54=Ox53[i].split(OxO2f7a[0]);var Ox50={name:Ox54[0].replace(/\s/g,OxO2f7a[6]),value:unescape(Ox54[1])};arr[arr[OxO2f7a[5]]]=Ox50;} ;return arr;} ;var __defaultcustomlist=[OxO2f7a[7],OxO2f7a[7],OxO2f7a[7],OxO2f7a[7],OxO2f7a[7],OxO2f7a[7],OxO2f7a[7],OxO2f7a[7]];function GetCustomColors(){var Ox128=__defaultcustomlist.concat();for(var i=0;i<18;i++){var Oxd5=GetCustomColor(i);if(Oxd5){Ox128[i]=Oxd5;} ;} ;return Ox128;} ;function GetCustomColor(Ox12a){return GetCookie(OxO2f7a[8]+Ox12a);} ;function SetCustomColor(Ox12a,Oxd5){SetCookie(OxO2f7a[8]+Ox12a,Oxd5,60*60*24*365);} ;var _origincolor=OxO2f7a[6];document[OxO2f7a[9]]=function (Ox1c9){Ox1c9=window[OxO2f7a[10]]||Ox1c9;var Ox12=Ox1c9[OxO2f7a[11]]||Ox1c9[OxO2f7a[12]];if(Ox12[OxO2f7a[13]]==OxO2f7a[14]){firecolorchange(Ox12[OxO2f7a[15]].backgroundColor);} ;} ;document[OxO2f7a[16]]=function (Ox1c9){Ox1c9=window[OxO2f7a[10]]||Ox1c9;var Ox12=Ox1c9[OxO2f7a[11]]||Ox1c9[OxO2f7a[12]];if(Ox12[OxO2f7a[13]]==OxO2f7a[14]){firecolorchange(_origincolor);} ;} ;document[OxO2f7a[17]]=function (Ox1c9){Ox1c9=window[OxO2f7a[10]]||Ox1c9;var Ox12=Ox1c9[OxO2f7a[11]]||Ox1c9[OxO2f7a[12]];if(Ox12[OxO2f7a[13]]==OxO2f7a[14]){var Ox296=document.getElementById(OxO2f7a[18])&&document.getElementById(OxO2f7a[18])[OxO2f7a[19]];if(Ox296){do_select(Ox12.getAttribute(OxO2f7a[20])||Ox12[OxO2f7a[15]][OxO2f7a[21]]);} else {do_select(Ox12.getAttribute(OxO2f7a[22])||Ox12[OxO2f7a[15]][OxO2f7a[21]]);} ;} ;} ;var _editor;function firecolorchange(Ox299){} ;function ShowColorDialog(Ox22b){var Ox134=OxO2f7a[23]+OxO2f7a[24];var Ox29b=OxO2f7a[25];var Ox137=showModalDialog(Ox134,null,Ox29b);if(Ox137!=null&&Ox137!==false){Ox22b(Ox137);} ;} ;if(top[OxO2f7a[26]]){if( typeof (top[OxO2f7a[26]])==OxO2f7a[27]){if(top[OxO2f7a[26]][OxO2f7a[28]]){firecolorchange=top[OxO2f7a[26]][OxO2f7a[28]];_origincolor=top[OxO2f7a[26]][OxO2f7a[29]];_editor=top[OxO2f7a[26]][OxO2f7a[30]];} ;} ;} ;var _selectedcolor=null;function do_select(Oxd5){_selectedcolor=Oxd5;firecolorchange(Oxd5);var Ox29e=document.getElementById(OxO2f7a[31]);if(Ox29e){Ox29e[OxO2f7a[32]]=Oxd5;} ;} ;function do_saverecent(Oxd5){if(!Oxd5){return ;} ;if(Oxd5[OxO2f7a[5]]!=7){return ;} ;if(Oxd5.substring(0,1)!=OxO2f7a[33]){return ;} ;var hex=Oxd5.substring(1,7);var Ox2a0=GetCookie(OxO2f7a[34]);if(!Ox2a0){Ox2a0=OxO2f7a[6];} ;if((Ox2a0[OxO2f7a[5]]%6)!=0){Ox2a0=OxO2f7a[6];} ;for(var i=0;i<Ox2a0[OxO2f7a[5]];i+=6){if(Ox2a0.substr(i,6)==hex){Ox2a0=Ox2a0.substr(0,i)+Ox2a0.substr(i+6);i-=6;} ;} ;if(Ox2a0[OxO2f7a[5]]>31*6){Ox2a0=Ox2a0.substr(0,31*6);} ;Ox2a0=hex+Ox2a0;SetCookie(OxO2f7a[34],Ox2a0,60*60*24*365);} ;function do_insert(){var Oxd5;var divpreview=document.getElementById(OxO2f7a[31]);if(divpreview){Oxd5=divpreview[OxO2f7a[32]];} else {Oxd5=_selectedcolor;} ;if(!Oxd5){return ;} ;if(/^[0-9A-F]{6}$/ig.test(Oxd5)){Oxd5=OxO2f7a[33]+Oxd5;} ;try{document.createElement(OxO2f7a[35])[OxO2f7a[15]][OxO2f7a[29]]=Oxd5;do_saverecent(Oxd5);Window_SetDialogReturnValue(window,Oxd5);Window_CloseDialog(window);} catch(x){alert(OxO2f7a[36]);divpreview[OxO2f7a[32]]=OxO2f7a[6];return false;} ;} ;