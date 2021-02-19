using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot1Kontrol : MonoBehaviour
{
    public float hiz;
    public float mesafe;
    bool sag = true;
    bool hareketEt;
    Animator a;

   public Transform toprak;
 
    void Start()
    {
        hareketEt = true;
        a = GetComponent<Animator>();
    }

    
    void Update()
    {
        Hareketdurumu();
    }
    void Hareketdurumu()
    {
        transform.Translate(Vector2.left * hiz * Time.deltaTime);
        RaycastHit2D yerbilgisi = Physics2D.Raycast(toprak.position, Vector2.down, mesafe);
        if (yerbilgisi.collider == false && hareketEt)
        {
            if (sag == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                sag = false;
                a.Play("bot1_run");
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                sag = true;
                a.Play("bot1_run");
            }
           

        }
    }
    
}
