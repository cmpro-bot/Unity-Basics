
using UnityEngine;

public class endtrigger : MonoBehaviour
{
    public GameManager gameManager;

    void onTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        Debug.Log("win");
        gameManager.completeLevel();
        }
    }
}
