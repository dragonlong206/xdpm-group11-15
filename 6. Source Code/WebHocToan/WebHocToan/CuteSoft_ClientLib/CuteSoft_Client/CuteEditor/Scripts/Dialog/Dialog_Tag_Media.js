var OxO1b99=["outer","btnbrowse","inp_src","onclick","value","cssText","style","src","FileName"];var outer=Window_GetElement(window,OxO1b99[0],true);var btnbrowse=Window_GetElement(window,OxO1b99[1],true);var inp_src=Window_GetElement(window,OxO1b99[2],true);btnbrowse[OxO1b99[3]]=function btnbrowse_onclick(){function Ox354(Ox137){if(Ox137){inp_src[OxO1b99[4]]=Ox137;} ;} ;editor.SetNextDialogWindow(window);editor.ShowSelectFileDialog(Ox354,inp_src.value);} ;UpdateState=function UpdateState_Media(){outer[OxO1b99[6]][OxO1b99[5]]=element[OxO1b99[6]][OxO1b99[5]];outer.mergeAttributes(element);if(element[OxO1b99[7]]){outer[OxO1b99[8]]=element[OxO1b99[8]];} else {outer.removeAttribute(OxO1b99[8]);} ;} ;SyncToView=function SyncToView_Media(){inp_src[OxO1b99[4]]=element[OxO1b99[8]];} ;SyncTo=function SyncTo_Media(element){element[OxO1b99[8]]=inp_src[OxO1b99[4]];} ;