using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OyunKontrol : MonoBehaviour
{
    public static int oyuncu_can = 100;
    public static int bot_can = 100;
    public Text botcan;
    public Text oyuncucan;
   
    void Start()
    {
      
    }

  
    void Update()
    {
        botcan.text =""+bot_can;
        oyuncucan.text = "" +oyuncu_can;
    }
}
