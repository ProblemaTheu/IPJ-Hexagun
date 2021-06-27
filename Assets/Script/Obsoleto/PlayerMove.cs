using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    //Rigidbody rb;
    public Text startText;

    public float timer;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        startText.gameObject.SetActive(true);

    }

    private void Update()
    {
        timer = Mathf.Clamp(timer - Time.deltaTime, 0, 100);
        if (timer == 0)
        {
            startText.gameObject.SetActive(false);
        }

    }
    /* void FixedUpdate()
    {
        float x = Input.GetAxis("Vertical");
        float y = Input.GetAxis("Horizontal");

        Vector3 force = new Vector3(x,0,y);
        force.Normalize();
        force *= speed;

        rb.AddForce(force);
    } */
}
