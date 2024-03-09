<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminHobiEkle.aspx.cs" Inherits="Admin_Hobiler_AdminHobiEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="Hobi"></asp:Label>
                <asp:TextBox ID="TxtHobi" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" Text="Ekle" CssClass="btn btn-primary" OnClick="Button1_Click" />
            </div>
        </div>
    </form>
</asp:Content>

