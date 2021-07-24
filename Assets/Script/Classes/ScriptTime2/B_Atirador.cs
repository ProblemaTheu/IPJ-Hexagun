using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class B_Atirador : MonoBehaviour
{


    private bool team = false; // Indicador do time A


    private float velocidade = 7;
    private int vidinha = 4;
    private float CoolDown = 2;
    private float Hit = 3;

    Rigidbody rb;
    public Slider health;
    public GameObject project;
    public GameObject time;


    private float StartCD = 2; // Vai sumir



    void Start()
    {
        CoolDown = StartCD; // Vai sumir

        rb = GetComponent<Rigidbody>();
        health.value += vidinha;
    }


    void Update()
    {
        CoolDown -= Time.deltaTime;
        Hit -= Time.deltaTime;
        velocidade = Library.Biblioteca.clampSpeed(velocidade);

        Transform ia = Library.Biblioteca.setTarget(rb, time);

        Library.Biblioteca.shootingRange(rb, ia, velocidade);
        CoolDown = Library.Biblioteca.shoot(rb, CoolDown, project);

    }

    private void OnCollisionStay(Collision collision)
    {
        //print(collision.gameObject.name);
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

