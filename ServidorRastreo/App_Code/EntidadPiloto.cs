using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EntidadPiloto
/// </summary>
public class EntidadPiloto
{
    // Declaracion de atributos necesarios para piloto

    // Declaracion de ccodigo de piloto, codigo unico y representativo
    private string _placa;
    // declaracion de la zona cubierta por el piloto actualmente
    private int _zonaCubierta;


    /*
    * Constructor para la entidad de pilotos
    * Parametros: *codigoPiloto --> entero que representa el codigo unico del piloto
    *             *estado       --> tipo de estado en el que se encuentra el piloto
    *             *zonaCubierta --> entero que representa la zona cubierta por el piloto
    */
    public EntidadPiloto(string placa, int zonaCubierta)
    {
        _placa = placa;
        _zonaCubierta = zonaCubierta;
    }

    // Encapsulamiento de los atributos de piloto


    public string GetPlaca()
    {
        return _placa;
    }

    public void SetPlaca(string placa)
    {
        _placa = placa;
    }


    public int GetZonaCubierta()
    {
        return _zonaCubierta;
    }

    public void SetZonaCubierta(int zonaCubierta)
    {
        _zonaCubierta = zonaCubierta;
    }
}