using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addGift : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    if (!IsPostBack)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
           
            connect.Open();

            SqlCommand cmd = new SqlCommand("select * from Registries", connect);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Registries.Items.Add(new ListItem(r["Registry_Name"].ToString(), r[0].ToString()));

            }
            
            r.Close();
            connect.Close();
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string Iname = Item_name.Text;
        string Icolor = Item_color.Text;
        string Iurl = Item_URL.Text;
        string desc = description.Text;
        string Istatus = Item_status.Text;
        string eid = Registries.SelectedValue;

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        
        connect.Open();

        SqlCommand cmd = new SqlCommand("insert into Gifts (Item_Name,Item_Color,Location_URL,Description,Item_Status,Event_Id) values('" + Iname + "','" + Icolor + "','" + Iurl + "','" + desc + "',1," + eid + ")", connect);
        int result = cmd.ExecuteNonQuery();

        if (result != 0)
        {
            status.InnerHtml = "Insert operation Sucess";
        }
        else
        {
            status.InnerHtml = "Insert Failed";
        }


    }
    protected void Registries_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
    