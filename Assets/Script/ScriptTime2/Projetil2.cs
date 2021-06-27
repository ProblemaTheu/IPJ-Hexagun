using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil2 : MonoBehaviour
{

    public float velocidade;

    private Transform ia1;
    private Vector3 alvo;
    // Start is called before the first frame update
    void Start()
    {
        ia1 = GameObject.FindWithTag("IA1").transform;

        alvo = new Vector3(ia1.position.x, ia1.position.y, ia1.position.z);
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
        if(other.CompareTag("IA1")){
            DestroyProjetil();
        }
        
    }

    void DestroyProjetil()
    {
        Destroy(gameObject);
    }
}
