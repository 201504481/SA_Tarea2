using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EntidadPiloto
/// </summary>
public class EntidadPiloto
{    
    // Enumarador para representar el tipo de estado que puede estar el piloto
    public enum Tipo_Estado
    {
        DISPONIBLE,
        OCUPADO
    }

    // Declaracion de atributos necesarios para piloto

    // Declaracion de ccodigo de piloto, codigo unico y representativo
    private string _placa;
    // Declaracion del tipo de estado en el que se encuentra el piloto
    private Tipo_Estado _estado;
    // declaracion de la zona cubierta por el piloto actualmente
    private int _zonaCubierta;
    private string _nombre;

    /*
    * Constructor para la entidad de pilotos
    * Parametros: *codigoPiloto --> entero que representa el codigo unico del piloto
    *             *estado       --> tipo de estado en el que se encuentra el piloto
    *             *zonaCubierta --> entero que representa la zona cubierta por el piloto
    */
    public EntidadPiloto(string placa, Tipo_Estado estado, int zonaCubierta, string nombre)
    {
        _placa = placa;
        _estado = estado;
        _zonaCubierta = zonaCubierta;
        _nombre = nombre;
    }

    // Encapsulamiento de los atributos de piloto
    public string GetNombre()
    {
        return _nombre;
    }

    public void SetNombre(string nombre)
    {
        _nombre = nombre;
    }

    public string GetPlaca()
    {
        return _placa;
    }

    public void SetPlaca(string placa)
    {
        _placa = placa;
    }

    public Tipo_Estado GetEstado()
    {
        return _estado;
    }

    public void SetEstado(Tipo_Estado estado)
    {
        _estado = estado;
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