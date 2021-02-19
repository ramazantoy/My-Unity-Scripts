using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class attack : MonoBehaviour
{
    AudioSource sound;
    public AudioClip deathsound;
    int sayac;
    public GameObject win;
    SpriteRenderer sr;
    public Sprite[] olumdizi;
    // Start is called before the first frame update
    void Start()
    {
        sayac = 0;
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Bot1")
        {
            sound.PlayOneShot(deathsound);
            collision.gameObject.GetComponent<Bot1Kontrol>().enabled = false;
            sayac++;
            collision.gameObject.GetComponent<Animator>().enabled=false;
            collision.gameObject.GetComponent<yoket>().enabled = true;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            
            sr = collision.gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = olumdizi[0];
            
        }
        else if (collision.gameObject.name == "Bot1.1")
        {
            sound.PlayOneShot(deathsound);
            collision.gameObject.GetComponent<Bot1Kontrol>().enabled = false;
            sayac++;
            collision.gameObject.GetComponent<yoket>().enabled = true;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            
            sr = collision.gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = olumdizi[0];

        }
        else if (collision.gameObject.name == "Bot2")
        {
            sound.PlayOneShot(deathsound);
            collision.gameObject.GetComponent<Bot2Kontrol>().enabled = false;
            sayac++;
            collision.gameObject.GetComponent<yoket>().enabled = true;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            
            sr = collision.gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = olumdizi[1];

        }
       else if (collision.gameObject.name == "Bot3")
        {
            sound.PlayOneShot(deathsound);
            sayac++;
            collision.gameObject.GetComponent<yoket>().enabled = true;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            collision.gameObject.GetComponent<Bot3Kontrol>().enabled = false;
            sr = collision.gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = olumdizi[3];

        }
       else if (collision.gameObject.name == "Bot4")
        {
            sound.PlayOneShot(deathsound);
            sayac++;
            collision.gameObject.GetComponent<yoket>().enabled = true;
            collision.gameObject.GetComponent<Animator>().enabled = false;
            collision.gameObject.GetComponent<CapsuleCollider2D>().enabled = false;
            collision.gameObject.GetComponent<Bot1Kontrol>().enabled = false;
            sr = collision.gameObject.GetComponent<SpriteRenderer>();
            sr.sprite = olumdizi[2];

        }
        if (sayac == 5) 
        {
            win.SetActive(true);
            Invoke("kazanma", 1.5f);
        }

    }
    void kazanma() 
    {
        SceneManager.LoadScene("Winner");
    }




}
