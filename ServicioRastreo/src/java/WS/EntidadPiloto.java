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
    // declaracion de la zona cubierta por el piloto actualmente
    private int _zonaCubierta;

    public EntidadPiloto(String placa, int zonaCubierta) {
        this._placa = placa;
        this._zonaCubierta = zonaCubierta;
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
    
}
