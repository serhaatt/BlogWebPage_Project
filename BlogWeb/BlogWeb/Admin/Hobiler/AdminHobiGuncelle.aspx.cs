using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Hobiler_AdminHobiGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        TxtId.Text = id.ToString();
        TxtId.Enabled = false;
        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TblHobilerTableAdapter dt = new DataSetTableAdapters.TblHobilerTableAdapter();
            TxtHobi.Text = dt.HobiyiGetir(id)[0].Hobi;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblHobilerTableAdapter dt = new DataSetTableAdapters.TblHobilerTableAdapter();
        dt.HobiGuncelle(TxtHobi.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminHobiler.aspx");
    }
}