var OxOfecb=["inp_src","box1","box2","box3","box4","box5","box6","box7","box8","box9","inp_start","CustomBullet","nodeName","LI","parentNode","none","decimal","upper-roman","upper-alpha","lower-alpha","lower-roman","disc","circle","square","listStyleType","style","border","solid 2px #708090","listStyleImage","","value","visibility","hidden","length","start","url(\x27","\x27)","visible","UL","OL","document","firstChild","element","solid 2px #ffffff","solid 2px #ECECF6","onclick"];var inp_src=Window_GetElement(window,OxOfecb[0],true);var box1=Window_GetElement(window,OxOfecb[1],true);var box2=Window_GetElement(window,OxOfecb[2],true);var box3=Window_GetElement(window,OxOfecb[3],true);var box4=Window_GetElement(window,OxOfecb[4],true);var box5=Window_GetElement(window,OxOfecb[5],true);var box6=Window_GetElement(window,OxOfecb[6],true);var box7=Window_GetElement(window,OxOfecb[7],true);var box8=Window_GetElement(window,OxOfecb[8],true);var box9=Window_GetElement(window,OxOfecb[9],true);var inp_start=Window_GetElement(window,OxOfecb[10],true);var CustomBullet=Window_GetElement(window,OxOfecb[11],true);OriginalnodeName=element[OxOfecb[12]];if(element[OxOfecb[12]]&&element[OxOfecb[12]]==OxOfecb[13]){OriginalnodeName=(element[OxOfecb[14]])[OxOfecb[12]];} ;var OriginalnodeName,CurrentnodeName,selectedObject;SyncToView=function SyncToView_LI(){if(element[OxOfecb[12]]==OxOfecb[13]){element=element[OxOfecb[14]];} ;switch((element[OxOfecb[25]][OxOfecb[24]]).toLowerCase()){case OxOfecb[15]:selectedObject=box1;break ;;case OxOfecb[16]:selectedObject=box2;break ;;case OxOfecb[17]:selectedObject=box3;break ;;case OxOfecb[18]:selectedObject=box4;break ;;case OxOfecb[19]:selectedObject=box5;break ;;case OxOfecb[20]:selectedObject=box6;break ;;case OxOfecb[21]:selectedObject=box7;break ;;case OxOfecb[22]:selectedObject=box8;break ;;case OxOfecb[23]:selectedObject=box9;break ;;default:selectedObject=box1;break ;;} ;selectedObject[OxOfecb[25]][OxOfecb[26]]=OxOfecb[27];if(element[OxOfecb[25]][OxOfecb[28]]==OxOfecb[29]){inp_src[OxOfecb[30]]=OxOfecb[29];CustomBullet[OxOfecb[25]][OxOfecb[31]]=OxOfecb[32];} else {var Ox119;Ox119=element[OxOfecb[25]][OxOfecb[28]];Ox119=Ox119.substring(4,Ox119[OxOfecb[33]]-1);inp_src[OxOfecb[30]]=Ox119;} ;} ;SyncTo=function SyncTo_LI(element){switch(selectedObject){case box1:;case box2:;case box3:;case box4:;case box5:;case box6:try{element.setAttribute(OxOfecb[34],inp_start.value);} catch(er){} ;break ;;case box7:;case box8:;case box9:break ;;} ;if(inp_src[OxOfecb[30]]){element[OxOfecb[25]][OxOfecb[28]]=OxOfecb[35]+inp_src[OxOfecb[30]]+OxOfecb[36];} ;} ;function ToggleCustomBullet(){if(CustomBullet[OxOfecb[25]][OxOfecb[31]]==OxOfecb[32]){CustomBullet[OxOfecb[25]][OxOfecb[31]]=OxOfecb[37];} else {CustomBullet[OxOfecb[25]][OxOfecb[31]]=OxOfecb[32];} ;} ;function doClick1(Ox366){if(element[OxOfecb[12]]==OxOfecb[13]){element=element[OxOfecb[14]];} ;selectedObject=Ox366;switch(selectedObject){case box1:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[15];break ;;case box2:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[16];break ;;case box3:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[17];break ;;case box4:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[18];break ;;case box5:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[19];break ;;case box6:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[20];break ;;case box7:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[21];break ;;case box8:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[22];break ;;case box9:element[OxOfecb[25]][OxOfecb[24]]=OxOfecb[23];break ;;} ;var Ox73=false;switch(selectedObject){case box1:;case box2:;case box3:;case box4:;case box5:;case box6:if(OriginalnodeName==OxOfecb[38]){OriginalnodeName=OxOfecb[39];Ox73=true;} ;break ;;case box7:;case box8:;case box9:if(OriginalnodeName==OxOfecb[39]){OriginalnodeName=OxOfecb[38];Ox73=true;} ;break ;;} ;if(Ox73){var Ox582=editwin[OxOfecb[40]].createElement(OriginalnodeName);while(element[OxOfecb[41]]){Ox582.appendChild(element.firstChild);} ;element[OxOfecb[14]].insertBefore(Ox582,element);element[OxOfecb[14]].removeChild(element);var arg=Window_FindDialogArguments(window);arg[OxOfecb[42]]=element=Ox582;} ;box1[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box2[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box3[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box4[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box5[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box6[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box7[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box8[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];box9[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];selectedObject[OxOfecb[25]][OxOfecb[26]]=OxOfecb[27];inp_src[OxOfecb[30]]=OxOfecb[29];SyncTo();} ;function doMouseOut(Ox366){if(Ox366==selectedObject){Ox366[OxOfecb[25]][OxOfecb[26]]=OxOfecb[27];} else {Ox366[OxOfecb[25]][OxOfecb[26]]=OxOfecb[43];} ;} ;function doMouseOver(Ox366){Ox366[OxOfecb[25]][OxOfecb[26]]=OxOfecb[44];} ;btnbrowse[OxOfecb[45]]=function btnbrowse_onclick(){function Ox354(Ox137){if(Ox137){inp_src[OxOfecb[30]]=Ox137;SyncTo(element);} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox354,inp_src.value,inp_src);} else {editor.ShowSelectImageDialog(Ox354,inp_src.value);} ;} ;