using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Invitations : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ema = emails.Text;
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);


        string message1 = "Please select gifts from here <br>";

        message1 += "http://localhost:52234/giftList.aspx?id=" + id;
  

        var fromAddress = new MailAddress("pothalashiva@gmail.com", "From Name");
        var toAddress = new MailAddress(ema, "To Name");
        const string fromPassword = "eatasulike";
        const string subject = "You are invited to the event";
        string body = message1;

        var smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            Timeout = 20000
        };
        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })
        {
            smtp.Send(message);
        }


    }
}
    