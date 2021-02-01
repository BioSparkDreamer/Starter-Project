using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    float timeLeft = 9.0f;
    void Start()
    {
        startTime = Time.time + 2;
        timerText = GetComponent<Text>();
    }
    void Update()
    {
        float t = Time.time - startTime;

        string seconds = (t % 60).ToString("f1");

        timerText.text = seconds;

        Destroy(gameObject, 9);

        timeLeft -= Time.deltaTime;
        if (timeLeft > 7)
        {
            timerText.enabled = false;
        }
        else
        {
            timerText.enabled = true;
        }
    }
}
