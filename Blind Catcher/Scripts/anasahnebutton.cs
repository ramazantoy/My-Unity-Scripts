using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class anasahnebutton : MonoBehaviour
{
    public GameObject box;
    public GameObject devam;
    public GameObject yeniden;
    public GameObject menu;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void anabutton(int a)
    {
        if (a == 0)
        {
            box.SetActive(true);
            devam.SetActive(true);
            yeniden.SetActive(true);
            menu.SetActive(true);
            Time.timeScale = 0;
        } else if (a == 1)
        {
            box.SetActive(false);
            devam.SetActive(false);
            yeniden.SetActive(false);
            menu.SetActive(false);
            Time.timeScale = 1;
        } else if (a == 2) 
        {
            SceneManager.LoadScene("AnaSahne");
        }
        else if (a == 3)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
