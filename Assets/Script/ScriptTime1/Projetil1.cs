using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil1 : MonoBehaviour
{

    public float velocidade;
    //[SerializeField] private float KnockBackStr;

    private Transform ia2;
    private Vector3 alvo;
    // Start is called before the first frame update
    void Start()
    {
        ia2 = GameObject.FindWithTag("IA2").transform;

        alvo = new Vector3(ia2.position.x, ia2.position.y, ia2.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, alvo, velocidade * Time.deltaTime);

        if(transform.position.x == alvo.x && transform.position.y == alvo.y && transform.position.z == alvo.z){

            DestroyProjetil();

        }
        
    }

    void OnColliderEnter(Collider other){
        if(other.CompareTag("IA2")){

            /*Rigidbody rb = other.GetComponent<Collider>().GetComponent<Rigidbody>();

        if(rb != null){
            Vector3 direction = other.transform.position - transform.position;
            direction.y = 0;

            rb.AddForce(direction.normalized * KnockBackStr, ForceMode.Impulse);


        }*/

            DestroyProjetil();
        }
        
    }

    void DestroyProjetil()
    {
        Destroy(gameObject);
    }

}
