<%@ Page Title="" Language="C#" MasterPageFile="/Admin.master" AutoEventWireup="true" CodeFile="AdminYetenekler.aspx.cs" Inherits="AdminYetenekler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>Yetenek</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                        <tr>
                            <th><%# Eval("Id") %></th>
                            <td><%# Eval("Yetenek") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminYetenekSil.Aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminYetenekGuncelle.Aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="/Admin/Yetenekler/AdminYetenekEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
    </form>
</asp:Content>

