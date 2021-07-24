using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Melee
{
    public class B_Melee : MonoBehaviour
    {

        private bool team = false; // Indicador que é o time A


        private float CoolDownDash = 3;
        private float velocidade = 3;
        private int vidinha = 6;

        Rigidbody rb;
        public Slider health;
        public GameObject time;

        //public Transform vortice;        
        //public Transform vortice1;        
        //public GameObject voce;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            health.value += vidinha;
        }


        void Update()
        {
            CoolDownDash -= Time.deltaTime;
            velocidade = Library.Biblioteca.clampMelee(velocidade);

            Transform ia = Library.Biblioteca.setTarget(rb, time);
            Library.Biblioteca.Dash(rb, ia, CoolDownDash, velocidade);
        }


        private void OnCollisionStay(Collision collision)
        {
            //print(collision.gameObject.tag);        
            for (int i = 0; i < 3; i++)
            {
                if (i == 0) velocidade = Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
                //if (i == 1) vidinha = (int) Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
                //if (i == 2) health.value = Library.Biblioteca.onPlaneMelee(collision, velocidade, vidinha, health, i);
            }

            if (collision.gameObject.layer == 6)
            {
                if (CoolDownDash <= 0)
                {
                    vidinha -= 2;
                    health.value -= 2;
                    CoolDownDash = 3;
                }
            }
        }


        private void OnCollisionEnter(Collision collision)
        {
            vidinha = Library.Biblioteca.damageLife(collision, vidinha, team);
            health.value = Library.Biblioteca.damageSlider(collision, health, team);
            velocidade = Library.Biblioteca.damageSpeed(collision, velocidade, team);

            for (int i = 0; i < 2; i++)
            {
                if (i == 0) velocidade = Library.Biblioteca.melee(collision, velocidade, CoolDownDash,team, i);
                if (i == 1) CoolDownDash = Library.Biblioteca.melee(collision, velocidade, CoolDownDash,team, i);
            }

            Library.Biblioteca.death(rb, vidinha, health);
        }

    }
}



/*if(collision.gameObject.CompareTag("Vortice"))        
        {        
        voce.transform.position = vortice1.transform.position;        
        }        
        if(collision.gameObject.CompareTag("Vortice1"))        
        {        
        voce.transform.position = vortice.transform.position.x;        
        }*/

/*private void OnTriggerEnter (Collider other)    
{    
if(GetComponent<Collider>().gameObject.CompareTag("Vortice"))    
{    
voce.transform.position = vortice1.transform.position;  
}    
if(GetComponent<Collider>().gameObject.CompareTag("Vortice1"))    
{    
voce.transform.position = vortice.transform.position;    
}    
}*/