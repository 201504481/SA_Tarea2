# Tarea 2 y 3 Software avanzado

|             Datos               |
|---------------------------------|
|Julio Alberto Arango Godinez     |
|201504481                        |


# Detalles del proyecto 

El proyecto es una aplicación SOA para la simulación de los siguientes servicios de carros para un servicio similar a Uber:

1.  Solicitud de servicio por parte del cliente
2.  Recepción de solicitud y aviso al piloto
3.  Solicitud de ubicación (rastreo) desde la administración del servicio de carros

Todos los servicios son orquestados por medio de un ESB creado por nuestra cuenta

## Pre-requisitos
Para la implementacion del proyecto se necesitan los siguientes requisitos
1.  Sistema Operativo, necesitaremos Windows Profesional
2.  Instalación de IIS
3.  .NET framework 3.5 o superior

## Proyecto alojado 

El proyecto actualmente se encuentra alojado en el siguiente enlace de github: [SA_Tarea2](https://github.com/201504481/SA_Tarea2) para clonar desde la terminal se puede realizar con el siguiente comando: 
```git
git clone git://github.com/201504481/SA_Tarea2.git
```
## Arquitectura
Para el proyecto se llevo la siguiente arquitectura de micro-servicios orquestado por ESB
![Arquitectura](https://github.com/201504481/SA_Tarea2/blob/master/img/Arquitectura.png)
 
## Definición de los servicios
### Servicio Cliente
El servicio de cliente tiene como atributos su nombre de usuario y la zona actual en la que reside, esta zona es la que se obtiene y se utiliza para la solicitud de viajes, dando solicitudes al EBS para pedir el viaje y que le manden el piloto mas cercano a su ubicación 

### Servicio Piloto
El servicio de pilotos contiene los atributos de código de piloto, el cual seria único y sobre el cual se pueden realizar actualizaciones, un estado que puede ser disponible u ocupado dependiendo si esta en un viaje y una ubicación que es en la que esta actualmente, esto para verificar que se este mandando el piloto mas cercano al realizar una petición de viaje.  


### Servicio Rastreo
El servicio de rastreo es el mas importante, este servicio le pide al ESB todos los pilotos disponibles y con esta información es el encargado de realizar todos los cálculos de que piloto es el mejor, cual seria el precio y retornar los datos de todo esto al ESB

# Interacción servicios con ESB
Nuestro enterprise service bus es el orquestador de todos nuestros micro-servicios, por esto se encuentras multiples interacciones de los servicios con el ESB y el ESB con los servicios y ninguna interacción entre servicios, las principales son:
## ESB

### SolicitudViajeCliente
Función alojada en el ESB, lo que recibe es una solicitud de viaje con una zona de ubicación y este realiza una petición al servidor de rastreo por medio de ObtenerPropuestaPiloto, mandando de parámetro la misma zona recibida.
### SolicitudPilotosDisponibles
Función alojada en el ESB, lo que recibe es una solicitud de un servidor para obtener todos los pilotos con estado disponible, por lo cual este realiza una petición al servicio de pilotos por medio de ObtenerConductoresDisponibles para que le devuelva todos los pilotos con estado disponible. 
### IngresoCliente
Función alojada en el ESB, recibe una solicitud para iniciar una sesión con un usuario, recibe de parámetro el nombre de usuario y la zona donde se ubica actualmente el usuario, el ESB realiza una petición al servidor de usuarios para la inserción por medio de IngresoCliente.
### OcuparPiloto
unción alojada en el ESB, recibe una solicitud para marcar como ocupado un piloto y este manda la petición al servicio de pilotos por medio de OcuparPiloto.

## Servidor Cliente

### IngresoCliente
Función alojada en el servidor de cliente, lo que recibe es una petición de ingreso por medio del ESB y este actualiza el usuario con la sesión actual iniciada.

## Servidor Piloto
### ObtenerConductoresDisponibles
Función alojada en el servidor de pilotos, lo que recibe es una petición del ESB para obtener todos los conductores cuyo estado esta disponible, devuelve una cadena con el siguiente formato: 
```git
Sintaxis: <CodPiloto>;<Zona>

111;1
222;2
333;3
444;4
```
### OcuparPiloto
Función alojada en el servidor de pilotos, lo que recibe es una petición desde el ESB para cambiar de estado un piloto, recibe de parámetro el código del piloto y este lo cambia a ocupado.

## Servidor Rastreo
### ObtenerPropuestaPiloto
Función alojada en el servidor de rastreo, lo que recibe es una petición desde el ESB para hacer todos los cálculos necesarios para obtener al mejor piloto, esta función entre todo su algoritmo va a pedir al ESB el listado de pilotos disponibles y con ese listado hace el análisis de cual es el que queda mas cerca de la zona dada.

# Copyright

* Copyright (C) 2005 - 2019 Open Source Matters. All rights reserved.
* Distributed under the GNU General Public License version 2 or later
* See [License details](https://github.com/201504481/SA_Tarea2/blob/master/LICENSE)