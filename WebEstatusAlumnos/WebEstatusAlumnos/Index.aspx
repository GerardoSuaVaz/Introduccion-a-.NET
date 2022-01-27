<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebEstatusAlumnos.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h1>Estatus</h1>
        <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>

    </div>
    <br>
    <div>
        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" href="Agregar.aspx"/>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
        <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" />
        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
    </div>
    <br>
    <div>
        <asp:Label ID="lblNombre" runat="server" Text="Nombre" Visible="False"></asp:Label>
        <asp:TextBox ID="txtNombre" runat="server" Visible="False"></asp:TextBox>
    </div>
    <br>
    <div>
        <asp:Label ID="lblClave" runat="server" Text="Clave" Visible="False"></asp:Label>
        <asp:TextBox ID="txtClave" runat="server" Visible="False"></asp:TextBox>
    </div>
    <br>
    <div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Visible="False"/>
        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Visible="False" />
   </div>
</asp:Content>


