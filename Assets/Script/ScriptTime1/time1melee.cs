using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time1melee : MonoBehaviour
{
    public float velocidade;
    public float DisParar;
    public float dash;

    private float CoolDownDash;
    public float StartCDDash;

    private Transform ia2;

    Rigidbody rb;
    public Slider health;
    int vidinha = 8;

    // Start is called before the first frame update
    void Start()
    {
        ia2 = GameObject.FindWithTag("IA2").transform;

        CoolDownDash = StartCDDash;

        rb = GetComponent<Rigidbody>();
        health.value += 8;
    }

    // Update is called once per frame
    void Update()
    {
        ia2 = GameObject.FindWithTag("IA2").transform;

        if(Vector3.Distance(transform.position, ia2.position) > DisParar ){
            transform.position = Vector3.MoveTowards(transform.position, ia2.position, velocidade * Time.deltaTime);

        } else if(Vector3.Distance(transform.position, ia2.position) < DisParar){
            transform.position = Vector3.MoveTowards(transform.position, ia2.position, dash * Time.deltaTime);

            if(CoolDownDash <= 0){
            transform.position = Vector3.MoveTowards(transform.position, ia2.position, dash * Time.deltaTime);
            CoolDownDash = StartCDDash;
        }
        else {
            CoolDownDash -= Time.deltaTime;

        }

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

