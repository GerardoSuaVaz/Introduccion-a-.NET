<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="PresentacionP.Prueba" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="form-horizontal">
        <h2>Agregar Alumno</h2>
        <div class="form-group">
            <label for="txtNombre" class="control-label col-md-2">Nombre</label>
            <div>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            </div>
        </div>
    </div>
</asp:Content>
