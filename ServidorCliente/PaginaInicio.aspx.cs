using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaInicio : System.Web.UI.Page
{
    // Instancia del bus de servidor 
    ESB.ServiceSoapClient esb = new ESB.ServiceSoapClient();
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
        // Conversion de la zona ingresada en el campo zona
        int zonacliente = Int32.Parse(txtZona.Text);
        // Ingreso o registro del usuario
        Service._clientes.IngresoRegistroCliente(txtNombre.Text, zonacliente);
        // Peticion al bus de servidor para la solicitud del viaje
        Respuesta.Text = esb.SolicitudViajeCliente(Service._clientes.ObtenerZonaUsuario());
    }
}