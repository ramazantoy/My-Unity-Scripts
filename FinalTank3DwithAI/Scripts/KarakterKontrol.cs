using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol : MonoBehaviour
{
    Rigidbody r;
    float yatay;
    float dikey;
  //  public GameObject mermi;
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }
    void Kontrol()
    {
        yatay = Input.GetAxisRaw("Horizontal");
        dikey = Input.GetAxisRaw("Vertical");
          r.velocity = new Vector3(-20 * dikey, 0, 20 * yatay);
        
   
        if (Input.GetKey(KeyCode.E))
        {
            gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * 40,0 ));
        }
        if (Input.GetKey(KeyCode.Q) )
        {
            gameObject.transform.Rotate(new Vector3(0, Time.deltaTime * -40, 0));
        }

    }
    void Ates()
    {
        if (Input.GetMouseButtonDown(0))
        {

        }
    }


    void Update()
    {
        Kontrol();
    }
}
