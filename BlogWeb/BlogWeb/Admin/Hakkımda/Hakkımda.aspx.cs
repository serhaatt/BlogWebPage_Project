using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Hakkımda : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)//sayfayı baştan yüklerken ilk yüklenen andaki verileri tekrar çekmesini engeller, güncel verileri çeker ve database i günceller
        {

            DataSetTableAdapters.TblHakkımdaTableAdapter dt = new DataSetTableAdapters.TblHakkımdaTableAdapter();
            TextBox1.Text = dt.HakkımdaListele()[0].Ad;
            TextBox2.Text = dt.HakkımdaListele()[0].Soyad;
            TextBox3.Text = dt.HakkımdaListele()[0].Adress;
            TextBox4.Text = dt.HakkımdaListele()[0].Email;
            TextBox5.Text = dt.HakkımdaListele()[0].Telefon;
            TextBox6.Text = dt.HakkımdaListele()[0].KısaNot;
            TextBox7.Text = dt.HakkımdaListele()[0].Fotograf;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataSetTableAdapters.TblHakkımdaTableAdapter dt1 = new DataSetTableAdapters.TblHakkımdaTableAdapter();
        dt1.HakkımdaGüncelle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("Default.aspx");
    }
}