using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    Rigidbody r;
    public GameObject sahip;
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

   void kontrol()
    {
        if(sahip.gameObject.transform.rotation.y >= 0 && sahip.gameObject.transform.rotation.y <= 30)
        {
            r.velocity = new Vector3(20, 0, (sahip.gameObject.transform.rotation.y)*20);
        }
    }
    void Update()
    {
        
    }
}
