using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time2 : MonoBehaviour
{
    public float velocidade;
    public float DisParar;
    public float DisRecuar;

    private float CoolDown;
    public float StartCD;

    public GameObject project;
    private Transform ia1;

    Rigidbody rb;
    public Slider health;
    int vidinha = 5;

    // Start is called before the first frame update
    void Start()
    {
        ia1 = GameObject.FindWithTag("IA1").transform;

        CoolDown = StartCD;

        rb = GetComponent<Rigidbody>();
        health.value += 5;
    }

    // Update is called once per frame
    void Update()
    {
        ia1 = GameObject.FindWithTag("IA1").transform;

        if(Vector3.Distance(transform.position, ia1.position) > DisParar ){
            transform.position = Vector3.MoveTowards(transform.position, ia1.position, velocidade * Time.deltaTime);

        } else if(Vector3.Distance(transform.position, ia1.position) < DisParar && Vector3.Distance(transform.position, ia1.position) > DisRecuar){
            transform.position = this.transform.position;

            if(CoolDown <= 0){
            Instantiate(project, transform.position, Quaternion.identity);
            CoolDown = StartCD;
        }
        else {
            CoolDown -= Time.deltaTime;

        }

        } else if(Vector3.Distance(transform.position, ia1.position) < DisRecuar){
            transform.position = Vector3.MoveTowards(transform.position, ia1.position, -velocidade * Time.deltaTime);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("IA1") || collision.gameObject.CompareTag("tiro1"))
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

