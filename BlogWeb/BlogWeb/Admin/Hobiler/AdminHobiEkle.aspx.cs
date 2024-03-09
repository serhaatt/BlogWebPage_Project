using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Hobiler_AdminHobiEkle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblHobilerTableAdapter dt = new DataSetTableAdapters.TblHobilerTableAdapter();
        dt.HobiEkle(TxtHobi.Text);
        Response.Redirect("AdminHobiler.aspx");
    }
}