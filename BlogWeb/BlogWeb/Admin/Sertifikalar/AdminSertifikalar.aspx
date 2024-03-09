<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSertifikalar.aspx.cs" Inherits="Admin_Sertifikalar_AdminSertifikalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>Sertifika</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                        <tr>
                            <th><%# Eval("Id") %></th>
                            <td><%# Eval("Ödül") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminSertifikaSil.Aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminSertifikaGuncelle.Aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="/Admin/Sertifikalar/AdminSertifikaEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Sertifika Ekle</asp:HyperLink>
    </form>
</asp:Content>

