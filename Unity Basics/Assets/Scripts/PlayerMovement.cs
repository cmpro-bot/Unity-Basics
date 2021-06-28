
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody rb;    
     public float forwardForce = 1000f;
     public float sideForce = 1000f;
     public float upForce = 5f;
     Vector3 e;
     void Start()
     {
          e = new Vector3(0.0f,1.0f,0.0f);   
     }
     
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
             rb.AddForce(0,0,forwardForce* Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
             rb.AddForce(0,0,-forwardForce* Time.deltaTime);
        }
       if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce* Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce* Time.deltaTime,0,0);
     }
         if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = e* upForce;
    }
}}
