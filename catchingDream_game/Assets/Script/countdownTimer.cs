using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{
	// public string LevelToLoad;
	public float startTimer = 120f;
	public float timer;
	private Text timerSeconds;
	public float getTimer()
	{
		return timer;
	}
	public float getStartTimer()
    {
		return startTimer;
    }

	void Start()
	{
		timerSeconds = GetComponent<Text>();
		timer = 0;
	}

	// Update is called once per frame
	void Update()
	{
		// Hitung maju waktu
		if(timer < startTimer)
        {
			timer += Time.deltaTime;
			timerSeconds.text = timer.ToString("f0");
		}
        else if (timer > startTimer)
        {
			// Suspend time
			timerSeconds.text = startTimer.ToString("f0");
			// Load next Level
			Invoke("loadNextLevel", 3.0f);
		}
	}
	void loadNextLevel()
    {
		if (SceneManager.GetActiveScene().buildIndex == 4)
			SceneManager.LoadScene("Levels");
		else
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
