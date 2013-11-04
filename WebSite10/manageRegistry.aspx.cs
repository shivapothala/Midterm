using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class managaRegistry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
            
            connect.Open();
            int id = 0;
            id = Convert.ToInt32(Request.QueryString["id"]);
            SqlCommand cmd = new SqlCommand("select * from Registries where id=" + id, connect);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Registry_name.Text = r["Registry_Name"].ToString();
                Registry_type.Text = r["Registry_Type"].ToString();
                Reg_first_name.Text = r["Reg_First_Name"].ToString();
                Reg_last_name.Text = r["Reg_Last_Name"].ToString();
                Co_Reg_fname.Text = r["CoReg_First_Name"].ToString();
                Co_Reg_lname.Text = r["CoReg_Last_Name"].ToString();
                datepicker.Value = r["Event_Date"].ToString().Substring(0, r["Event_Date"].ToString().Length-11);
                location.Text = r["Location"].ToString();
                city.Text = r["City"].ToString();
                event_time.Text = r["Event_Time"].ToString();
                   
                    
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string rname = Registry_name.Text;
        string rtype = Registry_type.Text;
        string rfname = Reg_first_name.Text;
        string rlname = Reg_last_name.Text;
        string crfname = Co_Reg_fname.Text;
        string crlname = Co_Reg_lname.Text;
        string edate = datepicker.Value;
        string locations = location.Text;
        string citys = city.Text;

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);
        
        connect.Open();

        int id = 0;
        id = Convert.ToInt32(Request.QueryString["id"]);
        SqlCommand cmd = new SqlCommand("update Events set Registry_Name='" + rname + "',Registry_Type='" + rtype + "',Reg_First_Name='" + rfname + "',Reg_Last_Name='" + rlname + "',CoReg_First_Name='" + crfname + "',CoReg_Last_Name='" + crlname + "',Event_Date='" + edate + "' where id=" + id, connect);
        int result = cmd.ExecuteNonQuery();

        if (result != 0)
        {
            status.InnerHtml = "Edited Sucessfully";
        }
        else
        {
            status.InnerHtml = "Edit Failed";
        }

    }
}
    }
}