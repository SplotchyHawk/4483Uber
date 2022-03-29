using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = Time.time.ToString("0");
        scoreText.text = Customer.dropoffCounter.ToString(); ;
    }
}
