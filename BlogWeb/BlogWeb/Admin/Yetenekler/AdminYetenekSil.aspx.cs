using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminYetenekSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);

        DataSetTableAdapters.TblYeteneklerTableAdapter dt = new DataSetTableAdapters.TblYeteneklerTableAdapter();
        dt.YetenekSil(id);
        Response.Redirect("AdminYetenekler.aspx");
    }
}