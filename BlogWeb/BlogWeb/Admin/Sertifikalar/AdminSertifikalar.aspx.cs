using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sertifikalar_AdminSertifikalar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblÖdülTableAdapter dt = new DataSetTableAdapters.TblÖdülTableAdapter();
        Repeater1.DataSource = dt.ÖdülListele();
        Repeater1.DataBind();
    }
}