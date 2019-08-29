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
Nuestro enterprise service bus es el orquestador de todos nuestros micro-servicios, por esto se encuentras múltiples interacciones de los servicios con el ESB y el ESB con los servicios y ninguna interacción entre servicios, las principales son:

## Servidor Cliente

### IngresoCliente
Función alojada en el servidor de cliente, lo que recibe es una petición de ingreso por medio del ESB y este actualiza el usuario con la sesión actual iniciada.

## Servidor Rastreo
### ObtenerPropuestaPiloto
Función alojada en el servidor de rastreo, lo que recibe es una petición desde el ESB para hacer todos los cálculos necesarios para obtener al mejor piloto, esta función entre todo su algoritmo va a pedir al ESB el listado de pilotos disponibles y con ese listado hace el análisis de cual es el que queda mas cerca de la zona dada, retornando la placa del piloto para hacer una llamada a toda la información del piloto.

## Servidor Piloto
### ObtenerInformacion 
Función alojada en el servidor de pilotos, donde recibe de parámetro la placa del piloto y recupera toda la información necesaria para el viaje, como nombre del piloto, placa del vehículo y tiempo estimado en llegar.

## Orquestado BPEL
Para la orquestación de estos microservicios se utilizo un BPEL con la herramienta de OpenESB y para realizar distintas pruebas se uso una composición de aplicaciones, la arquitectura llevada en el BPEL es la siguiente: 

![Arquitectura_BPEL](https://github.com/201504481/SA_Tarea2/blob/Tarea4/img/Arquitectura_BPEL.png)

Donde se utilizo conexión con los 3 microservicios y se simulo con otro wsdl, propio de OpenESB, las peticiones del usuario.

# Copyright

* Copyright (C) 2005 - 2019 Open Source Matters. All rights reserved.
* Distributed under the GNU General Public License version 2 or later
* See [License details](https://github.com/201504481/SA_Tarea2/blob/master/LICENSE)