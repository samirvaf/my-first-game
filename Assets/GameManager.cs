using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject levelCompleteUI;
    public float restartDelay = 2f;
    bool gameHasEnded = false;
    public void EndGame ()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("Game Over!");
            Invoke("RestartGame", restartDelay);
        }
    }

    public void LevelComplete ()
    {
        levelCompleteUI.SetActive(true);
    }

    void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
