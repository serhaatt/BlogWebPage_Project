using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Hobiler_AdminHobiSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);

        DataSetTableAdapters.TblHobilerTableAdapter dt = new DataSetTableAdapters.TblHobilerTableAdapter();
        dt.HobiSil(id);
        Response.Redirect("AdminHobiler.aspx");
    }
}