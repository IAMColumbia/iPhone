using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConsoleApplicationPhoneNoInterface;

public partial class PhonesInterace_Default : System.Web.UI.Page
{
    TelePhone t;        //Page has a Telephone object on it
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        switch (ddlListTypeOfPhone.SelectedValue)
        {
            case "TelePhone" :
                t = new TelePhone();
                break;
            case "CellPhone":
                t = new CellPhone();
                break;
            case "PrePaidPhone":
                t = new PrePaidPhone();
                break;
            case "PayPhone" :
                t = new PayPhone();
                break;
             case "Skype" :
                t = new Skype();
                break;
        }

        //Interface Disable
        if (t is IDialable)
        {
            pnlDial.Visible = true;
        }
        else
        {
            pnlDial.Visible = false;
        }

        //Interfae Textable
        if (t is ITxtAble)
        {
            pnlText.Visible = true;
        }
        else
        {
            pnlText.Visible = false;
        }

        //Interface Payable
        if (t is IPrePayable)
        {
            pnlPay.Visible = true;
        }
        else
        {
            pnlPay.Visible = false;
        }
    }

    protected void NumButtonPressed(object sender, CommandEventArgs e)
    {
        Button b = (Button)sender;
        if (lblNumToDial.Text.Length < 11)
        {

            lblNumToDial.Text += (b.Text);
        }
    }
    protected void btnDial_Click(object sender, EventArgs e)
    {

        if (t is IDialable)
        {
            PhoneNumber pn = new PhoneNumber(lblNumToDial.Text);
            lblDial.Text = pn.PhoneNum;
        }
    }
    protected void btnDialClear_Click(object sender, EventArgs e)
    {
        lblNumToDial.Text = "";
    }
    protected void btnDialbksp_Click(object sender, EventArgs e)
    {
        if (lblNumToDial.Text.Length > 0)
        {
            string newText = lblNumToDial.Text.Substring(0, lblNumToDial.Text.Length - 1);
            lblNumToDial.Text = newText;
        }
        
    }

    protected void ButtonSendText_Click(object sender, EventArgs e)
    {
        if(t is ITxtAble)
        {
            lblTextStatus.Text = TextBoxTextToSend.Text + " sent !!!";
        }
    }
}
