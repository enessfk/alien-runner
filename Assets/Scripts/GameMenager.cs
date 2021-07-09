using UnityEngine;
using UnityEngine.SceneManagement;
public class GameMenager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;



    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }


     public void EndGame()
    {
        if (gameHasEnded==false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            restart();
            Invoke("restart", restartDelay);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
