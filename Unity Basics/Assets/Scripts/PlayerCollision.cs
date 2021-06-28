
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public PlayerMovement movement;

   void OnCollisionEnter (Collision collisionInfo)
   {
       if(collisionInfo.collider.tag== "Obstacle")
       {
           movement.upForce = 0.0f;
           movement.forwardForce= 0.0f;
           movement.sideForce= 0.0f;
       }
   }
}
