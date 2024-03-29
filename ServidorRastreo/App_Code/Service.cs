﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]


public class Service : System.Web.Services.WebService
{
    GestionRastreo _gestionRastreo = new GestionRastreo();
    public Service () 
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent();  
    }

    /*
   * Metodo del servidor web que recibe la solicitud de obtener la propuesta del mejor piloto
   * Parametros: *zona --> tipo entero que cotiene la zona actual del cliente 
   * Realiza una llamada al servidor de rastreos para obtener la propuesta del piloto mas cercano
   */ 
    [WebMethod]
    public String ObtenerPropuestaPiloto(int zona) 
    {
        _gestionRastreo.ObtencionPilotosDisponibles();
        return _gestionRastreo.PropuestaPiloto(zona);
    }
    
}