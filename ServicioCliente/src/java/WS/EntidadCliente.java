/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package WS;

/**
 *
 * @author eljul
 */
public class EntidadCliente {

    private String _nombreUsuario;
    private int _zonaActual;

    public EntidadCliente(String nombreUsuario, int zonaActual) {
        _nombreUsuario = nombreUsuario;
        _zonaActual = zonaActual;
    }
    
    
    
    /**
     * @return the _nombreUsuario
     */
    public String getNombreUsuario() {
        return _nombreUsuario;
    }

    /**
     * @param _nombreUsuario the _nombreUsuario to set
     */
    public void setNombreUsuario(String _nombreUsuario) {
        this._nombreUsuario = _nombreUsuario;
    }

    /**
     * @return the _zonaActual
     */
    public int getZonaActual() {
        return _zonaActual;
    }

    /**
     * @param _zonaActual the _zonaActual to set
     */
    public void setZonaActual(int _zonaActual) {
        this._zonaActual = _zonaActual;
    }
    
}
