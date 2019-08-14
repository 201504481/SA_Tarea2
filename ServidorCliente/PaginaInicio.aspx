<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaginaInicio.aspx.cs" Inherits="PaginaInicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Nombre Usuario"></asp:Label>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    
        <br />
    
    </div>
        <asp:Label ID="Label2" runat="server" Text="Zona Actual"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtZona" runat="server"></asp:TextBox>
        <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnSolicitudViaje" runat="server" Text="Solicitar Viaje" OnClick="btnSolicitudViaje_Click"/>
        </p>
        <asp:Label ID="Respuesta" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
