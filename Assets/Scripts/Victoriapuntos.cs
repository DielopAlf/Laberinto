using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoriapuntos : MonoBehaviour
{
    
private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            //SceneManager.LoadScene();
                
         }
    }

}

    
    
        
    

