var OxO32f1=["rowSpan","removeNode","parentNode","firstChild","colSpan","nodeName","TABLE","Map","rowIndex","rows","length","cells","cellIndex","innerHTML","cell","\x26nbsp;","Can\x27t Get The Position ?","RowCount","ColCount","Unknown Error , pos ",":"," already have cell","Unknown Error , Unable to find bestpos","tbody","richDropDown","list_Templates","subcolumns","addcolumns","subcolspan","addcolspan","btn_row_dialog","btn_cell_dialog","inp_cell_width","inp_cell_height","btn_cell_editcell","tabledesign","subrows","addrows","subrowspan","addrowspan","display","style","none","disabled","value","width","height","[[ValidNumber]]","","\x3Ctable\x3E\x3Ctr\x3E\x3Ctd height=\x2224\x22\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","\x3Ctable\x3E\x3Ctr\x3E\x3Ctd\x3E\x3C/td\x3E\x3Ctd\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","\x3Ctable\x3E\x3Ctr\x3E\x3Ctd\x3E\x3C/td\x3E\x3Ctd\x3E\x3C/td\x3E\x3Ctd\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","\x3Ctable border=\x220\x22 cellpadding=\x220\x22 cellspacing=\x220\x22\x3E\x3Ctr\x3E\x3Ctd valign=\x22top\x22 colspan=\x222\x22\x3E\x3C/td\x3E\x3C/tr\x3E","\x3Ctr\x3E\x3Ctd valign=\x22top\x22 rowspan=\x222\x22\x3E\x3C/td\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3C/tr\x3E","\x3Ctr\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","\x3Ctr\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3Ctd valign=\x22top\x22 rowspan=\x222\x22\x3E\x3C/td\x3E\x3C/tr\x3E\x3Ctr\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","\x3Ctable border=\x220\x22 cellpadding=\x220\x22 cellspacing=\x220\x22\x3E\x3Ctr\x3E\x3Ctd valign=\x22top\x22 colspan=\x223\x22\x3E\x3C/td\x3E\x3C/tr\x3E","\x3Ctr\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3Ctd valign=\x22top\x22\x3E\x3C/td\x3E\x3C/tr\x3E","\x3Ctr\x3E\x3Ctd valign=\x22top\x22 colspan=\x223\x22\x3E\x3C/td\x3E\x3C/tr\x3E\x3C/table\x3E","DIV","onclick","bgColor","#d4d0c8","onmouseover","onmouseout","ondblclick","contains","ToggleBorder","backgroundColor","highlight","cssText","runtimeStyle","background-color:gray","onload","body","document","csstext","font:normal 11px Tahoma;background-color:windowtext;","isOpen"];function Table_GetCellFromMap(Ox508,Ox509,Ox50a){var Ox50b=Ox508[Ox509];if(Ox50b){return Ox50b[Ox50a];} ;} ;function Table_CanSubRowSpan(Ox38e){return Ox38e[OxO32f1[0]]>1;} ;function Element_RemoveNode(element,Ox50e){if(element[OxO32f1[1]]){element.removeNode(Ox50e);return ;} ;var p=element[OxO32f1[2]];if(!p){return ;} ;if(Ox50e){p.removeChild(element);return ;} ;while(true){var Ox239=element[OxO32f1[3]];if(!Ox239){break ;} ;p.insertBefore(Ox239,element);} ;p.removeChild(element);} ;function Table_CanSubColSpan(Ox38e){return Ox38e[OxO32f1[4]]>1;} ;function Table_GetTable(Ox42){for(;Ox42!=null;Ox42=Ox42[OxO32f1[2]]){if(Ox42[OxO32f1[5]]==OxO32f1[6]){return Ox42;} ;} ;return null;} ;function Table_SubRowSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox11f=Table_GetCellPositionFromMap(Ox508,Ox38e);var Ox512=Ox38c[OxO32f1[9]].item(Ox38e[OxO32f1[2]][OxO32f1[8]]+Ox38e[OxO32f1[0]]-1);var Ox513=0;for(var i=0;i<Ox512[OxO32f1[11]][OxO32f1[10]];i++){var Ox514=Ox512[OxO32f1[11]].item(i);var Ox515=Table_GetCellPositionFromMap(Ox508,Ox514);if(Ox515[OxO32f1[12]]<Ox11f[OxO32f1[12]]){Ox513=i+1;} ;} ;for(var i=0;i<Ox38e[OxO32f1[4]];i++){var Ox239=Ox512.insertCell(Ox513);if(Browser_IsOpera()){Ox239[OxO32f1[13]]=OxO32f1[14];} else {if(Browser_IsGecko()||Browser_IsSafari()){Ox239[OxO32f1[13]]=OxO32f1[15];} ;} ;} ;Ox38e[OxO32f1[0]]--;} ;function Table_GetCellPositionFromMap(Ox508,Ox38e){for(var y=0;y<Ox508[OxO32f1[10]];y++){var Ox50b=Ox508[y];for(var x=0;x<Ox50b[OxO32f1[10]];x++){if(Ox50b[x]==Ox38e){return {rowIndex:y,cellIndex:x};} ;} ;} ;throw ( new Error(-1,OxO32f1[16]));} ;function Table_GetCellMap(Ox38c){return Table_CalculateTableInfo(Ox38c)[OxO32f1[7]];} ;function Table_GetRowCount(Ox42){return Table_CalculateTableInfo(Ox42)[OxO32f1[17]];} ;function Table_GetColCount(Ox42){return Table_CalculateTableInfo(Ox42)[OxO32f1[18]];} ;function Table_CalculateTableInfo(Ox42){var Ox38c=Table_GetTable(Ox42);var Ox51b=Ox38c[OxO32f1[9]];for(var Oxa=Ox51b[OxO32f1[10]]-1;Oxa>=0;Oxa--){var Ox37e=Ox51b.item(Oxa);if(Ox37e[OxO32f1[11]][OxO32f1[10]]==0){Element_RemoveNode(Ox37e,true);continue ;} ;} ;var Ox51c=Ox51b[OxO32f1[10]];var Ox51d=0;var Ox51e= new Array(Ox51b.length);for(var Ox51f=0;Ox51f<Ox51c;Ox51f++){Ox51e[Ox51f]=[];} ;function Ox520(Oxa,Ox239,Ox38e){while(Oxa>=Ox51c){Ox51e[Ox51c]=[];Ox51c++;} ;var Ox521=Ox51e[Oxa];if(Ox239>=Ox51d){Ox51d=Ox239+1;} ;if(Ox521[Ox239]!=null){throw ( new Error(-1,OxO32f1[19]+Oxa+OxO32f1[20]+Ox239+OxO32f1[21]));} ;Ox521[Ox239]=Ox38e;} ;function Ox522(Oxa,Ox239){var Ox521=Ox51e[Oxa];if(Ox521){return Ox521[Ox239];} ;} ;for(var Ox51f=0;Ox51f<Ox51b[OxO32f1[10]];Ox51f++){var Ox37e=Ox51b.item(Ox51f);var Ox523=Ox37e[OxO32f1[11]];for(var Ox392=0;Ox392<Ox523[OxO32f1[10]];Ox392++){var Ox38e=Ox523.item(Ox392);var Ox524=Ox38e[OxO32f1[0]];var Ox525=Ox38e[OxO32f1[4]];var Ox521=Ox51e[Ox51f];var Ox526=-1;for(var Ox527=0;Ox527<Ox51d+Ox525+1;Ox527++){if(Ox524==1&&Ox525==1){if(Ox521[Ox527]==null){Ox526=Ox527;break ;} ;} else {var Ox528=true;for(var Ox529=0;Ox529<Ox524;Ox529++){for(var Ox52a=0;Ox52a<Ox525;Ox52a++){if(Ox522(Ox51f+Ox529,Ox527+Ox52a)!=null){Ox528=false;break ;} ;} ;} ;if(Ox528){Ox526=Ox527;break ;} ;} ;} ;if(Ox526==-1){throw ( new Error(-1,OxO32f1[22]));} ;if(Ox524==1&&Ox525==1){Ox520(Ox51f,Ox526,Ox38e);} else {for(var Ox529=0;Ox529<Ox524;Ox529++){for(var Ox52a=0;Ox52a<Ox525;Ox52a++){Ox520(Ox51f+Ox529,Ox526+Ox52a,Ox38e);} ;} ;} ;} ;} ;var Ox137={};Ox137[OxO32f1[17]]=Ox51c;Ox137[OxO32f1[18]]=Ox51d;Ox137[OxO32f1[7]]=Ox51e;for(var Oxa=0;Oxa<Ox51c;Oxa++){var Ox521=Ox51e[Oxa];for(var Ox239=0;Ox239<Ox51d;Ox239++){} ;} ;return Ox137;} ;function Table_SubColSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);Ox38e[OxO32f1[2]].insertCell(Ox38e[OxO32f1[12]]+1)[OxO32f1[0]]=Ox38e[OxO32f1[0]];Ox38e[OxO32f1[4]]--;} ;function Table_CanAddRowSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox11f=Table_GetCellPositionFromMap(Ox508,Ox38e);var Ox52d=0;for(var Ox239=0;Ox239<Ox38e[OxO32f1[4]];Ox239++){var Ox52e=Table_GetCellFromMap(Ox508,Ox11f[OxO32f1[8]]+Ox38e[OxO32f1[0]],Ox11f[OxO32f1[12]]+Ox239);if(Ox52e==null){return false;} ;if(Ox52d!=0&&Ox52d!=Ox52e[OxO32f1[0]]){return false;} ;Ox52d=Ox52e[OxO32f1[0]];var Ox52f=Table_GetCellPositionFromMap(Ox508,Ox52e);if(Ox52f[OxO32f1[12]]<Ox11f[OxO32f1[12]]){return false;} ;if(Ox52f[OxO32f1[12]]+Ox52e[OxO32f1[4]]>Ox11f[OxO32f1[12]]+Ox38e[OxO32f1[4]]){return false;} ;} ;return true;} ;function Table_AddRow(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox51d=Ox4[OxO32f1[18]];var Ox51c=Ox4[OxO32f1[17]];var Ox37e;if(!Browser_IsSafari()){Ox37e=Ox38c.insertRow(-1);} else {var Ox21c=document.createElement(OxO32f1[23]);Ox38c.appendChild(Ox21c);Ox37e=Ox21c.insertRow(-1);} ;for(var i=0;i<Ox51d;i++){var Ox239=Ox37e.insertCell(-1);if(Browser_IsOpera()){Ox239[OxO32f1[13]]=OxO32f1[14];} else {if(Browser_IsGecko()||Browser_IsSafari()){Ox239[OxO32f1[13]]=OxO32f1[15];} ;} ;} ;} ;function Table_AddCol(Ox38e){var Ox38c=Table_GetTable(Ox38e);for(var Oxa=0;Oxa<Ox38c[OxO32f1[9]][OxO32f1[10]];Oxa++){var Ox37e=Ox38c[OxO32f1[9]].item(Oxa);var Ox239=Ox37e.insertCell(-1);if(Browser_IsOpera()){Ox239[OxO32f1[13]]=OxO32f1[14];} else {if(Browser_IsGecko()||Browser_IsSafari()){Ox239[OxO32f1[13]]=OxO32f1[15];} ;} ;} ;} ;function Table_CleanUpTableInfo(Ox38c,Ox4){var Ox51b=Ox38c[OxO32f1[9]];for(var Oxa=Ox51b[OxO32f1[10]]-1;Oxa>=0;Oxa--){var Ox37e=Ox51b.item(Oxa);if(Ox37e[OxO32f1[11]][OxO32f1[10]]==0){Element_RemoveNode(Ox37e,true);continue ;} ;} ;var Ox508=Ox4[OxO32f1[7]];var Ox51d=Ox4[OxO32f1[18]];var Ox51c=Ox4[OxO32f1[17]];for(var Ox51f=1;Ox51f<Ox51c;Ox51f++){var Ox533=true;for(var Ox392=0;Ox392<Ox51d;Ox392++){if(Table_GetCellFromMap(Ox508,Ox51f-1,Ox392)!=Table_GetCellFromMap(Ox508,Ox51f,Ox392)){Ox533=false;break ;} ;} ;if(Ox533){for(var Ox392=0;Ox392<Ox51d;Ox392++){var Ox38e=Table_GetCellFromMap(Ox508,Ox51f,Ox392);if(Ox38e){if(Ox38e[OxO32f1[0]]>1){Ox38e[OxO32f1[0]]=Ox38e[OxO32f1[0]]-1;} ;Ox392+=Ox38e[OxO32f1[4]]-1;} ;} ;} ;} ;for(var Ox392=1;Ox392<Ox51d;Ox392++){var Ox533=true;for(var Ox51f=0;Ox51f<Ox51c;Ox51f++){if(Table_GetCellFromMap(Ox508,Ox51f,Ox392-1)!=Table_GetCellFromMap(Ox508,Ox51f,Ox392)){Ox533=false;break ;} ;} ;if(Ox533){for(var Ox51f=0;Ox51f<Ox51c;Ox51f++){var Ox38e=Table_GetCellFromMap(Ox508,Ox51f,Ox392);if(Ox38e){if(Ox38e[OxO32f1[4]]>1){Ox38e[OxO32f1[4]]=Ox38e[OxO32f1[4]]-1;} ;Ox51f+=Ox38e[OxO32f1[0]]-1;} ;} ;} ;} ;} ;function Table_SubRow(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox51d=Ox4[OxO32f1[18]];var Ox51c=Ox4[OxO32f1[17]];if(Ox51c==0){return ;} ;var Ox535={};var Ox51f=Ox51c-1;for(var Ox392=0;Ox392<Ox51d;Ox392++){var Ox38e=Table_GetCellFromMap(Ox508,Ox51f,Ox392);if(Ox38e){if(Ox38e[OxO32f1[2]]==null){continue ;} ;if(Ox38e[OxO32f1[0]]==1){Element_RemoveNode(Ox38e,true);} else {Ox38e[OxO32f1[0]]=Ox38e[OxO32f1[0]]-1;} ;} ;} ;Ox4[OxO32f1[17]]--;Table_CleanUpTableInfo(Ox38c,Ox4);} ;function Table_CanAddColSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox11f=Table_GetCellPositionFromMap(Ox508,Ox38e);var Ox537=0;for(var Oxa=0;Oxa<Ox38e[OxO32f1[0]];Oxa++){var Ox52e=Table_GetCellFromMap(Ox508,Ox11f[OxO32f1[8]]+Oxa,Ox11f[OxO32f1[12]]+Ox38e[OxO32f1[4]]);if(Ox52e==null){return false;} ;if(Ox537!=0&&Ox537!=Ox52e[OxO32f1[4]]){return false;} ;Ox537=Ox52e[OxO32f1[4]];var Ox52f=Table_GetCellPositionFromMap(Ox508,Ox52e);if(Ox52f[OxO32f1[8]]<Ox11f[OxO32f1[8]]){return false;} ;if(Ox52f[OxO32f1[8]]+Ox52e[OxO32f1[0]]>Ox11f[OxO32f1[8]]+Ox38e[OxO32f1[0]]){return false;} ;} ;return true;} ;function Table_AddRowSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox11f=Table_GetCellPositionFromMap(Ox508,Ox38e);var Ox52d=0;for(var Ox239=0;Ox239<Ox38e[OxO32f1[4]];Ox239++){var Ox52e=Table_GetCellFromMap(Ox508,Ox11f[OxO32f1[8]]+Ox38e[OxO32f1[0]],Ox11f[OxO32f1[12]]+Ox239);if(Ox52d==0){Ox52d=Ox52e[OxO32f1[0]];} ;Element_RemoveNode(Ox52e,true);} ;Ox38e[OxO32f1[0]]=Ox38e[OxO32f1[0]]+Ox52d;for(var Ox51f=0;Ox51f<Ox38e[OxO32f1[0]];Ox51f++){for(var Ox392=0;Ox392<Ox38e[OxO32f1[4]];Ox392++){Ox4[OxO32f1[7]][Ox11f[OxO32f1[8]]+Ox51f][Ox11f[OxO32f1[12]]+Ox392]=Ox38e;} ;} ;Table_CleanUpTableInfo(Ox38c,Ox4);} ;function Table_AddColSpan(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox11f=Table_GetCellPositionFromMap(Ox508,Ox38e);var Ox537=0;for(var Oxa=0;Oxa<Ox38e[OxO32f1[0]];Oxa++){var Ox52e=Table_GetCellFromMap(Ox508,Ox11f[OxO32f1[8]]+Oxa,Ox11f[OxO32f1[12]]+Ox38e[OxO32f1[4]]);if(Ox537==0){Ox537=Ox52e[OxO32f1[4]];} ;Element_RemoveNode(Ox52e,true);} ;Ox38e[OxO32f1[4]]+=Ox537;for(var Ox51f=0;Ox51f<Ox38e[OxO32f1[0]];Ox51f++){for(var Ox392=0;Ox392<Ox38e[OxO32f1[4]];Ox392++){Ox4[OxO32f1[7]][Ox11f[OxO32f1[8]]+Ox51f][Ox11f[OxO32f1[12]]+Ox392]=Ox38e;} ;} ;Table_CleanUpTableInfo(Ox38c,Ox4);} ;function Table_SubCol(Ox38e){var Ox38c=Table_GetTable(Ox38e);var Ox4=Table_CalculateTableInfo(Ox38c);var Ox508=Ox4[OxO32f1[7]];var Ox51d=Ox4[OxO32f1[18]];var Ox51c=Ox4[OxO32f1[17]];if(Ox51c==0){return ;} ;var Ox535={};var Ox392=Ox51d-1;for(var Ox51f=0;Ox51f<Ox51c;Ox51f++){var Ox38e=Table_GetCellFromMap(Ox508,Ox51f,Ox392);if(Ox38e[OxO32f1[2]]==null){continue ;} ;if(Ox38e[OxO32f1[4]]==1){Element_RemoveNode(Ox38e,true);} else {Ox38e[OxO32f1[4]]=Ox38e[OxO32f1[4]]-1;} ;} ;Ox4[OxO32f1[18]]--;Table_CleanUpTableInfo(Ox38c,Ox4);} ;var richDropDown=Window_GetElement(window,OxO32f1[24],true);var list_Templates=Window_GetElement(window,OxO32f1[25],true);var subcolumns=Window_GetElement(window,OxO32f1[26],true);var addcolumns=Window_GetElement(window,OxO32f1[27],true);var subcolspan=Window_GetElement(window,OxO32f1[28],true);var addcolspan=Window_GetElement(window,OxO32f1[29],true);var btn_row_dialog=Window_GetElement(window,OxO32f1[30],true);var btn_cell_dialog=Window_GetElement(window,OxO32f1[31],true);var inp_cell_width=Window_GetElement(window,OxO32f1[32],true);var inp_cell_height=Window_GetElement(window,OxO32f1[33],true);var btn_cell_editcell=Window_GetElement(window,OxO32f1[34],true);var tabledesign=Window_GetElement(window,OxO32f1[35],true);var subrows=Window_GetElement(window,OxO32f1[36],true);var addrows=Window_GetElement(window,OxO32f1[37],true);var subrowspan=Window_GetElement(window,OxO32f1[38],true);var addrowspan=Window_GetElement(window,OxO32f1[39],true);btn_cell_editcell[OxO32f1[41]][OxO32f1[40]]=OxO32f1[42];UpdateState=function UpdateState_InsertTable(){btn_cell_editcell[OxO32f1[43]]=btn_row_dialog[OxO32f1[43]]=btn_cell_dialog[OxO32f1[43]]=GetElementCell()==null;} ;SyncToView=function SyncToView_InsertTable(){var Ox54d=GetElementCell();if(Ox54d){inp_cell_width[OxO32f1[44]]=Ox54d[OxO32f1[45]];inp_cell_height[OxO32f1[44]]=Ox54d[OxO32f1[46]];} ;} ;SyncTo=function SyncTo_InsertTable(element){var Ox54d=GetElementCell();if(Ox54d){try{Ox54d[OxO32f1[45]]=inp_cell_width[OxO32f1[44]];Ox54d[OxO32f1[46]]=inp_cell_height[OxO32f1[44]];} catch(er){alert(OxO32f1[47]);} ;} ;} ;function selectTemplate(Ox93){var Ox550=OxO32f1[48];switch(Ox93){case 1:Ox550=OxO32f1[49];break ;;case 2:Ox550=OxO32f1[50];break ;;case 3:Ox550=OxO32f1[51];break ;;case 4:Ox550=OxO32f1[52];Ox550=Ox550+OxO32f1[53];Ox550=Ox550+OxO32f1[54];break ;;case 5:Ox550=OxO32f1[52];Ox550=Ox550+OxO32f1[55];break ;;case 6:Ox550=OxO32f1[56];Ox550=Ox550+OxO32f1[57];Ox550=Ox550+OxO32f1[58];break ;;default:break ;;} ;try{var Ox75=document.createElement(OxO32f1[59]);Ox75[OxO32f1[13]]=Ox550;var Ox38c=Ox75.children(0);ApplyTable(Ox38c,element);ApplyTable(Ox38c,tabledesign);HandleTableChanged();hidePopup();} catch(x){} ;} ;subcolumns[OxO32f1[60]]=function subcolumns_onclick(){Table_SubCol(GetElementCell());Table_SubCol(currentcell);HandleTableChanged();} ;addcolumns[OxO32f1[60]]=function addcolumns_onclick(){Table_AddCol(GetElementCell());Table_AddCol(currentcell);HandleTableChanged();} ;subrows[OxO32f1[60]]=function subrows_onclick(){Table_SubRow(GetElementCell());Table_SubRow(currentcell);HandleTableChanged();} ;addrows[OxO32f1[60]]=function addrows_onclick(){Table_AddRow(currentcell);Table_AddRow(GetElementCell());HandleTableChanged();} ;subcolspan[OxO32f1[60]]=function subcolspan_onclick(){Table_SubColSpan(GetElementCell());Table_SubColSpan(currentcell);HandleTableChanged();} ;addcolspan[OxO32f1[60]]=function addcolspan_onclick(){Table_AddColSpan(GetElementCell());Table_AddColSpan(currentcell);HandleTableChanged();} ;subrowspan[OxO32f1[60]]=function subrowspan_onclick(){Table_SubRowSpan(GetElementCell());Table_SubRowSpan(currentcell);HandleTableChanged();} ;addrowspan[OxO32f1[60]]=function addrowspan_onclick(){Table_AddRowSpan(GetElementCell());Table_AddRowSpan(currentcell);HandleTableChanged();} ;function InitDesignTableCells(){for(var Oxa=0;Oxa<tabledesign[OxO32f1[9]][OxO32f1[10]];Oxa++){var Ox37e=tabledesign[OxO32f1[9]][Oxa];for(var Ox239=0;Ox239<Ox37e[OxO32f1[11]][OxO32f1[10]];Ox239++){var Ox38e=Ox37e[OxO32f1[11]][Ox239];Ox38e.removeAttribute(OxO32f1[45]);Ox38e.removeAttribute(OxO32f1[46]);Ox38e[OxO32f1[45]]=OxO32f1[48];Ox38e[OxO32f1[46]]=OxO32f1[48];Ox38e[OxO32f1[61]]=OxO32f1[62];Ox38e[OxO32f1[63]]=cell_mouseover;Ox38e[OxO32f1[64]]=cell_mouseout;Ox38e[OxO32f1[60]]=cell_click;Ox38e[OxO32f1[65]]=cell_dblclick;} ;} ;} ;function Element_Contains(element,Ox17c){if(!Browser_IsOpera()){if(element[OxO32f1[66]]){return element.contains(Ox17c);} ;} ;for(;Ox17c!=null;Ox17c=Ox17c[OxO32f1[2]]){if(element==Ox17c){return true;} ;} ;return false;} ;function HandleTableChanged(){if(!Element_Contains(tabledesign,currentcell)){SetCurrentCell(tabledesign.rows(0).cells(0));} ;InitDesignTableCells();UpdateButtonStates();editor.ExecCommand(OxO32f1[67]);editor.ExecCommand(OxO32f1[67]);} ;function cell_mouseover(){var Ox38e=this;Ox38e[OxO32f1[41]][OxO32f1[68]]=OxO32f1[69];} ;function cell_mouseout(){var Ox38e=this;Ox38e[OxO32f1[41]][OxO32f1[68]]=OxO32f1[62];} ;function cell_click(){var Ox38e=this;SetCurrentCell(Ox38e);} ;function cell_dblclick(){var Ox38e=this;SetCurrentCell(Ox38e);} ;btn_cell_editcell[OxO32f1[60]]=function btn_cell_editcell_onclick(){var Ox38e=GetElementCell();var Ox27a=editor.EditInWindow(Ox38e.innerHTML,window);if(Ox27a!=null&&Ox27a!==false){Ox38e[OxO32f1[13]]=Ox27a;} ;} ;btn_cell_dialog[OxO32f1[60]]=function btn_cell_dialog_onclick(){editor.SetNextDialogWindow(window);editor.ShowTagDialogWithNoCancellable(GetElementCell());} ;btn_row_dialog[OxO32f1[60]]=function btn_row_dialog_onclick(){editor.SetNextDialogWindow(window);editor.ShowTagDialogWithNoCancellable(GetElementCell().parentNode);} ;var currentcell=null;function GetElementCell(){if(currentcell==null){return null;} ;return element[OxO32f1[9]][currentcell[OxO32f1[2]][OxO32f1[8]]][OxO32f1[11]][currentcell[OxO32f1[12]]];} ;function SetCurrentCell(Ox38e){if(currentcell!=null){if(Browser_IsWinIE()){currentcell[OxO32f1[71]][OxO32f1[70]]=OxO32f1[48];} else {currentcell[OxO32f1[41]][OxO32f1[70]]=OxO32f1[48];} ;} ;currentcell=Ox38e;if(Browser_IsWinIE()){currentcell[OxO32f1[71]][OxO32f1[70]]=OxO32f1[72];} else {currentcell[OxO32f1[41]][OxO32f1[70]]=OxO32f1[72];} ;UpdateButtonStates();SyncToViewInternal();} ;function UpdateButtonStates(){subcolspan[OxO32f1[43]]=!Table_CanSubColSpan(currentcell);addcolspan[OxO32f1[43]]=!Table_CanAddColSpan(currentcell);subrowspan[OxO32f1[43]]=!Table_CanSubRowSpan(currentcell);addrowspan[OxO32f1[43]]=!Table_CanAddRowSpan(currentcell);subrows[OxO32f1[43]]=Table_GetRowCount(currentcell)<2;subcolumns[OxO32f1[43]]=Table_GetColCount(currentcell)<2;} ;function ApplyTable(src,Ox567){if(Browser_IsSafari()){Ox567[OxO32f1[41]][OxO32f1[46]]=OxO32f1[48];} ;for(var Oxa=Ox567[OxO32f1[9]][OxO32f1[10]]-1;Oxa>=0;Oxa--){Ox567[OxO32f1[9]][Oxa].removeNode(true);} ;for(var Oxa=0;Oxa<src[OxO32f1[9]][OxO32f1[10]];Oxa++){var Ox568=src[OxO32f1[9]][Oxa];var Ox569;if(!Browser_IsSafari()){Ox569=Ox567.insertRow(-1);} else {var Ox21c=document.createElement(OxO32f1[23]);Ox567.appendChild(Ox21c);Ox569=Ox21c.insertRow(-1);} ;Ox569[OxO32f1[41]][OxO32f1[70]]=Ox568[OxO32f1[41]][OxO32f1[70]];for(var Ox239=0;Ox239<Ox568[OxO32f1[11]][OxO32f1[10]];Ox239++){var Ox56a=Ox568[OxO32f1[11]][Ox239];var Ox56b=Ox569.insertCell(-1);Ox56b[OxO32f1[0]]=Ox56a[OxO32f1[0]];Ox56b[OxO32f1[4]]=Ox56a[OxO32f1[4]];Ox56b[OxO32f1[41]][OxO32f1[70]]=Ox56a[OxO32f1[41]][OxO32f1[70]];if(Browser_IsOpera()){Ox56b[OxO32f1[13]]=OxO32f1[14];} else {if(Browser_IsGecko()||Browser_IsSafari()){Ox56b[OxO32f1[13]]=OxO32f1[15];} ;} ;} ;} ;} ;window[OxO32f1[73]]=function window_onload(){ApplyTable(element,tabledesign);InitDesignTableCells();SetCurrentCell(tabledesign[OxO32f1[9]][0][OxO32f1[11]][0]);} ;function updateList(){} ;var oPopup;if(Browser_IsWinIE()){oPopup=window.createPopup();} else {richDropDown[OxO32f1[41]][OxO32f1[40]]=OxO32f1[42];} ;function selectTemplates(){if(Browser_IsWinIE()){oPopup[OxO32f1[75]][OxO32f1[74]][OxO32f1[13]]=list_Templates[OxO32f1[13]];oPopup[OxO32f1[75]][OxO32f1[74]][OxO32f1[41]][OxO32f1[76]]=OxO32f1[77];oPopup.show(0,32,380,220,richDropDown);} ;} ;function hidePopup(){if(Browser_IsWinIE()){if(oPopup){if(oPopup[OxO32f1[78]]){oPopup.hide();} ;} ;} ;} ;