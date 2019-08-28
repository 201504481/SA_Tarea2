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
    // Declaracion de un random, por motivos del demo
    Random _rnd = new Random();


    /*
    * Constructor para la gestion de pilotos
    * Parametros: ninguno
    * nstancia la lista de pilotos y para motivos de la simulacion se insertan 8 pilotos
    */
    public GestionPiloto() {
        _listaPilotos = new LinkedList<EntidadPiloto>();
        AgregarPiloto(new EntidadPiloto("123ABC", EntidadPiloto.Tipo_Estado.DISPONIBLE, 1,"Julio Arango"));
        AgregarPiloto(new EntidadPiloto("456DEF", EntidadPiloto.Tipo_Estado.DISPONIBLE, 2, "Julia Sierra"));
        AgregarPiloto(new EntidadPiloto("789GHI", EntidadPiloto.Tipo_Estado.DISPONIBLE, 3, "Alba Chinchilla"));
        AgregarPiloto(new EntidadPiloto("123JKL", EntidadPiloto.Tipo_Estado.DISPONIBLE, 4, "Gustavo Cruz"));
        AgregarPiloto(new EntidadPiloto("456MNO", EntidadPiloto.Tipo_Estado.DISPONIBLE, 5, "Daniel Garcia"));
        AgregarPiloto(new EntidadPiloto("789PQR", EntidadPiloto.Tipo_Estado.DISPONIBLE, 6, "Juan Carlos"));
        AgregarPiloto(new EntidadPiloto("124STU", EntidadPiloto.Tipo_Estado.DISPONIBLE, 7, "Lupita Godinez"));
        AgregarPiloto(new EntidadPiloto("456VWX", EntidadPiloto.Tipo_Estado.DISPONIBLE, 8, "Edgar Arriola"));
    }

    /*
    * Metodo para agregar nuevos pilotos 
    * Parametros: *EntidadPiloto, nodo que contiene todos los datos del piloto
    * agrega el piloto mandado a la lista de pilotos
    */
    public void AgregarPiloto(EntidadPiloto piloto) {
        _listaPilotos.AddLast(piloto);
    }


    public String ObtenerInformacion(string placa) {

        foreach (EntidadPiloto piloto in _listaPilotos)
        {
            if (piloto.GetPlaca() == placa)
            {
                return "Nombre Piloto: " + piloto.GetNombre() + "\n" +
                    "Placa Carro: " + piloto.GetPlaca() + "\n" +
                    "Zona Actual: " + piloto.GetZonaCubierta() + "\n" +
                    "Tiempo Estimado: " + _rnd.Next(1, 15); 
            }
        }
        return "Sin pilotos disponibles";
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
           
        }
    }
}