<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <div class="form-horizontal">
    <h2>Agregar Alumno</h2>
      <div class="form-group">
        <label for="txtId" class="control-label col-md-2">ID</label>
        <div>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control text-box single-line" Enabled="False"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="txtNombre" class="control-label col-md-2">Nombre</label>
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtNombre" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="txtPApellido" class="control-label col-md-2">Primer Apellido</label>
        <div>
            <asp:TextBox ID="txtPApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtPApellido" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
    </div>
     <div class="form-group">
        <label for="txtSApellido" class="control-label col-md-2">Segundo Apellido</label>
        <div>
            <asp:TextBox ID="txtSApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>
    </div>
    <div class="form-group">
        <label for="txtFNacimiento" class="control-label col-md-2">Fecha de Nacimiento</label>
        <div>
            <asp:TextBox ID="txtFNacimiento" runat="server" CssClass="form-control text-box single-line" type ="Date"></asp:TextBox>
            <asp:RangeValidator ControlToValidate="txtFNacimiento" MaximumValue="2000/12/31" MinimumValue="1990/01/01" ID="RangeValidator1" runat="server" ErrorMessage="Fuera de Rango" Font-Bold="True" ForeColor="Red"></asp:RangeValidator>
            <asp:RequiredFieldValidator ControlToValidate="txtFNacimiento" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
       </div>
    </div>
    <div class="form-group">
    <label for="txtCurp" class="control-label col-md-2">CURP</label>
        <div>
            <asp:TextBox ID="txtCurp" runat="server" CssClass="form-control text-box single-line" ></asp:TextBox>
            <asp:RegularExpressionValidator   ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato no valido" ForeColor="Red" Font-Bold="True" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$" ControlToValidate="txtCurp"></asp:RegularExpressionValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="txtCorreo" class="control-label col-md-2">Correo</label>
        <div>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtCorreo" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="txtTelefono" class="control-label col-md-2">Telefono</label>
        <div>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
           <asp:RequiredFieldValidator ControlToValidate="txtTelefono" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="form-group">
        <label for="txtEstado" class="control-label col-md-2">Estado</label>
        <div>
            <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="txtEstatus" class="control-label col-md-2">Estatus</label>
        <div>
            <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" />
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la Lista</a>
        </div>
    </div>   
   </div>
<%--</div>--%>
</asp:Content>
