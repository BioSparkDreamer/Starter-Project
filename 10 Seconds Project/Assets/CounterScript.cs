using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterScript : MonoBehaviour
{
    public Text scoreText;
    private int score;
    float timeLeft = 9.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        scoreText.text = score.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            score = score + 1;
            SetScoreText ();
        }

        Destroy(gameObject, 9);
        timeLeft -= Time.deltaTime;
        if (timeLeft > 7)
        {
            scoreText.enabled = false;
        }
        else
        {
            scoreText.enabled = true;
        }
    }

    void SetScoreText()
    {
        scoreText.text = "" + score.ToString();
    }
}
