using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Sniper : MonoBehaviour
{


    private bool team = false; // Indicador do time A


    private float velocidade = 3;
    private int vidinha = 2;
    private float CoolDown = 4;
    private float Hit = 3;

    Rigidbody rb;
    public Slider health;
    public GameObject project;
    public GameObject time;


    private float DisParar = 10; // vão sumir
    private float DisRecuar = 3; // vão sumir
    private float StartCD = 5; // Vai sumir



    void Start()
    {
        CoolDown = StartCD; // Vai sumir

        rb = GetComponent<Rigidbody>();
        health.value += vidinha;
    }

    // Update is called once per frame
    void Update()
    {
        CoolDown -= Time.deltaTime;
        Hit -= Time.deltaTime;
        velocidade = Library.Biblioteca.clampSpeed(velocidade);

        Transform ia = Library.Biblioteca.setTarget(rb, time);

        // -------------------------------------------------- Movimentação em direção --------------------------------------------
        if (Vector3.Distance(rb.transform.position, ia.position) > DisParar)
        {
            rb.transform.position = Vector3.MoveTowards(rb.transform.position, ia.position, velocidade * Time.deltaTime);
        }

        // ------------------------------------------------ Recuo + Atirar enquanto recua ----------------------------------------
        else
        {
            if (Vector3.Distance(rb.transform.position, ia.position) < DisRecuar)
            {
                rb.transform.position = Vector3.MoveTowards(rb.transform.position, ia.position, (-velocidade / 2) * Time.deltaTime);
            }

            transform.position = this.transform.position;

            if (CoolDown <= 0)
            {
                Instantiate(project, transform.position, Quaternion.identity);
                CoolDown = StartCD;
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //print(collision.gameObject.tag);        
        for (int i = 0; i < 3; i++)
        {
            if (i == 0) velocidade = Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
            //if (i == 1) vidinha = (int)Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
            //if (i == 2) health.value = Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
        }

        if (collision.gameObject.layer == 6)
        {
            if (Hit <= 0)
            {
                vidinha -= 1;
                health.value -= 1;
                Hit = 3;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        vidinha = Library.Biblioteca.damageLife(collision, vidinha, team);
        health.value = Library.Biblioteca.damageSlider(collision, health, team);
        velocidade = Library.Biblioteca.damageSpeed(collision, velocidade, team);

        Library.Biblioteca.death(rb, vidinha, health);
    }
}