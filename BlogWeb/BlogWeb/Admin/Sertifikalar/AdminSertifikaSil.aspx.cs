using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sertifikalar_AdminSertifikaSil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        DataSetTableAdapters.TblÖdülTableAdapter dt = new DataSetTableAdapters.TblÖdülTableAdapter();
        dt.OdulSil(id);
        Response.Redirect("AdminSertifikalar.aspx");
    }
}