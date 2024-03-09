using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblHakkımdaTableAdapter dt = new DataSetTableAdapters.TblHakkımdaTableAdapter();
        Repeater1.DataSource = dt.HakkımdaListele();
        Repeater1.DataBind();

        DataSetTableAdapters.TblDeneyimTableAdapter dt2 = new DataSetTableAdapters.TblDeneyimTableAdapter();
        Repeater2.DataSource = dt2.DeneyimListele();
        Repeater2.DataBind();

        DataSetTableAdapters.TblEğitimTableAdapter dt3 = new DataSetTableAdapters.TblEğitimTableAdapter();
        Repeater3.DataSource = dt3.EğitimListele();
        Repeater3.DataBind();

        DataSetTableAdapters.TblHakkımdaTableAdapter dt4 = new DataSetTableAdapters.TblHakkımdaTableAdapter();
        Repeater4.DataSource = dt.HakkımdaListele();
        Repeater4.DataBind();

        DataSetTableAdapters.TblYeteneklerTableAdapter dt5 = new DataSetTableAdapters.TblYeteneklerTableAdapter();
        Repeater5.DataSource = dt5.YetenekListele();
        Repeater5.DataBind();

        DataSetTableAdapters.TblHobilerTableAdapter dt6 = new DataSetTableAdapters.TblHobilerTableAdapter();
        Repeater6.DataSource = dt6.ListeleHobiler();
        Repeater6.DataBind();

        DataSetTableAdapters.TblÖdülTableAdapter dt7 = new DataSetTableAdapters.TblÖdülTableAdapter();
        Repeater7.DataSource = dt7.ÖdülListele();
        Repeater7.DataBind();

    }
}