<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreditResponse.aspx.cs" Inherits="CreditResponse.CreditResponse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
     <title>SCResponse</title>
    <script type="text/javascript" src="assets/js/jquery-1.11.1.min.js"></script>    
        <script type="text/javascript">
            function repurchaseInvoice(reqno, billno) {              
                window.sessionStorage.setItem("reqno", reqno);
                window.sessionStorage.setItem("billno", billno);
                window.location.href = "/Shop/RepurchaseInvoice";
            }
    </script>
</head>

<body>
    <form id="form1" runat="server">
    <div>
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
       <asp:Label runat="server" ID="lblerrormsg" ForeColor="Red" Font-Size="X-Large"></asp:Label>
    </div>
    
    </div>
    </form>
</body>
</html>