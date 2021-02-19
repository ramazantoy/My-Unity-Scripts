using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotGorus : MonoBehaviour
{
    public GameObject karakterkirmizi;
    AudioSource sound;
    public AudioClip gameoversound;
    public GameObject kirmizi;
    public GameObject siyah;
    public GameObject[] cheater;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }


    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            karakterkirmizi.SetActive(false);
            sound.PlayOneShot(gameoversound);
            cheater[0].GetComponent<SpriteRenderer>().enabled = true;
            cheater[1].GetComponent<SpriteRenderer>().enabled = true;
            cheater[2].GetComponent<SpriteRenderer>().enabled = true;
            cheater[3].GetComponent<SpriteRenderer>().enabled = true;
            cheater[4].GetComponent<SpriteRenderer>().enabled = true;
            kirmizi.SetActive(true);
            siyah.SetActive(false);
            Invoke("yukle", 1.5f);
            
        }
    }

    void yukle() 
    {
        SceneManager.LoadScene("GameOver");
    }
}
