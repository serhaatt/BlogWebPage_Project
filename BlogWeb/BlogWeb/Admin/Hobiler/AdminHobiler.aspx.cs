using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Hobiler_AdminHobiler : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblHobilerTableAdapter dt = new DataSetTableAdapters.TblHobilerTableAdapter();
        Repeater1.DataSource = dt.ListeleHobiler();
        Repeater1.DataBind();
    }
}