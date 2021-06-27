using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time1range : MonoBehaviour
{
    public float velocidade;
    public float DisParar;
    public float DisRecuar;

    private float CoolDown;
    public float StartCD;

    public GameObject project;
    private Transform ia2;

    Rigidbody rb;
    public Slider health;
    int vidinha = 2;

    // Start is called before the first frame update
    void Start()
    {
        ia2 = GameObject.FindWithTag("IA2").transform;

        CoolDown = StartCD;

        rb = GetComponent<Rigidbody>();
        health.value += 2;
    }

    // Update is called once per frame
    void Update()
    {
        ia2 = GameObject.FindWithTag("IA2").transform;

        if(Vector3.Distance(transform.position, ia2.position) > DisParar ){
            transform.position = Vector3.MoveTowards(transform.position, ia2.position, velocidade * Time.deltaTime);

        } else if(Vector3.Distance(transform.position, ia2.position) < DisParar && Vector3.Distance(transform.position, ia2.position) > DisRecuar){
            transform.position = this.transform.position;

            if(CoolDown <= 0){
            Instantiate(project, transform.position, Quaternion.identity);
            CoolDown = StartCD;
        }
        else {
            CoolDown -= Time.deltaTime;

        }
        
        } else if(Vector3.Distance(transform.position, ia2.position) < DisRecuar){
            transform.position = Vector3.MoveTowards(transform.position, ia2.position, -velocidade * Time.deltaTime);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("IA2") || collision.gameObject.CompareTag("tiro2"))
        {
            health.value--;
            vidinha--;

            if (vidinha == 0)
            {
                Destroy(rb.gameObject);
            }


        }


    }

}

