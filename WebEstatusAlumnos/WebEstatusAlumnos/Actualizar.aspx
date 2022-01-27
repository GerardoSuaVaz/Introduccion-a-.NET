<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizar.aspx.cs" Inherits="WebEstatusAlumnos.Actualizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <asp:Label ID="lblId" runat="server" Text="ID:"></asp:Label>
    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </div>
    <br>
    <div>
    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    </div>
    <br>
    <div>
    <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
    <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
    </div>
    <br>
    <div>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    </div>
</asp:Content>
