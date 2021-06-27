using UnityEngine;
using UnityEngine.UI;

public class Playable1 : MonoBehaviour
{

    Rigidbody rb;
    public Slider health;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag ("IA2") || collision.gameObject.CompareTag ("tiro2"))
        {
            health.value--;

            if (health.value == 0)
            {
                Destroy(rb.gameObject);
            }


        }


    }
}
