using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Movimientojugador : MonoBehaviour
{
    public Text valor;

    public float movimientoEjeZ;
    public float movimientoEjeY;
    public float movimientoEjeX;

    public float velocidadMovimiento = -1.7f;
    // Start is called before the first frame update
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        movimientoEjeX = -Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }

}
          