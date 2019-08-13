using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EntidadPiloto
/// </summary>
public class EntidadPiloto
{
    private int _codigoPiloto;
    private Tipo_Estado _estado;
    private int _zonaCubierta;

    public enum Tipo_Estado { 
        DISPONIBLE,
        OCUPADO
    }

    public EntidadPiloto(Tipo_Estado estado, int zonaCubierta)
    {
        _estado = estado;
        _zonaCubierta = zonaCubierta;
    }

    public int GetCodigoPiloto()
    {
        return _codigoPiloto;
    }

    public void SetCodigoPiloto(int codigoPiloto)
    {
        _codigoPiloto = codigoPiloto;
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