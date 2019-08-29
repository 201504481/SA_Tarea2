
package WS;

@javax.jws.WebService
public class ServicioPiloto {
    GestionPiloto _pilotosActuales = new GestionPiloto();
    
     /*
   * Metodo del servidor web que recibe la solicitud para obtener los conductores disponibles
   * Parametros: ninguno 
   * Realiza una llamada a la gestion de pilotos para obtener los disponibles
   */ 

    public String ObtenerConductoresDisponibles(String placa) {
        return _pilotosActuales.ObtenerInformacion(placa);
    } 
}
