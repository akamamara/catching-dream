using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
	bool gameHasEnded = false;
	public float restartDelay = 0.05f;
	public GameObject PanelGameOver;

	public void endGame()
	{
		if(gameHasEnded == false)
		{
			gameHasEnded = true;
			Invoke("stopTime", restartDelay);
			Invoke("openPanel", restartDelay);
			// Restart();
		}
		 
	}
	void openPanel()
    {
		PanelGameOver.SetActive(true);
		Debug.Log("GAME OVER!");
	}
	void stopTime()
    {
		Time.timeScale = 0;
	}

	void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
