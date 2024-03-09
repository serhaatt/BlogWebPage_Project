<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminDeneyimler.aspx.cs" Inherits="AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>Başlık</th>
                <th>AltBaşlık</th>
                <th>Açıklama</th>
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
                            <td><%# Eval("Tarih") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimSil.Aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminDeneyimGuncelle.Aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Deneyim Ekle</asp:HyperLink>
    </form>

</asp:Content>

