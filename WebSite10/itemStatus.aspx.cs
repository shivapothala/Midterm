using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class itemStatus : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        connect.Open();

        SqlCommand cmd = new SqlCommand("update Products set status = 0 where id=" + id, connect);
        int result = cmd.ExecuteNonQuery();

        if (result != 0)
        {
            status.InnerHtml = "Done Sucessful update";
            Response.Redirect("Registries.aspx");
        }
        else
        {
            status.InnerHtml = "Failed";
        }
    }
}

    