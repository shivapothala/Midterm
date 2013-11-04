using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registries : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        
        connect.Open();


        SqlCommand cmd = new SqlCommand("select * from Registries", connect);

        SqlDataReader r = cmd.ExecuteReader();

        string output = "<table><tr><th>Registry Name</th><th>Registry Type</th><th>Event Date</th><th>Event Time</th><th>Details</th><th>Send Invitations</th></tr>";

        while (r.Read())
        {
            output += "<tr>";
            output += "<td>" + r["event_name"] + "</td>";
            output += "<td>" + r["Event_type"] + "</td>";
            output += "<td>" + r["event_date"].ToString().Substring(0, r["event_date"].ToString().Length - 11) + "</td>";
            output += "<td>" + r["event_time"].ToString() + "</td>";

            output += "<td><a  data-role='button' data-inline='true' href='event-edit.aspx?id=" + r["id"] + "' >Edit </a>&nbsp;&nbsp;<a  data-role='button' data-inline='true'   href='addGift.aspx'> Add Gifts </a></td>";
            output += "<td><a  data-role='button' data-theme='b' data-inline='true' href='giftList.aspx?id=" + r["id"] + "'>Gift List</a><a  data-role='button' data-theme='b' data-inline='true' href='Invitations.aspx?id=" + r["id"] + "'>Send Invitations</a></td>";
            output += "</tr>";
        }

        output += "</table>";
        //innercontent.InnerHtml = output;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Server.Transfer("createRegistry.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("manageRegistry.aspx");
    }
}