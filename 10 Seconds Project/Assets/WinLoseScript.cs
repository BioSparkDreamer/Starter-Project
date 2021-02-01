using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoseScript : MonoBehaviour
{
    public Text WinLose;
    private int count;
    public AudioSource winMusic;
    public AudioSource loseMusic;
    float timeLeft = 18.0f;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            count = count + 1;
        }
        timeLeft -= Time.deltaTime;
        if (timeLeft < 9 && count >= 50)
        {
            GetComponent<Text>().enabled = true;
            GetComponent<Text>().text = "You Win! Game by Cesar Silva.";
            winMusic.Play();
        }
        
        if (timeLeft < 9 && count < 50)
        {
            GetComponent<Text>().enabled = true;
            GetComponent<Text>().text = "You Lose! Game by Cesar Silva.";
            loseMusic.Play();
        }
    }
}
