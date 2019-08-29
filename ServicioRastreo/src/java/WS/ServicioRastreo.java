
package WS;

@javax.jws.WebService
public class ServicioRastreo {
    
    GestionRastreo _gestionRastreo = new GestionRastreo();

    public String ObtenerPropuestaPiloto(int zona) 
    {
        _gestionRastreo.ObtencionPilotosDisponibles();
        return _gestionRastreo.ObtenerInformacion(zona);
    }
}
