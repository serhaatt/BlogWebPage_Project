using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Yetenekler_AdminYetenekGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        TxtId.Enabled = false;
        TxtId.Text = id.ToString();
        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TblYeteneklerTableAdapter dt = new DataSetTableAdapters.TblYeteneklerTableAdapter();
            TxtYetenek.Text = dt.YetenekGetir(id)[0].Yetenek;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblYeteneklerTableAdapter dt = new DataSetTableAdapters.TblYeteneklerTableAdapter();
        dt.YetenekGuncelle(TxtYetenek.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminYetenekler.aspx");
    }
}