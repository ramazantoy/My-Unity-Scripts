using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ates : MonoBehaviour
{
    public GameObject bullet;
    public Transform dogmayeri;
    GameObject ins_bullet;
    Rigidbody r;
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Mouse0)))
        {
            ins_bullet = Instantiate(bullet, dogmayeri.position, dogmayeri.rotation) as GameObject;
            r = ins_bullet.GetComponent<Rigidbody>();
            r.AddRelativeForce(-1*Vector3.forward, ForceMode.Impulse);
        }
    }
}
