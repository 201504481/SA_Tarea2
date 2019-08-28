using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class Service : System.Web.Services.WebService
{
    // Instancia de variables globales, guion bajo al principio como estandard de codigo

    // Instancia de servidor de rastreo
    ServidorRastreo.Service_RastreoSoapClient _rastreo = new ServidorRastreo.Service_RastreoSoapClient();
    // Instancia de servidor de pilotos
    ServidorPiloto.Service_PilotoSoapClient _pilotos = new ServidorPiloto.Service_PilotoSoapClient();
    // Instancia de servidor de clientes
    ServidorCliente.Service_ClienteSoapClient _clientes = new ServidorCliente.Service_ClienteSoapClient();

    /*
    * Metodo del servidor web que recibe la solicitud de viaje de un cliente
    * Parametros: *zona --> tipo entero que cotiene la zona actual del cliente 
    * Realiza una llamada al servidor de rastreos para obtener la propuesta del piloto mas cercano
    */ 
    [WebMethod]
    public String SolicitudViajeCliente(int zona)
    {
        return _rastreo.ObtenerPropuestaPiloto(zona);
    }

    /*
    * Metodo del servidor web que recibe la solicitud de pilotos disponibles 
    * Parametros: ninguno 
    * Realiza una llamada al servidor de pilotos para obtener la lista de conductores disponibles
    */ 
    [WebMethod]
    public string SolicitudPilotosDisponibles()
    {
        
        return _pilotos.ObtenerConductoresDisponibles();
    }

    /*
    * Metodo del servidor web que recibe la solicitud de modificar el estado de un piloto a ocupado
    * Parametros: *codigoPiloto --> entero que contiene el codigo unico del piloto a cambiar el estado 
    * Realiza una llamada al servidor de pilotos para modificar el estado del piloto
    */ 
    [WebMethod]
    public void OcuparPiloto(int codigoPiloto) 
    {
        _pilotos.OcuparPiloto(codigoPiloto);
    }

    /*
    * Metodo del servidor web que recibe la solicitud el ingreso de un cliente
    * Parametros: *nombreUsuario --> cadena que contiene el nombre del usuario
    *             *zonaActual    --> entero que contiene la zona actual del usuario que intenta registrarse 
    */
    [WebMethod]
    public Boolean IngresoCliente(String nombreUsuario, int zonaActual)
    {
        return true
    }
}