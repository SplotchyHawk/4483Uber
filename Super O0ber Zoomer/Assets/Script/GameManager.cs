using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        TimerController timerController;
    }

    void Update()
    {
        if (Customer.dropoffCounter > 9)
        {
            SceneManager.LoadScene(2);
        }
    }
}
