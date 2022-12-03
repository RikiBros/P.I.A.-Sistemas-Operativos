<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registros.aspx.cs" Inherits="P.I.A.Sistemas_Operativos.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>REGISTRO DE USUARIOS</h1>
     <br />
    <asp:Label ID="lbl_nombre" runat="server" Text="Nombre:" CssClass="badge" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="txt_nombre" runat="server" CssClass="form-control"></asp:TextBox>
    <br />
    <asp:Label ID="lbl_pass" runat="server" Text="Contraseña:" CssClass="badge" Font-Bold="True"></asp:Label>
    <asp:TextBox ID="txt_pass" runat="server" CssClass="form-control" TextMode="Password" OnTextChanged="txt_pass_TextChanged"></asp:TextBox>
    <br />
    <asp:Button ID="btn_reg" runat="server" Text="¡Registrar!" CssClass="btn btn-success" OnClick="btn_reg_Click"/>
    <asp:Label ID="lbl_message" runat="server" CssClass="badge" Font-Bold="True"></asp:Label>
    </asp:Content>

