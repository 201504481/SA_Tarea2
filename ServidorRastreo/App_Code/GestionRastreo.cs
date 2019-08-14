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
        // Peticion al ESB con todos los pilotos disponibles
        String cadena = esb.SolicitudPilotosDisponibles();
        // Analizador para obtener todos los datos de los pilotos disponibles 
        /* Ejemplo de cadena:<codigoPiloto>;<zona>
        *  111;1
        *  222;2
        */

        String[] pilotos = cadena.Split('\n');
        for (int posicion = 0; posicion < pilotos.Length - 1; posicion++)
        {
            String piloto = pilotos[posicion];
            String[] datosPiloto = piloto.Split(';');
            int codigo = Int32.Parse(datosPiloto[0]);
            int zona = Int32.Parse(datosPiloto[1]);
            // Insercion del piloto conn todos sus datos
            _pilotosDisponibles.AddLast(new EntidadPiloto(codigo, zona));
        }
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
            OcuparPiloto(_pilotosDisponibles.ElementAt(posicionActual).GetCodigoPiloto());
            // Mensaje de retorno con la informacion del nuevo conductor
            return "Piloto mas cercano: " + _pilotosDisponibles.ElementAt(posicionActual).GetCodigoPiloto() + "\n" +
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