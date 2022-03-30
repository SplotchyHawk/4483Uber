using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Debug.Log("PAUSED");
        //timerController.EndTimer();
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(true);
        Debug.Log("RESUMED");
        Time.timeScale = 1f;
        //timerController.UnpauseTimer();
        pauseMenu.SetActive(false);

    }

    public void Home(int sceneID)
    {
        Debug.Log("HOME");
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    public void Restart()
    {
        Debug.Log("RESTART");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Customer.dropoffCounter = 0;
    }
}
