
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager gameManager;

     void OnTriggerEnter()
    {
        
        Debug.Log("win");
        gameManager.completeLevel();
     
    }
    
}
