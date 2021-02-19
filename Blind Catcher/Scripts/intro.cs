using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("gecis",9.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void gecis() 
    {
        SceneManager.LoadScene("menu");
    }
}
