using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot2Kontrol : MonoBehaviour
{

    public float hiz;
    public float mesafe;
    public float atlamahizi;
    public float dusmehizi;
    bool donus;
    bool hareketEt;
    Vector3 final = new Vector3(0.46f, -0.203f, -2.183761f);
    Animator a;

    public Transform toprak;
    void Start()
    {
        hareketEt = true;
        donus = false;
        a = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Hareketdurumu();
    }
    void Hareketdurumu()
    {
        transform.Translate(Vector2.left * hiz * Time.deltaTime);
        RaycastHit2D yerbilgisi = Physics2D.Raycast(toprak.position, Vector2.down, mesafe);
        a.Play("bot2_run");
        if (gameObject.transform.position.x <= 12f){
            transform.eulerAngles = new Vector3(0, -180, 0);
            donus = true;
        }
        if (gameObject.transform.position.x >= 25f)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            donus = false;

        }
        if (yerbilgisi.collider == false && hareketEt)
        {
            if (!donus)
            {
                transform.Translate(Vector2.up  * atlamahizi);
                a.Play("bot2_jump");
            }
            else
            {
                transform.Translate(-Vector2.up  * dusmehizi);
            }
         
           
        }


        }
    }
   

