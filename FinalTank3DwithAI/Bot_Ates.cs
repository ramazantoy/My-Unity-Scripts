using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Ates : MonoBehaviour
{
    public GameObject bullet;
    public Transform dogmayeri;
    GameObject ins_bullet;
    Rigidbody r;
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "oyuncu")
        {
            InvokeRepeating("ates", 2, 5);
          
        }
    }
    void ates()
    {
        ins_bullet = Instantiate(bullet, dogmayeri.position, dogmayeri.rotation) as GameObject;
        r = ins_bullet.GetComponent<Rigidbody>();
        r.AddRelativeForce(-1 * Vector3.forward, ForceMode.Impulse);
    }
    void Update()
    {
       
         
        

    }
}
