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
public class EntidadPiloto {

    // Declaracion de atributos necesarios para piloto

    // Declaracion de ccodigo de piloto, codigo unico y representativo
    private String _placa;
    // Declaracion del tipo de estado en el que se encuentra el piloto
    private Tipo_Estado _estado;
    // declaracion de la zona cubierta por el piloto actualmente
    private int _zonaCubierta;
    private String _nombre;

    public EntidadPiloto(String placa, Tipo_Estado estado, int zonaCubierta, String nombre) {
        _placa = placa;
        _estado = estado;
        _zonaCubierta = zonaCubierta;
        _nombre = nombre;
    }
    
    
    
    /**
     * @return the _placa
     */
    public String getPlaca() {
        return _placa;
    }

    /**
     * @param _placa the _placa to set
     */
    public void setPlaca(String _placa) {
        this._placa = _placa;
    }

    /**
     * @return the _estado
     */
    public Tipo_Estado getEstado() {
        return _estado;
    }

    /**
     * @param _estado the _estado to set
     */
    public void setEstado(Tipo_Estado _estado) {
        this._estado = _estado;
    }

    /**
     * @return the _zonaCubierta
     */
    public int getZonaCubierta() {
        return _zonaCubierta;
    }

    /**
     * @param _zonaCubierta the _zonaCubierta to set
     */
    public void setZonaCubierta(int _zonaCubierta) {
        this._zonaCubierta = _zonaCubierta;
    }

    /**
     * @return the _nombre
     */
    public String getNombre() {
        return _nombre;
    }

    /**
     * @param _nombre the _nombre to set
     */
    public void setNombre(String _nombre) {
        this._nombre = _nombre;
    }
     // Enumarador para representar el tipo de estado que puede estar el piloto
    public enum Tipo_Estado
    {
        DISPONIBLE,
        OCUPADO
    }
}
