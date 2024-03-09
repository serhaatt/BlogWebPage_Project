using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        TxtId.Enabled = false;
        TxtId.Text = id.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TblDeneyimTableAdapter dt = new DataSetTableAdapters.TblDeneyimTableAdapter();
            TxtBaslik.Text = dt.DeneyimGetir(id)[0].Başlık;
            TxtAltBaslik.Text = dt.DeneyimGetir(id)[0].AltBaşlık;
            TxtAciklama.Text = dt.DeneyimGetir(id)[0].Açıklama;
            TxtTarih.Text = dt.DeneyimGetir(id)[0].Tarih;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblDeneyimTableAdapter dt = new DataSetTableAdapters.TblDeneyimTableAdapter();
        dt.DeneyimGüncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminDeneyimler.aspx");
    }
}