using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



namespace Library
{
    public class Biblioteca : MonoBehaviour
    {


        public static Transform setTarget(Rigidbody rb, GameObject time)
        {
            Transform ia = time.transform.GetChild(0).gameObject.transform; // Primeiro filho
            for (int i = 1; i < time.transform.childCount; i++) // Segundo em diante para comparação
            {
                Transform obj = time.transform.GetChild(i).gameObject.transform;
                if (Vector3.Distance(rb.transform.position, obj.transform.position) < Vector3.Distance(rb.transform.position, ia.transform.position))
                {
                    ia = obj;
                }
            }

            return ia;
        }



        public static float onPlaneMelee(Collision collision, float velocidade, int vidinha, Slider health, int i)
        {
            float velocidadeMax = 3;
            float hitCD = 1f - Time.deltaTime;

            if (collision.gameObject.CompareTag("Montanha"))
            {
                float clampvel = Mathf.Clamp(velocidade / 2, velocidadeMax - 2, velocidadeMax);
                velocidade = clampvel;
            }
            else if (collision.gameObject.CompareTag("Agua"))
            {
                float clampvel = Mathf.Clamp(velocidade / 2, velocidadeMax - 1, velocidadeMax);
                velocidade = clampvel;
            }
            else if (collision.gameObject.CompareTag("Buraco"))
            {
                float clampvel = Mathf.Clamp(velocidade + Time.deltaTime, 0, velocidadeMax * 1.5f);
                velocidade = clampvel;
            }
            /*else if ((collision.gameObject.CompareTag("IA2") && collision.gameObject.layer == 6) || (collision.gameObject.CompareTag("IA1") && collision.gameObject.layer == 6))
            {
                if (hitCD <= 0)
                {
                    vidinha--;
                    health.value--;
                    hitCD = 1f - Time.deltaTime;
                }
            }*/

            return velocidade;
            //if (i == 1) return vidinha;
            //else if (i == 2) return health.value;
        }

        public static float onPlaneAtirador(Collision collision, float velocidade, int vidinha, Slider health, int i)
        {
            float velocidadeMax = 2.5f;
            float hitCD = 1f - Time.deltaTime;

            if (collision.gameObject.CompareTag("Montanha"))
            {
                float clampvel = Mathf.Clamp(velocidade - 1, velocidadeMax - 2, velocidadeMax);
                velocidade = clampvel;
            }
            else if (collision.gameObject.CompareTag("Agua"))
            {
                float clampvel = Mathf.Clamp(velocidade / 2, velocidadeMax - 1, velocidadeMax);
                velocidade = clampvel;
            }
            else if (collision.gameObject.CompareTag("Buraco"))
            {
                float clampvel = Mathf.Clamp(velocidade / 2, velocidadeMax - 1, velocidadeMax);
                velocidade = clampvel;
            }
            /*else if ( (collision.gameObject.CompareTag("IA2") && collision.gameObject.layer == 6) || (collision.gameObject.CompareTag("IA1") && collision.gameObject.layer == 6) )
            {
                if (hitCD <= 0)
                {
                    Debug.Log("Rodou aqui");
                    vidinha--;
                    health.value--;
                    hitCD = 1f - Time.deltaTime;
                }
            }*/

            return velocidade;
            //if (i == 1) return vidinha;
            //else if (i == 2) return health.value;
        }



        public static void Dash(Rigidbody rb, Transform ia, float CoolDownDash, float velocidade)
        {
            float dash = 10;

            if (Vector3.Distance(rb.transform.position, ia.position) < 3 && CoolDownDash <= 0)
            {
                rb.transform.position = Vector3.MoveTowards(rb.transform.position, ia.position, dash * Time.deltaTime);
            }
            else
            {
                rb.transform.position = Vector3.MoveTowards(rb.transform.position, ia.position, velocidade * Time.deltaTime);
            }
        }



        public static float clampMelee(float velocidade)
        {
            float velocidadeMax = 3;
            float clampvel = Mathf.Clamp(velocidade + Time.deltaTime * 1.5f, 0, velocidadeMax);
            velocidade = clampvel;
            return velocidade;
        }

        public static float clampSpeed(float velocidade)
        {
            float velocidadeMax = 3;
            float clampvel = Mathf.Clamp(velocidade + Time.deltaTime, 0, velocidadeMax);
            velocidade = clampvel;
            return velocidade;
        }




        public static int damageLife(Collision collision, int vidinha, bool team) 
        {
            if (team == true)
            {
                if (collision.gameObject.CompareTag("IA2") && collision.gameObject.layer == 6) vidinha -= 2;

                if (collision.gameObject.CompareTag("Projetil2")) vidinha--;

                if (collision.gameObject.CompareTag("ProjetilSniper2")) vidinha -= 2;
            }
            else if (team == false)
            {
                if (collision.gameObject.CompareTag("IA1") && collision.gameObject.layer == 6) vidinha -= 2;

                if (collision.gameObject.CompareTag("Projetil1")) vidinha--;

                if (collision.gameObject.CompareTag("ProjetilSniper1")) vidinha -= 2;
            }

            return vidinha;
        }

        public static float damageSpeed(Collision collision, float velocidade, bool team)
        {
            if (team == true)
            {
                if (collision.gameObject.CompareTag("IA2") && collision.gameObject.layer == 6) velocidade -= 2;

                if (collision.gameObject.CompareTag("Projetil2")) velocidade--;

                if (collision.gameObject.CompareTag("ProjetilSniper2")) velocidade -= 2;
            }
            else if (team == false)
            {
                if(collision.gameObject.CompareTag("IA1") && collision.gameObject.layer == 6) velocidade -= 2;

                if (collision.gameObject.CompareTag("Projetil1")) velocidade--;

                if (collision.gameObject.CompareTag("ProjetilSniper1")) velocidade -= 2;
            }

            return velocidade;
        }

        public static float damageSlider(Collision collision, Slider health, bool team)
        {
            if (team == true)
            {
                if (collision.gameObject.CompareTag("IA2") && collision.gameObject.layer == 6) health.value -= 2;

                if (collision.gameObject.CompareTag("Projetil2")) health.value--;

                if (collision.gameObject.CompareTag("ProjetilSniper2")) health.value -= 2;
            }
            else if (team == false)
            {
                if (collision.gameObject.CompareTag("IA1") && collision.gameObject.layer == 6) health.value -= 2;

                if (collision.gameObject.CompareTag("Projetil1")) health.value--;

                if (collision.gameObject.CompareTag("ProjetilSniper1")) health.value -= 2;
            }

            return health.value;
        }




        public static float melee (Collision collision, float velocidade, float CoolDownDash, bool team, int i)
        {
            float StartCDDash = 3;

            if (team == true)
            {
                if (collision.gameObject.CompareTag("IA2"))
                {
                    velocidade = 0.2f;  
                    CoolDownDash = StartCDDash;
                }
            }
            else if (team == false)
            {
                if (collision.gameObject.CompareTag("IA1"))
                {
                    velocidade = 0.2f;
                    CoolDownDash = StartCDDash;
                }
            }

            if (i == 1) return CoolDownDash;
            else return velocidade;
                
        }



        public static void death(Rigidbody rb, float vidinha, Slider health)
        {
            if (vidinha <= 0) Destroy(rb.gameObject);
            if (vidinha < 0) health.value += -vidinha;
        }



        public static void shootingRange(Rigidbody rb, Transform ia, float velocidade)
        {
            float DisParar = 6;
            float DisRecuar = 3;

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

                //rb.transform.position = this.rb.transform.position;
            }
        }


        public static float shoot(Rigidbody rb, float CoolDown, GameObject project)
        {
            float StartCD = 2;

            if (CoolDown <= 0)
            {
                Instantiate(project, rb.transform.position, Quaternion.identity);
                CoolDown = StartCD;
            }

            return CoolDown;
        }

    }
}

