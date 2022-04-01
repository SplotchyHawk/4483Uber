using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    public void Pause()
    {
        Debug.Log("PAUSED");

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Debug.Log("RESUMED");

        pauseMenu.SetActive(true);
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);

    }

    public void Home(int sceneID)
    {
        Debug.Log("HOME");

        Time.timeScale = 1f;
        Customer.dropoffCounter = 0;
        Customer.mesh = true;
        SceneManager.LoadScene(sceneID);
        
    }

    public void Restart()
    {
        Debug.Log("RESTART");

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        Customer.mesh = true;
        Customer.dropoffCounter = 0;
    }
}
