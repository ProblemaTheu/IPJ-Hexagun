using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onclick : MonoBehaviour
{

    void OnMouseDown(){
        
        Debug.Log ("Something Touched");
        Destroy (gameObject);
    }
}

