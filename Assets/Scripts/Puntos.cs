using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{

    public float puntos;
    public Text textoPuntos;
    public void Update()
    {
        textoPuntos.text = "Puntos:" + puntos.ToString();

        if(puntos<0)
            {
                puntos=0;
        
            }
     }

}
