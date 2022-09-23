using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimientojugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;

    // Start is called before the first frame update
    void Start()
    {
       

        
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Imput.GetAxis("horizontal");
        movimientoEjeX = Imput.GetAxis("Vertical");
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);
    }
}
         