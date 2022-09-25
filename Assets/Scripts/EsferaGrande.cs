using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaGrande : MonoBehaviour
{
    public GameObject Objpuntos;
    public float puntosQueDa;
    private void OnTriggerEnter(Collider other
        )
    {
        if (other.tag=="Player")
        {
            Objpuntos.GetComponent<Puntos>().puntos += puntosQueDa;
            Destroy(gameObject);
        }
    }
}
