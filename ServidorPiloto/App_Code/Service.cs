using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://ServicioPiloto.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]

public class Service_Piloto : System.Web.Services.WebService
{
    GestionPiloto _pilotosActuales = new GestionPiloto();

    public Service_Piloto()
    {
        
    }
    /*
   * Metodo del servidor web que recibe la solicitud para obtener los conductores disponibles
   * Parametros: ninguno 
   * Realiza una llamada a la gestion de pilotos para obtener los disponibles
   */ 
    [WebMethod]
    public string ObtenerConductoresDisponibles(string placa) {
        return _pilotosActuales.ObtenerInformacion(placa);
    }

    /*
   * Metodo del servidor web que recibe la solicitud de cambiar el estado de un piloto
   * Parametros: *codigoPiloto --> tipo entero que contiene el codigo del piloto a cambiar el estado
   * Realiza una llamada a la gestion de pilotos para cambiar el estado del piloto
   */
    [WebMethod]
    public void OcuparPiloto(int codigoPiloto)
    {
        _pilotosActuales.OcuparPiloto(codigoPiloto);
    }
}