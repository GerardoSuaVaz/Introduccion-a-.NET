<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="WebEstatusAlumnos.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
<div>
<asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
<asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
</div>
<br>
<div>
<asp:Label ID="lblClave" runat="server" Text="Clave"></asp:Label>
<asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
</div>
<br>
<div>
<asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
</div>
</asp:Content>

