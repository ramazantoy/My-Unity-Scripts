using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_mermi : MonoBehaviour
{
    
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "oyuncu")
        {
            OyunKontrol.oyuncu_can -= 10;
           
        }

    }
  
    void Update()
    {
        
    }
}
