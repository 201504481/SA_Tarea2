using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EntidadCliente
/// </summary>
public class EntidadCliente
{
    // Instancia de atributos de la entidad de cliente
    private String _nombreUsuario;
    private int _zonaActual;

    /*
    * Constructor para la Entidad de Clientes
    * Parametros: *nombreUsuario --> cadena que contiene el nombre del usuario
    *             *zonaActual    --> entero que contiene la zona actual del usuario 
    */
    public EntidadCliente(String nombreUsuario, int zonaActual) 
    {
        _nombreUsuario = nombreUsuario;
        _zonaActual = zonaActual;
    }

    // Encapsulamiento atributod de la entidad
    public int GetZonaActual()
    {
        return _zonaActual;
    }

    public void SetZonaActual(int zonaActual)
    {
        _zonaActual = zonaActual;
    }

    public String GetNombreUsuario() 
    {
        return _nombreUsuario;
    }

    public void SetNombreUsuario(String nombreUsuario) 
    {
        _nombreUsuario = nombreUsuario;
    }
}