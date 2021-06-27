using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time2melee : MonoBehaviour
{
    public float velocidade;
    public float DisParar;
    public float dash;

    private float CoolDownDash;
    public float StartCDDash;

    private Transform ia1;

    Rigidbody rb;
    public Slider health;
    int vidinha = 8;

    // Start is called before the first frame update
    void Start()
    {
        ia1 = GameObject.FindWithTag("IA1").transform;

        CoolDownDash = StartCDDash;
        rb = GetComponent<Rigidbody>();
        health.value += 8;
    }

    // Update is called once per frame
    void Update()
    {
        ia1 = GameObject.FindWithTag("IA1").transform;

        if(Vector3.Distance(transform.position, ia1.position) > DisParar ){
            transform.position = Vector3.MoveTowards(transform.position, ia1.position, velocidade * Time.deltaTime);

        } else if(Vector3.Distance(transform.position, ia1.position) < DisParar){
            transform.position = Vector3.MoveTowards(transform.position, ia1.position, dash * Time.deltaTime);

            if(CoolDownDash <= 0){
            transform.position = Vector3.MoveTowards(transform.position, ia1.position, dash * Time.deltaTime);
            CoolDownDash = StartCDDash;
        }
        else {
            CoolDownDash -= Time.deltaTime;

        }

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

