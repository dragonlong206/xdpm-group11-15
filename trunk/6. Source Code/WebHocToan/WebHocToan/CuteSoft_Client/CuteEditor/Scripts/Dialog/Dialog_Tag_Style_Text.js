var OxO6094=["","sel_align","sel_valign","sel_justify","sel_letter","tb_letter","sel_letter_unit","sel_line","tb_line","sel_line_unit","tb_indent","sel_indent_unit","sel_direction","sel_writingmode","outer","div_demo","disabled","selectedIndex","cssText","style","value","textAlign","verticalAlign","textJustify","letterSpacing","length","options","lineHeight","textIndent","direction","writingMode"];function ParseFloatToString(Ox24){var Ox8=parseFloat(Ox24);if(isNaN(Ox8)){return OxO6094[0];} ;return Ox8+OxO6094[0];} ;var sel_align=Window_GetElement(window,OxO6094[1],true);var sel_valign=Window_GetElement(window,OxO6094[2],true);var sel_justify=Window_GetElement(window,OxO6094[3],true);var sel_letter=Window_GetElement(window,OxO6094[4],true);var tb_letter=Window_GetElement(window,OxO6094[5],true);var sel_letter_unit=Window_GetElement(window,OxO6094[6],true);var sel_line=Window_GetElement(window,OxO6094[7],true);var tb_line=Window_GetElement(window,OxO6094[8],true);var sel_line_unit=Window_GetElement(window,OxO6094[9],true);var tb_indent=Window_GetElement(window,OxO6094[10],true);var sel_indent_unit=Window_GetElement(window,OxO6094[11],true);var sel_direction=Window_GetElement(window,OxO6094[12],true);var sel_writingmode=Window_GetElement(window,OxO6094[13],true);var outer=Window_GetElement(window,OxO6094[14],true);var div_demo=Window_GetElement(window,OxO6094[15],true);UpdateState=function UpdateState_Text(){tb_letter[OxO6094[16]]=sel_letter_unit[OxO6094[16]]=(sel_letter[OxO6094[17]]>0);tb_line[OxO6094[16]]=sel_line_unit[OxO6094[16]]=(sel_line[OxO6094[17]]>0);div_demo[OxO6094[19]][OxO6094[18]]=element[OxO6094[19]][OxO6094[18]];} ;SyncToView=function SyncToView_Text(){sel_align[OxO6094[20]]=element[OxO6094[19]][OxO6094[21]];sel_valign[OxO6094[20]]=element[OxO6094[19]][OxO6094[22]];sel_justify[OxO6094[20]]=element[OxO6094[19]][OxO6094[23]];sel_letter[OxO6094[20]]=element[OxO6094[19]][OxO6094[24]];sel_letter_unit[OxO6094[17]]=0;if(sel_letter[OxO6094[17]]==-1){if(ParseFloatToString(element[OxO6094[19]].letterSpacing)){tb_letter[OxO6094[20]]=ParseFloatToString(element[OxO6094[19]].letterSpacing);for(var i=0;i<sel_letter_unit[OxO6094[26]][OxO6094[25]];i++){var Ox13b=sel_letter_unit[OxO6094[26]][i][OxO6094[20]];if(Ox13b&&element[OxO6094[19]][OxO6094[24]].indexOf(Ox13b)!=-1){sel_letter_unit[OxO6094[17]]=i;break ;} ;} ;} ;} ;sel_line[OxO6094[20]]=element[OxO6094[19]][OxO6094[27]];sel_line_unit[OxO6094[17]]=0;if(sel_line[OxO6094[17]]==-1){if(ParseFloatToString(element[OxO6094[19]].lineHeight)){tb_line[OxO6094[20]]=ParseFloatToString(element[OxO6094[19]].lineHeight);for(var i=0;i<sel_line_unit[OxO6094[26]][OxO6094[25]];i++){var Ox13b=sel_line_unit[OxO6094[26]][i][OxO6094[20]];if(Ox13b&&element[OxO6094[19]][OxO6094[27]].indexOf(Ox13b)!=-1){sel_line_unit[OxO6094[17]]=i;break ;} ;} ;} ;} ;sel_indent_unit[OxO6094[17]]=0;if(!isNaN(ParseFloatToString(element[OxO6094[19]].textIndent))){tb_indent[OxO6094[20]]=ParseFloatToString(element[OxO6094[19]].textIndent);for(var i=0;i<sel_indent_unit[OxO6094[26]][OxO6094[25]];i++){var Ox13b=sel_indent_unit[OxO6094[26]][i][OxO6094[20]];if(Ox13b&&element[OxO6094[19]][OxO6094[28]].indexOf(Ox13b)!=-1){sel_indent_unit[OxO6094[17]]=i;break ;} ;} ;} ;sel_direction[OxO6094[20]]=element[OxO6094[19]][OxO6094[29]];sel_writingmode[OxO6094[20]]=element[OxO6094[19]][OxO6094[30]];} ;SyncTo=function SyncTo_Text(element){element[OxO6094[19]][OxO6094[21]]=sel_align[OxO6094[20]];element[OxO6094[19]][OxO6094[22]]=sel_valign[OxO6094[20]];element[OxO6094[19]][OxO6094[23]]=sel_justify[OxO6094[20]];if(sel_letter[OxO6094[17]]>0){element[OxO6094[19]][OxO6094[24]]=sel_letter[OxO6094[20]];} else {if(ParseFloatToString(tb_letter.value)){element[OxO6094[19]][OxO6094[24]]=ParseFloatToString(tb_letter.value)+sel_letter_unit[OxO6094[20]];} else {element[OxO6094[19]][OxO6094[24]]=OxO6094[0];} ;} ;if(sel_line[OxO6094[17]]>0){element[OxO6094[19]][OxO6094[27]]=sel_line[OxO6094[20]];} else {if(ParseFloatToString(tb_line.value)){element[OxO6094[19]][OxO6094[27]]=ParseFloatToString(tb_line.value)+sel_line_unit[OxO6094[20]];} else {element[OxO6094[19]][OxO6094[27]]=OxO6094[0];} ;} ;if(ParseFloatToString(tb_indent.value)){element[OxO6094[19]][OxO6094[28]]=ParseFloatToString(tb_indent.value)+sel_indent_unit[OxO6094[20]];} else {element[OxO6094[19]][OxO6094[28]]=OxO6094[0];} ;element[OxO6094[19]][OxO6094[29]]=sel_direction[OxO6094[20]]||OxO6094[0];element[OxO6094[19]][OxO6094[30]]=sel_writingmode[OxO6094[20]]||OxO6094[0];} ;