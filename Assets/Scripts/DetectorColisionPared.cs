using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material Paredes;



    [SerializeField]
    Material ParedChoque;

    bool paredRoja = false;


    float tiempoEnRojo = 5f;
    //funcion que se ejecuta por cada imagen del juego
    private void Update()
    {
        if (paredRoja == true)
         {



            tiempoEnRojo = tiempoEnRojo - Time.deltaTime;
            if (tiempoEnRojo < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = Paredes;
                paredRoja = false;
                tiempoEnRojo = 5f;
            }    
          }
    }

    //funcion que se ejecuta al chocar un objeto con este GameObject.
    private void OnCollisionEnter(Collision col)
    {
        
        if(col.gameObject.tag =="Player")
        {

            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = ParedChoque;
            paredRoja = true;
        }
                
    }
}
