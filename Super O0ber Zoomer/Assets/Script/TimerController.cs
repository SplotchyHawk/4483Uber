using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerController : MonoBehaviour
{
    public static TimerController instance;

    public Text timeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;
    private float timeRemaining = 300.0f;
    private string timeRemainingStr;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        timeCounter.text = "Time: 05:00.00";
        timerGoing = false;
        BeginTimer();
    }

    public void BeginTimer()
    {
        timerGoing = true;
        StartCoroutine(UpdateTimer());
    }

    public void EndTimer()
    {
        timerGoing = false;

    }

    public void UnpauseTimer()
    {
        timerGoing = true;

    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                yield return null;

            }
            else
            {
                timeRemaining = 0;
                EndTimer();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timeCounter.text = string.Format("Time: {0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
    }
}
