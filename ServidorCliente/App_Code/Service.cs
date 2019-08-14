using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service : System.Web.Services.WebService
{
    // Instancia de la gestion de clientes utilizada para toda la sesion.
    public static GestionCliente _clientes = new GestionCliente();

    public Service () {
        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    /*
    * Metodo del servidor web que recibe la solicitud el ingreso de un cliente
    * Parametros: *nombreUsuario --> cadena que contiene el nombre del usuario
    *             *zonaActual    --> entero que contiene la zona actual del usuario que intenta registrarse 
    */
    [WebMethod]
    public Boolean IngresoCliente(String nombreUsuario, int zonaActual)
    {
        return _clientes.IngresoRegistroCliente(nombreUsuario, zonaActual);
    }
    
}