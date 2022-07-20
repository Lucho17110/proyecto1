using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //This is a reference to call our rigidbody component "rb"
    public Rigidbody rb;

    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpv = 500f;

    // Update is called once per frame. We use FixedUpdate when we mess with physics
    void FixedUpdate()
    {
        //Add a foward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime); 
        //The Time.deltaTime method is used to run in the same way in all computers
        
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime,0, 0, ForceMode.VelocityChange);
        }   
    }
}
     