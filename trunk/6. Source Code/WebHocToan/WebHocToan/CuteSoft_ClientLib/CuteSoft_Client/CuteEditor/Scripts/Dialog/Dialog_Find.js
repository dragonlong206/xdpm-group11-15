var OxO110d=["stringSearch","stringReplace","MatchWholeWord","MatchCase","document","checked","length","value","Nothing to search.","selection","body","type","Control","text","Finished Searching the document. Would you like to start again from the top?","","textedit","[[WordNotFound]]","[[WordReplaced]] : ","Please use replace funtion."];var editwin=Window_GetDialogArguments(window);var stringSearch=Window_GetElement(window,OxO110d[0],true);var stringReplace=Window_GetElement(window,OxO110d[1],true);var MatchWholeWord=Window_GetElement(window,OxO110d[2],true);var MatchCase=Window_GetElement(window,OxO110d[3],true);var editdoc=editwin[OxO110d[4]];function get_ie_matchtype(){var Ox309=0;var Ox30a=0;var Ox30b=0;if(MatchCase[OxO110d[5]]){Ox30a=4;} ;if(MatchWholeWord[OxO110d[5]]){Ox30b=2;} ;Ox309=Ox30a+Ox30b;return (Ox309);} ;function checkInputString(){if(stringSearch[OxO110d[7]][OxO110d[6]]<1){alert(OxO110d[8]);return false;} else {return true;} ;} ;function IsMatchSearchValue(Ox24){if(!Ox24){return false;} ;if(stringSearch[OxO110d[7]]==Ox24){return true;} ;if(MatchCase[OxO110d[5]]){return false;} ;return stringSearch[OxO110d[7]].toLowerCase()==Ox24.toLowerCase();} ;var _ie_range=null;function IE_Restore(){editwin.focus();if(_ie_range!=null){_ie_range.select();} ;} ;function IE_Save(){editwin.focus();_ie_range=editdoc[OxO110d[9]].createRange();} ;function MoveToBodyStart(){if(Browser_UseIESelection()){range=document[OxO110d[10]].createTextRange();range.collapse(true);range.select();IE_Save();} else {editwin.getSelection().collapse(editdoc.body,0);} ;} ;function DoFind(){if(Browser_UseIESelection()){IE_Restore();var Ox12f=editdoc[OxO110d[9]];if(Ox12f[OxO110d[11]]==OxO110d[12]){MoveToBodyStart();} ;var Ox21f=Ox12f.createRange();Ox21f.collapse(false);if(Ox21f.findText(stringSearch.value,1000000000,get_ie_matchtype())){Ox21f.select();IE_Save();return true;} ;} else {var Ox21f=editwin.getSelection().getRangeAt(0);if(editwin.find(stringSearch.value,MatchCase.checked,false,false,MatchWholeWord.checked,false,false)){return true;} ;} ;} ;function DoReplace(){if(Browser_UseIESelection()){IE_Restore();var Ox12f=editdoc[OxO110d[9]];if(Ox12f[OxO110d[11]]!=OxO110d[12]){var Ox21f=Ox12f.createRange();if(IsMatchSearchValue(Ox21f.text)){Ox21f[OxO110d[13]]=stringReplace[OxO110d[7]];Ox21f.collapse(false);IE_Save();return true;} ;} ;} else {var Ox12f=editwin.getSelection();if(IsMatchSearchValue(Ox12f.toString())){Ox12f.deleteFromDocument();Ox12f.getRangeAt(0).insertNode(editdoc.createTextNode(stringReplace.value));Ox12f.getRangeAt(0).collapse(false);return true;} ;} ;return false;} ;function FindTxt(){if(!checkInputString()){return false;} ;while(true){if(DoFind()){return ;} ;if(!confirm(OxO110d[14])){return ;} ;MoveToBodyStart();} ;} ;function ReplaceTxt(){if(!checkInputString()){return ;} ;DoReplace();FindTxt();} ;function ReplaceAllTxt(){if(!checkInputString()){return ;} ;var Ox317=0;var msg=OxO110d[15];MoveToBodyStart();if(Browser_UseIESelection()){var Ox12f=editdoc[OxO110d[9]];if(Ox12f[OxO110d[11]]==OxO110d[12]){MoveToBodyStart();} ;var Ox318=Ox12f.createRange();var Ox317=0;var msg=OxO110d[15];Ox318.expand(OxO110d[16]);Ox318.collapse();Ox318.select();while(Ox318.findText(stringSearch.value,1000000000,get_ie_matchtype())){Ox318.select();Ox318[OxO110d[13]]=stringReplace[OxO110d[7]];Ox317++;} ;if(Ox317==0){msg=OxO110d[17];} else {msg=OxO110d[18]+Ox317;} ;alert(msg);} else {if((stringReplace[OxO110d[7]]).indexOf(stringSearch.value)==-1){DoFind();while(DoReplace()){Ox317++;DoFind();FindTxt();} ;if(Ox317==0){msg=OxO110d[17];} else {msg=OxO110d[18]+Ox317;} ;alert(msg);} else {FindTxt();alert(OxO110d[19]);} ;} ;} ;