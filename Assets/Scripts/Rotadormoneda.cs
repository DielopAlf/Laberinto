using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotadormoneda : MonoBehaviour
{
    [SerializeField]
    float rotacionX = 20f;

    void Update()
    {
        transform.Rotate(0.0f, rotacionX * Time.deltaTime, 0f);
    }
}
