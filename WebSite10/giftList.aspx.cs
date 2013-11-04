using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class giftList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        int id = 0;

        id = Convert.ToInt32(Request.QueryString["id"]);

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        
        connect.Open();

        SqlCommand cmd = new SqlCommand("select * from Gifts where event_id = " + id, connect);
        SqlDataReader r = cmd.ExecuteReader();

        string output = "";
        while (r.Read())
        {
            string temp_output = "<ul>";
            temp_output += "<div class='item-head'><h2>" + r["product_name"].ToString() + "</h2></div>";
            temp_output += "<div class='item-desc'>" + r["description"].ToString() + "</div>";
            if (r["status"].ToString() == "0")
            {
                temp_output += "<div class='item-but'><a data-role='button' data-theme='b' href='#'>Reserved for Wedding</a></div>";
            }
        }
    }
}