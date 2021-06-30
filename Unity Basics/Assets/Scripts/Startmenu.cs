using UnityEngine.SceneManagement;
using UnityEngine;

public class Startmenu : MonoBehaviour
{
    public void StartGame()
    {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
}
}