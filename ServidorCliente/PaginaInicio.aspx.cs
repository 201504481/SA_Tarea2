using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaInicio : System.Web.UI.Page
{

    // Instancia de la gestion de clientes utilizada para toda la sesion.
    GestionCliente _clientes = new GestionCliente();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /*
    * Metodo para la solicitud del viaje
    * Parametros: eventos del boton 
    * Realiza la peticion al bus de servidor para la solicitud del viaje
    */
    protected void btnSolicitudViaje_Click(object sender, EventArgs e)
    {
        ESB.ServiceSoapClient esb = new ESB.ServiceSoapClient();
        // Conversion de la zona ingresada en el campo zona
        int zonacliente = Int32.Parse(txtZona.Text);
        // Ingreso o registro del usuario
        _clientes.IngresoRegistroCliente(txtNombre.Text, zonacliente);
        // Peticion al bus de servidor para la solicitud del viaje
        Respuesta.Text = esb.SolicitudViajeCliente(_clientes.ObtenerZonaUsuario());
    }
}