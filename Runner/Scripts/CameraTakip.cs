using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public GameObject karakter;
    Vector3 mesafe;
    void Start()
    {
        mesafe = transform.position - karakter.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = karakter.transform.position + mesafe;
    }
}
