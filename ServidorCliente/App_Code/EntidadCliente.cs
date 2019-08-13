using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EntidadCliente
/// </summary>
public class EntidadCliente
{
    private String _nombreUsuario;
    private int _zonaActual;

    public EntidadCliente(String nombreUsuario) {
        _nombreUsuario = nombreUsuario;
    }

    public int GetZonaActual()
    {
        return _zonaActual;
    }

    public void SetZonaActual(String zonaActual)
    {
        _zonaActual = zonaActual;
    }

    public String GetNombreUsuario() {
        return _nombreUsuario;
    }

    public void SetNombreUsuario(String nombreUsuario) {
        _nombreUsuario = nombreUsuario;
    }
}