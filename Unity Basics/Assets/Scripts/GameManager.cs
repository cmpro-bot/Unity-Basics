
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartdelay=1f;
    public GameObject completeLevelUI;
    public void completeLevel()
    {
        Debug.Log("level won");
        completeLevelUI.SetActive(true);
    }
    public void endGame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded=true;
            Debug.Log("Game Over");
            Invoke("restart",restartdelay);
        }
       
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}