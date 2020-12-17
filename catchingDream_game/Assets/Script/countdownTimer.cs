using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
    // public string LevelToLoad;
    public float startTimer = 30f;
    public float timer;
    private Text timerSeconds;
    public float getTimer()
    {
        return startTimer;
    }

    void Start()
    {
        timerSeconds = GetComponent<Text>();
        timer = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if(timer <= -3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
