using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    SqlConnection dt = new SqlConnection(@"Data Source=SERHATG\SERHAT;Initial Catalog=BlogWebDb;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        dt.Open();
        SqlCommand kmt = new SqlCommand("Select* from TblAdmin where Kullanıcı=@P1 and Şifre=@P2", dt);
        kmt.Parameters.AddWithValue("@P1", TextBox1.Text);
        kmt.Parameters.AddWithValue("@P2", TextBox2.Text);
        SqlDataReader dr = kmt.ExecuteReader();
        if(dr.Read())
        {
            Response.Redirect("/Admin/Hakkımda/Hakkımda.aspx");
        }
        else
        {
            Response.Write("Hatalı Kullanıcı Adı veya Şifre");
        }
    }
}