
package WS;

@javax.jws.WebService
public class ServicioCliente {
    // Instancia de la gestion de clientes utilizada para toda la sesion.
    public static GestionCliente _clientes = new GestionCliente();
    
    public int PeticionIni(String nombre) {
        return _clientes.ObtenerZonaUsuario(nombre);
    }
}
