var OxObf5e=["inp_action","sel_Method","inp_name","inp_id","inp_encode","sel_target","Name","value","name","id","action","method","encoding","application/x-www-form-urlencoded","","target"];var inp_action=Window_GetElement(window,OxObf5e[0],true);var sel_Method=Window_GetElement(window,OxObf5e[1],true);var inp_name=Window_GetElement(window,OxObf5e[2],true);var inp_id=Window_GetElement(window,OxObf5e[3],true);var inp_encode=Window_GetElement(window,OxObf5e[4],true);var sel_target=Window_GetElement(window,OxObf5e[5],true);UpdateState=function UpdateState_Form(){} ;SyncToView=function SyncToView_Form(){if(element[OxObf5e[6]]){inp_name[OxObf5e[7]]=element[OxObf5e[6]];} ;if(element[OxObf5e[8]]){inp_name[OxObf5e[7]]=element[OxObf5e[8]];} ;inp_id[OxObf5e[7]]=element[OxObf5e[9]];if(element[OxObf5e[10]]){inp_action[OxObf5e[7]]=element[OxObf5e[10]];} ;if(element[OxObf5e[11]]){sel_Method[OxObf5e[7]]=element[OxObf5e[11]];} ;if(element[OxObf5e[12]]==OxObf5e[13]){inp_encode[OxObf5e[7]]=OxObf5e[14];} else {inp_encode[OxObf5e[7]]=element[OxObf5e[12]];} ;if(element[OxObf5e[15]]){sel_target[OxObf5e[7]]=element[OxObf5e[15]];} ;} ;SyncTo=function SyncTo_Form(element){element[OxObf5e[8]]=inp_name[OxObf5e[7]];if(element[OxObf5e[6]]){element[OxObf5e[6]]=inp_name[OxObf5e[7]];} else {if(element[OxObf5e[8]]){element.removeAttribute(OxObf5e[8],0);element[OxObf5e[6]]=inp_name[OxObf5e[7]];} else {element[OxObf5e[6]]=inp_name[OxObf5e[7]];} ;} ;element[OxObf5e[9]]=inp_id[OxObf5e[7]];element[OxObf5e[10]]=inp_action[OxObf5e[7]];element[OxObf5e[11]]=sel_Method[OxObf5e[7]];try{element[OxObf5e[12]]=inp_encode[OxObf5e[7]];} catch(e){} ;element[OxObf5e[15]]=sel_target[OxObf5e[7]];if(element[OxObf5e[15]]==OxObf5e[14]){element.removeAttribute(OxObf5e[15]);} ;if(element[OxObf5e[6]]==OxObf5e[14]){element.removeAttribute(OxObf5e[6]);} ;if(element[OxObf5e[10]]==OxObf5e[14]){element.removeAttribute(OxObf5e[10]);} ;} ;