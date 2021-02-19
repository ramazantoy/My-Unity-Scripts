using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyuncu_mermi : MonoBehaviour
{
   
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bot")
        {
            OyunKontrol.bot_can -= 10;
           
        }

    }

    void Update()
    {
        
    }
}
