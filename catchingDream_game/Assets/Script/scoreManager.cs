using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreManager : MonoBehaviour
{
	// public string LevelToLoad;
	private Text scoreText;
	public int score;
	void Start()
	{
		scoreText = GetComponent<Text>();
		score = 0;
	}
	public void addScore(int scr)
    {
		score += scr;
    }
	public int getScore()
    {
		return score;
    }
}
