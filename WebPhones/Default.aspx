<%@ Page Language="C#" AutoEventWireup="true" 
    CodeFile="Default.aspx.cs" 
    Inherits="PhonesInterace_Default" Debug="true"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
    
      function pageLoad() {
      }
    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <h1>OOP Phones</h1>
        
        <asp:DropDownList  ID="ddlListTypeOfPhone" runat="server" autopostback="true">
           <asp:ListItem runat="server" Name="TelePhone" Value="TelePhone"/>
           <asp:ListItem runat="server" Name="CellPhone" Value="CellPhone"/>
           <asp:ListItem runat="server" Name="PrePaidPhone" Value="PrePaidPhone"/>
           
           <asp:ListItem runat="server" Name="PayPhone" Value="PayPhone"/>
           <asp:ListItem runat="server" Name="Skype" Value="Skype"/>
        </asp:DropDownList>
        
        <asp:UpdatePanel ID="pnlDial" runat="server" Visible="false">
        <ContentTemplate>
        <asp:Label ID="lblDial" runat=server></asp:Label>
        <div>
            <div id="row1">
                <asp:button runat="server" ID="btnNum1" text="1" onCommand="NumButtonPressed" /> 
                <asp:button runat="server" ID="btnNum2" text="2" onCommand="NumButtonPressed"/> 
                <asp:button runat="server" ID="btnNum3" text="3" onCommand="NumButtonPressed"/> 
                <asp:button runat="server" ID="btnNum4" text="4" onCommand="NumButtonPressed"/> 
                <asp:button runat="server" ID="btnNum5" text="5" onCommand="NumButtonPressed"/> 
                <asp:button runat="server" ID="btnNum6" text="6" onCommand="NumButtonPressed"/> 
                <asp:button runat="server" ID="btnNum7" text="7" onCommand="NumButtonPressed"/>
                <asp:button runat="server" ID="btnNum8" text="8" onCommand="NumButtonPressed"/>
                <asp:button runat="server" ID="btnNum9" text="9" onCommand="NumButtonPressed"/>
                <asp:button runat="server" ID="btnNum0" text="0" onCommand="NumButtonPressed"/>
                <asp:button runat="server" ID="btnNumStar" text="*" onCommand="NumButtonPressed"/>
                <asp:button runat="server" ID="btnNumPound" text="#" onCommand="NumButtonPressed"/>
                 
                
            </div>
            <div>
                Number:<asp:Label id="lblNumToDial" runat="server" />
                <asp:Button id="btnDial" runat="server" text="Dial" onclick="btnDial_Click"/>
                <asp:Button ID="btnDialClear" runat="server" Text="Clear" 
                    onclick="btnDialClear_Click" style="width: 46px" />
                <asp:Button ID="btnDialbksp" runat="server" Text="<-" 
                    onclick="btnDialbksp_Click" />
            </div>
        </div>
        </ContentTemplate>
        </asp:UpdatePanel>
        
        
        <asp:UpdatePanel ID="pnlText" runat="server">
        <ContentTemplate>
        
             Text:
            <asp:TextBox ID="TextBoxTextToSend" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSendText"
                runat="server" Text="Send Text" onclick="ButtonSendText_Click"  />
            <asp:Label ID="lblTextStatus" runat="server" />
        </ContentTemplate>
        </asp:UpdatePanel>
        
        <asp:Panel id="pnlPay" runat="server" Visible="false">
            Pay:
            Amount To Pay<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Pay" />
        
        
        </asp:Panel>
        
           
        
    </div>
    </form>
</body>
</html>
