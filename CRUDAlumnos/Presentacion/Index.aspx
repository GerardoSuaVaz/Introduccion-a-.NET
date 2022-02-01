<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentacion.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado Alumnos</h2> 
    <br/>
    <dr>
 <asp:Button ID="btnAgregar" runat="server" Text="Agregar" class="btn btn-primary" OnClick="btnAgregar_Click" />
    <dr>
    <br />
    <asp:GridView ID="gvEstatus" runat="server" OnSelectedIndexChanged="gvEstatus_SelectedIndexChanged" AutoGenerateColumns="False" OnRowCommand="gvEstatus_RowCommand">
        <Columns>
            <asp:BoundField DataField="idAlumno" HeaderText="Id" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="pApellido" HeaderText="Primer Apellido" />
            <asp:BoundField DataField="sApellido" HeaderText="Segundo Apellido" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="telefono" HeaderText="Telefono" />
            <asp:BoundField DataField="estado" HeaderText="Estado" />
            <asp:BoundField DataField="estatus" HeaderText="Estatus" />
            <asp:ButtonField ButtonType="Button" Text="Detalles" CommandName="Detalles" ControlStyle-CssClass="btn btn-warning"/>
            <asp:ButtonField Text="Editar" CommandName="Editar" ControlStyle-CssClass="btn btn-success"/>
            <asp:ButtonField Text="Eliminar" CommandName="Eliminar" ControlStyle-CssClass="btn btn-danger"/>
        </Columns>
    </asp:GridView>
</asp:Content>

