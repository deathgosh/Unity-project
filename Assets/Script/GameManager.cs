using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float RestartDelay = 2f;
    bool GameHasEnd = false;
    public void GameEnd()
    {

        if (GameHasEnd == false)
        {
            GameHasEnd = true;
            
            Invoke("Restart", RestartDelay);
        }
       
    }
    void  Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public GameObject LevelWonUI;


    public void LevelWon()
    {
        LevelWonUI.SetActive(true);
    }
}



