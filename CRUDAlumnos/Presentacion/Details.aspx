<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <div class="form-horizontal">
	<h2>Datos del Alumno</h2>        	
	<dl class="dl-horizontal">
		<dt>
			ID
		</dt>
		<dd>
			<asp:Label ID="lblId" runat="server" Text="3"></asp:Label>
		</dd>
    </dl>
	<dl class="dl-horizontal">
		<dt>
			Nombre
		</dt>
		<dd>
			<asp:Label ID="lblNombre" runat="server" Text="Marcelo Isaia"></asp:Label>
		</dd>
	</dl>
	  <dl class="dl-horizontal">
		<dt>
			Primer Apellido
		</dt>
		<dd>
			<asp:Label ID="lblPApellido" runat="server" Text="Garcia"></asp:Label>
		</dd>
	</dl>
	<dl class="dl-horizontal">
		<dt>
			Segundo Apellido
		</dt>
		<dd>
			<asp:Label ID="lblSApellido" runat="server" Text="Miron"></asp:Label>
		</dd>
	</dl>
	  <dl class="dl-horizontal">
		<dt>
			Fecha de Nacimiento
		</dt>
		<dd>
			<asp:Label ID="lblFNacimiento" runat="server" Text="01/01/1995"></asp:Label>
		</dd>
	  </dl>
	    <dl class="dl-horizontal">
		<dt>
			CURP
		</dt>
		<dd>
			<asp:Label ID="lblCurp" runat="server" Text="CURP00000000000003"></asp:Label>
		</dd>
	</dl>
	  <dl class="dl-horizontal">
		<dt>
			Correo
		</dt>
		<dd>
			<asp:Label ID="lblCorreo" runat="server" Text="CURP00000000000003"></asp:Label>
		</dd>
	</dl>
	   <dl class="dl-horizontal">
		<dt>
			Telefono
		</dt>
		<dd>
			<asp:Label ID="lblTelefono" runat="server" Text="2711372600"></asp:Label>
		</dd>
	</dl>
	  <dl class="dl-horizontal">
		<dt>
			Estado
		</dt>
		<dd>
			<asp:Label ID="lblEstado" runat="server" Text="Veracruz"></asp:Label>
		</dd>
	</dl>
	  <dl class="dl-horizontal">
		<dt>
			Estatus
		</dt>
		<dd>
			<asp:Label ID="lblEstatus" runat="server" Text="Prospecto"></asp:Label>
		</dd>
	</dl>	
	<div class="form-group">
		<div class="col-md-2">
			<a href="Index.aspx">Regresar a la Lista</a>
		</div>
	</div>
	<div class="form-group">
		<div class="col-md-2">
			<asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="Button1_Click" CssClass="btn btn-default"/>
		</div>
	</div>	
</div>

</asp:Content>
