<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreditResponse.aspx.cs" 
MaintainScrollPositionOnPostback="true" EnableEventValidsation="true" ValidateRequest="true" Inherits="CreditResponse" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>SCResponse</title>
    <script src="~/Scripts/jquery-1.4.1-vsdoc.js" type="text/javascript"></script>
    <script src="~/Scripts/jquery-1.4.1.js" type="text/javascript"></script>
    <script src="~/Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="~/js/JavaScripts.js"></script>
        <script type="text/javascript">
            function repurchaseInvoice(reqno, billno) {
                window.sessionStorage.setItem("reqno", reqno);
                window.sessionStorage.setItem("billno", billno);
                window.location.href = "sarso.html#/RpI";
            }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" CombineScripts="false">
        <Scripts>
            <asp:ScriptReference Path="~/scripts/webkit.js" />
        </Scripts>
    </asp:ToolkitScriptManager>
    <asp:Label ID="lbl_MID" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_TXNID" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_ORDERID" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_BANKTXNID" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_TXNAMOUNT" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_CURRENCY" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_STATUS" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_RESPCODE" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_RESPMSG" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_TXNDATE" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_GATEWAYNAME" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_BANKNAME" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_PAYMENTMODE" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_CHECKSUMHASH" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_EMAIL" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_MOBILE_NO" runat="server" Visible="false"></asp:Label>
    <asp:Label ID="lbl_CUST_ID" runat="server" Visible="false"></asp:Label>
    
    <div>
       <asp:Label runat="server" ID="lblerrormsg" ForeColor="Red"></asp:Label>
    </div>
    </div>
    </form>
</body>
</html>
