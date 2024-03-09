<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminEgitimler.aspx.cs" Inherits="AdminEgitimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>Başlık</th>
                <th>AltBaşlık</th>
                <th>Açıklama</th>
                <th>Genel Not Ortalaması</th>
                <th>Tarih</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                        <tr>
                            <th><%# Eval("Id") %></th>
                            <td><%# Eval("Başlık") %></td>
                            <td><%# Eval("AltBaşlık") %></td>
                            <td><%# Eval("Açıklama") %></td>
                            <td><%# Eval("GNot") %></td>
                            <td><%# Eval("Tarih") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimSil.Aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminEgitimGuncelle.Aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminEgitimEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Eğitim Ekle</asp:HyperLink>
    </form>
</asp:Content>

