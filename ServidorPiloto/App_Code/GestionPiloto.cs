using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestionPiloto
/// </summary>
public class GestionPiloto
{
    // Declaracion de variables globales

    // Declaracion de lista con todos los pilotos disponibles
    private LinkedList<EntidadPiloto> _listaPilotos;

    /*
    * Constructor para la gestion de pilotos
    * Parametros: ninguno
    * nstancia la lista de pilotos y para motivos de la simulacion se insertan 8 pilotos
    */
    public GestionPiloto() {
        _listaPilotos = new LinkedList<EntidadPiloto>();
        AgregarPiloto(new EntidadPiloto(111, EntidadPiloto.Tipo_Estado.DISPONIBLE, 1));
        AgregarPiloto(new EntidadPiloto(222, EntidadPiloto.Tipo_Estado.DISPONIBLE, 2));
        AgregarPiloto(new EntidadPiloto(333, EntidadPiloto.Tipo_Estado.DISPONIBLE, 3));
        AgregarPiloto(new EntidadPiloto(444, EntidadPiloto.Tipo_Estado.DISPONIBLE, 4));
        AgregarPiloto(new EntidadPiloto(555, EntidadPiloto.Tipo_Estado.DISPONIBLE, 5));
        AgregarPiloto(new EntidadPiloto(666, EntidadPiloto.Tipo_Estado.DISPONIBLE, 6));
        AgregarPiloto(new EntidadPiloto(777, EntidadPiloto.Tipo_Estado.DISPONIBLE, 7));
        AgregarPiloto(new EntidadPiloto(888, EntidadPiloto.Tipo_Estado.DISPONIBLE, 8));
    }

    /*
    * Metodo para agregar nuevos pilotos 
    * Parametros: *EntidadPiloto, nodo que contiene todos los datos del piloto
    * agrega el piloto mandado a la lista de pilotos
    */
    public void AgregarPiloto(EntidadPiloto piloto) {
        _listaPilotos.AddLast(piloto);
    }

    /*
    * Metodo para la obtencion de pilotod disponibles
    * Parametros: ninguno
    * Recorre todos los pilotos y concatena todos los disponibles en una sola cadena
    * Retorna la cadena con los pilotos disponibles 
    */
    public String ObtenerPilotosDisponibles() {
        String contenidoPilotos = "";
        // Ciclo iterador para recorrer todos los pilotos disponibles
        foreach (EntidadPiloto piloto in _listaPilotos) {
            // Verificacion si el piloto actual esta disponible
            if(piloto.GetEstado() == EntidadPiloto.Tipo_Estado.DISPONIBLE)
            {
                // Concatenacion de la informacion del piloto disponible
                contenidoPilotos += piloto.GetCodigoPiloto() + ";" + piloto.GetZonaCubierta() + "\n";
            }
        }
        return contenidoPilotos;
    }

    /*
    * Metodo para el cambio de estado del piloto
    * Parametros: *codigo    --> entero que contiene el codigo del piloto que se desea modificar
    * Recorre todos los pilotos y cambia el necesario
    */
    public void OcuparPiloto(int codigo) 
    {
        // Ciclo iterador para recorrer todos los pilotos disponibles
        foreach (EntidadPiloto piloto in _listaPilotos)
        {
            // Verificacion si el piloto actual corresponde al codigo mandado
            if (piloto.GetCodigoPiloto() == codigo)
            {
                // Modificacion del estado del piloto
                piloto.SetEstado(EntidadPiloto.Tipo_Estado.OCUPADO);
                break;
            }
        }
    }
}