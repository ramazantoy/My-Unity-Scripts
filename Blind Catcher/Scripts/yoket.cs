using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yoket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("sil",1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sil() 
    {
        gameObject.SetActive(false);
    }
}
