function waitCursor() 
{
    document.forms[0].style.cursor = 'wait';
}

function defaultCursor() 
{
    document.forms[0].style.cursor = 'default';
}

function performPostback(cntl) 
{
//            alert('cntl = ' + cntl.id);
    __doPostBack(cntl.id, cntl.name);
}

function cancelClick() 
{
    //do nothing
}

function openRedirector(pageName,parm1) 
{
    //waitCursor();
    window.location.href = "AutoRedirector.aspx?pageName=" + pageName + "&Parm1=" + parm1;
}

function checkInactivating(cntl,entityType) 
{
    if (cntl.value.toUpperCase() == "FALSE")
    {
        var answer;
        answer = confirm("Are you sure that you want to Inactivate this " + entityType + "?");
        if (answer == false)
        {
            cntl.value = "True";
        }
        
    }
}

function checkPriceStartDate(cntl) 
{
    var strStartDate = cntl.value;
    var dtStartDate = new Date(strStartDate);
    var dtTodayWithTime = new Date();
    var dtToday = new Date(dtTodayWithTime.getFullYear(),dtTodayWithTime.getMonth(),dtTodayWithTime.getDate());

    if (dtStartDate < dtToday)
    {
        alert('The Start Date cannot be in the past.');
        cntl.value = dtToday.format("MM/dd/yyyy");
    }

    
}

function hideLargeViewers(elementId) 
{
    //document.getElementById(elementId).style.visibility = 'hidden';
}

function openAddAssetAttachment(tagNumber) 
{
    var answer = window.showModalDialog("AssetAddAttachment.aspx?TagNumber=" + tagNumber,"","dialogWidth=600px;dialogHeight=200px;center:yes;status=no;resizable=yes");
    if (answer == undefined)
    {
        //user closed without choosing
    }
    else
    {
        if (answer.buttonPressed == 'Cancel')
        {
            //user canceled edit
        }
        else
        {
            if (answer.fileToUpload.length == 0)
            {
                //there was no file to upload
            }
            else
            {
                //a file was uploaded, the gridview will be refreshed in server side code
            }
        }
    }
}

function returnUploadFile(btnName,fileUploadCntlID) 
{
    var fileUploadCntl = document.getElementById(fileUploadCntlID);
    var o = new Object();
    o.buttonPressed = btnName;
    o.fileToUpload = fileUploadCntl.value;
    window.returnValue = o;
    //the window cannot always be closed here.  there is something funky when using the fileupload control; it doesn't react the same as other controls.
    //if the window is closed here, server side events don't get fired, OR when using a handler (ashx), there are no files in the context.Request.Files collection.
    //so to skirt around this little snafu, after the file is uploaded and saved to the DB, a line of simple script is written out that will confirm success
    //and close the window.
    if (btnName == 'Cancel')
    {
      window.close();
    }
}

function openAssetAttachment(itemID) 
{
    window.open("AssetDisplayAttachment.aspx?ItemID=" + itemID,null,"height=700,width=800,status=no,resizable=yes,toolbar=no,menubar=no,location=no");
}

function showFullPhoto(ctrl)
{
    ctrl.style.height = '160px';
    ctrl.style.width = '120px';
}

function showSmallPhoto(ctrl)
{
    ctrl.style.height = '32px';
    ctrl.style.width = '32px';
}

function setAllCheckBoxes(CheckValue)
{
    //alert('here');
	var objInputs = document.getElementsByTagName("input");
	
	if(!objInputs)
    {
		return;
    }
	
	var countInputs = objInputs.length;
	for(var i = 0; i < countInputs; i++)
	{
	    var inputId = objInputs[i].id;
	    if (inputId.indexOf("cbxSelect") != -1)
	    {
	        objInputs[i].checked = CheckValue.checked;
	    }
	}
}

function hideConfirmMessage(ctrlID,btnctrlID,lblSendingctrlID,imgctrlID)
{
    var lblConfirmCntl = document.getElementById(ctrlID);
    var btnUpdateCntl = document.getElementById(btnctrlID);
    var btnSendingMsgCntl = document.getElementById(lblSendingctrlID);
    var btnImageCntl = document.getElementById(imgctrlID);
    lblConfirmCntl.style.display = "none";
    
    btnSendingMsgCntl.style.display = "inline";
    btnImageCntl.style.display = "inline";

    setTimeout('document.images["' + imgctrlID + '"].src = "images/progress_bar.gif"', 200); 
    
    btnUpdateCntl.click();
}




