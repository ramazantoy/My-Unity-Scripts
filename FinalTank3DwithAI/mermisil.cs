using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermisil : MonoBehaviour
{
  


bool detachChildren = false;

    void Awake()
    {
        Invoke("DestroyNow", 5);
    }

    void DestroyNow()
    {
        if (detachChildren)
        {
            transform.DetachChildren();
        }
        DestroyObject(this.gameObject);
    }

    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
