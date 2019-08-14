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
    private int _codigoPiloto;
    // declaracion de la zona cubierta por el piloto actualmente
    private int _zonaCubierta;

    /*
    * Constructor para la entidad de pilotos
    * Parametros: *codigoPiloto --> entero que representa el codigo unico del piloto
    *             *zonaCubierta --> entero que representa la zona cubierta por el piloto
    */
    public EntidadPiloto(int codigoPiloto, int zonaCubierta)
    {
        _codigoPiloto = codigoPiloto;
        _zonaCubierta = zonaCubierta;
    }

    // Encapsulamiento de atributos necesarios para el piloto
    public int GetCodigoPiloto()
    {
        return _codigoPiloto;
    }

    public void SetCodigoPiloto(int codigoPiloto)
    {
        _codigoPiloto = codigoPiloto;
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