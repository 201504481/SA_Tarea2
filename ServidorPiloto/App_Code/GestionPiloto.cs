using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestionPiloto
/// </summary>
public class GestionPiloto
{
    private LinkedList<EntidadPiloto> _listaPilotos;

    public GestionPiloto() {
        _listaPilotos = new LinkedList<EntidadPiloto>();
    }

    public void AgregarPiloto(EntidadPiloto piloto) {
        _listaPilotos.AddLast(piloto);
    }

    public String ObtenerPilotos() {
        String contenidoPilotos = "";
        foreach (EntidadPiloto piloto in _listaPilotos) {
            contenidoPilotos += "Codigo: " + piloto.GetCodigoPiloto() + " Estado: " + piloto.GetEstado() + " Zona Actual: " + piloto.GetZonaCubierta() + "\n";
        }
        return contenidoPilotos;
    }
}