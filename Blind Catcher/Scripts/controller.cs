using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonclick(int a) 
    {
        if (a == 0) 
        {
            SceneManager.LoadScene("AnaSahne");
        }
        else if (a == 1) 
        { 
           Application.Quit(); 
        }
        else if (a == 2)
        {
            SceneManager.LoadScene("menu");
        }
    }
}
