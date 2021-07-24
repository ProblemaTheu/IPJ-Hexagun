using UnityEngine;
using UnityEngine.UI;

public class Playable2 : MonoBehaviour
{

    Rigidbody rb;
    public Slider health;
    int vidinha = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        health.value += 5;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag ("IA1") || collision.gameObject.CompareTag ("tiro1"))
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
