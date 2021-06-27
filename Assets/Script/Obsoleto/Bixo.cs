using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Bixo : MonoBehaviour
{

    public GameObject pla;
    private NavMeshAgent nav;
    public Slider vidaIA1;
    Rigidbody rb;

    // Attacking AI Codes
    public float lookRadius = 3f;
    Transform target;
    NavMeshAgent agent;


    // Start is called before the first frame update
    void Start()
    {
        pla = GameObject.FindWithTag("IA2");
        nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();

        // Attacking AI Codes
        agent = GetComponent<NavMeshAgent>();
        target = PlayerManagement.instance.player1.transform;


    }

    // Update is called once per frame
    void Update()
    {
        pla = GameObject.FindWithTag("IA2");
        //nav.destination = pla.transform.position; // te ca�a independente da posi��o

        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IA2"))
        {
            vidaIA1.value--;
            if (vidaIA1.value == 0)
            {
                rb.gameObject.SetActive(false);
            }

          
        }
    }

    private void OnTriggerEnter1(Collider other)
    {
        if (other.CompareTag("Montanha"))
        {
            vidaIA1.value--;
            if (vidaIA1.value == 0)
            {
                rb.gameObject.SetActive(false);
            }

          
        }
    }

    #region VisualRange
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    #endregion
}
