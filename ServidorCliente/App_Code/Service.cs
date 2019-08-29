using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service_Cliente : System.Web.Services.WebService
{
    // Instancia de la gestion de clientes utilizada para toda la sesion.
    public static GestionCliente _clientes = new GestionCliente();
    ESB.ServiceSoapClient esb = new ESB.ServiceSoapClient();

    public Service_Cliente()
    {
        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }



    [WebMethod]
    public int PeticionIni(string nombre) {
        return _clientes.ObtenerZonaUsuario(nombre);
    }

    [WebMethod]
    public String HolaMundo(string nombre)
    {
        return "Hola Mundo ";
    }
}