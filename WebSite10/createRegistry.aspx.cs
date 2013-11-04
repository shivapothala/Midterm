using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class createRegistry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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
        

        string etime = event_time.Text;

        SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["constring"].ConnectionString);

        connect.Open();

        SqlCommand cmd = new SqlCommand("insert into Registries (Registry_Name,Registry_Type,Reg_First_Name,Reg_Last_Name,CoReg_First_Name,CoReg_Last_Name,Event_Date,Location,City,Event_time) values('" + rname + "','" + rtype + "','" + rfname + "','" + rlname + "','" + crfname + "','" + crlname + "','" + edate + "','" + location + "','" + city + "','" + etime + "') ", connect);

        int result = cmd.ExecuteNonQuery();

        if (result != 0)
        {
            status.InnerHtml = "Created Sucessfully";
        }
        else
        {
            status.InnerHtml = "Creating Registry Failed";
        }


    }
}