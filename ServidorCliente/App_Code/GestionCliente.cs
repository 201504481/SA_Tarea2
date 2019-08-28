using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de GestionCliente
/// </summary>
public class GestionCliente
{
    // Declaracion de variables globales

    // Declaracion de la lista de clientes de esta gestion
    LinkedList<EntidadCliente> _listaClientes;
    // Declaracion del cliente Activo, contendra el usuario con la sesion iniciada
    EntidadCliente _clienteActivo;

    /*
    * Constructor de la gestion de clientes 
    * Parametros: ninguno 
    * Realiza la instancia de la lista de clientes
    */
    public GestionCliente() {
        _listaClientes = new LinkedList<EntidadCliente>();
        _listaClientes.AddLast(new EntidadCliente("Julius1525", 5));
        _listaClientes.AddLast(new EntidadCliente("Maxito15", 7));
        _listaClientes.AddLast(new EntidadCliente("FidoDido", 10));
        _listaClientes.AddLast(new EntidadCliente("RositaMargarita", 2));
        _listaClientes.AddLast(new EntidadCliente("Julian25", 3));

    }

    /*
    * Metodo para Obtener la zona actual del usuario con sesion activa
    * Parametros: ninguno 
    * Retorna la zona del usuario con sesion activa
    */
    public int ObtenerZonaUsuario(string nombre) 
    {
        foreach (EntidadCliente cliente in _listaClientes)
        {
            if (cliente.GetNombreUsuario() == nombre) {
                return cliente.GetZonaActual();
            }
        }
        return 0;
    }

    /*
    * Metodo para el registro de un nuevo usuario
    * Parametros: *nombreUsuario --> cadena que contiene el nombre del usuario
    *             *zonaActual    --> entero que contiene la zona actual del usuario que intenta registrarse 
    * Verifica si el usuario actual esta registrado, por motivos de flujo de la aplicacion si no existe lo inserta
    */
    public Boolean IngresoRegistroCliente(String nombreUsuario, int zonaActual)
    {
        // Ciclo iterador por cada cliente en la lista de clientes
        foreach(EntidadCliente cliente in _listaClientes)
        {
            String nombreClienteActual = cliente.GetNombreUsuario();
            // Verificacion si el nombre del cliente actual es el mismo del usuario a ingresar
            if (nombreClienteActual.Equals(nombreUsuario)) 
            {
                // Actualizacion del cliente con sesion iniciada y zona del mismo usuario
                _clienteActivo = cliente;
                _clienteActivo.SetZonaActual(zonaActual);
                // Retorno para finalizar el flujo del metodo, ingresando el usuario 
                return true;
            }
        }
        // Registro del usuario debido a no encontrar ninguno similar
        EntidadCliente nuevo = new EntidadCliente(nombreUsuario, zonaActual);
        _listaClientes.AddLast(nuevo);
        // Actualizacion del cliente con sesion iniciada 
        _clienteActivo = nuevo;
        return false;
    }
}