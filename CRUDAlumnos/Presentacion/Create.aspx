<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="form-horizontal">
    <h2>Agregar Alumno</h2>
<div class="form-group">
        <label for="txtNombre" class="control-label col-md-2">Nombre</label>       
        <div>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtNombre" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
  
        <label for="txtPApellido" class="control-label col-md-2">Primer Apellido</label>
        <div>
            <asp:TextBox ID="txtPApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtPApellido" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo Obligatorio" ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>

   
        <label for="txtSApellido" class="control-label col-md-2">Segundo Apellido</label>
        <div>
            <asp:TextBox ID="txtSApellido" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
        </div>

  
        <label for="txtFNacimiento" class="control-label col-md-2">Fecha de Nacimiento</label>
        <div>
            <asp:TextBox ID="txtFNacimiento" runat="server" CssClass="form-control text-box single-line" type ="Date"></asp:TextBox>
            <asp:RangeValidator ControlToValidate="txtFNacimiento" MaximumValue="2000/12/31" MinimumValue="1990/01/01" ID="RangeValidator1" runat="server" ErrorMessage="Fuera de Rango" Font-Bold="True" ForeColor="Red"></asp:RangeValidator>
            <asp:RequiredFieldValidator ControlToValidate="txtFNacimiento" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo Obligatorio" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
       </div>
    
   
       <label for="txtCurp" class="control-label col-md-2">CURP</label>
        <div>
            <asp:TextBox ID="txtCurp" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RegularExpressionValidator   ID="RegularExpressionValidator1" runat="server" ErrorMessage="Formato no valido" ForeColor="Red" Font-Bold="True" ValidationExpression="^[A-Z]{1}[AEIOU]{1}[A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM]{1}(AS|BC|BS|CC|CS|CH|CL|CM|DF|DG|GT|GR|HG|JC|MC|MN|MS|NT|NL|OC|PL|QT|QR|SP|SL|SR|TC|TS|TL|VZ|YN|ZS|NE)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z]{1}[0-9]{1}$" ControlToValidate="txtCurp"></asp:RegularExpressionValidator>
        </div>
  
    
        <label for="txtCorreo" class="control-label col-md-2">Correo</label>
        <div>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtCorreo" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo Obligatorio"  ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
       
        <label for="txtTelefono" class="control-label col-md-2">Telefono</label>
        <div>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control text-box single-line"></asp:TextBox>
            <asp:RequiredFieldValidator ControlToValidate="txtTelefono" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo Obligatorio"  ForeColor="Red" Font-Bold="True"></asp:RequiredFieldValidator>
        </div>
  
  
     <div class="form-group">
        <label for="lblEstado" class="control-label col-md-2">Estado</label>
        <div>
            <asp:DropDownList ID="ddlEstado" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="form-group">
        <label for="lblEstatus" class="control-label col-md-2">Estatus</label>
        <div>
            <asp:DropDownList ID="ddlEstatus" runat="server"></asp:DropDownList>
        </div> 
   </div>
</div>
   
    <div class="form-group">
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"/>
    </div>
    <div class="form-group">
        <div>
            <a href="Index.aspx">Regresar a la Lista</a>
        </div>
    </div> 
    <script type="text/javascript">
        function validarFechas(sender, arguments) {
            var tbFN = document.getElementById('<%=txtFNacimiento.ClientID %>').value;
            //1997-07-15
            var tbCurp = document.getElementById('<%=txtCurp.ClientID %>').value;
            var fCurp = tbCurp.substr(4, 6);
            var day = fCurp.substr(4, 2);
            var month = fCurp.substr(2, 2);
            var year = fCurp.substr(0, 2);
            var fech = year + "-" + month + "-" + day;
            tbFN = tbFN.split('-');
            var year1 = tbFN[0];
            var month1 = tbFN[1];
            var day1 = parseInt(tbFN[2]) + 1;
            var fech2 = year1 + "-" + month1 + "-" + day1;
            var FechNaci = new Date(fech2);
            fCurp = new Date(fech);
            var verdadera=3;
            var falsa=5;
            //FechNaci = moment(FechNaci).format('YYYY-MM-DD');
            //fCurp = moment(fCurp).format('YYYY-MM-DD');
            //970715
            //tbFN.toISOString();
            //fCurp.toISOString();

            if (FechNaci == fCurp) {
                //arguments.IsValid = true;
                verdadero = 6;
            } else {
                //arguments.IsValid = false;
                falsa = 4;
            }
        }
    </script>
</div>

</asp:Content>
