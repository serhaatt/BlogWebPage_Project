using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblEğitimTableAdapter dt = new DataSetTableAdapters.TblEğitimTableAdapter();
        Repeater1.DataSource = dt.EğitimListele();
        Repeater1.DataBind();
    }
}