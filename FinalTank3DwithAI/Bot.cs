
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    NavMeshAgent agent;
    Vector3[] noktalar;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        noktalar = new Vector3[6];
        noktalar[0] = new Vector3(-227f, 1, 0);
        noktalar[1] = new Vector3(-166f, 1, 0);
        noktalar[2] = new Vector3(-104.2f, 1, 0);
        noktalar[3] = new Vector3(-29f, 1, 0);
        noktalar[4] = new Vector3(-74f, 1, 0);
        noktalar[5] = new Vector3(-234f, 1, 0);
        InvokeRepeating("hedef", 2, 10);
    }

  

    void  hedef()
    {
        agent.SetDestination(noktalar[Random.Range(0,6)]);
    }
    void Update()
    {
       
    }
}
