using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


public class Bixo2 : MonoBehaviour
{

    public GameObject pla;
    private NavMeshAgent nav;
    public Slider vidaIA2;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        pla = GameObject.FindWithTag("IA1");
        nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        pla = GameObject.FindWithTag("IA1");
        nav.destination = pla.transform.position;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag ("IA1"))   
        {           
            vidaIA2.value--;
            if (vidaIA2.value == 0)
            {
                rb.gameObject.SetActive(false);
            }
        }
    }
}
