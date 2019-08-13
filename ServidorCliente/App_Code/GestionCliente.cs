using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestionCliente
/// </summary>
public class GestionCliente
{
    LinkedList<EntidadCliente> _listaClientes;
    EntidadCliente _clienteActivo;

    public GestionCliente() {
        _listaClientes = new LinkedList<EntidadCliente>();
    }

    public int ObtenerZonaUsuario() 
    {
        if (_clienteActivo != null) 
        {
            return _clienteActivo.GetZonaActual();
        }
        else 
        {
            return 0;   
        }   
    }

    public void RegistroCliente(String nombreUsuario)
    {
        foreach(EntidadCliente cliente in _listaClientes)
        {
            String nombreClienteActual = cliente.GetNombreUsuario();
            if (nombreClienteActual.Equals(nombreUsuario)) 
            {
                _clienteActivo = cliente;
                break;
            }
        }
        _clienteActivo = null;
    }

    public void SolicitarViaje() {
        ESB.ServiceSoapClient esb = new ESB.ServiceSoapClient();
        
    }
}