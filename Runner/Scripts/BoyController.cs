using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyController : MonoBehaviour
{
    Animator animator;
    Rigidbody r;
    public int forceConst = 70;
    public GameObject[] Roads;

    private bool canJump;
    private bool Jump;


    void Start()
    {
        animator = GetComponent<Animator>();
        r = GetComponent<Rigidbody>();
     //   r.velocity = new Vector3(0, 0, 20f);
     
    }

    
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime*20f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            canJump = true;
           
     
          //gameObject.transform.position = gameObject.transform.position + new Vector3(0, 0, 5);
        }
        if (canJump == true)
        {
            if (Jump == true)
            {
                canJump = false;
                animator.SetTrigger("RunnigJump");
                r.AddForce(0, forceConst, 0, ForceMode.Impulse);
            }

        }
        if (Input.GetKey(KeyCode.A) && Jump)
        {
            transform.Translate(Vector3.left * Time.deltaTime *20f);
        }
        if (Input.GetKey(KeyCode.D) && Jump)
        {
            transform.Translate(Vector3.right * Time.deltaTime * 20f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Jump = true;
        //   Debug.Log("zıplayabilir");
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            Jump = false;
          // Debug.Log("zıplayamaz");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "cevre2")
        {
            Roads[0].gameObject.transform.position = Roads[3].gameObject.transform.position + new Vector3(0, 0, 169);
            Roads[1].gameObject.transform.position = Roads[0].gameObject.transform.position + new Vector3(0, 0, 169);
        }
        if (other.gameObject.tag == "cevre3")
        {
            Roads[2].gameObject.transform.position = Roads[1].gameObject.transform.position + new Vector3(0, 0, 169);
            Roads[3].gameObject.transform.position = Roads[2].gameObject.transform.position + new Vector3(0, 0, 169);
        }
      
        
    }
}

