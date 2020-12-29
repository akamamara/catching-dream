using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
	public GameObject[] obstaclePatterns;
	// public GameObject obstacle;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseTime;
	public float minTime = 0.65f;

	public countdownTimer countdownTimer;
	
	private int rand;
	private int sebelumnya = -1;

	private void Start()
    {
		sebelumnya = -1;
	}
	
	private void Update()
	{
		if (timeBtwSpawn <= 0 && countdownTimer.getTimer() < countdownTimer.getStartTimer() - 1)
		{
			Debug.Log(countdownTimer.getTimer());
            // Randomize spawn object
            int rand = Random.Range(0, obstaclePatterns.Length);
			if (rand == sebelumnya)
			{
				rand = Random.Range(sebelumnya + 1, obstaclePatterns.Length);
			}

			// Spawn object
			Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
			// Instantiate(obstacle, transform.position, Quaternion.identity);

			// Time between spawn object
			timeBtwSpawn = startTimeBtwSpawn;
			if (startTimeBtwSpawn > minTime)
			{
				startTimeBtwSpawn -= decreaseTime;
			}
            sebelumnya = rand;
		} 
		else
		{
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}
