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
	private bool endGame = false;

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
			endGame = false;
			timer += Time.deltaTime;
            timerSeconds.text = timer.ToString("f0") + "s";
		}
		if(timer > startTimer)
        {
			if(endGame == false)
            {
				endGame = true;
				FindObjectOfType<spawnerEndGame>().spawnEndGame();
			}
			// FindObjectOfType<EndGameManager>().Invoke("openPanel", 3.0f);
		}
	}
}
