using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sertifikalar_AdminSertifikaGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        TxtId.Text = id.ToString();
        TxtId.Enabled = false;

        if(Page.IsPostBack==false)
        {
            DataSetTableAdapters.TblÖdülTableAdapter dt = new DataSetTableAdapters.TblÖdülTableAdapter();
            TxtSertifika.Text=dt.OduluGetir(id)[0].Ödül;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblÖdülTableAdapter dt = new DataSetTableAdapters.TblÖdülTableAdapter();
        dt.OdulGuncelle(TxtSertifika.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminSertifikalar.aspx");
    }
}