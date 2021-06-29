
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     public Rigidbody rb;    
     public float forwardForce = 1000f;
     public float sideForce = 1000f;
     public float upForce = 5f;
     Vector3 e;
     public Transform player;
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
            rb.AddForce(sideForce* Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce* Time.deltaTime,0,0,ForceMode.VelocityChange);
     }
         if(Input.GetKeyDown(KeyCode.Space))
        {
            if (player.position.y<=1.2f)
            {
                rb.velocity = e* upForce;
            }
            
    }
}}
