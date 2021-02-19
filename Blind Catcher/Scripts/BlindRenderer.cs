using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindRenderer : MonoBehaviour
{
    public GameObject colli;
    public Sprite[] sprite;
    SpriteRenderer sr;
    int i;
    bool fullcharge;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        i = 0;
        fullcharge = false;
        colli.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&Time.timeScale!=0)
        {

            colli.SetActive(true);
            StopAllCoroutines();
            StartCoroutine(NotBlind());

        }
       else if(Input.GetKeyUp(KeyCode.Space) && Time.timeScale != 0)
        {
            colli.SetActive(false);
            StopAllCoroutines();
            StartCoroutine(Blind());

        }


    }
    IEnumerator NotBlind()
    {
        while (i < sprite.Length)
        {
            if (Input.GetKey(KeyCode.Space) && !fullcharge && Time.timeScale != 0)
            {
                if (i == sprite.Length-1 || i<0)
                {
                    fullcharge = true;
                    break;
                }
                else
                {
                    sr.sprite = sprite[i];
                    i++;
                }
           
              
                yield return new WaitForSeconds(0.05f);
                yield return 0;

            }       
        }
        //StartCoroutine(NotBlind());
    }
    IEnumerator Blind()
    {
        while (i >=0)
        {
            sr.sprite = sprite[i];
            i--;
            yield return new WaitForSeconds(0.07f);
            yield return 0;
        }
        fullcharge = false;
        i = 0;
       // StartCoroutine(Blind());
    }

}


