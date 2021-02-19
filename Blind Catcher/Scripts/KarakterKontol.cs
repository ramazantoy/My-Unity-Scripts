using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontol : MonoBehaviour
{
    public AudioClip attacksound;
    AudioSource sound;
    public GameObject attack;
    Animator a;
    Rigidbody2D r;
    float yatay;
    bool ziplayabilir = true;
    public float karakterhizi;
    public float ziplamayuksekligi;
    void Start()
    {
        r = GetComponent<Rigidbody2D>();
        a = GetComponent<Animator>();
        Time.timeScale = 1;
        attack.SetActive(false);
        sound = GetComponent<AudioSource>();

    }
    void Hareket()       
    {
        if (Input.GetKeyDown(KeyCode.LeftAlt) && Time.timeScale != 0)
        {
            a.Play("attack");
            attack.SetActive(true);
            sound.PlayOneShot(attacksound);
        }
        if (Input.GetKeyUp(KeyCode.LeftAlt) && Time.timeScale != 0)
        {

            Invoke("kilickapat", 0.5f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && ziplayabilir && Time.timeScale != 0)
        {
           
            r.AddForce(Vector2.up * ziplamayuksekligi);
            a.Play("jump");
         
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Time.timeScale != 0) {
            gameObject.transform.localScale = new Vector3(3, 3, 3);
            r.velocity = new Vector2(karakterhizi, r.velocity.y);
            if (ziplayabilir)
            {
                a.Play("run");
            }
            
               }
        else if (Input.GetKey(KeyCode.LeftArrow) && Time.timeScale != 0)
        {
            gameObject.transform.localScale = new Vector3(-3, 3, 3);
            r.velocity = new Vector2(-karakterhizi, r.velocity.y);
            if (ziplayabilir)
            {
                a.Play("run");
            }
              
        }
        
        }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            ziplayabilir = true;
          //  Debug.Log("zıplayabilir");
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            ziplayabilir = false;
       //    Debug.Log("zıplayamaz");
        }
    }

    void Update()
    {
        Hareket();
    }
    void kilickapat() 
    {
        attack.SetActive(false);
    }
}
