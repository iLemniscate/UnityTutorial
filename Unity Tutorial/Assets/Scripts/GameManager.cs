using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool game = true;
    public float restartDelay = 2f;
    public GameObject finishUI;

    public void CompleteLevel()
    {
        finishUI.SetActive(true);
    }

    public void GameOver()
    {
        if (game)
        {
            game = false;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
