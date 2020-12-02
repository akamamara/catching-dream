using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerTree : MonoBehaviour
{
	public GameObject[] treePatterns;
	public GameObject[] treePatterns_2;
	private int[] sebelumnya = { 0, 0 };
	private int inc = 0;
	// public GameObject treePatterns;

	private float timeBtwSpawn;
	public float startTimeBtwSpawn;
	public float decreaseTime;
	public float minTime = 0.65f;
	
	private int rand;

	private void Start()
    {
		inc = 0;
    }

	private void Update()
	{
		if (timeBtwSpawn <= 0)
		{
			int rand = Random.Range(0, treePatterns.Length);
			if(sebelumnya[0] == sebelumnya[1])
            {
				if (sebelumnya[1] < 3)
					rand = Random.Range(3, treePatterns.Length);
				else if (sebelumnya[1] < 6)
					rand = Random.Range(0, treePatterns_2.Length);
			}

			Instantiate(treePatterns[rand], transform.position, Quaternion.identity);
			// Instantiate(treePatterns, transform.position, Quaternion.identity);
			timeBtwSpawn = startTimeBtwSpawn;
			if (startTimeBtwSpawn > minTime)
			{
				startTimeBtwSpawn -= decreaseTime;
			}

			if(inc < 2) { 
				sebelumnya[inc] = rand;
				inc++;
			}
			else
				inc = 0;
		}
		else
		{
			timeBtwSpawn -= Time.deltaTime;
		}
	}
}
