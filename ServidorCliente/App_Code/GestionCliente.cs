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
    }

    /*
    * Metodo para Obtener la zona actual del usuario con sesion activa
    * Parametros: ninguno 
    * Retorna la zona del usuario con sesion activa
    */
    public int ObtenerZonaUsuario() 
    {
        // Verificacion si existe un cliente activo
        if (_clienteActivo != null) 
        {
            // Retorno de la zona del cliente con sesion activa
            return _clienteActivo.GetZonaActual();
        }
        else 
        {
            // Retorno de una zona inexistente debido a que no existe sesion activa
            return -1;   
        }   
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