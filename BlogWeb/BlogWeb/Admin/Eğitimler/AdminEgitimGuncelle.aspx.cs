using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminEgitimGuncelle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        short id = Convert.ToInt16(Request.QueryString["Id"]);
        TxtId.Enabled = false;
        TxtId.Text = id.ToString();

        if (Page.IsPostBack == false)
        {
            DataSetTableAdapters.TblEğitimTableAdapter dt = new DataSetTableAdapters.TblEğitimTableAdapter();
            TxtBaslik.Text = dt.EgitimiGetir(id)[0].Başlık;
            TxtAltBaslik.Text = dt.EgitimiGetir(id)[0].AltBaşlık;
            TxtAciklama.Text = dt.EgitimiGetir(id)[0].Açıklama;
            TxtGnot.Text = dt.EgitimiGetir(id)[0].GNot;
            TxtTarih.Text = dt.EgitimiGetir(id)[0].Tarih;
        }
    }

    protected void BtnGuncelle_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblEğitimTableAdapter dt = new DataSetTableAdapters.TblEğitimTableAdapter();
        dt.EgitimGuncelle(TxtBaslik.Text, TxtAltBaslik.Text, TxtAciklama.Text,TxtGnot.Text, TxtTarih.Text,Convert.ToInt16(TxtId.Text));
        Response.Redirect("AdminEgitimler.aspx");
    }
}