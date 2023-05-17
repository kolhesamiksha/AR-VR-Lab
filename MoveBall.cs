using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    

    // Update is called once per frame
    float power=100;
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if(Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * power);
        if(Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * power);
        if(Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward * power);
        if(Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back * power);
    }
}
