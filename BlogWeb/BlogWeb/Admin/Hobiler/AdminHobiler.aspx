<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminHobiler.aspx.cs" Inherits="Admin_Hobiler_AdminHobiler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <table class="table table-bordered">

            <tr>
                <th>ID</th>
                <th>Hobi</th>
                <th>İşlemler</th>
            </tr>
            <tbody>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>

                        <tr>
                            <th><%# Eval("Id") %></th>
                            <td><%# Eval("Hobi") %></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "AdminHobiSil.Aspx?Id=" + Eval("Id") %>' ID="HyperLink1" runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%# "AdminHobiGuncelle.Aspx?Id=" + Eval("Id") %>' ID="HyperLink2" runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>

        <asp:HyperLink NavigateUrl="/Admin/Hobiler/AdminHobiEkle.aspx" ID="HyperLink1" runat="server" CssClass="btn btn-info">Hobi Ekle</asp:HyperLink>
    </form>
</asp:Content>

