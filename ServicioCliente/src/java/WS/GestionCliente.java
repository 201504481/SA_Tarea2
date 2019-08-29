/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS;

import java.util.LinkedList;

/**
 *
 * @author eljul
 */
public class GestionCliente {
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
        _listaClientes.add(new EntidadCliente("Julius1525", 5));
        _listaClientes.add(new EntidadCliente("Maxito15", 7));
        _listaClientes.add(new EntidadCliente("FidoDido", 10));
        _listaClientes.add(new EntidadCliente("RositaMargarita", 2));
        _listaClientes.add(new EntidadCliente("Julian25", 3));

    }

    /*
    * Metodo para Obtener la zona actual del usuario con sesion activa
    * Parametros: ninguno 
    * Retorna la zona del usuario con sesion activa
    */
    public int ObtenerZonaUsuario(String nombre) 
    {
        for (EntidadCliente cliente : _listaClientes)
        {
            if (cliente.getNombreUsuario().equalsIgnoreCase(nombre)) {
                return cliente.getZonaActual();
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
        for (EntidadCliente cliente : _listaClientes)
        {
            String nombreClienteActual = cliente.getNombreUsuario();
            // Verificacion si el nombre del cliente actual es el mismo del usuario a ingresar
            if (nombreClienteActual.equalsIgnoreCase(nombreUsuario)) 
            {
                // Actualizacion del cliente con sesion iniciada y zona del mismo usuario
                _clienteActivo = cliente;
                _clienteActivo.setZonaActual(zonaActual);
                // Retorno para finalizar el flujo del metodo, ingresando el usuario 
                return true;
            }
        }
        // Registro del usuario debido a no encontrar ninguno similar
        EntidadCliente nuevo = new EntidadCliente(nombreUsuario, zonaActual);
        _listaClientes.add(nuevo);
        // Actualizacion del cliente con sesion iniciada 
        _clienteActivo = nuevo;
        return false;
    }
}
