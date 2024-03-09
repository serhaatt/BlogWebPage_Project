using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);

        DataSetTableAdapters.TblEğitimTableAdapter dt = new DataSetTableAdapters.TblEğitimTableAdapter();
        dt.EgitimSil(id);
        Response.Redirect("AdminEgitimler.aspx");
    }
}