<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="WebEstatusAlumnos.Consultar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Label ID="lblId" runat="server" Text="ID: "></asp:Label>
    <asp:TextBox ID="txtId" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <br>
    <div>
    <asp:Label ID="lblNombre" runat="server" Text="Nombre: "></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <br>
     <div>
    <asp:Label ID="lblClave" runat="server" Text="Clave: "></asp:Label>
    <asp:TextBox ID="txtClave" runat="server" Enabled="False"></asp:TextBox>
    </div>
    <br>
    <div>
        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" />
    </div>
    
</asp:Content>
