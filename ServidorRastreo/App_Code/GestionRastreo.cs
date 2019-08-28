using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestionRastreo
/// </summary>
public class GestionRastreo
{
    
    // Declaracion de variables globales

    // Instancia al bus de servidor
    ESB.ServiceSoapClient esb = new ESB.ServiceSoapClient();
    // Declaracion de lista que contendra los pilotos disponibles actuales
    LinkedList<EntidadPiloto> _pilotosDisponibles;
    // Declaracion de un random, por motivos del demo
    Random _rnd = new Random();

    /*
    * Metodo para la obtencion de todos los pilotos disponibles actuales
    * Parametros: ninguno
    * Obtiene los pilotos disponnibles y los agrega al listado global
    */
    public void ObtencionPilotosDisponibles()
    {
        // Instancia de una nueva lista de pilotos disponibles
        _pilotosDisponibles = new LinkedList<EntidadPiloto>();

        _pilotosDisponibles.AddLast(new EntidadPiloto("123ABC", 1));
        _pilotosDisponibles.AddLast(new EntidadPiloto("456DEF", 2));
        _pilotosDisponibles.AddLast(new EntidadPiloto("789GHI", 3));
        _pilotosDisponibles.AddLast(new EntidadPiloto("123JKL", 4));
        _pilotosDisponibles.AddLast(new EntidadPiloto("456MNO", 5));
        _pilotosDisponibles.AddLast(new EntidadPiloto("789PQR", 6));
        _pilotosDisponibles.AddLast(new EntidadPiloto("124STU", 7));
        _pilotosDisponibles.AddLast(new EntidadPiloto("456VWX", 8));
    }


    public String ObtenerInformacion(int zona) {
        int zonaActual = _pilotosDisponibles.ElementAt(0).GetZonaCubierta();
        // Ciclo iterador para recorrer todos los pilotos disponibles
        foreach (EntidadPiloto piloto in _pilotosDisponibles)
        {
            int zonaAux = piloto.GetZonaCubierta();
            int diferenciaActual = zonaActual > zona ? zonaActual - zona : zona - zonaActual;
            int diferenciaNueva = zonaAux > zona ? zonaAux - zona : zona - zonaAux;

            if (diferenciaNueva < diferenciaActual) {
                zonaActual = zonaAux;
            }
        }

        foreach (EntidadPiloto piloto in _pilotosDisponibles)
        {
            if (piloto.GetZonaCubierta() == zonaActual)
            {
                return piloto.GetPlaca();
            }
        }
        return "000000";
    }

    /*
    * Metodo para calcular la mejor propuesta de piloto disponible
    * Parametros: *zona --> entero que marca la zona interesada en buscar piloto
    * Analiza los pilotos disponibles y calcula el mas cercano
    */
    public String PropuestaPiloto(int zona) {
        // Verificacion si existe algun piloto disponible
        if (_pilotosDisponibles.Count != 0)
        {
            // Coloca al primer piloto como el mas cercano
            int posicionActual = 0;
            int zonaActual = _pilotosDisponibles.ElementAt(posicionActual).GetZonaCubierta();

            // Ciclo iterativo de pilotos que comienza desde el segundo piloto para calcular cual es mejor
            for(int posicion = 1; posicion < _pilotosDisponibles.Count; posicion++) 
            {
                // Obtencion de la zona cubierta por el piloto actual 
                int zonaNueva = _pilotosDisponibles.ElementAt(posicion).GetZonaCubierta();
                // Calculo de distancia con el piloto mas cercano actual
                int distanciaActual = (zona > zonaActual ? zona - zonaActual : zonaActual - zona);
                // Calculo de distancia con el piloto de la nueva propuesta
                int distanciaNueva = (zona > zonaNueva ? zona - zonaNueva : zonaNueva - zona);
                //Verificacion si la distacia es mas corta
                if (distanciaNueva < distanciaActual) {
                    // Sustitucion del antiguo conductor con el conductor nuevo mas cercano
                    posicionActual = posicion;
                    zonaActual = zonaNueva;
                }
            }
            // Peticion al ESB para marcar como ocupado el conductor elegido
            
            // Mensaje de retorno con la informacion del nuevo conductor
            return "Piloto mas cercano: "  + "\n" +
                " Se encuentra en zona:" + zonaActual + " El precio actual es de: " + CalculoPrecio(zona, zonaActual);
        }
        // Mensaje de retorno que no existen conductores disponibles
        return " No hay pilotos disponibles \n Porfavor intentar mas tarde";
    }

    /*
    * Metodo para el calculo de precio
    * Parametros: *zonaCliente   --> entero que marca la zona actual del cliente
    *             *zonaConductor --> entero que marca la zona actual del piloto 
    */
    public int CalculoPrecio(int zonaCliente, int zonaConductor)
    {
        // Calculo de distancia 
        int distancia = (zonaCliente > zonaConductor ? zonaCliente - zonaConductor : zonaConductor - zonaCliente) ;
        // Calculo de precio, por motivos del demo se toma un valor random
        return distancia * 20 + _rnd.Next(1, 51); 
    }

    /*
    * Metodo para la peticion de ocupacion del piloto
    * Parametros: *codiPiloto   --> entero con el codigo del piloto que se desea ocupar
    */
    public void OcuparPiloto(int codigoPiloto) 
    {
        
        // Peticion al bus de servidor
        esb.OcuparPiloto(codigoPiloto);
    }
}